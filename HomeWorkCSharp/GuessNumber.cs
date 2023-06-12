using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.Remoting.Lifetime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeWorkCSharp
{
    public partial class FormGuessNumber : Form
    {
        public FormGuessNumber()
        {
            InitializeComponent();
            number();
        }

        static int answer = 0;    
        int max = 100;
        int min = 0;        
        
        public static void number()
        {
            Random random = new Random();
            answer = random.Next(1, 100); 
        }       

        private void btnGuess_Click(object sender, EventArgs e)
        {
            string input = Interaction.InputBox("請輸入一個數字", "輸入框", "");
            int i = int.Parse(input); 
            if (input != null)
            {
                if (int.TryParse(input, out i))
                {
                    if (i >= 1 && i <= 100)
                    {
                        if (i == answer)
                        { MessageBox.Show("恭喜!猜對了"); }
                        else if (i < answer)
                        {
                            min = i;
                            labResult.Text = $"太小了，請再猜{min}到{max}之間的數字";
                        }
                        else if (i > answer)
                        {
                            max = i;
                            labResult.Text = $"太大了，請再猜{min}到{max}之間的數字";
                        }
                        else 
                        { MessageBox.Show("請輸入提示範圍內的數字"); }
                    }
                    else if(i>100)
                    {
                        MessageBox.Show("數字超過，請輸入提示範圍內的數字");
                    }
                }
                else
                { MessageBox.Show("請輸入數字"); }
            }
        }
        private void btnShow_Click(object sender, EventArgs e)
        {
            MessageBox.Show("答案是:"+ answer);
            number();
        }      
    }
}
