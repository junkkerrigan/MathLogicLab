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
using Antlr4.Runtime;
using Antlr4.Runtime.Atn;
using Antlr4.Runtime.Misc;
using DFA = Antlr4.Runtime.Dfa.DFA;

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.7.2")]
[System.CLSCompliant(false)]
public partial class PropositionalLogicGrammarLexer : Lexer {
	protected static DFA[] decisionToDFA;
	protected static PredictionContextCache sharedContextCache = new PredictionContextCache();
	public const int
		COMMA=1, CONCLUSION=2, CONJUNCTION=3, DISJUNCTION=4, IMPLICATION=5, LITERAL=6, 
		LITERAL_NEGATION=7, NEGATION=8, LETTER=9, LBRACKET=10, RBRACKET=11, LCURLYBRACKET=12, 
		RCURLYBRACKET=13, WHITESPACE=14, INVALID=15;
	public static string[] channelNames = {
		"DEFAULT_TOKEN_CHANNEL", "HIDDEN"
	};

	public static string[] modeNames = {
		"DEFAULT_MODE"
	};

	public static readonly string[] ruleNames = {
		"COMMA", "CONCLUSION", "CONJUNCTION", "DISJUNCTION", "IMPLICATION", "LITERAL", 
		"LITERAL_NEGATION", "NEGATION", "LETTER", "LBRACKET", "RBRACKET", "LCURLYBRACKET", 
		"RCURLYBRACKET", "WHITESPACE", "INVALID"
	};


	public PropositionalLogicGrammarLexer(ICharStream input)
	: this(input, Console.Out, Console.Error) { }

	public PropositionalLogicGrammarLexer(ICharStream input, TextWriter output, TextWriter errorOutput)
	: base(input, output, errorOutput)
	{
		Interpreter = new LexerATNSimulator(this, _ATN, decisionToDFA, sharedContextCache);
	}

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

	public override string[] ChannelNames { get { return channelNames; } }

	public override string[] ModeNames { get { return modeNames; } }

	public override string SerializedAtn { get { return new string(_serializedATN); } }

