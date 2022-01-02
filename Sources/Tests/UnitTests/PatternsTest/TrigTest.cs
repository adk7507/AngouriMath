//
// Copyright (c) 2019-2022 Angouri.
// AngouriMath is licensed under MIT.
// Details: https://github.com/asc-community/AngouriMath/blob/master/LICENSE.md.
// Website: https://am.angouri.org.
//

/*
 * This file was auto-generated by TestGenerator
 * Do not modify it; modify TestGenerator.java and rerun it instead.
 */

/*
 * It's super important to test all following cases because they test replacements for Trigonometric functions
 * so if one is wrong your result might be wrong at all
 */


using AngouriMath;
using static AngouriMath.Entity.Number;
using System;
using System.Linq;
using AngouriMath.Extensions;
using HonkSharp.Fluency;
using HonkSharp.Functional;
using Xunit;

namespace UnitTests.PatternsTest
{
    public sealed class TestTrigTableConsts
    {
        // TODO: Remove when we implement extra precision for rounding
        internal static void AssertEqualWithoutLast3Digits(Real expected, Real actual) =>
            Assert.Equal(expected.EDecimal.RoundToExponent(expected.EDecimal.Ulp().Exponent + 3),
                         actual.EDecimal.RoundToExponent(expected.EDecimal.Ulp().Exponent + 3));

        // For MemberData to show up as individual test cases, all arguments must be serializable:
        // https://github.com/xunit/xunit/issues/1473#issuecomment-333226539
        public static readonly System.Collections.Generic.IEnumerable<object[]> TrigTestData =
            new[] { nameof(MathS.Sin), nameof(MathS.Cos), nameof(MathS.Tan), nameof(MathS.Cotan) }
            .SelectMany(_ => Enumerable.Range(1, 29), (func, i) => new object[] { func, i });

        [Theory]
        [MemberData(nameof(TrigTestData))]
        public void TrigTest(string trigFunc, int twoPiOver)
        {
            var toSimplify =
                (Entity?)typeof(MathS).GetMethod(trigFunc)?.Invoke(null, new object[] { 2 * MathS.pi / twoPiOver })
                ?? throw new Exception($"{trigFunc} not found.");
            var expected = Assert.IsAssignableFrom<Real>(toSimplify.EvalNumerical());
            var actual = Assert.IsAssignableFrom<Real>(toSimplify.InnerSimplified.EvalNumerical());
            AssertEqualWithoutLast3Digits(expected, actual);
        }
        
        [Theory]
        [InlineData("pi", true)]
        [InlineData("pi / 2", true)]
        [InlineData("pi / 3", true)]
        [InlineData("pi / 6", true)]
        [InlineData("2 pi / 3", true)]
        [InlineData("4 pi / 7", true)]
        [InlineData("-pi", true)]
        [InlineData("-pi / 2", true)]
        [InlineData("-pi / 3", true)]
        [InlineData("-pi / 6", true)]
        [InlineData("-2 pi / 3", true)]
        [InlineData("-4 pi / 7", true)]
        [InlineData("200pi - pi", true)]
        [InlineData("200pi - pi / 2", true)]
        [InlineData("200pi - pi / 3", true)]
        [InlineData("200pi - pi / 6", true)]
        [InlineData("200pi - 2 pi / 3", true)]
        [InlineData("200pi - 4 pi / 7", true)]
        [InlineData("200pi + pi", true)]
        [InlineData("200pi + pi / 2", true)]
        [InlineData("200pi + pi / 3", true)]
        [InlineData("200pi + pi / 6", true)]
        [InlineData("200pi + 2 pi / 3", true)]
        [InlineData("200pi + 4 pi / 7", true)]
        [InlineData("1 + 2", false)]
        [InlineData("pi - 2", false)]
        public void SineHalvedTest(string angle, bool mustBeComputed)
        {
            var sin2x = MathS.Sin(angle);
            var sinx = MathS.ExperimentalFeatures.GetSineOfHalvedAngle(angle, sin2x);
            
            if (mustBeComputed)
                sinx.ShouldBeNotNull().ShouldApproximatelyEqual(MathS.Sin(angle.ToEntity() / 2));
            else
                sinx.ShouldBeNull();
        }
        
