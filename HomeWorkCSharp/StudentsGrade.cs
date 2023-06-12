using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeWorkCSharp
{
    public partial class StudentsGradeFrm : Form
    {
        public StudentsGradeFrm()
        {
            InitializeComponent();
        }
       
        List<Student> stulst= new List<Student>();
        bool insert = false, search = false;
        int lowNum = 0, hightNum = 100;
        void WriteList(string n, int a, int b, int c) //輸入三科成績並計算後輸入至stu陣列
        {
            Student stu = new Student();
            stu.Name = n;
            stu.國文 = a;
            stu.英文 = b;
            stu.數學 = c;
            stu.totalScore = a + b + c;
            stu.Average = (float)stu.totalScore / 3;
            string maxSbj = "國文", minSbj = "國文";
            int max = a, min = a;
            if (b < min) { min = b; minSbj = "英文"; }
            else { max = b;maxSbj = "英文"; }
            if (c < min) { min = c; minSbj = "數學"; }
            else if (c > max) { max = c;maxSbj = "數學"; }
            stu.Max = maxSbj + $"{max}";
            stu.Min = minSbj + $"{min}";
            if (insert) stulst.Insert(0, stu);
            else stulst.Add(stu);
            btnStats.Enabled = true;
        }
        void ScoreGen(int a)  //生成隨機的分數資料，參數為生成比數
        {
            
            Random random = new Random();
            for (int i = 0; i < a; i++)
            {
                Student stu=new Student();
                stu.國文 = random.Next(0, 101);
                stu.英文 = random.Next(0, 101);
                stu.數學 = random.Next(0,101);
                stu.Name = $"{stulst.Count()+1}";
                WriteList(stu.Name,stu.國文,stu.英文,stu.數學);
            }
        }
        void ListUpdate() //同步stu陣列資料到表單上顯示
        {
            this.lstVwGrade.BeginUpdate();
            this.lstVwGrade.Items.Clear();
            foreach (Student stu in stulst)
            {
                ListViewItem lvi = new ListViewItem();
                if (search && (stu.國文 < lowNum || stu.國文 > hightNum)) { continue; }
                //若在搜尋 則判斷成績是否超出指定範圍，利用continue跳出
                //若不跳出，則新增一列資料到ListView
                lvi.Text = stu.Name;
                lvi.SubItems.Add($"{stu.國文}");
                lvi.SubItems.Add($"{stu.英文}");
                lvi.SubItems.Add($"{stu.數學}");
                lvi.SubItems.Add($"{stu.totalScore}");
                lvi.SubItems.Add($"{stu.Average:F}");
                lvi.SubItems.Add($"{stu.Max}");
                lvi.SubItems.Add($"{stu.Min}");
                this.lstVwGrade.Items.Add(lvi);
            }
            this.lstVwGrade.EndUpdate();
            //表單顯示狀況同步"統計"按鈕的關閉
            if (lstVwGrade.Items.Count == 0) { btnStats.Enabled = false; }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            //讀取txtbox字串，並處理型態錯誤及數值超出範圍的情形
            Student stu=new Student();
            stu.Name = txtName.Text;
            if (stu.Name.Length < 1)
                MessageBox.Show($"請輸入姓名", "姓名不得為空值", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (!int.TryParse(txt國文.Text, out stu.國文) ||
                !int.TryParse(txt英文.Text, out stu.英文) ||
                !int.TryParse(txt數學.Text, out stu.數學))
                MessageBox.Show($"請輸入整數", "格式錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (stu.國文 < 0 || stu.國文 > 100)
            {
                MessageBox.Show("國文分數打錯囉！！", "分數錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt國文.Focus();
            }
            else if (stu.英文 < 0 || stu.英文 > 100)
            {
                MessageBox.Show("英文分數打錯囉！！", "分數錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt國文.Focus();
            }
            else if (stu.數學 < 0 || stu.數學 > 100)
            {
                MessageBox.Show("數學分數打錯囉！！", "分數錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt國文.Focus();
            }
            else
            {
                WriteList(stu.Name,stu.國文,stu.英文,stu.數學);
                ListUpdate();
            }
        }
        private void btnInsert_Click(object sender, EventArgs e)
        {
            insert = true;
            btnAdd.PerformClick();
            insert = false;
        }
        private void btnRemove_Click(object sender, EventArgs e)
        {
            stulst.RemoveAt(0);
            ListUpdate();
        }

        private void btn隨機20_Click(object sender, EventArgs e)
        {
            ScoreGen(20);
            ListUpdate();
        }

        private void btn隨機存_Click(object sender, EventArgs e)
        {
            ScoreGen(1);
            ListUpdate();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            search = true;
            //讀取上下界，若無輸入則定為0-100
            if (!int.TryParse(txtNum1.Text, out lowNum)) { lowNum = 0; }
            if (!int.TryParse(txtNum2.Text, out hightNum)) { hightNum = 100; }
            ListUpdate();
            search = false;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            foreach (Control btn in this.Controls.OfType<Button>())
            { btn.Enabled = true; }
            this.lstVwStats.Items.Clear();
            stulst.Clear();
            ListUpdate();
        }
        private void btnStats_Click(object sender, EventArgs e)
        {
            int a = 0, b = 0, c = 0;
            int maxA = 0, maxB = 0, maxC = 0;
            int minA = 100, minB = 100, minC = 100;
            foreach (Student stu in stulst)
            {
                a += stu.國文;
                b += stu.英文;
                c += stu.數學;
                if (stu.國文 > maxA) maxA = stu.國文;
                if (stu.國文 < minA) minA = stu.國文;
                if (stu.英文 > maxB) maxB = stu.英文;
                if (stu.英文 < minB) minB = stu.英文;
                if (stu.數學 > maxC) maxC = stu.數學;
                if (stu.數學 < minC) minC = stu.數學;
            }
            this.lstVwStats.BeginUpdate();
            this.lstVwStats.Items.Clear();

            ListViewItem sum = new ListViewItem();
            sum.Text = "總分";
            sum.SubItems.Add($"{a}");
            sum.SubItems.Add($"{b}");
            sum.SubItems.Add($"{c}");
            this.lstVwStats.Items.Add(sum);

            ListViewItem avg = new ListViewItem();
            avg.Text = "平均";
            avg.SubItems.Add($"{a / stulst.Count:F}");
            avg.SubItems.Add($"{b / stulst.Count:F}");
            avg.SubItems.Add($"{c / stulst.Count:F}");
            this.lstVwStats.Items.Add(avg);

            ListViewItem max = new ListViewItem();
            max.Text = "最高";
            max.SubItems.Add($"{maxA}");
            max.SubItems.Add($"{maxB}");
            max.SubItems.Add($"{maxC}");
            this.lstVwStats.Items.Add(max);

            ListViewItem min = new ListViewItem();
            min.Text = "最低";
            min.SubItems.Add($"{minA}");
            min.SubItems.Add($"{minB}");
            min.SubItems.Add($"{minC}");
            this.lstVwStats.Items.Add(min);

            this.lstVwStats.EndUpdate();
            foreach (Control item in this.Controls)
            {
                if (item is Button && item != btnReset)
                {
                    item.Enabled = false;
                }
            }
        }
    }
}
