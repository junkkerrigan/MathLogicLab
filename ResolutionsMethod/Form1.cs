using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Antlr4.Runtime;

namespace ResolutionsMethod
{
    public partial class Form1 : Form
    {
        // {AvB, BvC}|=AvC
        // {~BvAvC, BvC, ~AvC}|=A
        // {A, A, A}|=A
        // {PvQ, ~PvR, ~QvS, ~RvSvP, ~SvP}|=P
        // {A->B, C->D} |= A&B->C&D
        // {A->B, C->D} |= A&C->B&D

        TextBox Formula;
        Button Submit;
        RichTextBox Result;

        public Form1()
        {
            InitializeComponent();
            Formula = new TextBox()
            {
                Size = new Size(400, 30),
                Location = new Point((ClientSize.Width - 500) / 2, 
                    (ClientSize.Height - 300) / 2),
                Font = new Font("Verdana", 20),
            };
            Submit = new Button()
            {
                Size = new Size(80, 30),
                Location = new Point(Formula.Right + 15, Formula.Top + 5),
                Text = "Submit",
            };
            Submit.Click += (s, e) =>
            {
                var inputStream = new AntlrInputStream(Formula.Text);
                var lexer = new PropositionalLogicGrammarLexer(inputStream);
                var commonTokenStream = new CommonTokenStream(lexer);
                var parser = new PropositionalLogicGrammarParser(commonTokenStream);
                var res = parser.statement();
                HashSet<Literal> allVars = new HashSet<Literal>();
                var ans = (new PropositionalVisitor(ref allVars)).Visit(res);
                var contraryInstance = new Estimation();
                bool isNonContr = 
                    ans.IsNonContradictory(ref contraryInstance, allVars);
                Result.Text = "";
                Result.Text += $"Formula is {isNonContr}";
                if (!isNonContr)
                {
                    Result.Text += $"\nContrary instance is: {contraryInstance.Print()}";
                }
            };
            Result = new RichTextBox()
            {
                Size = new Size(ClientSize.Width - 200, ClientSize.Height - Formula.Bottom - 80),
                Location = new Point(100, Formula.Bottom + 40),
                Font = new Font("Verdana", 20),
            };
            Controls.Add(Formula);
            Controls.Add(Submit);
            Controls.Add(Result);

            SizeChanged += (s, e) =>
            {
                Formula.Location = new Point((ClientSize.Width - 500) / 2,
                    (ClientSize.Height - 200) / 2);
                Submit.Location = new Point(Formula.Right + 15, Formula.Top + 5);
                Result.Size = new Size(ClientSize.Width - 200, ClientSize.Height - Formula.Bottom - 80);
                Result.Location = new Point(100, Formula.Bottom + 40);
            };
        }


    }
}
