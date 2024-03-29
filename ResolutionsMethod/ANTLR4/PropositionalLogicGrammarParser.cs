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

using System;
using System.IO;
using System.Text;
using System.Diagnostics;
using System.Collections.Generic;
using Antlr4.Runtime;
using Antlr4.Runtime.Atn;
using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using DFA = Antlr4.Runtime.Dfa.DFA;

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.7.2")]
[System.CLSCompliant(false)]
public partial class PropositionalLogicGrammarParser : Parser {
	protected static DFA[] decisionToDFA;
	protected static PredictionContextCache sharedContextCache = new PredictionContextCache();
	public const int
		COMMA=1, CONCLUSION=2, CONJUNCTION=3, DISJUNCTION=4, IMPLICATION=5, LITERAL=6, 
		LITERAL_NEGATION=7, NEGATION=8, LETTER=9, LBRACKET=10, RBRACKET=11, LCURLYBRACKET=12, 
		RCURLYBRACKET=13, WHITESPACE=14, INVALID=15;
	public const int
		RULE_statement = 0, RULE_result = 1, RULE_expression = 2;
	public static readonly string[] ruleNames = {
		"statement", "result", "expression"
	};

	private static readonly string[] _LiteralNames = {
		null, "','", "'|='", null, null, "'->'", null, null, null, null, "'('", 
		"')'", "'{'", "'}'"
	};
	private static readonly string[] _SymbolicNames = {
		null, "COMMA", "CONCLUSION", "CONJUNCTION", "DISJUNCTION", "IMPLICATION", 
		"LITERAL", "LITERAL_NEGATION", "NEGATION", "LETTER", "LBRACKET", "RBRACKET", 
		"LCURLYBRACKET", "RCURLYBRACKET", "WHITESPACE", "INVALID"
	};
	public static readonly IVocabulary DefaultVocabulary = new Vocabulary(_LiteralNames, _SymbolicNames);

	[NotNull]
	public override IVocabulary Vocabulary
	{
		get
		{
			return DefaultVocabulary;
		}
	}

	public override string GrammarFileName { get { return "PropositionalLogicGrammar.g4"; } }

	public override string[] RuleNames { get { return ruleNames; } }

	public override string SerializedAtn { get { return new string(_serializedATN); } }

	static PropositionalLogicGrammarParser() {
		decisionToDFA = new DFA[_ATN.NumberOfDecisions];
		for (int i = 0; i < _ATN.NumberOfDecisions; i++) {
			decisionToDFA[i] = new DFA(_ATN.GetDecisionState(i), i);
		}
	}

		public PropositionalLogicGrammarParser(ITokenStream input) : this(input, Console.Out, Console.Error) { }

		public PropositionalLogicGrammarParser(ITokenStream input, TextWriter output, TextWriter errorOutput)
		: base(input, output, errorOutput)
	{
		Interpreter = new ParserATNSimulator(this, _ATN, decisionToDFA, sharedContextCache);
	}

