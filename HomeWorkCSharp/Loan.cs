using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static HomeWorkCSharp.FrmLoan;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HomeWorkCSharp
{
    public partial class FrmLoan : Form
    {
        public FrmLoan()
        {
            InitializeComponent();
            InitialListView();
        }     
       
        public double benjin, nr, mr, mB, mLi, tLi, mBL;
        public int pmoth;        

        private void btn計算_Click(object sender, EventArgs e)
        {
            listViewlab.Items.Clear();
            
            //{本金-(本金/貸款月數*(n-1)月)}*24/100(利率)/12(每月利息) +本金= 每月應還本金+每月應還利息
            //月還本金=本金/月數(還月總數=貸款年期*12)
            //月還本息金額=每月應還本金+每月應付利息
            //月還利息金額=本金餘額*月利率(年利率/12)       

            benjin = Convert.ToDouble(txtPrice.Text);
            pmoth = Convert.ToInt32(txt貸款期數月.Text);
            nr = Convert.ToDouble(txt年利率.Text)*0.01;    //年利率      
                        
            mB = benjin / pmoth; //月還本金=本金/月數(還月總數=貸款年期*12)
            mr =  nr / 12; //月利率
            tLi = 0;
            
            for (int n = 1; n < (pmoth +1); n++)
            {
                mBL = (benjin - (mB * (n - 1)))* mr + benjin ; 
                mLi = (benjin - (mB * (n - 1))) * mr; //月還利息金額=本金餘額*月利率(年利率/12)  
                tLi += mLi;
                
                ListViewItem lv = new ListViewItem();
                lv.Text = n.ToString("f0");
                lv.SubItems.Add(mB.ToString("f0"));
                lv.SubItems.Add(mLi.ToString("f0"));
                lv.SubItems.Add((mB + mLi).ToString("f0"));
                listViewlab.Items.Add(lv);
            }
           
            txt全部利息.Text = Convert.ToString(tLi); 
        }

        private void InitialListView()
        {
            listViewlab.View = View.Details;
            listViewlab.GridLines = true;
            listViewlab.LabelEdit = false;
            listViewlab.FullRowSelect = true;            
            listViewlab.Columns.Add("期數", 50);
            listViewlab.Columns.Add("償還本金", 80);
            listViewlab.Columns.Add("償還利息", 80);
            listViewlab.Columns.Add("本期應繳金額", 110);            
        }

        private void btn清除_Click(object sender, EventArgs e)
        {          
            listViewlab.Items.Clear();
            txt全部利息.Text = Convert.ToString("");
        }
    }
}
