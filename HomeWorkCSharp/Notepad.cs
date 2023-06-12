using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace HomeWorkCSharp
{
    public partial class Notepad : Form
    {
        string filename = "";
        public Notepad()
        {
            InitializeComponent();
            timer1.Enabled = true;
            timer1.Interval = 1000;
            this.statusStrip1.Text = "系統當前時間：" + DateTime.Now.ToString();
        }
        
        private void 開啟ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog oFD = new OpenFileDialog();
            if (oFD.ShowDialog() == DialogResult.OK)
            {
                string filename = oFD.FileName;
                txtBox.Text = System.IO.File.ReadAllText(filename, Encoding.Default);
            }
        }
        
        private void 新增NCtrlNToolStripMenuItem_Click(object sender, EventArgs e)
        {   //新建選項
            txtBox.Clear();                       //清空豐富文字區
            filename = "";                              //開始的檔名為空
            this.Text = "無標題-EditorPrimer";          //初始化檔案標題
        }
        private void 結束XToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
            Application.Exit();
        }
        private void 儲存SCtrlSToolStripMenuItem_Click(object sender, EventArgs e)
        {   //儲存選項實現程式碼
            if (filename.Length > 0)
            {
                //檔名不是空，原來已經有此檔案則直接儲存
                txtBox.SaveFile(filename, RichTextBoxStreamType.PlainText);
            }
            else
            {
                //檔名是空，屬於新建的檔案,呼叫另存為事件
                另存新檔AToolStripMenuItem_Click(sender, e);
            }
        }
        private void 剪下TCtrlXToolStripMenuItem_Click(object sender, EventArgs e)
        { txtBox.Cut();}
        private void 複製CCtrlCToolStripMenuItem_Click(object sender, EventArgs e)
        { txtBox.Copy(); }
        private void 貼上PCtrlVToolStripMenuItem_Click(object sender, EventArgs e)
        {  txtBox.Paste(); }
        private void 全選AToolStripMenuItem_Click(object sender, EventArgs e)
        {  txtBox.SelectAll(); }
     
        private void 另存新檔AToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //另存為選項,程式碼與開啟檔案選項類似
            saveFileDialog1.Filter = "文字檔案 | *.txt";            //設定儲存檔案型別過濾器
            saveFileDialog1.FilterIndex = 1;                        //檔案對話方塊中當前選定篩選器的索引
            saveFileDialog1.InitialDirectory = "E:\\";              //儲存檔案時的預設目錄
            if (saveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                //點選了儲存檔案對話方塊的確定按鈕
                filename = saveFileDialog1.FileName;                //更新檔名
                //儲存檔案,引數分別是檔案的路徑path 和檔案的型別(這裡指定為純文字)
                txtBox.SaveFile(filename, RichTextBoxStreamType.PlainText);
                //獲取檔案儲存路徑並更新視窗標題列
                int index = filename.LastIndexOf('\\');             //找到最後一個斜線的下標索引
                string Text_2 = filename.Substring(index + 1);      //去掉檔案路徑獲取檔名(引數下標索引，擷取長度(不指定直到最後))
                this.Text = Text_2 + "-EditorPrimer";               //更新標題列
            }
        }

        private void 列印PCtrlPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintDocument PD = new PrintDocument();
            PD.PrintPage += new PrintPageEventHandler(PD_PrintPage);
            PD.Print();
        }
        void PD_PrintPage(object sender, PrintPageEventArgs e){              }
        private void 預覽列印VToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintDocument PD = new PrintDocument();
            PD.PrintPage += new PrintPageEventHandler(PD_PrintPage);
            PrintPreviewDialog PPD = new PrintPreviewDialog();
            PPD.Document = PD;
            PPD.ShowDialog();
        }
        private void 復原UCtrlZToolStripMenuItem_Click(object sender, EventArgs e)
        { txtBox.Undo(); }
        private void 取消復原RCtrlYToolStripMenuItem_Click(object sender, EventArgs e)
        { txtBox.ClearUndo(); }
        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            this.statusStrip1.Text = "系統當前時間：" + DateTime.Now.ToString();
        }
        private void 顏色CToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            { txtBox.BackColor = colorDialog1.Color; }
        }
        private void 字型VToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog();
            if (fontDialog.ShowDialog() == DialogResult.OK)
            {
                if (txtBox.Focused)
                {
                    txtBox.Font = fontDialog.Font;
                }
                else
                    txtBox.Font = fontDialog.Font;
            }
        }
        private void toUpperUToolStripMenuItem_Click(object sender, EventArgs e)
        {          
            string tex= Convert.ToString(txtBox.Text);
            tex = tex.ToUpper();
            txtBox.Text = tex;
        }
        private void toLowerLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string tex = Convert.ToString(txtBox.Text);
            tex = tex.ToLower();
            txtBox.Text = tex;
        }

        private void 自動換行ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (自動換行ToolStripMenuItem.Checked == true)
            {
                txtBox.WordWrap = false;
                txtBox.WordWrap = false;
                自動換行ToolStripMenuItem.Checked = false;
            }
            else
            {
                txtBox.WordWrap = true;
                txtBox.WordWrap = true;
                自動換行ToolStripMenuItem.Checked = true;
            }
        }
      
        private void 字體選色ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                txtBox.SelectionColor = colorDialog1.Color;
            }
        }
    }
}
