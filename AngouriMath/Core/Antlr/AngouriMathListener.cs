//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.8
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from ./AngouriMath.g by ANTLR 4.8

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

namespace AngouriMath.Core.Antlr {

    using System.Linq;
    using AngouriMath;
    using static AngouriMath.Core.Exceptions.FunctionArgumentCountException;

using Antlr4.Runtime.Misc;
using IParseTreeListener = Antlr4.Runtime.Tree.IParseTreeListener;
using IToken = Antlr4.Runtime.IToken;

/// <summary>
/// This interface defines a complete listener for a parse tree produced by
/// <see cref="AngouriMathParser"/>.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.8")]
[System.CLSCompliant(false)]
internal interface IAngouriMathListener : IParseTreeListener {
	/// <summary>
	/// Enter a parse tree produced by <see cref="AngouriMathParser.factorial_expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFactorial_expression([NotNull] AngouriMathParser.Factorial_expressionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="AngouriMathParser.factorial_expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFactorial_expression([NotNull] AngouriMathParser.Factorial_expressionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="AngouriMathParser.power_list"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterPower_list([NotNull] AngouriMathParser.Power_listContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="AngouriMathParser.power_list"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitPower_list([NotNull] AngouriMathParser.Power_listContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="AngouriMathParser.power_expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterPower_expression([NotNull] AngouriMathParser.Power_expressionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="AngouriMathParser.power_expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitPower_expression([NotNull] AngouriMathParser.Power_expressionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="AngouriMathParser.unary_expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterUnary_expression([NotNull] AngouriMathParser.Unary_expressionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="AngouriMathParser.unary_expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitUnary_expression([NotNull] AngouriMathParser.Unary_expressionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="AngouriMathParser.mult_expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterMult_expression([NotNull] AngouriMathParser.Mult_expressionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="AngouriMathParser.mult_expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitMult_expression([NotNull] AngouriMathParser.Mult_expressionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="AngouriMathParser.sum_expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSum_expression([NotNull] AngouriMathParser.Sum_expressionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="AngouriMathParser.sum_expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSum_expression([NotNull] AngouriMathParser.Sum_expressionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="AngouriMathParser.negate_expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterNegate_expression([NotNull] AngouriMathParser.Negate_expressionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="AngouriMathParser.negate_expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitNegate_expression([NotNull] AngouriMathParser.Negate_expressionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="AngouriMathParser.and_expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAnd_expression([NotNull] AngouriMathParser.And_expressionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="AngouriMathParser.and_expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAnd_expression([NotNull] AngouriMathParser.And_expressionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="AngouriMathParser.xor_expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterXor_expression([NotNull] AngouriMathParser.Xor_expressionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="AngouriMathParser.xor_expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitXor_expression([NotNull] AngouriMathParser.Xor_expressionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="AngouriMathParser.or_expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOr_expression([NotNull] AngouriMathParser.Or_expressionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="AngouriMathParser.or_expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOr_expression([NotNull] AngouriMathParser.Or_expressionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="AngouriMathParser.implies_expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterImplies_expression([NotNull] AngouriMathParser.Implies_expressionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="AngouriMathParser.implies_expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitImplies_expression([NotNull] AngouriMathParser.Implies_expressionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="AngouriMathParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterExpression([NotNull] AngouriMathParser.ExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="AngouriMathParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitExpression([NotNull] AngouriMathParser.ExpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="AngouriMathParser.function_arguments"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFunction_arguments([NotNull] AngouriMathParser.Function_argumentsContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="AngouriMathParser.function_arguments"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFunction_arguments([NotNull] AngouriMathParser.Function_argumentsContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="AngouriMathParser.atom"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAtom([NotNull] AngouriMathParser.AtomContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="AngouriMathParser.atom"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAtom([NotNull] AngouriMathParser.AtomContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="AngouriMathParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterStatement([NotNull] AngouriMathParser.StatementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="AngouriMathParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitStatement([NotNull] AngouriMathParser.StatementContext context);
}
} // namespace AngouriMath.Core.Antlr
