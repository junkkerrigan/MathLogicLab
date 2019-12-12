//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.7.2
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from .\PropositionalLogicGrammar.g4 by ANTLR 4.7.2

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using IToken = Antlr4.Runtime.IToken;

/// <summary>
/// This interface defines a complete generic visitor for a parse tree produced
/// by <see cref="PropositionalLogicGrammarParser"/>.
/// </summary>
/// <typeparam name="Result">The return type of the visit operation.</typeparam>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.7.2")]
[System.CLSCompliant(false)]
public interface IPropositionalLogicGrammarVisitor<Result> : IParseTreeVisitor<Result> {
	/// <summary>
	/// Visit a parse tree produced by <see cref="PropositionalLogicGrammarParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitStatement([NotNull] PropositionalLogicGrammarParser.StatementContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="PropositionalLogicGrammarParser.result"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitResult([NotNull] PropositionalLogicGrammarParser.ResultContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>Disjunction</c>
	/// labeled alternative in <see cref="PropositionalLogicGrammarParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitDisjunction([NotNull] PropositionalLogicGrammarParser.DisjunctionContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>Literal</c>
	/// labeled alternative in <see cref="PropositionalLogicGrammarParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitLiteral([NotNull] PropositionalLogicGrammarParser.LiteralContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>LiteralNegation</c>
	/// labeled alternative in <see cref="PropositionalLogicGrammarParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitLiteralNegation([NotNull] PropositionalLogicGrammarParser.LiteralNegationContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>Conjunction</c>
	/// labeled alternative in <see cref="PropositionalLogicGrammarParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitConjunction([NotNull] PropositionalLogicGrammarParser.ConjunctionContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>Implication</c>
	/// labeled alternative in <see cref="PropositionalLogicGrammarParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitImplication([NotNull] PropositionalLogicGrammarParser.ImplicationContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>Parentheses</c>
	/// labeled alternative in <see cref="PropositionalLogicGrammarParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitParentheses([NotNull] PropositionalLogicGrammarParser.ParenthesesContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>Invalid</c>
	/// labeled alternative in <see cref="PropositionalLogicGrammarParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitInvalid([NotNull] PropositionalLogicGrammarParser.InvalidContext context);
}
