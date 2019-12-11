grammar PropositionalLogicGrammar;


statement : LCURLYBRACKET (expression COMMA)+ expression RCURLYBRACKET CONCLUSION expression EOF;

expression /* determine the order */
	: LBRACKET expression RBRACKET #Parentheses
	| expression IMPLICATION expression #Implication
	| expression DISJUNCTION expression #Disjunction
	| expression CONJUNCTION expression #Conjunction
	| LITERAL #Literal
	| INVALID #Invalid
	;


CONCLUSION : '|=';
CONJUNCTION : '&';
DISJUNCTION : 'v';
IMPLICATION : '->';
LITERAL : (NEGATION)? LETTER;
NEGATION : '~';
LETTER : ('A'..'Z');
LBRACKET : '(';
RBRACKET : ')';
LCURLYBRACKET : '{';
RCURLYBRACKET : '}';
WHITESPACE : (' ' | '\t')+ -> skip;
INVALID : .;