        [Theory]
        [InlineData("pi", true)]
        [InlineData("pi / 2", true)]
        [InlineData("pi / 3", true)]
        [InlineData("pi / 6", true)]
        [InlineData("2 pi / 3", true)]
        [InlineData("4 pi / 7", true)]
        [InlineData("-pi", true)]
        [InlineData("-pi / 2", true)]
        [InlineData("-pi / 3", true)]
        [InlineData("-pi / 6", true)]
        [InlineData("-2 pi / 3", true)]
        [InlineData("-4 pi / 7", true)]
        [InlineData("200pi - pi", true)]
        [InlineData("200pi - pi / 2", true)]
        [InlineData("200pi - pi / 3", true)]
        [InlineData("200pi - pi / 6", true)]
        [InlineData("200pi - 2 pi / 3", true)]
        [InlineData("200pi - 4 pi / 7", true)]
        [InlineData("200pi + pi", true)]
        [InlineData("200pi + pi / 2", true)]
        [InlineData("200pi + pi / 3", true)]
        [InlineData("200pi + pi / 6", true)]
        [InlineData("200pi + 2 pi / 3", true)]
        [InlineData("200pi + 4 pi / 7", true)]
        [InlineData("1 + 2", false)]
        [InlineData("pi - 2", false)]
        public void CosineHalvedTest(string angle, bool mustBeComputed)
        {
            var cos2x = MathS.Cos(angle);
            var cosx = MathS.ExperimentalFeatures.GetCosineOfHalvedAngle(angle, cos2x);
            
            if (mustBeComputed)
                cosx.ShouldBeNotNull().ShouldApproximatelyEqual(MathS.Cos(angle.ToEntity() / 2));
            else
                cosx.ShouldBeNull();
        }
        
        [Theory, CombinatorialData]
        public Unit SineCosineMultiplerExpansionTest(
            [CombinatorialValues("pi", "pi / 2", "- pi / 3", "pi / 10", "3", "30 pi", "-30 pi")] string xRaw, 
            [CombinatorialValues(-3, -2, -1, 0, 1, 2, 3, 4, 5)] int n,
            [CombinatorialValues(true, false)] bool testSin
            )
            => testSin.Let(out var x, xRaw.ToEntity()) switch
            {
                true =>
                    MathS.ExperimentalFeatures.ExpandSineArgumentMultiplied(
                    sinx: MathS.Sin(x),
                    cosx: MathS.Cos(x),
                    n: n
                    ).ShouldApproximatelyEqual(MathS.Sin(n * x)),
                false => 
                    MathS.ExperimentalFeatures.ExpandCosineArgumentMultiplied(
                        sinx: MathS.Sin(x),
                        cosx: MathS.Cos(x),
                        n: n
                    ).ShouldApproximatelyEqual(MathS.Cos(n * x))
            };
        
        [Theory]
        [InlineData("pi", 1, 2, 3, "34", "pi / 6")]
        [InlineData("pi")]
        [InlineData("pi", 0)]
        [InlineData("pi", -1)]
        [InlineData("pi / 6", "pi / 3")]
        [InlineData(0)]
        [InlineData("-pi / 6", "pi / 6")]
        [InlineData("pi / 10", "pi / 9", "pi / 8")]
        [InlineData("pi / 10", "pi / 9", "pi / 8", 1, 2, 3, 5, 6, 7)]
        public void ExpandSineOfSumTest(params object[] anglesRaw)
            => anglesRaw.Select(c => c is int i ? (Entity)i : c.Downcast<string>())
                .Pipe(angles => MathS.ExperimentalFeatures.ExpandSineOfSum(
                    angles.Select(
                            angle => (SinX: MathS.Sin(angle), CosX: MathS.Cos(angle))
                        ).ToList()
                )
                .ShouldApproximatelyEqual(
                    MathS.Sin(angles.Aggregate((a, b) => a + b))
                )
                );
        
