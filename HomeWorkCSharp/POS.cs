using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeWorkCSharp
{
    public partial class FrmPOS : Form
    {
        public FrmPOS()
        {
            InitializeComponent();
        }

        double 炒飯num = 0, 炒飯price = 80;
        double 麵num = 0, 麵price = 90;
        double 披薩num = 0, 披薩price = 350;
        double 燉飯num = 0, 燉飯price = 210;
        double 炒飯total, 麵total, 披薩total, 燉飯total  ;
        string[] TotalOder = new string[4];

        private void btn炒飯_Click(object sender, EventArgs e)
        {            
            炒飯num += 1;
            string result炒飯 = "炒飯 Fried Rice x " + 炒飯num + " ,共 NT$ " + 炒飯num * 炒飯price + " 元\r\n";
            TotalOder[0] = result炒飯;
            txtOrder.Text = TotalOder[0] + TotalOder[1] + TotalOder[2] + TotalOder[3];
            炒飯total = 炒飯num * 炒飯price;
            txtTotalPrice.Text = "NT$ " + Convert.ToString(炒飯total + 麵total + 披薩total + 燉飯total);
        }

        private void btn麵_Click(object sender, EventArgs e)
        {
            麵num += 1;
            string result麵 = "麵 Noodle x " + 麵num + " ,共 NT$ " + 麵num * 麵price + " 元\r\n";
            TotalOder[1] = result麵;
            txtOrder.Text = TotalOder[0] + TotalOder[1] + TotalOder[2] + TotalOder[3];
            麵total = 麵num * 麵price;
            txtTotalPrice.Text = "NT$ " + Convert.ToString(炒飯total + 麵total + 披薩total + 燉飯total);
        }
        private void btn披薩_Click(object sender, EventArgs e)
        {
            披薩num += 1;
            string result披薩 = "披薩 Pizza x " + 披薩num + " ,共 NT$ " + 披薩num * 披薩price + " 元\r\n";
            TotalOder[2] = result披薩;
            txtOrder.Text = TotalOder[0] + TotalOder[1] + TotalOder[2] + TotalOder[3];
            披薩total = 披薩num * 披薩price;
            txtTotalPrice.Text = "NT$ " + Convert.ToString(炒飯total + 麵total + 披薩total + 燉飯total);
        }
        private void btn燉飯_Click(object sender, EventArgs e)
        {
            燉飯num += 1;
            string result燉飯 = "燉飯 Stew x " + 燉飯num + " ,共 NT$ " + 燉飯num * 燉飯price + " 元\r\n";
            TotalOder[3] = result燉飯;
            txtOrder.Text = TotalOder[0] + TotalOder[1] + TotalOder[2] + TotalOder[3];
            燉飯total = 燉飯num * 燉飯price;
            txtTotalPrice.Text = "NT$ " + Convert.ToString(炒飯total + 麵total + 披薩total + 燉飯total);
        }   

        private void btnMoney_Click(object sender, EventArgs e)
        {
            MessageBox.Show("總金額： " + txtTotalPrice.Text, "確認付款", MessageBoxButtons.OKCancel);
        }

        private void btnCredit_Click(object sender, EventArgs e)
        {
            double cc = (炒飯total + 麵total + 披薩total + 燉飯total) * 0.9;
            MessageBox.Show("總金額： " + txtTotalPrice.Text + "\n折扣後的金額：NT$" + cc, "確認付款", MessageBoxButtons.OKCancel);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            炒飯total = 麵total = 披薩total = 燉飯total = 0;
            txtTotalPrice.Text = string.Empty +"NT$ 0";
            txtOrder.Text = string.Empty + "尚未點餐";
        }
    }
}
