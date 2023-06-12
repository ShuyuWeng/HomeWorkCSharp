using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeWorkCSharp
{
    public partial class FrmMyCalc : Form
    {        
        
        public FrmMyCalc()
        {
            InitializeComponent();
        }
        //https://ithelp.ithome.com.tw/articles/10246440
        double result;
        private void butMyCalcAdd_Click(object sender, EventArgs e)
        {
            result = Convert.ToDouble(txtMyClalcNum1.Text) + Convert.ToDouble(txtMyClalcNum2.Text);
            txtMyClassAns.Text = result.ToString();            
        }

        private void btnMyCalcSub_Click(object sender, EventArgs e)
        {
            result = Convert.ToDouble(txtMyClalcNum1.Text) - Convert.ToDouble(txtMyClalcNum2.Text);
            txtMyClassAns.Text = result.ToString();
        }

        private void btnMyCalcMult_Click(object sender, EventArgs e)
        {
            result = Convert.ToDouble(txtMyClalcNum1.Text) * Convert.ToDouble(txtMyClalcNum2.Text);
            txtMyClassAns.Text = result.ToString();
        }

        private void btnMyCalcDiv_Click(object sender, EventArgs e)
        {
            result = Convert.ToDouble(txtMyClalcNum1.Text) / Convert.ToDouble(txtMyClalcNum2.Text);
            txtMyClassAns.Text = result.ToString();
        }             
    }
}
