﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace Check_for_balanced_parentheses_using_stack
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
        //this function is to check if balanced parenthses or not 
        public bool CheckBalancedParenthes(string expression)
        {
            // get the expression length
            int lenght = expression.Length;

            //initialize anew instance of the stack class
            Stack s = new Stack();

            // loop through the expression
            for (int i = 0; i <= lenght-1; i++)
            {
                if (expression[i].ToString() == "(" || expression[i].ToString() == "{" || expression[i].ToString()=="[")
                {
                    s.Push(expression[i]);
                }

                else if (expression[i].ToString() == ")" || expression[i].ToString() == "}" || expression[i].ToString() == "]")
                {
                    if (s.Count == 0 || s.Peek().ToString() != getpair(expression[i].ToString()).ToString())
                    {
                        return false;
                    }
                    else
                    {
                        s.Pop();
                    }
                }
            }
                return s.Count == 0 ? true : false ;
        }

        // this function for check if the pair with expression[i] or not
        public string getpair(string s)
        {
            if (s==")")
            {
                return "(";
            }
            else if (s == "}")
            {
                return "{";
            }
            else 
            {
                return "[";
            }
        }

        

        private void Form1_Load(object sender, EventArgs e)
        {
            wrightpbox.Visible = false;
            wrongpbox.Visible = false;
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            if (CheckBalancedParenthes(richTextBox1.Text))
            {
                labout.Text = "the expression is right";
                wrightpbox.Visible = true;
                wrongpbox.Visible = false;
                labout.ForeColor = Color.Green;

            }

            else
            {
                labout.Text = "the parantheses arn't balanced";
                wrightpbox.Visible = false;
                wrongpbox.Visible = true;
                labout.ForeColor = Color.Red;
            }
        }
    }
}
