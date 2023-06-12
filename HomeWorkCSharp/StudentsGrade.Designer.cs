namespace HomeWorkCSharp
{
    partial class StudentsGradeFrm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txt數學 = new System.Windows.Forms.TextBox();
            this.lab數學 = new System.Windows.Forms.Label();
            this.txt英文 = new System.Windows.Forms.TextBox();
            this.lab英文 = new System.Windows.Forms.Label();
            this.txt國文 = new System.Windows.Forms.TextBox();
            this.lab國文 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lab姓名 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btn隨機存 = new System.Windows.Forms.Button();
            this.btnStats = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btn隨機20 = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNum2 = new System.Windows.Forms.TextBox();
            this.txtNum1 = new System.Windows.Forms.TextBox();
            this.lstVwGrade = new System.Windows.Forms.ListView();
            this.lstVwStats = new System.Windows.Forms.ListView();
            this.clmName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clm國文 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clm英文 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clm數學 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clm_Total = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clm_Average = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmMax = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmMin = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt數學
            // 
            this.txt數學.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt數學.Location = new System.Drawing.Point(61, 165);
            this.txt數學.Name = "txt數學";
            this.txt數學.Size = new System.Drawing.Size(100, 33);
            this.txt數學.TabIndex = 19;
            // 
            // lab數學
            // 
            this.lab數學.AutoSize = true;
            this.lab數學.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lab數學.Location = new System.Drawing.Point(12, 168);
            this.lab數學.Name = "lab數學";
            this.lab數學.Size = new System.Drawing.Size(52, 24);
            this.lab數學.TabIndex = 18;
            this.lab數學.Text = "數學:";
            // 
            // txt英文
            // 
            this.txt英文.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt英文.Location = new System.Drawing.Point(61, 116);
            this.txt英文.Name = "txt英文";
            this.txt英文.Size = new System.Drawing.Size(100, 33);
            this.txt英文.TabIndex = 17;
            // 
            // lab英文
            // 
            this.lab英文.AutoSize = true;
            this.lab英文.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lab英文.Location = new System.Drawing.Point(12, 119);
            this.lab英文.Name = "lab英文";
            this.lab英文.Size = new System.Drawing.Size(52, 24);
            this.lab英文.TabIndex = 16;
            this.lab英文.Text = "英文:";
            // 
            // txt國文
            // 
            this.txt國文.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt國文.Location = new System.Drawing.Point(61, 65);
            this.txt國文.Name = "txt國文";
            this.txt國文.Size = new System.Drawing.Size(100, 33);
            this.txt國文.TabIndex = 15;
            // 
            // lab國文
            // 
            this.lab國文.AutoSize = true;
            this.lab國文.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lab國文.Location = new System.Drawing.Point(12, 68);
            this.lab國文.Name = "lab國文";
            this.lab國文.Size = new System.Drawing.Size(52, 24);
            this.lab國文.TabIndex = 14;
            this.lab國文.Text = "國文:";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtName.Location = new System.Drawing.Point(61, 16);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 33);
            this.txtName.TabIndex = 13;
            // 
            // lab姓名
            // 
            this.lab姓名.AutoSize = true;
            this.lab姓名.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lab姓名.Location = new System.Drawing.Point(12, 19);
            this.lab姓名.Name = "lab姓名";
            this.lab姓名.Size = new System.Drawing.Size(52, 24);
            this.lab姓名.TabIndex = 12;
            this.lab姓名.Text = "姓名:";
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnAdd.Location = new System.Drawing.Point(16, 217);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(136, 26);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "加入學生資料";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btn隨機存
            // 
            this.btn隨機存.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn隨機存.Location = new System.Drawing.Point(16, 313);
            this.btn隨機存.Name = "btn隨機存";
            this.btn隨機存.Size = new System.Drawing.Size(136, 26);
            this.btn隨機存.TabIndex = 20;
            this.btn隨機存.Text = "隨機儲存資料";
            this.btn隨機存.UseVisualStyleBackColor = true;
            this.btn隨機存.Click += new System.EventHandler(this.btn隨機存_Click);
            // 
            // btnStats
            // 
            this.btnStats.Enabled = false;
            this.btnStats.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnStats.Location = new System.Drawing.Point(603, 457);
            this.btnStats.Name = "btnStats";
            this.btnStats.Size = new System.Drawing.Size(136, 26);
            this.btnStats.TabIndex = 21;
            this.btnStats.Text = "各科統計";
            this.btnStats.UseVisualStyleBackColor = true;
            this.btnStats.Click += new System.EventHandler(this.btnStats_Click);
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnReset.Location = new System.Drawing.Point(179, 457);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(136, 26);
            this.btnReset.TabIndex = 22;
            this.btnReset.Text = "重設所有資料";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btn隨機20
            // 
            this.btn隨機20.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn隨機20.Location = new System.Drawing.Point(16, 345);
            this.btn隨機20.Name = "btn隨機20";
            this.btn隨機20.Size = new System.Drawing.Size(136, 26);
            this.btn隨機20.TabIndex = 23;
            this.btn隨機20.Text = "隨機加入20筆";
            this.btn隨機20.UseVisualStyleBackColor = true;
            this.btn隨機20.Click += new System.EventHandler(this.btn隨機20_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnInsert.Location = new System.Drawing.Point(16, 249);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(136, 26);
            this.btnInsert.TabIndex = 25;
            this.btnInsert.Text = "插入第一筆";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnRemove.Location = new System.Drawing.Point(16, 281);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(136, 26);
            this.btnRemove.TabIndex = 26;
            this.btnRemove.Text = "刪除第一筆";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtNum2);
            this.groupBox1.Controls.Add(this.txtNum1);
            this.groupBox1.Location = new System.Drawing.Point(16, 391);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(145, 100);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "查詢國文成績";
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnSearch.Location = new System.Drawing.Point(3, 66);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(136, 26);
            this.btnSearch.TabIndex = 28;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 12);
            this.label1.TabIndex = 30;
            this.label1.Text = "－";
            // 
            // txtNum2
            // 
            this.txtNum2.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtNum2.Location = new System.Drawing.Point(91, 27);
            this.txtNum2.Name = "txtNum2";
            this.txtNum2.Size = new System.Drawing.Size(42, 33);
            this.txtNum2.TabIndex = 29;
            // 
            // txtNum1
            // 
            this.txtNum1.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtNum1.Location = new System.Drawing.Point(11, 27);
            this.txtNum1.Name = "txtNum1";
            this.txtNum1.Size = new System.Drawing.Size(42, 33);
            this.txtNum1.TabIndex = 28;
            // 
            // lstVwGrade
            // 
            this.lstVwGrade.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmName,
            this.clm國文,
            this.clm英文,
            this.clm數學,
            this.clm_Total,
            this.clm_Average,
            this.clmMax,
            this.clmMin});
            this.lstVwGrade.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lstVwGrade.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lstVwGrade.HideSelection = false;
            this.lstVwGrade.Location = new System.Drawing.Point(179, 12);
            this.lstVwGrade.Name = "lstVwGrade";
            this.lstVwGrade.Size = new System.Drawing.Size(560, 294);
            this.lstVwGrade.TabIndex = 2;
            this.lstVwGrade.TileSize = new System.Drawing.Size(20, 20);
            this.lstVwGrade.UseCompatibleStateImageBehavior = false;
            this.lstVwGrade.View = System.Windows.Forms.View.Details;
            // 
            // lstVwStats
            // 
            this.lstVwStats.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lstVwStats.HideSelection = false;
            this.lstVwStats.Location = new System.Drawing.Point(179, 312);
            this.lstVwStats.Name = "lstVwStats";
            this.lstVwStats.Size = new System.Drawing.Size(560, 130);
            this.lstVwStats.TabIndex = 29;
            this.lstVwStats.UseCompatibleStateImageBehavior = false;
            this.lstVwStats.View = System.Windows.Forms.View.Details;
            // 
            // clmName
            // 
            this.clmName.Text = "姓名";
            // 
            // clm國文
            // 
            this.clm國文.Text = "國文";
            // 
            // clm英文
            // 
            this.clm英文.Text = "英文";
            // 
            // clm數學
            // 
            this.clm數學.Text = "數學";
            // 
            // clm_Total
            // 
            this.clm_Total.Text = "總分";
            // 
            // clm_Average
            // 
            this.clm_Average.Text = "平均";
            // 
            // clmMax
            // 
            this.clmMax.Text = "最高分";
            // 
            // clmMin
            // 
            this.clmMin.Text = "最低分";
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "國文";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "英文";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "數學";
            // 
            // StudentsGradeFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 516);
            this.Controls.Add(this.lstVwStats);
            this.Controls.Add(this.lstVwGrade);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.btn隨機20);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnStats);
            this.Controls.Add(this.btn隨機存);
            this.Controls.Add(this.txt數學);
            this.Controls.Add(this.lab數學);
            this.Controls.Add(this.txt英文);
            this.Controls.Add(this.lab英文);
            this.Controls.Add(this.txt國文);
            this.Controls.Add(this.lab國文);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lab姓名);
            this.Controls.Add(this.btnAdd);
            this.Name = "StudentsGradeFrm";
            this.Text = "StudentGrade";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt數學;
        private System.Windows.Forms.Label lab數學;
        private System.Windows.Forms.TextBox txt英文;
        private System.Windows.Forms.Label lab英文;
        private System.Windows.Forms.TextBox txt國文;
        private System.Windows.Forms.Label lab國文;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lab姓名;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btn隨機存;
        private System.Windows.Forms.Button btnStats;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btn隨機20;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNum2;
        private System.Windows.Forms.TextBox txtNum1;
        private System.Windows.Forms.ListView lstVwGrade;
        private System.Windows.Forms.ListView lstVwStats;
        private System.Windows.Forms.ColumnHeader clmName;
        private System.Windows.Forms.ColumnHeader clm國文;
        private System.Windows.Forms.ColumnHeader clm英文;
        private System.Windows.Forms.ColumnHeader clm數學;
        private System.Windows.Forms.ColumnHeader clm_Total;
        private System.Windows.Forms.ColumnHeader clm_Average;
        private System.Windows.Forms.ColumnHeader clmMax;
        private System.Windows.Forms.ColumnHeader clmMin;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
    }
}