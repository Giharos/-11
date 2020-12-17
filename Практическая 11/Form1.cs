using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Практическая_11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            Regex regex = new Regex("a\\d*a");
            string s = "a1a a22a a333a a4444a a55555a aba aca";
            textBox1.Text = s;
            MatchCollection matches = regex.Matches(s);
            if (matches.Count > 0)
            {
                for (int i = 0; i < matches.Count; i++)
                    listBox1.Items.Add(matches[i]);
            }
            else MessageBox.Show("В списке №1 совпадений не найдено.");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {           
            Regex regex1 = new Regex("\\ba[^ex]a\\b");
            string s1 = "aba aea aca aza axa a-a a#a";
            textBox2.Text = s1;          
            MatchCollection matches1 = regex1.Matches(s1);
            if (matches1.Count > 0)
            {
                for (int i = 0; i < matches1.Count; i++)
                    lb2.Items.Add(matches1[i]);
            }
            else MessageBox.Show("В списке №2 совпадений не найдено.");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            lb2.Items.Clear();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Практическая работа №11\n" +
                "Платов Андрей вариант 12\n" +
                "1.Дана строка 'a1a a22a a333a a4444a a55555a aba aca'. Напишите регулярное выражение, которое найдет строки, в которых по краям стоят буквы 'a', а между ними любое количество цифр.\n" +
                "2.Дана строка 'aba aea aca aza axa a-a a#a'.Напишите регулярное выражение, котороенайдет строки следующего вида: по краям стоят буквы 'a', а между ними - не 'e' и не'x'.");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