        [Theory]
        [InlineData("pi", 1, 2, 3, "34", "pi / 6")]
        [InlineData("pi")]
        [InlineData("pi", 0)]
        [InlineData("pi", -1)]
        [InlineData("pi / 6", "pi / 3")]
        [InlineData(0)]
        [InlineData("-pi / 6", "pi / 6")]
        [InlineData("pi / 10", "pi / 9", "pi / 8")]
        [InlineData("pi / 10", "pi / 9", "pi / 8", 1, 2, 3, 5, 6, 7)]
        public void ExpandCosineOfSumTest(params object[] anglesRaw)
            => anglesRaw.Select(c => c is int i ? (Entity)i : c.Downcast<string>())
                .Pipe(angles => MathS.ExperimentalFeatures.ExpandCosineOfSum(
                        angles.Select(
                            angle => (SinX: MathS.Sin(angle), CosX: MathS.Cos(angle))
                        ).ToList()
                    )
                    .ShouldApproximatelyEqual(
                        MathS.Cos(angles.Aggregate((a, b) => a + b))
                    )
                );
        
        [Theory]
        [InlineData("1/3 pi + 1/6 pi")]
        [InlineData("1/4 pi + 1/7 pi")]
        [InlineData("1/3 pi + 2/6 pi")]
        [InlineData("1/4 pi + 2/7 pi")]
        [InlineData("55/84 pi + 2/3 pi")]
        [InlineData("142pi - 23pi")]
        [InlineData("17/7pi")]
        [InlineData("pi/3 - pi/2")]
        [InlineData("pi")]
        [InlineData("pi / 42")]
        [InlineData("1/2pi")]
        [InlineData("1/3pi")]
        [InlineData("-4/3pi")]
        [InlineData("-4/3pi - 7/4pi")]
        [InlineData("-4/3pi + 7/4pi")]
        [InlineData("-4/3pi + 3/4pi")]
        [InlineData("-4/3pi + 3/7pi")]
        [InlineData("pi / (3 * 4 * 7)")]
        [InlineData("100/7pi")]
        [InlineData("100/7pi + 100/3pi")]
        public void SymbolicSineFormTest(string angle)
            => angle
                .Pipe(angle => angle.ToEntity())
                .Simplify()  // so that we don't lose precision, but at the same time compose it all into a single  argument
                .Pipe(
                    angle => MathS.ExperimentalFeatures.SymbolicFormOfSine(angle)
                        .ShouldBeNotNull()
                        .ShouldApproximatelyEqual(MathS.Sin(angle))
                    );
        
        [Theory]
        [InlineData("1/3 pi + 1/6 pi")]
        [InlineData("1/4 pi + 1/7 pi")]
        [InlineData("1/3 pi + 2/6 pi")]
        [InlineData("1/4 pi + 2/7 pi")]
        [InlineData("55/84 pi + 2/3 pi")]
        [InlineData("142pi - 23pi")]
        [InlineData("17/7pi")]
        [InlineData("pi/3 - pi/2")]
        [InlineData("pi")]
        [InlineData("pi / 42")]
        [InlineData("1/2pi")]
        [InlineData("1/3pi")]
        [InlineData("-4/3pi")]
        [InlineData("-4/3pi - 7/4pi")]
        [InlineData("-4/3pi + 7/4pi")]
        [InlineData("-4/3pi + 3/4pi")]
        [InlineData("-4/3pi + 3/7pi")]
        [InlineData("pi / (3 * 4 * 7)")]
        [InlineData("100/7pi")]
        [InlineData("100/7pi + 100/3pi")]
        public void SymbolicCosineFormTest(string angle)
            => angle
                .Pipe(angle => angle.ToEntity())
                .Simplify()  // so that we don't lose precision, but at the same time compose it all into a single  argument
                .Pipe(
                    angle => MathS.ExperimentalFeatures.SymbolicFormOfCosine(angle)
                        .ShouldBeNotNull()
                        .ShouldApproximatelyEqual(MathS.Cos(angle))
                );
    }
}

