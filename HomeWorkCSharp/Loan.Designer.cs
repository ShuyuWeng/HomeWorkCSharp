namespace HomeWorkCSharp
{
    partial class FrmLoan
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
            this.lab貸款金額 = new System.Windows.Forms.Label();
            this.lab貸款期數月 = new System.Windows.Forms.Label();
            this.lab年利率 = new System.Windows.Forms.Label();
            this.lab全部利息 = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn清除 = new System.Windows.Forms.Button();
            this.btn計算 = new System.Windows.Forms.Button();
            this.txt年利率 = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txt全部利息 = new System.Windows.Forms.TextBox();
            this.txt貸款期數月 = new System.Windows.Forms.TextBox();
            this.listViewlab = new System.Windows.Forms.ListView();
            this.tableLayoutPanel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lab貸款金額
            // 
            this.lab貸款金額.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lab貸款金額.AutoSize = true;
            this.lab貸款金額.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lab貸款金額.Location = new System.Drawing.Point(16, 28);
            this.lab貸款金額.Name = "lab貸款金額";
            this.lab貸款金額.Size = new System.Drawing.Size(69, 19);
            this.lab貸款金額.TabIndex = 0;
            this.lab貸款金額.Text = "貸款金額";
            // 
            // lab貸款期數月
            // 
            this.lab貸款期數月.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lab貸款期數月.AutoSize = true;
            this.lab貸款期數月.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lab貸款期數月.Location = new System.Drawing.Point(4, 176);
            this.lab貸款期數月.Name = "lab貸款期數月";
            this.lab貸款期數月.Size = new System.Drawing.Size(94, 19);
            this.lab貸款期數月.TabIndex = 1;
            this.lab貸款期數月.Text = "貸款期數(月)";
            // 
            // lab年利率
            // 
            this.lab年利率.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lab年利率.AutoSize = true;
            this.lab年利率.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lab年利率.Location = new System.Drawing.Point(12, 102);
            this.lab年利率.Name = "lab年利率";
            this.lab年利率.Size = new System.Drawing.Size(77, 19);
            this.lab年利率.TabIndex = 2;
            this.lab年利率.Text = "年利率(%)";
            // 
            // lab全部利息
            // 
            this.lab全部利息.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lab全部利息.AutoSize = true;
            this.lab全部利息.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lab全部利息.Location = new System.Drawing.Point(16, 250);
            this.lab全部利息.Name = "lab全部利息";
            this.lab全部利息.Size = new System.Drawing.Size(69, 19);
            this.lab全部利息.TabIndex = 9;
            this.lab全部利息.Text = "全部利息";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.BackColor = System.Drawing.Color.LightBlue;
            this.tableLayoutPanel3.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.Controls.Add(this.panel2, 0, 4);
            this.tableLayoutPanel3.Controls.Add(this.txt年利率, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.lab貸款期數月, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.lab年利率, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.txtPrice, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.lab貸款金額, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.lab全部利息, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.txt全部利息, 1, 3);
            this.tableLayoutPanel3.Controls.Add(this.txt貸款期數月, 1, 2);
            this.tableLayoutPanel3.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tableLayoutPanel3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 5;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(239, 375);
            this.tableLayoutPanel3.TabIndex = 14;
            // 
            // panel2
            // 
            this.tableLayoutPanel3.SetColumnSpan(this.panel2, 2);
            this.panel2.Controls.Add(this.btn清除);
            this.panel2.Controls.Add(this.btn計算);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(1, 297);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(237, 77);
            this.panel2.TabIndex = 16;
            // 
            // btn清除
            // 
            this.btn清除.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn清除.FlatAppearance.BorderSize = 2;
            this.btn清除.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn清除.Location = new System.Drawing.Point(123, 26);
            this.btn清除.Name = "btn清除";
            this.btn清除.Size = new System.Drawing.Size(76, 37);
            this.btn清除.TabIndex = 12;
            this.btn清除.Text = "清除";
            this.btn清除.UseVisualStyleBackColor = true;
            this.btn清除.Click += new System.EventHandler(this.btn清除_Click);
            // 
            // btn計算
            // 
            this.btn計算.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn計算.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn計算.Location = new System.Drawing.Point(21, 26);
            this.btn計算.Name = "btn計算";
            this.btn計算.Size = new System.Drawing.Size(75, 37);
            this.btn計算.TabIndex = 11;
            this.btn計算.Text = "計算";
            this.btn計算.UseVisualStyleBackColor = true;
            this.btn計算.Click += new System.EventHandler(this.btn計算_Click);
            // 
            // txt年利率
            // 
            this.txt年利率.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt年利率.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt年利率.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt年利率.Location = new System.Drawing.Point(115, 98);
            this.txt年利率.Margin = new System.Windows.Forms.Padding(2);
            this.txt年利率.Name = "txt年利率";
            this.txt年利率.Size = new System.Drawing.Size(110, 27);
            this.txt年利率.TabIndex = 5;
            this.txt年利率.TabStop = false;
            this.txt年利率.Text = "2.4";
            this.txt年利率.WordWrap = false;
            // 
            // txtPrice
            // 
            this.txtPrice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPrice.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtPrice.Location = new System.Drawing.Point(115, 24);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(2);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(110, 27);
            this.txtPrice.TabIndex = 7;
            this.txtPrice.TabStop = false;
            this.txtPrice.Text = "100000";
            this.txtPrice.WordWrap = false;
            // 
            // txt全部利息
            // 
            this.txt全部利息.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt全部利息.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt全部利息.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt全部利息.Location = new System.Drawing.Point(115, 246);
            this.txt全部利息.Margin = new System.Windows.Forms.Padding(2);
            this.txt全部利息.Name = "txt全部利息";
            this.txt全部利息.Size = new System.Drawing.Size(110, 27);
            this.txt全部利息.TabIndex = 10;
            this.txt全部利息.TabStop = false;
            this.txt全部利息.WordWrap = false;
            // 
            // txt貸款期數月
            // 
            this.txt貸款期數月.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt貸款期數月.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt貸款期數月.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt貸款期數月.Location = new System.Drawing.Point(115, 172);
            this.txt貸款期數月.Margin = new System.Windows.Forms.Padding(2);
            this.txt貸款期數月.Name = "txt貸款期數月";
            this.txt貸款期數月.Size = new System.Drawing.Size(110, 27);
            this.txt貸款期數月.TabIndex = 6;
            this.txt貸款期數月.TabStop = false;
            this.txt貸款期數月.Text = "240";
            this.txt貸款期數月.WordWrap = false;
            // 
            // listViewlab
            // 
            this.listViewlab.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewlab.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.listViewlab.HideSelection = false;
            this.listViewlab.Location = new System.Drawing.Point(257, 12);
            this.listViewlab.Name = "listViewlab";
            this.listViewlab.Size = new System.Drawing.Size(336, 501);
            this.listViewlab.TabIndex = 15;
            this.listViewlab.UseCompatibleStateImageBehavior = false;
            this.listViewlab.View = System.Windows.Forms.View.List;
            // 
            // FrmLoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 547);
            this.Controls.Add(this.listViewlab);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Name = "FrmLoan";
            this.Text = "貸款金額計算";
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lab貸款金額;
        private System.Windows.Forms.Label lab貸款期數月;
        private System.Windows.Forms.Label lab年利率;
        private System.Windows.Forms.Label lab全部利息;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TextBox txt年利率;
        private System.Windows.Forms.TextBox txt貸款期數月;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txt全部利息;
        private System.Windows.Forms.Button btn清除;
        private System.Windows.Forms.Button btn計算;
        private System.Windows.Forms.ListView listViewlab;
        private System.Windows.Forms.Panel panel2;
    }
}