	static PropositionalLogicGrammarLexer() {
		decisionToDFA = new DFA[_ATN.NumberOfDecisions];
		for (int i = 0; i < _ATN.NumberOfDecisions; i++) {
			decisionToDFA[i] = new DFA(_ATN.GetDecisionState(i), i);
		}
	}
	private static char[] _serializedATN = {
		'\x3', '\x608B', '\xA72A', '\x8133', '\xB9ED', '\x417C', '\x3BE7', '\x7786', 
		'\x5964', '\x2', '\x11', 'G', '\b', '\x1', '\x4', '\x2', '\t', '\x2', 
		'\x4', '\x3', '\t', '\x3', '\x4', '\x4', '\t', '\x4', '\x4', '\x5', '\t', 
		'\x5', '\x4', '\x6', '\t', '\x6', '\x4', '\a', '\t', '\a', '\x4', '\b', 
		'\t', '\b', '\x4', '\t', '\t', '\t', '\x4', '\n', '\t', '\n', '\x4', '\v', 
		'\t', '\v', '\x4', '\f', '\t', '\f', '\x4', '\r', '\t', '\r', '\x4', '\xE', 
		'\t', '\xE', '\x4', '\xF', '\t', '\xF', '\x4', '\x10', '\t', '\x10', '\x3', 
		'\x2', '\x3', '\x2', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', 
		'\x4', '\x3', '\x4', '\x3', '\x5', '\x3', '\x5', '\x3', '\x6', '\x3', 
		'\x6', '\x3', '\x6', '\x3', '\a', '\x3', '\a', '\x3', '\b', '\x3', '\b', 
		'\x3', '\b', '\x3', '\t', '\x3', '\t', '\x3', '\n', '\x3', '\n', '\x3', 
		'\v', '\x3', '\v', '\x3', '\f', '\x3', '\f', '\x3', '\r', '\x3', '\r', 
		'\x3', '\xE', '\x3', '\xE', '\x3', '\xF', '\x6', '\xF', '@', '\n', '\xF', 
		'\r', '\xF', '\xE', '\xF', '\x41', '\x3', '\xF', '\x3', '\xF', '\x3', 
		'\x10', '\x3', '\x10', '\x2', '\x2', '\x11', '\x3', '\x3', '\x5', '\x4', 
		'\a', '\x5', '\t', '\x6', '\v', '\a', '\r', '\b', '\xF', '\t', '\x11', 
		'\n', '\x13', '\v', '\x15', '\f', '\x17', '\r', '\x19', '\xE', '\x1B', 
		'\xF', '\x1D', '\x10', '\x1F', '\x11', '\x3', '\x2', '\x6', '\x4', '\x2', 
		'(', '(', '`', '`', '\x4', '\x2', 'x', 'x', '~', '~', '\x5', '\x2', '#', 
		'#', '/', '/', '\x80', '\x80', '\x4', '\x2', '\v', '\v', '\"', '\"', '\x2', 
		'G', '\x2', '\x3', '\x3', '\x2', '\x2', '\x2', '\x2', '\x5', '\x3', '\x2', 
		'\x2', '\x2', '\x2', '\a', '\x3', '\x2', '\x2', '\x2', '\x2', '\t', '\x3', 
		'\x2', '\x2', '\x2', '\x2', '\v', '\x3', '\x2', '\x2', '\x2', '\x2', '\r', 
		'\x3', '\x2', '\x2', '\x2', '\x2', '\xF', '\x3', '\x2', '\x2', '\x2', 
		'\x2', '\x11', '\x3', '\x2', '\x2', '\x2', '\x2', '\x13', '\x3', '\x2', 
		'\x2', '\x2', '\x2', '\x15', '\x3', '\x2', '\x2', '\x2', '\x2', '\x17', 
		'\x3', '\x2', '\x2', '\x2', '\x2', '\x19', '\x3', '\x2', '\x2', '\x2', 
		'\x2', '\x1B', '\x3', '\x2', '\x2', '\x2', '\x2', '\x1D', '\x3', '\x2', 
		'\x2', '\x2', '\x2', '\x1F', '\x3', '\x2', '\x2', '\x2', '\x3', '!', '\x3', 
		'\x2', '\x2', '\x2', '\x5', '#', '\x3', '\x2', '\x2', '\x2', '\a', '&', 
		'\x3', '\x2', '\x2', '\x2', '\t', '(', '\x3', '\x2', '\x2', '\x2', '\v', 
		'*', '\x3', '\x2', '\x2', '\x2', '\r', '-', '\x3', '\x2', '\x2', '\x2', 
		'\xF', '/', '\x3', '\x2', '\x2', '\x2', '\x11', '\x32', '\x3', '\x2', 
		'\x2', '\x2', '\x13', '\x34', '\x3', '\x2', '\x2', '\x2', '\x15', '\x36', 
		'\x3', '\x2', '\x2', '\x2', '\x17', '\x38', '\x3', '\x2', '\x2', '\x2', 
		'\x19', ':', '\x3', '\x2', '\x2', '\x2', '\x1B', '<', '\x3', '\x2', '\x2', 
		'\x2', '\x1D', '?', '\x3', '\x2', '\x2', '\x2', '\x1F', '\x45', '\x3', 
		'\x2', '\x2', '\x2', '!', '\"', '\a', '.', '\x2', '\x2', '\"', '\x4', 
		'\x3', '\x2', '\x2', '\x2', '#', '$', '\a', '~', '\x2', '\x2', '$', '%', 
		'\a', '?', '\x2', '\x2', '%', '\x6', '\x3', '\x2', '\x2', '\x2', '&', 
		'\'', '\t', '\x2', '\x2', '\x2', '\'', '\b', '\x3', '\x2', '\x2', '\x2', 
		'(', ')', '\t', '\x3', '\x2', '\x2', ')', '\n', '\x3', '\x2', '\x2', '\x2', 
		'*', '+', '\a', '/', '\x2', '\x2', '+', ',', '\a', '@', '\x2', '\x2', 
		',', '\f', '\x3', '\x2', '\x2', '\x2', '-', '.', '\x5', '\x13', '\n', 
		'\x2', '.', '\xE', '\x3', '\x2', '\x2', '\x2', '/', '\x30', '\x5', '\x11', 
		'\t', '\x2', '\x30', '\x31', '\x5', '\x13', '\n', '\x2', '\x31', '\x10', 
		'\x3', '\x2', '\x2', '\x2', '\x32', '\x33', '\t', '\x4', '\x2', '\x2', 
		'\x33', '\x12', '\x3', '\x2', '\x2', '\x2', '\x34', '\x35', '\x4', '\x43', 
		'\\', '\x2', '\x35', '\x14', '\x3', '\x2', '\x2', '\x2', '\x36', '\x37', 
		'\a', '*', '\x2', '\x2', '\x37', '\x16', '\x3', '\x2', '\x2', '\x2', '\x38', 
		'\x39', '\a', '+', '\x2', '\x2', '\x39', '\x18', '\x3', '\x2', '\x2', 
		'\x2', ':', ';', '\a', '}', '\x2', '\x2', ';', '\x1A', '\x3', '\x2', '\x2', 
		'\x2', '<', '=', '\a', '\x7F', '\x2', '\x2', '=', '\x1C', '\x3', '\x2', 
		'\x2', '\x2', '>', '@', '\t', '\x5', '\x2', '\x2', '?', '>', '\x3', '\x2', 
		'\x2', '\x2', '@', '\x41', '\x3', '\x2', '\x2', '\x2', '\x41', '?', '\x3', 
		'\x2', '\x2', '\x2', '\x41', '\x42', '\x3', '\x2', '\x2', '\x2', '\x42', 
		'\x43', '\x3', '\x2', '\x2', '\x2', '\x43', '\x44', '\b', '\xF', '\x2', 
		'\x2', '\x44', '\x1E', '\x3', '\x2', '\x2', '\x2', '\x45', '\x46', '\v', 
		'\x2', '\x2', '\x2', '\x46', ' ', '\x3', '\x2', '\x2', '\x2', '\x4', '\x2', 
		'\x41', '\x3', '\b', '\x2', '\x2',
	};

	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN);


}
