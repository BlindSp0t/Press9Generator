using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Press9Generator
{
    public partial class Form1 : Form
    {
        private List<LetterMatrice> __Initial = new List<LetterMatrice>();
        private List<LetterMatrice> __Phrase = new List<LetterMatrice>();
        private LetterMatrice __Output = new LetterMatrice();

        public Form1()
        {
            InitializeComponent();

            // Initialize the Letters library
            Initialize();
        }

        /// <summary>
        /// Generates the random text and renders it in the output textbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            // Reinitialize the controls of the form
            lbCheckCopy.Hide();
            __Phrase.Clear();
            __Output = new LetterMatrice();
            tbOutput.Clear();

            // Check for user input
            if (tbInput.TextLength > 0)
            {
                string s = tbInput.Text;

                // Converts input to lower
                // since the programs only understands lowercase chars
                s = s.ToLowerInvariant();

                // For each letter in the user's input
                // add a "converted" letter object
                // to the phrase library
                foreach(char c in s)
                {
                    try
                    {
                        __Phrase.Add(__Initial.Where(x => x.Char == c).First());
                    }
                    catch(Exception ex) { }
                }

                // Converts the phrase library to a single "letter"
                foreach(LetterMatrice lm in __Phrase)
                {
                    __Output.Line1 += lm.Line1;
                    __Output.Line2 += lm.Line2;
                    __Output.Line3 += lm.Line3;
                    __Output.Line4 += lm.Line4;
                    __Output.Line5 += lm.Line5;
                }

                // Add a buffered line to the top and bottom
                // for upgraded randomness
                int ct = __Output.Line1.Length;
                string buffer0 = "";
                string buffer1 = "";
                int i = 0;
                Random r = new Random();
                char[] numbers = { '0', '1', '2', '3', '4', '5', '6', '7', '8' };
                while(i < ct)
                {
                    buffer0 += numbers[r.Next(0, numbers.Length - 1)];
                    buffer1 += numbers[r.Next(0, numbers.Length - 1)];
                    i++;
                }

                // Outputs the result of the transformation
                // to the output textbox
                // With nonrandom numbers added to the end 
                tbOutput.AppendText(buffer0);
                tbOutput.AppendText("1");
                tbOutput.AppendText(Environment.NewLine);
                tbOutput.AppendText(__Output.Line1);
                tbOutput.AppendText("3");
                tbOutput.AppendText(Environment.NewLine);
                tbOutput.AppendText(__Output.Line2);
                tbOutput.AppendText("3");
                tbOutput.AppendText(Environment.NewLine);
                tbOutput.AppendText(__Output.Line3);
                tbOutput.AppendText("7");
                tbOutput.AppendText(Environment.NewLine);
                tbOutput.AppendText(__Output.Line4);
                tbOutput.AppendText("5");
                tbOutput.AppendText(Environment.NewLine);
                tbOutput.AppendText(__Output.Line5);
                tbOutput.AppendText("2");
                tbOutput.AppendText(Environment.NewLine);
                tbOutput.AppendText(buffer1);
                tbOutput.AppendText("1");
                tbOutput.AppendText(Environment.NewLine);
                tbOutput.AppendText(Environment.NewLine);

                /// Outputs the additional infos
                tbOutput.AppendText("Step1: Highlight the numbers﻿");
                tbOutput.AppendText(Environment.NewLine);
                tbOutput.AppendText("Step2: Ctrl and F﻿");
                tbOutput.AppendText(Environment.NewLine);
                tbOutput.AppendText("Step3: Put 9 in ");
                tbOutput.AppendText(Environment.NewLine);
                tbOutput.AppendText("Step4: Enjoy");
            }
            else
            {
                tbInput.BackColor = Color.OrangeRed;
            }
        }

        /// <summary>
        /// Registers the output textbox to the user's clipboard
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btCopy_Click(object sender, EventArgs e)
        {
            if (tbOutput.Text.Length > 0)
            {
                Clipboard.SetText(tbOutput.Text);
                lbCheckCopy.Show();
            }
            else
            {
                tbInput.BackColor = Color.OrangeRed;
            }
        }


        /// <summary>
        /// Initializes the Letters library
        /// </summary>
        private void Initialize()
        {
            LetterMatrice a = new LetterMatrice();
            a.Line1 = "7999999"; a.Line2 = "8992199"; a.Line3 = "8999999"; a.Line4 = "6992799"; a.Line5 = "4991199"; a.Char = 'a';
            __Initial.Add(a);
            LetterMatrice b = new LetterMatrice();
            b.Line1 = "2999990"; b.Line2 = "3997199"; b.Line3 = "5999992"; b.Line4 = "3994499"; b.Line5 = "6999995"; b.Char = 'b';
            __Initial.Add(b);
            LetterMatrice c = new LetterMatrice();
            c.Line1 = "3399999"; c.Line2 = "0995232"; c.Line3 = "7997541"; c.Line4 = "6993647"; c.Line5 = "1099999"; c.Char = 'c';
            __Initial.Add(c);
            LetterMatrice d = new LetterMatrice();
            d.Line1 = "0999992"; d.Line2 = "8992199"; d.Line3 = "4995799"; d.Line4 = "0991699"; d.Line5 = "6999995"; d.Char = 'd';
            __Initial.Add(d);
            LetterMatrice e = new LetterMatrice();
            e.Line1 = "5999999"; e.Line2 = "5991432"; e.Line3 = "0999902"; e.Line4 = "5994375"; e.Line5 = "3999999"; e.Char = 'e';
            __Initial.Add(e);
            LetterMatrice f = new LetterMatrice();
            f.Line1 = "0999999"; f.Line2 = "3997546"; f.Line3 = "3999957"; f.Line4 = "1990062"; f.Line5 = "4994372"; f.Char = 'f';
            __Initial.Add(f);
            LetterMatrice g = new LetterMatrice();
            g.Line1 = "1699999"; g.Line2 = "4994200"; g.Line3 = "1992299"; g.Line4 = "5994059"; g.Line5 = "4299990"; g.Char = 'g';
            __Initial.Add(g);
            LetterMatrice h = new LetterMatrice();
            h.Line1 = "4995499"; h.Line2 = "5991599"; h.Line3 = "0999999"; h.Line4 = "0994599"; h.Line5 = "2991299"; h.Char = 'h';
            __Initial.Add(h);
            LetterMatrice i = new LetterMatrice();
            i.Line1 = "5999999"; i.Line2 = "3759953"; i.Line3 = "0379972"; i.Line4 = "5519930"; i.Line5 = "5999999"; i.Char = 'i';
            __Initial.Add(i);
            LetterMatrice j = new LetterMatrice();
            j.Line1 = "2999999"; j.Line2 = "1129957"; j.Line3 = "5319935"; j.Line4 = "0479962"; j.Line5 = "1999170"; j.Char = 'j';
            __Initial.Add(j);
            LetterMatrice k = new LetterMatrice();
            k.Line1 = "1996099"; k.Line2 = "7991994"; k.Line3 = "6999476"; k.Line4 = "3995994"; k.Line5 = "6994699"; k.Char = 'k';
            __Initial.Add(k);
            LetterMatrice l = new LetterMatrice();
            l.Line1 = "1994453"; l.Line2 = "4994504"; l.Line3 = "2990671"; l.Line4 = "2994764"; l.Line5 = "6999999"; l.Char = 'l';
            __Initial.Add(l);
            LetterMatrice m = new LetterMatrice();
            m.Line1 = "2999999"; m.Line2 = "4999999"; m.Line3 = "3993199"; m.Line4 = "7992399"; m.Line5 = "3997099"; m.Char = 'm';
            __Initial.Add(m);
            LetterMatrice n = new LetterMatrice();
            n.Line1 = "0994399"; n.Line2 = "1999399"; n.Line3 = "4990999"; n.Line4 = "1992799"; n.Line5 = "7994699"; n.Char = 'n';
            __Initial.Add(n);
            LetterMatrice o = new LetterMatrice();
            o.Line1 = "7799990"; o.Line2 = "4991699"; o.Line3 = "0994399"; o.Line4 = "2992499"; o.Line5 = "6099995"; o.Char = 'o';
            __Initial.Add(o);
            LetterMatrice p = new LetterMatrice();
            p.Line1 = "1999997"; p.Line2 = "7996399"; p.Line3 = "7999997"; p.Line4 = "2997037"; p.Line5 = "7992727"; p.Char = 'p';
            __Initial.Add(p);
            LetterMatrice q = new LetterMatrice();
            q.Line1 = "2299991"; q.Line2 = "5997599"; q.Line3 = "4997799"; q.Line4 = "6990999"; q.Line5 = "0099999"; q.Char = 'q';
            __Initial.Add(q);
            LetterMatrice r = new LetterMatrice();
            r.Line1 = "0999996"; r.Line2 = "4991499"; r.Line3 = "6999993"; r.Line4 = "7993990"; r.Line5 = "0993599"; r.Char = 'r';
            __Initial.Add(r);
            LetterMatrice s = new LetterMatrice();
            s.Line1 = "6799999"; s.Line2 = "2991702"; s.Line3 = "1599997"; s.Line4 = "7262099"; s.Line5 = "6999990"; s.Char = 's';
            __Initial.Add(s);
            LetterMatrice t = new LetterMatrice();
            t.Line1 = "4999999"; t.Line2 = "3319906"; t.Line3 = "6339942"; t.Line4 = "2549934"; t.Line5 = "4009932"; t.Char = 't';
            __Initial.Add(t);
            LetterMatrice u = new LetterMatrice();
            u.Line1 = "1992099"; u.Line2 = "7996499"; u.Line3 = "3997699"; u.Line4 = "6997399"; u.Line5 = "2299993"; u.Char = 'u';
            __Initial.Add(u);
            LetterMatrice v = new LetterMatrice();
            v.Line1 = "5991499"; v.Line2 = "4990299"; v.Line3 = "0496791"; v.Line4 = "6493793"; v.Line5 = "0059927"; v.Char = 'v';
            __Initial.Add(v);
            LetterMatrice w = new LetterMatrice();
            w.Line1 = "5994299"; w.Line2 = "5995799"; w.Line3 = "3997699"; w.Line4 = "3999999"; w.Line5 = "4999999"; w.Char = 'w';
            __Initial.Add(w);
            LetterMatrice x = new LetterMatrice();
            x.Line1 = "1997199"; x.Line2 = "5590790"; x.Line3 = "7749944"; x.Line4 = "4692596"; x.Line5 = "6990099"; x.Char = 'x';
            __Initial.Add(x);
            LetterMatrice y = new LetterMatrice();
            y.Line1 = "5997699"; y.Line2 = "3499799"; y.Line3 = "7619999"; y.Line4 = "0743799"; y.Line5 = "6016299"; y.Char = 'y';
            __Initial.Add(y);
            LetterMatrice z = new LetterMatrice();
            z.Line1 = "0999999"; z.Line2 = "4730990"; z.Line3 = "6279910"; z.Line4 = "7299765"; z.Line5 = "7999999"; z.Char = 'z';
            __Initial.Add(z);
            LetterMatrice space = new LetterMatrice();
            space.Line1 = "16"; space.Line2 = "76"; space.Line3 = "33"; space.Line4 = "68"; space.Line5 = "11"; space.Char = ' ';
            __Initial.Add(space);

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.ProcessStartInfo sInfo = new System.Diagnostics.ProcessStartInfo("https://www.reddit.com/user/BlindSp0t/");
            System.Diagnostics.Process.Start(sInfo);
        }
    }
}
