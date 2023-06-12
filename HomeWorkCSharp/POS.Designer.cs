namespace HomeWorkCSharp
{
    partial class FrmPOS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPOS));
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtTotalPrice = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCredit = new System.Windows.Forms.Button();
            this.btnMoney = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtOrder = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.frmMenu = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn燉飯 = new System.Windows.Forms.Button();
            this.btn麵 = new System.Windows.Forms.Button();
            this.btn披薩 = new System.Windows.Forms.Button();
            this.btn炒飯 = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.txtTotalPrice);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(235, 18);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(151, 100);
            this.panel2.TabIndex = 1;
            // 
            // txtTotalPrice
            // 
            this.txtTotalPrice.BackColor = System.Drawing.SystemColors.MenuText;
            this.txtTotalPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotalPrice.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtTotalPrice.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtTotalPrice.ForeColor = System.Drawing.SystemColors.Window;
            this.txtTotalPrice.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txtTotalPrice.Location = new System.Drawing.Point(8, 45);
            this.txtTotalPrice.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTotalPrice.Name = "txtTotalPrice";
            this.txtTotalPrice.ReadOnly = true;
            this.txtTotalPrice.Size = new System.Drawing.Size(138, 29);
            this.txtTotalPrice.TabIndex = 7;
            this.txtTotalPrice.TabStop = false;
            this.txtTotalPrice.Text = "NT$0 ";
            this.txtTotalPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(4, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "總金額 Total Price";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.btnCredit);
            this.panel3.Controls.Add(this.btnMoney);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(235, 124);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(151, 122);
            this.panel3.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(67, 91);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "信用卡打9折!";
            // 
            // btnCredit
            // 
            this.btnCredit.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnCredit.Location = new System.Drawing.Point(78, 48);
            this.btnCredit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCredit.Name = "btnCredit";
            this.btnCredit.Size = new System.Drawing.Size(67, 31);
            this.btnCredit.TabIndex = 4;
            this.btnCredit.Text = "信用卡";
            this.btnCredit.UseVisualStyleBackColor = true;
            this.btnCredit.Click += new System.EventHandler(this.btnCredit_Click);
            // 
            // btnMoney
            // 
            this.btnMoney.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnMoney.Location = new System.Drawing.Point(8, 48);
            this.btnMoney.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnMoney.Name = "btnMoney";
            this.btnMoney.Size = new System.Drawing.Size(65, 31);
            this.btnMoney.TabIndex = 3;
            this.btnMoney.Text = "現金";
            this.btnMoney.UseVisualStyleBackColor = true;
            this.btnMoney.Click += new System.EventHandler(this.btnMoney_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(4, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "付款方式";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.txtOrder);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Location = new System.Drawing.Point(392, 18);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(250, 282);
            this.panel4.TabIndex = 3;
            // 
            // txtOrder
            // 
            this.txtOrder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOrder.BackColor = System.Drawing.SystemColors.Window;
            this.txtOrder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtOrder.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtOrder.Font = new System.Drawing.Font("微軟正黑體", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtOrder.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtOrder.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txtOrder.Location = new System.Drawing.Point(8, 24);
            this.txtOrder.Margin = new System.Windows.Forms.Padding(0);
            this.txtOrder.Multiline = true;
            this.txtOrder.Name = "txtOrder";
            this.txtOrder.ReadOnly = true;
            this.txtOrder.Size = new System.Drawing.Size(235, 250);
            this.txtOrder.TabIndex = 2;
            this.txtOrder.TabStop = false;
            this.txtOrder.Text = "尚未點餐";
            this.txtOrder.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;            
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(4, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "點餐清單 List";
            // 
            // frmMenu
            // 
            this.frmMenu.AutoSize = true;
            this.frmMenu.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.frmMenu.Location = new System.Drawing.Point(3, 4);
            this.frmMenu.Name = "frmMenu";
            this.frmMenu.Size = new System.Drawing.Size(89, 20);
            this.frmMenu.TabIndex = 0;
            this.frmMenu.Text = "菜單 Menu";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn燉飯);
            this.panel1.Controls.Add(this.frmMenu);
            this.panel1.Controls.Add(this.btn麵);
            this.panel1.Controls.Add(this.btn披薩);
            this.panel1.Controls.Add(this.btn炒飯);
            this.panel1.Location = new System.Drawing.Point(7, 18);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(222, 319);
            this.panel1.TabIndex = 0;
            // 
            // btn燉飯
            // 
            this.btn燉飯.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn燉飯.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn燉飯.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn燉飯.BackgroundImage")));
            this.btn燉飯.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn燉飯.CausesValidation = false;
            this.btn燉飯.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn燉飯.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn燉飯.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn燉飯.ForeColor = System.Drawing.Color.Snow;
            this.btn燉飯.Location = new System.Drawing.Point(113, 174);
            this.btn燉飯.Name = "btn燉飯";
            this.btn燉飯.Size = new System.Drawing.Size(97, 144);
            this.btn燉飯.TabIndex = 4;
            this.btn燉飯.TabStop = false;
            this.btn燉飯.Text = "燉飯\r\nStew\r\nNT210";
            this.btn燉飯.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn燉飯.UseCompatibleTextRendering = true;
            this.btn燉飯.UseMnemonic = false;
            this.btn燉飯.UseVisualStyleBackColor = false;
            this.btn燉飯.Click += new System.EventHandler(this.btn燉飯_Click);
            // 
            // btn麵
            // 
            this.btn麵.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn麵.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn麵.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn麵.BackgroundImage")));
            this.btn麵.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn麵.CausesValidation = false;
            this.btn麵.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn麵.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn麵.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn麵.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn麵.Location = new System.Drawing.Point(113, 24);
            this.btn麵.Name = "btn麵";
            this.btn麵.Size = new System.Drawing.Size(97, 144);
            this.btn麵.TabIndex = 2;
            this.btn麵.TabStop = false;
            this.btn麵.Text = "麵\r\nNoodle\r\nNT90";
            this.btn麵.UseCompatibleTextRendering = true;
            this.btn麵.UseMnemonic = false;
            this.btn麵.UseVisualStyleBackColor = false;
            this.btn麵.Click += new System.EventHandler(this.btn麵_Click);
            // 
            // btn披薩
            // 
            this.btn披薩.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn披薩.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn披薩.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn披薩.BackgroundImage")));
            this.btn披薩.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn披薩.CausesValidation = false;
            this.btn披薩.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn披薩.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn披薩.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn披薩.ForeColor = System.Drawing.Color.LightGoldenrodYellow;
            this.btn披薩.Location = new System.Drawing.Point(9, 174);
            this.btn披薩.Name = "btn披薩";
            this.btn披薩.Size = new System.Drawing.Size(97, 144);
            this.btn披薩.TabIndex = 3;
            this.btn披薩.TabStop = false;
            this.btn披薩.Text = "披薩\r\nPizza\r\nNT350";
            this.btn披薩.UseCompatibleTextRendering = true;
            this.btn披薩.UseMnemonic = false;
            this.btn披薩.UseVisualStyleBackColor = false;
            this.btn披薩.Click += new System.EventHandler(this.btn披薩_Click);
            // 
            // btn炒飯
            // 
            this.btn炒飯.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn炒飯.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn炒飯.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn炒飯.BackgroundImage")));
            this.btn炒飯.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn炒飯.CausesValidation = false;
            this.btn炒飯.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn炒飯.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn炒飯.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn炒飯.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn炒飯.Location = new System.Drawing.Point(8, 24);
            this.btn炒飯.Name = "btn炒飯";
            this.btn炒飯.Size = new System.Drawing.Size(97, 144);
            this.btn炒飯.TabIndex = 1;
            this.btn炒飯.TabStop = false;
            this.btn炒飯.Text = "炒飯\r\nFried Rice\r\nNT80\r\n";
            this.btn炒飯.UseCompatibleTextRendering = true;
            this.btn炒飯.UseMnemonic = false;
            this.btn炒飯.UseVisualStyleBackColor = false;
            this.btn炒飯.Click += new System.EventHandler(this.btn炒飯_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnClear.Location = new System.Drawing.Point(523, 306);
            this.btnClear.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(87, 31);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "清除清單";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // FrmPOS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 424);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FrmPOS";
            this.Text = "Bar POS";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label frmMenu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn燉飯;
        private System.Windows.Forms.Button btn披薩;
        private System.Windows.Forms.Button btn麵;
        private System.Windows.Forms.Button btn炒飯;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCredit;
        private System.Windows.Forms.Button btnMoney;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox txtOrder;
        private System.Windows.Forms.TextBox txtTotalPrice;
    }
}