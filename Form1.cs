using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewTryCombAlg
{
    public partial class BreakingAlgorithm : Form
    {     
        const int Max = 100;
        public List<int> Allowed = new List<int>() {};
        int[] s = new int[Max];
        public void Print(int length)
        {
            uint i;
            for (i = 1; i < length; i++)
            {
                textBox1.AppendText(s[i] + " + ");
            }
            textBox1.AppendText(s[length]+"");
            textBox1.AppendText(Environment.NewLine);
            
            
        }
        public void DevNum(int n, int pos)
        {
            int gTarget = Allowed.Count;
            int k;
            int p;
            for (p = gTarget; p > 0; p--)
            {
                k = Allowed[p - 1];
                if (n > k)
                {
                    s[pos] = k;

                    if (s[pos] <= s[pos - 1])
                    
                        DevNum(n - k, pos + 1);
                    
                }
                else if (n == k)
                {
                    s[pos] = k;
                    if (s[pos] <= s[pos - 1])
                    
                        Print(pos);
                    
                }
            }
            
        }
        public BreakingAlgorithm()
        {
            InitializeComponent();
        }





        public void button(object sender, EventArgs e)
        {
            textBox1.Clear();
                foreach (string str in AllowedNum.Text.Split(' ',','))
                {
                    if (int.Parse(str) <= int.Parse(TargetN.Text))
                    {


                        try
                        {


                            Allowed.Add(int.Parse(str));
                        }
                        catch
                        {
                            MessageBox.Show("Моля въведете цели числа, разделени със space.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Моля въведете числа, които са по-малки от целта."); break;
                    }
                }


                try
                {
                    s[0] = int.Parse(TargetN.Text) + 1;
                    DevNum(int.Parse(TargetN.Text), 1);
                }
                catch
                {
                    MessageBox.Show("Моля въведете цяло число");

                }
                Allowed.Clear();
            }



        }

    }
    
