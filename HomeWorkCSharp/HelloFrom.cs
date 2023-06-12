using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.Windows.Forms;

namespace Lab_Frm
{
    public partial class HelloFrom : System.Windows.Forms.Form
    {
        public HelloFrom()
        {
            InitializeComponent();
        }

        private void btnNameHello_Click(object sender, EventArgs e)
        {
            string input = null;
            if (string.IsNullOrWhiteSpace(input)) { MessageBox.Show("尚未輸入資料"); }
            else 
            {   
            string name =  txtName.Text;
            string nameEN = txtNameEN.Text;
            string gender = txtGender.Text;
            string starSign = txtStarSign.Text;
            string chiZodiac = txtChiZodiac.Text;
            System.Windows.Forms.MessageBox.Show("Hello, " + "\r\n我的姓名是：" + name + "\r\n我的英文名是：" + nameEN + "\r\n我的性別是：" + gender + "\r\n我的星座是：" + starSign + "\r\n我的生肖是：" + chiZodiac + "!");
            }
        }

        private void btnNameHi_Click(object sender, EventArgs e)
        {
            string input = null;
            if (string.IsNullOrWhiteSpace(input)) { MessageBox.Show("尚未輸入資料"); }
            else
            {
            string name = txtName.Text;
            string nameEN = txtNameEN.Text;
            string gender = txtGender.Text;
            string starSign = txtStarSign.Text;
            string chiZodiac = txtChiZodiac.Text;
            System.Windows.Forms.MessageBox.Show("Hi," + "\r\n我的姓名是：" + name + "\r\n我的英文名是：" + nameEN + "\r\n我的性別是：" + gender + "\r\n我的星座是：" + starSign + "\r\n我的生肖是：" + chiZodiac + "!");
            }
        }

    }
}
