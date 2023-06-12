using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeWorkCSharp
{
    public partial class ForDoWhile :Form
    {
        public ForDoWhile()
        {
            InitializeComponent();            
        }
        private void btn清空結果欄_Click(object sender, EventArgs e)
        {
            lab結果.Text = "結果";            
            lab結果.ForeColor = Color.Gray;
            lab結果.BackColor = Color.LightSkyBlue;
        }       
        private void btn九九乘法表_Click(object sender, EventArgs e)
        {                       
            string result = "";            
            for (int i = 1; i < 10; i++)
            {
                for (int j = 1; j < 10; j++)
                { result += string.Format("{0,1}×{1,1}={2,2} |", i,j,i*j);}
                result += "\r\n";
            }            
            lab結果.Text = result;
            lab結果.BackColor = Color.LightSkyBlue;
        }
        private void btn直角聖誕樹_Click(object sender, EventArgs e)
        {
            string result = "";
            int i, j;            
            if (int.TryParse(txtRow.Text, out i))
            {
                for (i = 0; i <int.Parse(txtRow.Text) ; i++)
                {
                    for (j = 0; j < i + 1; j++)
                    { result += "*"; }
                    result += "\n";
                }
            }else
            { MessageBox.Show("請在Row欄位輸入整數"); }
            lab結果.Text = result;
            lab結果.BackColor = Color.LightSkyBlue;
        }
        private void btn最大小_Click(object sender, EventArgs e)
        {
            int[] num = { 1, 5, 6, 7, 97, 54, 887, 65, 578 };           
            int max = num[0];
            int min = num[0];              
            for (int i = 0; i < 9; i++)
            {
                if (num[i] > max)
                { max = num[i]; }
                if (num[i] < min)
                { min = num[i]; }
            }
            lab結果.Text = $"陣列值為[ 1, 5, 6, 7, 97, 54, 887, 65, 578 ]\n" + $"最高為{max}分, \n最低分數為{min}分";
            lab結果.BackColor = Color.LightSkyBlue;
        }        
        private void btnSwap_Click(object sender, EventArgs e)
        {
            string a = "英文", b = "數學";
            lab結果.Text = $"第一天-第一科:{a}, 第二科:{b}\r\n";
            Swap(ref a, ref b);
            lab結果.Text += $"第二天-第一科:{a}, 第二科:{b}\r\n";            
        }
        void Swap(ref string A, ref string B)
        {
            string T = A;
            A = B;
            B = T;
            lab結果.BackColor = Color.LightSkyBlue;
        }
        private void btn奇偶_Click(object sender, EventArgs e)
        {            
            string result = "";
            int num;
            if (int.TryParse(txt陣列.Text, out num))
            {
                if (num % 2 == 0)
                { result = "偶數"; }
                else
                { result = "奇數"; }
                lab結果.Text = $" {num}是{result}";
            }           
            else 
            { MessageBox.Show("請在Number輸入整數"); }
            lab結果.BackColor = Color.LightSkyBlue;
        }
        private void btn奇偶合_Click(object sender, EventArgs e)
        {
            int[] num = { 1, 5, 6, 7, 97, 54, 887, 65, 578 };
            int count = 0, odd, even;
            odd = even = num[0];
            for (int i = 0; i < num.Length ; i++)
            {
                if (num[i] % 2 == 0)
                {
                  count++;
                    if (num[i] > even)
                    {even = num[i];}
                    else if (num[i] > odd)
                    { odd = num[i];}
                }
            }
            lab結果.Text = $"陣列值為[ 1, 5, 6, 7, 97, 54, 887, 65, 578 ]\n" + $"奇數共{num.Length-count}個, \n偶數共{count}個";
            lab結果.BackColor = Color.LightSkyBlue;
        }

        private void btn最長名字_Click(object sender, EventArgs e)
        {
            string[] Name = { "Zeus", "Hera", "Poseidon", "Hestia", "Demeter", "Apollo", "Artemis", "Aphrodite", "Athena", "Ares", "Hephaestus", "Hermes", "Dionysus", "Asclepius", "Hades"};
            int 字數 = 0;
            string result = "";
            for(int i = 0; i < Name.Length;i++)
            {
                if (Name[i].Length > 字數)
                {
                    字數 = Name[i].Length;
                    result = Name[i];
                }                
            }
            lab結果.Text = $"陣列值為[Zeus,Hera,Poseidon,Hestia,Demeter,Apollo,Artemis,Aphrodite,Athena,Ares,Hephaestus,Hermes,Dionysus,Asclepius,Hades]\n" + $"最長名字是{result},共{字數}字";
            lab結果.BackColor = Color.LightSkyBlue;
        }

        private void btnC有幾個_Click(object sender, EventArgs e)
        {
            string[] Name = {"Zeus","Hera","Poseidon","Hestia","Demeter","Apollo","Artemis","Aphrodite","Athena","Ares","Hephaestus","Hermes","Dionysus","Asclepius","Hades"};            
            int count = 0;           
            foreach(string 字母 in Name)
            {  count += 字母.ToLower().Count(a => a == 'a');  }
            lab結果.Text = $"陣列值為[Zeus,Hera,Poseidon,Hestia,Demeter,Apollo,Artemis,Aphrodite,Athena,Ares,Hephaestus,Hermes,Dionysus,Asclepius,Hades]\n" + $"有A和a的字共{count}個";
            lab結果.BackColor = Color.LightSkyBlue;
        }

        private void btnSum_Click(object sender, EventArgs e)
        {
            int[] num = { 1, 5, 6, 7, 97, 54, 887, 65, 578 };
            int count = num.Sum();
            lab結果.Text = $"陣列值為[ 1, 5, 6, 7, 97, 54, 887, 65, 578 ]\n" + $"合計為{count}";
            lab結果.BackColor = Color.LightSkyBlue;
        }

        private void btn樂透不重複_Click(object sender, EventArgs e)
        {
            int[] randomArry = new int[6];
            Random rdn = new Random();           
            for (int i=0;i<6;i++)
            {
                randomArry[i] = rdn.Next(1,49); //亂數產生，亂數產生的範圍是1~49
                for (int j = 0; j<i;j++)
                {
                    while (randomArry[j] == randomArry[i]) //檢查是否與前面產生的數值發生重複，如果有就重新產生
                    {
                        j = 0; //如有重複，將變數j設為0，再次檢查 (因為還是有重複的可能)
                        randomArry[i] = rdn.Next(1,49); //重新產生，存回陣列，亂數產生的範圍是1~49
                    }
                }
            }
            lab結果.Text = $"{randomArry[0]} {randomArry[1]} {randomArry[2]} {randomArry[3]} {randomArry[4]} {randomArry[5]} ";
            lab結果.BackColor = Color.LightSkyBlue;
        }

        private void btnMax_Click(object sender, EventArgs e)
        {           
            int[] num =  { 1, 5, 6, 7, 97, 54, 887, 65, 578 };
            int max = num[0];           
            foreach (int i in num)
            {
                if (i > max)
                {max = i;}
            }
            lab結果.Text = $"陣列值為[ 1, 5, 6, 7, 97, 54, 887, 65, 578 ]\n" + $"最高為{max}分";
            lab結果.BackColor = Color.LightSkyBlue;
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            int[] num = { 1, 5, 6, 7, 97, 54, 887, 65, 578 };
            int min = num[0];
            foreach (int i in num)
            {
                if (i < min)
                { min = i; }                
            }
            lab結果.Text = $"陣列值為[ 1, 5, 6, 7, 97, 54, 887, 65, 578 ]\n" + $"最低分數為{min}分";
            lab結果.BackColor = Color.LightSkyBlue;
        }

        private void btn二維10_Click(object sender, EventArgs e)
        {
            string result = "";
            int[,] array = new int[10, 10];           
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                { array[i, j] = 0; }
            }
            // 將陣列的邊框元素設置為1
            for (int i = 0; i < array.GetLength(0); i++)
            {
                array[i, 0] = 1;             // 第一列
                array[i, array.GetLength(1) - 1] = 1;  // 最後一列
            }
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array[0, j] = 1;             // 第一行
                array[array.GetLength(0) - 1, j] = 1;  // 最後一行
            }

            // 輸出陣列
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                { result += array[i, j] + " "; }
                result +="\n";
            }
            lab結果.Text = result ;
            lab結果.BackColor = Color.LightSkyBlue;
        }

        private void btn二維01_Click(object sender, EventArgs e)
        {
            string result = "";
            int[,] array = new int[10, 10];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {  array[i, j] = 1; }
            }
          
            for (int i = 0; i < array.GetLength(0); i++)
            {
                array[i, 0] = 0;            
                array[i, array.GetLength(1) - 1] = 0; 
            }
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array[0, j] = 0;           
                array[array.GetLength(0) - 1, j] = 0;  
            }
            
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                { result += array[i, j] + " "; }
                result += "\n";
            }
            lab結果.Text = result;
            lab結果.BackColor = Color.LightSkyBlue;
        }

        private void btn二維陣列_Click(object sender, EventArgs e)
        {
            string result = "";
            int[,] array = new int[10, 10];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if ( i % 2 == 0)
                    { array[i, j] = (j%2 == 0)? 1:0 ;}
                    else
                    { array[i, j] = (j%2 == 0)? 0:1 ;}
                }                
            }
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                { result += array[i, j] + " "; }
                result += "\n";
            }
            lab結果.Text = result;
            lab結果.BackColor = Color.LightSkyBlue;
        }

        private void btn100二進位_Click(object sender, EventArgs e)
        {            
            if (string.IsNullOrEmpty(txtRow.Text))
            {  MessageBox.Show("請在Row欄位輸入整數"); }
            else
            {
                int num = int.Parse(txtRow.Text);
                string result = Convert.ToString(num, 2).PadLeft(8, '0');
                lab結果.Text = result;
            }           
            lab結果.BackColor = Color.LightSkyBlue;
        }
        int start, end, step;
        bool Readtxt()//讀取參數
        {
            if(int.TryParse(txtFrom.Text, out start)
                &&int.TryParse(txtTo.Text, out end)
                    &&int.TryParse(txtStep.Text,out step))
            { return true; }
            else
            {
                MessageBox.Show("請輸入整數", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtFrom.Focus();
                return false;
            }
        }

        private void btnDo_Click(object sender, EventArgs e)
        {
            if (Readtxt())
            {
                int sum = 0;
                int i = start;
                do { sum += i; i += step; }
                while (i < end);
                step--;
                LoopResult(ref start,ref end,ref step,ref sum);
            }
        }

        private void btnWhile_Click(object sender, EventArgs e)
        {
            if (Readtxt())
            {
                int sum = 0;
                int i = start;
                while (i < end) { sum += i; i += step; }
                step--;
                LoopResult(ref start, ref end, ref step, ref sum);
            }
        }
        private void btnFor_Click(object sender, EventArgs e)
        {
            if (Readtxt())
            {
                int sum = 0;
                for (int i = start; i < end; i += step)
                { sum += i;}
                step--;
                LoopResult(ref start, ref end, ref step, ref sum);
            }
        }
        void LoopResult<S>(ref S a, ref S b, ref S c, ref S d)
        {
            lab結果.Text = $"{a} 到 {b}，間隔 {c} \r\n 加總為{d} ";
        }
    }
   

}