	public partial class StatementContext : ParserRuleContext {
		public ITerminalNode LCURLYBRACKET() { return GetToken(PropositionalLogicGrammarParser.LCURLYBRACKET, 0); }
		public ExpressionContext[] expression() {
			return GetRuleContexts<ExpressionContext>();
		}
		public ExpressionContext expression(int i) {
			return GetRuleContext<ExpressionContext>(i);
		}
		public ITerminalNode RCURLYBRACKET() { return GetToken(PropositionalLogicGrammarParser.RCURLYBRACKET, 0); }
		public ITerminalNode CONCLUSION() { return GetToken(PropositionalLogicGrammarParser.CONCLUSION, 0); }
		public ResultContext result() {
			return GetRuleContext<ResultContext>(0);
		}
		public ITerminalNode Eof() { return GetToken(PropositionalLogicGrammarParser.Eof, 0); }
		public ITerminalNode[] COMMA() { return GetTokens(PropositionalLogicGrammarParser.COMMA); }
		public ITerminalNode COMMA(int i) {
			return GetToken(PropositionalLogicGrammarParser.COMMA, i);
		}
		public StatementContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_statement; } }
		public override void EnterRule(IParseTreeListener listener) {
			IPropositionalLogicGrammarListener typedListener = listener as IPropositionalLogicGrammarListener;
			if (typedListener != null) typedListener.EnterStatement(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IPropositionalLogicGrammarListener typedListener = listener as IPropositionalLogicGrammarListener;
			if (typedListener != null) typedListener.ExitStatement(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IPropositionalLogicGrammarVisitor<TResult> typedVisitor = visitor as IPropositionalLogicGrammarVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitStatement(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public StatementContext statement() {
		StatementContext _localctx = new StatementContext(Context, State);
		EnterRule(_localctx, 0, RULE_statement);
		try {
			int _alt;
			EnterOuterAlt(_localctx, 1);
			{
			State = 6; Match(LCURLYBRACKET);
			State = 12;
			ErrorHandler.Sync(this);
			_alt = Interpreter.AdaptivePredict(TokenStream,0,Context);
			while ( _alt!=2 && _alt!=global::Antlr4.Runtime.Atn.ATN.INVALID_ALT_NUMBER ) {
				if ( _alt==1 ) {
					{
					{
					State = 7; expression(0);
					State = 8; Match(COMMA);
					}
					} 
				}
				State = 14;
				ErrorHandler.Sync(this);
				_alt = Interpreter.AdaptivePredict(TokenStream,0,Context);
			}
			State = 15; expression(0);
			State = 16; Match(RCURLYBRACKET);
			State = 17; Match(CONCLUSION);
			State = 18; result();
			State = 19; Match(Eof);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class ResultContext : ParserRuleContext {
		public ExpressionContext expression() {
			return GetRuleContext<ExpressionContext>(0);
		}
		public ResultContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_result; } }
		public override void EnterRule(IParseTreeListener listener) {
			IPropositionalLogicGrammarListener typedListener = listener as IPropositionalLogicGrammarListener;
			if (typedListener != null) typedListener.EnterResult(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IPropositionalLogicGrammarListener typedListener = listener as IPropositionalLogicGrammarListener;
			if (typedListener != null) typedListener.ExitResult(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IPropositionalLogicGrammarVisitor<TResult> typedVisitor = visitor as IPropositionalLogicGrammarVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitResult(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public ResultContext result() {
		ResultContext _localctx = new ResultContext(Context, State);
		EnterRule(_localctx, 2, RULE_result);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 21; expression(0);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class ExpressionContext : ParserRuleContext {
		public ExpressionContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_expression; } }
	 
		public ExpressionContext() { }
		public virtual void CopyFrom(ExpressionContext context) {
			base.CopyFrom(context);
		}
	}
	public partial class DisjunctionContext : ExpressionContext {
		public ExpressionContext[] expression() {
			return GetRuleContexts<ExpressionContext>();
		}
		public ExpressionContext expression(int i) {
			return GetRuleContext<ExpressionContext>(i);
		}
		public ITerminalNode DISJUNCTION() { return GetToken(PropositionalLogicGrammarParser.DISJUNCTION, 0); }
		public DisjunctionContext(ExpressionContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			IPropositionalLogicGrammarListener typedListener = listener as IPropositionalLogicGrammarListener;
			if (typedListener != null) typedListener.EnterDisjunction(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IPropositionalLogicGrammarListener typedListener = listener as IPropositionalLogicGrammarListener;
			if (typedListener != null) typedListener.ExitDisjunction(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IPropositionalLogicGrammarVisitor<TResult> typedVisitor = visitor as IPropositionalLogicGrammarVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitDisjunction(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class LiteralContext : ExpressionContext {
		public ITerminalNode LITERAL() { return GetToken(PropositionalLogicGrammarParser.LITERAL, 0); }
		public LiteralContext(ExpressionContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			IPropositionalLogicGrammarListener typedListener = listener as IPropositionalLogicGrammarListener;
			if (typedListener != null) typedListener.EnterLiteral(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IPropositionalLogicGrammarListener typedListener = listener as IPropositionalLogicGrammarListener;
			if (typedListener != null) typedListener.ExitLiteral(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IPropositionalLogicGrammarVisitor<TResult> typedVisitor = visitor as IPropositionalLogicGrammarVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitLiteral(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class LiteralNegationContext : ExpressionContext {
		public ITerminalNode LITERAL_NEGATION() { return GetToken(PropositionalLogicGrammarParser.LITERAL_NEGATION, 0); }
		public LiteralNegationContext(ExpressionContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			IPropositionalLogicGrammarListener typedListener = listener as IPropositionalLogicGrammarListener;
			if (typedListener != null) typedListener.EnterLiteralNegation(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IPropositionalLogicGrammarListener typedListener = listener as IPropositionalLogicGrammarListener;
			if (typedListener != null) typedListener.ExitLiteralNegation(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IPropositionalLogicGrammarVisitor<TResult> typedVisitor = visitor as IPropositionalLogicGrammarVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitLiteralNegation(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class ConjunctionContext : ExpressionContext {
		public ExpressionContext[] expression() {
			return GetRuleContexts<ExpressionContext>();
		}
		public ExpressionContext expression(int i) {
			return GetRuleContext<ExpressionContext>(i);
		}
		public ITerminalNode CONJUNCTION() { return GetToken(PropositionalLogicGrammarParser.CONJUNCTION, 0); }
		public ConjunctionContext(ExpressionContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			IPropositionalLogicGrammarListener typedListener = listener as IPropositionalLogicGrammarListener;
			if (typedListener != null) typedListener.EnterConjunction(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IPropositionalLogicGrammarListener typedListener = listener as IPropositionalLogicGrammarListener;
			if (typedListener != null) typedListener.ExitConjunction(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IPropositionalLogicGrammarVisitor<TResult> typedVisitor = visitor as IPropositionalLogicGrammarVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitConjunction(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class ImplicationContext : ExpressionContext {
		public ExpressionContext[] expression() {
			return GetRuleContexts<ExpressionContext>();
		}
		public ExpressionContext expression(int i) {
			return GetRuleContext<ExpressionContext>(i);
		}
		public ITerminalNode IMPLICATION() { return GetToken(PropositionalLogicGrammarParser.IMPLICATION, 0); }
		public ImplicationContext(ExpressionContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			IPropositionalLogicGrammarListener typedListener = listener as IPropositionalLogicGrammarListener;
			if (typedListener != null) typedListener.EnterImplication(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IPropositionalLogicGrammarListener typedListener = listener as IPropositionalLogicGrammarListener;
			if (typedListener != null) typedListener.ExitImplication(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IPropositionalLogicGrammarVisitor<TResult> typedVisitor = visitor as IPropositionalLogicGrammarVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitImplication(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class ParenthesesContext : ExpressionContext {
		public ITerminalNode LBRACKET() { return GetToken(PropositionalLogicGrammarParser.LBRACKET, 0); }
		public ExpressionContext expression() {
			return GetRuleContext<ExpressionContext>(0);
		}
		public ITerminalNode RBRACKET() { return GetToken(PropositionalLogicGrammarParser.RBRACKET, 0); }
		public ParenthesesContext(ExpressionContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			IPropositionalLogicGrammarListener typedListener = listener as IPropositionalLogicGrammarListener;
			if (typedListener != null) typedListener.EnterParentheses(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IPropositionalLogicGrammarListener typedListener = listener as IPropositionalLogicGrammarListener;
			if (typedListener != null) typedListener.ExitParentheses(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IPropositionalLogicGrammarVisitor<TResult> typedVisitor = visitor as IPropositionalLogicGrammarVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitParentheses(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class InvalidContext : ExpressionContext {
		public ITerminalNode INVALID() { return GetToken(PropositionalLogicGrammarParser.INVALID, 0); }
		public InvalidContext(ExpressionContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			IPropositionalLogicGrammarListener typedListener = listener as IPropositionalLogicGrammarListener;
			if (typedListener != null) typedListener.EnterInvalid(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IPropositionalLogicGrammarListener typedListener = listener as IPropositionalLogicGrammarListener;
			if (typedListener != null) typedListener.ExitInvalid(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IPropositionalLogicGrammarVisitor<TResult> typedVisitor = visitor as IPropositionalLogicGrammarVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitInvalid(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public ExpressionContext expression() {
		return expression(0);
	}

	private ExpressionContext expression(int _p) {
		ParserRuleContext _parentctx = Context;
		int _parentState = State;
		ExpressionContext _localctx = new ExpressionContext(Context, _parentState);
		ExpressionContext _prevctx = _localctx;
		int _startState = 4;
		EnterRecursionRule(_localctx, 4, RULE_expression, _p);
		try {
			int _alt;
			EnterOuterAlt(_localctx, 1);
			{
			State = 31;
			ErrorHandler.Sync(this);
			switch (TokenStream.LA(1)) {
			case LBRACKET:
				{
				_localctx = new ParenthesesContext(_localctx);
				Context = _localctx;
				_prevctx = _localctx;

				State = 24; Match(LBRACKET);
				State = 25; expression(0);
				State = 26; Match(RBRACKET);
				}
				break;
			case LITERAL_NEGATION:
				{
				_localctx = new LiteralNegationContext(_localctx);
				Context = _localctx;
				_prevctx = _localctx;
				State = 28; Match(LITERAL_NEGATION);
				}
				break;
			case LITERAL:
				{
				_localctx = new LiteralContext(_localctx);
				Context = _localctx;
				_prevctx = _localctx;
				State = 29; Match(LITERAL);
				}
				break;
			case INVALID:
				{
				_localctx = new InvalidContext(_localctx);
				Context = _localctx;
				_prevctx = _localctx;
				State = 30; Match(INVALID);
				}
				break;
			default:
				throw new NoViableAltException(this);
			}
			Context.Stop = TokenStream.LT(-1);
			State = 44;
			ErrorHandler.Sync(this);
			_alt = Interpreter.AdaptivePredict(TokenStream,3,Context);
			while ( _alt!=2 && _alt!=global::Antlr4.Runtime.Atn.ATN.INVALID_ALT_NUMBER ) {
				if ( _alt==1 ) {
					if ( ParseListeners!=null )
						TriggerExitRuleEvent();
					_prevctx = _localctx;
					{
					State = 42;
					ErrorHandler.Sync(this);
					switch ( Interpreter.AdaptivePredict(TokenStream,2,Context) ) {
					case 1:
						{
						_localctx = new ConjunctionContext(new ExpressionContext(_parentctx, _parentState));
						PushNewRecursionContext(_localctx, _startState, RULE_expression);
						State = 33;
						if (!(Precpred(Context, 6))) throw new FailedPredicateException(this, "Precpred(Context, 6)");
						State = 34; Match(CONJUNCTION);
						State = 35; expression(7);
						}
						break;
					case 2:
						{
						_localctx = new DisjunctionContext(new ExpressionContext(_parentctx, _parentState));
						PushNewRecursionContext(_localctx, _startState, RULE_expression);
						State = 36;
						if (!(Precpred(Context, 5))) throw new FailedPredicateException(this, "Precpred(Context, 5)");
						State = 37; Match(DISJUNCTION);
						State = 38; expression(6);
						}
						break;
					case 3:
						{
						_localctx = new ImplicationContext(new ExpressionContext(_parentctx, _parentState));
						PushNewRecursionContext(_localctx, _startState, RULE_expression);
						State = 39;
						if (!(Precpred(Context, 4))) throw new FailedPredicateException(this, "Precpred(Context, 4)");
						State = 40; Match(IMPLICATION);
						State = 41; expression(5);
						}
						break;
					}
					} 
				}
				State = 46;
				ErrorHandler.Sync(this);
				_alt = Interpreter.AdaptivePredict(TokenStream,3,Context);
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			UnrollRecursionContexts(_parentctx);
		}
		return _localctx;
	}

	public override bool Sempred(RuleContext _localctx, int ruleIndex, int predIndex) {
		switch (ruleIndex) {
		case 2: return expression_sempred((ExpressionContext)_localctx, predIndex);
		}
		return true;
	}
	private bool expression_sempred(ExpressionContext _localctx, int predIndex) {
		switch (predIndex) {
		case 0: return Precpred(Context, 6);
		case 1: return Precpred(Context, 5);
		case 2: return Precpred(Context, 4);
		}
		return true;
	}

	private static char[] _serializedATN = {
		'\x3', '\x608B', '\xA72A', '\x8133', '\xB9ED', '\x417C', '\x3BE7', '\x7786', 
		'\x5964', '\x3', '\x11', '\x32', '\x4', '\x2', '\t', '\x2', '\x4', '\x3', 
		'\t', '\x3', '\x4', '\x4', '\t', '\x4', '\x3', '\x2', '\x3', '\x2', '\x3', 
		'\x2', '\x3', '\x2', '\a', '\x2', '\r', '\n', '\x2', '\f', '\x2', '\xE', 
		'\x2', '\x10', '\v', '\x2', '\x3', '\x2', '\x3', '\x2', '\x3', '\x2', 
		'\x3', '\x2', '\x3', '\x2', '\x3', '\x2', '\x3', '\x3', '\x3', '\x3', 
		'\x3', '\x4', '\x3', '\x4', '\x3', '\x4', '\x3', '\x4', '\x3', '\x4', 
		'\x3', '\x4', '\x3', '\x4', '\x3', '\x4', '\x5', '\x4', '\"', '\n', '\x4', 
		'\x3', '\x4', '\x3', '\x4', '\x3', '\x4', '\x3', '\x4', '\x3', '\x4', 
		'\x3', '\x4', '\x3', '\x4', '\x3', '\x4', '\x3', '\x4', '\a', '\x4', '-', 
		'\n', '\x4', '\f', '\x4', '\xE', '\x4', '\x30', '\v', '\x4', '\x3', '\x4', 
		'\x2', '\x3', '\x6', '\x5', '\x2', '\x4', '\x6', '\x2', '\x2', '\x2', 
		'\x35', '\x2', '\b', '\x3', '\x2', '\x2', '\x2', '\x4', '\x17', '\x3', 
		'\x2', '\x2', '\x2', '\x6', '!', '\x3', '\x2', '\x2', '\x2', '\b', '\xE', 
		'\a', '\xE', '\x2', '\x2', '\t', '\n', '\x5', '\x6', '\x4', '\x2', '\n', 
		'\v', '\a', '\x3', '\x2', '\x2', '\v', '\r', '\x3', '\x2', '\x2', '\x2', 
		'\f', '\t', '\x3', '\x2', '\x2', '\x2', '\r', '\x10', '\x3', '\x2', '\x2', 
		'\x2', '\xE', '\f', '\x3', '\x2', '\x2', '\x2', '\xE', '\xF', '\x3', '\x2', 
		'\x2', '\x2', '\xF', '\x11', '\x3', '\x2', '\x2', '\x2', '\x10', '\xE', 
		'\x3', '\x2', '\x2', '\x2', '\x11', '\x12', '\x5', '\x6', '\x4', '\x2', 
		'\x12', '\x13', '\a', '\xF', '\x2', '\x2', '\x13', '\x14', '\a', '\x4', 
		'\x2', '\x2', '\x14', '\x15', '\x5', '\x4', '\x3', '\x2', '\x15', '\x16', 
		'\a', '\x2', '\x2', '\x3', '\x16', '\x3', '\x3', '\x2', '\x2', '\x2', 
		'\x17', '\x18', '\x5', '\x6', '\x4', '\x2', '\x18', '\x5', '\x3', '\x2', 
		'\x2', '\x2', '\x19', '\x1A', '\b', '\x4', '\x1', '\x2', '\x1A', '\x1B', 
		'\a', '\f', '\x2', '\x2', '\x1B', '\x1C', '\x5', '\x6', '\x4', '\x2', 
		'\x1C', '\x1D', '\a', '\r', '\x2', '\x2', '\x1D', '\"', '\x3', '\x2', 
		'\x2', '\x2', '\x1E', '\"', '\a', '\t', '\x2', '\x2', '\x1F', '\"', '\a', 
		'\b', '\x2', '\x2', ' ', '\"', '\a', '\x11', '\x2', '\x2', '!', '\x19', 
		'\x3', '\x2', '\x2', '\x2', '!', '\x1E', '\x3', '\x2', '\x2', '\x2', '!', 
		'\x1F', '\x3', '\x2', '\x2', '\x2', '!', ' ', '\x3', '\x2', '\x2', '\x2', 
		'\"', '.', '\x3', '\x2', '\x2', '\x2', '#', '$', '\f', '\b', '\x2', '\x2', 
		'$', '%', '\a', '\x5', '\x2', '\x2', '%', '-', '\x5', '\x6', '\x4', '\t', 
		'&', '\'', '\f', '\a', '\x2', '\x2', '\'', '(', '\a', '\x6', '\x2', '\x2', 
		'(', '-', '\x5', '\x6', '\x4', '\b', ')', '*', '\f', '\x6', '\x2', '\x2', 
		'*', '+', '\a', '\a', '\x2', '\x2', '+', '-', '\x5', '\x6', '\x4', '\a', 
		',', '#', '\x3', '\x2', '\x2', '\x2', ',', '&', '\x3', '\x2', '\x2', '\x2', 
		',', ')', '\x3', '\x2', '\x2', '\x2', '-', '\x30', '\x3', '\x2', '\x2', 
		'\x2', '.', ',', '\x3', '\x2', '\x2', '\x2', '.', '/', '\x3', '\x2', '\x2', 
		'\x2', '/', '\a', '\x3', '\x2', '\x2', '\x2', '\x30', '.', '\x3', '\x2', 
		'\x2', '\x2', '\x6', '\xE', '!', ',', '.',
	};

	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN);


}
