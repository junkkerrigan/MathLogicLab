using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Antlr4.Runtime.Misc;

namespace ResolutionsMethod
{
    class PropositionalVisitor : PropositionalLogicGrammarBaseVisitor<Conjunct>
    {
        public PropositionalVisitor() : base()
        {
        }

        public override Conjunct VisitConjunction([NotNull] PropositionalLogicGrammarParser.ConjunctionContext context)
        {
            var l = WalkLeft(context);
            var r = WalkRight(context);
            Debug.WriteLine("Conjunction: "); l.Print(); Debug.Write(" & "); r.Print();
            return l.Add(r);
        }

        public override Conjunct VisitDisjunction([NotNull] PropositionalLogicGrammarParser.DisjunctionContext context)
        {
            var l = WalkLeft(context);
            var r = WalkRight(context);
            Debug.WriteLine("\nDisjunction: "); l.Print(); Debug.Write(" v "); r.Print();
            return l.Disjunction(r);
        }

        public override Conjunct VisitImplication([NotNull] PropositionalLogicGrammarParser.ImplicationContext context)
        {
            var l = WalkLeft(context);
            var r = WalkRight(context);
            Debug.WriteLine("Implication: "); l.Print(); Debug.Write(" -> "); r.Print();
            var notL = l.Negation();
            return notL.Disjunction(r);
        }

        public override Conjunct VisitInvalid([NotNull] PropositionalLogicGrammarParser.InvalidContext context)
        {
            throw new Exception();
        }

        public override Conjunct VisitLiteral([NotNull] PropositionalLogicGrammarParser.LiteralContext context)
        {
            var l = new Literal(context.GetText(), false);
            var d = new Disjunct(l);
            var ans = new Conjunct(d);
            Debug.WriteLine("\nLiteral: "); ans.Print();
            return ans;
        }

        public override Conjunct VisitLiteralNegation([NotNull] PropositionalLogicGrammarParser.LiteralNegationContext context)
        {
            var l = new Literal(context.GetText().Substring(1), true);
            var d = new Disjunct(l);
            var ans = new Conjunct(d);
            Debug.WriteLine("\nLiteralNegation: "); ans.Print();
            return ans;
        }

        public override Conjunct VisitParentheses([NotNull] PropositionalLogicGrammarParser.ParenthesesContext context)
        {
            var ans = Visit(context.expression());
            Debug.WriteLine("\nParentheses: "); ans.Print();
            return ans;
        }

        public override Conjunct VisitStatement([NotNull] PropositionalLogicGrammarParser.StatementContext context)
        {
            var neg = Visit(context.result()).Negation();
            Debug.WriteLine("\nAddin neg "); neg.Print();
            var res = new Conjunct(neg);
            foreach (var expr in context.expression())
            {
                var addon = Visit(expr);
                Debug.WriteLine("\nAdding "); addon.Print();
                res = res.Add(addon);
                Debug.WriteLine("\nres now is "); res.Print();
            }

            return res;
        }

        private Conjunct WalkLeft(PropositionalLogicGrammarParser.ExpressionContext context)
        {
            return Visit(context.GetRuleContext<PropositionalLogicGrammarParser.ExpressionContext>(0));
        }

        private Conjunct WalkRight(PropositionalLogicGrammarParser.ExpressionContext context)
        {
            return Visit(context.GetRuleContext<PropositionalLogicGrammarParser.ExpressionContext>(1));
        }
    }
}
