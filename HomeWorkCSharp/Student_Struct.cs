using HomeWorkCSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Lab_Frm
{
    public partial class sStructForm : Form
    {
        public sStructForm()
        {
            InitializeComponent();
        }

        private  Student stu;
        double totalScore = 0;
        private void btnAdd_Click(object sender, EventArgs e)
        {         
                stu.Name = txtName.Text;
                stu.國文 = int.Parse(txt國文.Text);
                stu.英文 = int.Parse(txt英文.Text);
                stu.數學 = int.Parse(txt數學.Text);
                totalScore = stu.國文 + stu.英文 + stu.數學;                               
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
          
             lab結果.Text = $"姓名:{stu.Name}\n國文:{stu.國文}\n英文:{stu.英文}\n數學:{stu.數學}";         
        }

        private void btn平均分數_Click(object sender, EventArgs e)
        {                 
             lab統計.Text = $"總分:{totalScore},平均分數:{((int)totalScore / 3)}";              
        }

        private void btn最高最低_Click(object sender, EventArgs e)
        {
            string[] 科目 = {"國文", "英文","數學"};
            int[] scores = {stu.國文, stu.英文, stu.數學};
            int hscore = scores[0];
            int lscore = scores[0];
            int h = 0;
            int l = 0;
            if (string.IsNullOrWhiteSpace(txtName.Text)) { MessageBox.Show("尚未輸入資料"); }
            else
            {
                for (int i = 0; i < 3; i++)
                {
                    if (scores[i] > hscore)
                    {
                        hscore = scores[i];
                        h = i;
                    }
                    if (scores[i] < lscore)
                    {
                        lscore = scores[i];
                        l = i;
                    }
                }
                lab統計.Text = $"最高分數為{科目[h]}{hscore}分, \n最低分數為{科目[l]}{lscore}分";
            }                
        }
        

        
    }
}
