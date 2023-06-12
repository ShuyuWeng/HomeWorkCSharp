using HomeWorkCSharp;
using Lab_Frm;
using System;
using System.Windows.Forms;

namespace HomeWork
{
    public partial class frmHomepage : Form
    {
        public frmHomepage()
        {
            InitializeComponent();
        }

        //https://blog.csdn.net/qq_36819953/article/details/85262143
        private void btnOpenName_Click(object sender, EventArgs e)
        {
            HelloFrom frm_M02 = new HelloFrom();
            //設置子視窗不顯示為頂級窗口
            frm_M02.TopLevel = false;
            //設置子窗口的樣式，沒有上面的標題欄
            //frm_M02.FormBorderStyle = FormBorderStyle.None;
            //填充
            //frm_M02.Dock = DockStyle.Fill;
            //清空panel裡的控件
            splitContainer2.Panel2.Controls.Clear();
            //加入控件
            splitContainer2.Panel2.Controls.Add(frm_M02);
            frm_M02.Show();
        }

        private void btnOpenMyClass_Click(object sender, EventArgs e)
        {
            FrmMyCalc frmCalc = new FrmMyCalc();
            frmCalc.TopLevel = false;            
            splitContainer2.Panel2.Controls.Clear();
            splitContainer2.Panel2.Controls.Add(frmCalc);
            frmCalc.Show();
        }

        private void btnOpenPOS_Click(object sender, EventArgs e)
        {
            FrmPOS frmPOS = new FrmPOS();
            frmPOS.TopLevel = false;            
            splitContainer2.Panel2.Controls.Clear();
            splitContainer2.Panel2.Controls.Add(frmPOS);
            frmPOS.Show();
        }

        private void btnOpenLoan_Click(object sender, EventArgs e)
        {
            FrmLoan frmLoan = new FrmLoan();
            frmLoan.TopLevel = false;
            splitContainer2.Panel2.Controls.Clear();
            splitContainer2.Panel2.Controls.Add(frmLoan);
            frmLoan.Show();
        }      

        private void btnOpenStuStructForm_Click(object sender, EventArgs e)
        {
            sStructForm sStruckFrm = new sStructForm();
            sStruckFrm.TopLevel = false;
            splitContainer2.Panel2.Controls.Clear();
            splitContainer2.Panel2.Controls.Add(sStruckFrm);
            sStruckFrm.Show();
        }

        private void btnOpenStuGrade_Click(object sender, EventArgs e)
        {
            StudentsGradeFrm sGFrm = new StudentsGradeFrm();
            sGFrm.TopLevel = false;
            splitContainer2.Panel2.Controls.Clear();
            splitContainer2.Panel2.Controls.Add(sGFrm);
            sGFrm.Show();
        }

        private void btnOpenGuess_Click(object sender, EventArgs e)
        {
            FormGuessNumber GN = new FormGuessNumber();
            GN.TopLevel = false;
            splitContainer2.Panel2.Controls.Clear();
            splitContainer2.Panel2.Controls.Add(GN);
            GN.Show();
        }        

        private void btnOpenForDoWhile_Click(object sender, EventArgs e)
        {
            ForDoWhile fdw = new ForDoWhile();
            fdw.TopLevel = false;
            splitContainer2.Panel2.Controls.Clear();
            splitContainer2.Panel2.Controls.Add(fdw);
            fdw.Show();
        }     

        private void btnOpenAlam_Click(object sender, EventArgs e)
        {
            Alarm AL = new Alarm();
            AL.TopLevel = false;
            splitContainer2.Panel2.Controls.Clear();
            splitContainer2.Panel2.Controls.Add(AL);
            AL.Show();
        }

        private void btnOpenNotepad_Click(object sender, EventArgs e)
        {
            Notepad Np = new Notepad();
            Np.TopLevel = false;
            splitContainer2.Panel2.Controls.Clear();
            splitContainer2.Panel2.Controls.Add(Np);
            Np.Show();
        }

        private void btnOpenPainter_Click(object sender, EventArgs e)
        {
            小畫家 paint = new 小畫家();
            paint.TopLevel = false;
            splitContainer2.Panel2.Controls.Clear();
            splitContainer2.Panel2.Controls.Add(paint);
            paint.Show();
        }

    }
}
