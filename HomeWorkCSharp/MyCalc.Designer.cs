namespace HomeWorkCSharp
{
    partial class FrmMyCalc
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
            this.FrmMyClacNum1 = new System.Windows.Forms.Label();
            this.FrmMyCalcNum2 = new System.Windows.Forms.Label();
            this.txtMyClalcNum1 = new System.Windows.Forms.TextBox();
            this.txtMyClalcNum2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.frmMyCalcAns = new System.Windows.Forms.Label();
            this.txtMyClassAns = new System.Windows.Forms.Label();
            this.butMyCalcAdd = new System.Windows.Forms.Button();
            this.btnMyCalcSub = new System.Windows.Forms.Button();
            this.btnMyCalcMult = new System.Windows.Forms.Button();
            this.btnMyCalcDiv = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FrmMyClacNum1
            // 
            this.FrmMyClacNum1.AutoSize = true;
            this.FrmMyClacNum1.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.FrmMyClacNum1.Location = new System.Drawing.Point(39, 42);
            this.FrmMyClacNum1.Name = "FrmMyClacNum1";
            this.FrmMyClacNum1.Size = new System.Drawing.Size(86, 24);
            this.FrmMyClacNum1.TabIndex = 0;
            this.FrmMyClacNum1.Text = "Num1：";
            // 
            // FrmMyCalcNum2
            // 
            this.FrmMyCalcNum2.AutoSize = true;
            this.FrmMyCalcNum2.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.FrmMyCalcNum2.Location = new System.Drawing.Point(39, 104);
            this.FrmMyCalcNum2.Name = "FrmMyCalcNum2";
            this.FrmMyCalcNum2.Size = new System.Drawing.Size(86, 24);
            this.FrmMyCalcNum2.TabIndex = 1;
            this.FrmMyCalcNum2.Text = "Num2：";
            // 
            // txtMyClalcNum1
            // 
            this.txtMyClalcNum1.Location = new System.Drawing.Point(131, 44);
            this.txtMyClalcNum1.Name = "txtMyClalcNum1";
            this.txtMyClalcNum1.Size = new System.Drawing.Size(100, 22);
            this.txtMyClalcNum1.TabIndex = 2;           
            // 
            // txtMyClalcNum2
            // 
            this.txtMyClalcNum2.Location = new System.Drawing.Point(131, 104);
            this.txtMyClalcNum2.Name = "txtMyClalcNum2";
            this.txtMyClalcNum2.Size = new System.Drawing.Size(100, 22);
            this.txtMyClalcNum2.TabIndex = 3;            
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(39, 186);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "=================";
            // 
            // frmMyCalcAns
            // 
            this.frmMyCalcAns.AutoSize = true;
            this.frmMyCalcAns.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.frmMyCalcAns.Location = new System.Drawing.Point(46, 230);
            this.frmMyCalcAns.Name = "frmMyCalcAns";
            this.frmMyCalcAns.Size = new System.Drawing.Size(64, 24);
            this.frmMyCalcAns.TabIndex = 5;
            this.frmMyCalcAns.Text = "Ans：";
            // 
            // txtMyClassAns
            // 
            this.txtMyClassAns.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMyClassAns.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtMyClassAns.Location = new System.Drawing.Point(131, 229);
            this.txtMyClassAns.Name = "txtMyClassAns";
            this.txtMyClassAns.Size = new System.Drawing.Size(100, 23);
            this.txtMyClassAns.TabIndex = 6;
            // 
            // butMyCalcAdd
            // 
            this.butMyCalcAdd.Location = new System.Drawing.Point(60, 143);
            this.butMyCalcAdd.Name = "butMyCalcAdd";
            this.butMyCalcAdd.Size = new System.Drawing.Size(40, 40);
            this.butMyCalcAdd.TabIndex = 7;
            this.butMyCalcAdd.Text = "＋";
            this.butMyCalcAdd.UseVisualStyleBackColor = true;
            this.butMyCalcAdd.Click += new System.EventHandler(this.butMyCalcAdd_Click);
            // 
            // btnMyCalcSub
            // 
            this.btnMyCalcSub.Location = new System.Drawing.Point(116, 142);
            this.btnMyCalcSub.Name = "btnMyCalcSub";
            this.btnMyCalcSub.Size = new System.Drawing.Size(40, 40);
            this.btnMyCalcSub.TabIndex = 8;
            this.btnMyCalcSub.Text = "－";
            this.btnMyCalcSub.UseVisualStyleBackColor = true;
            this.btnMyCalcSub.Click += new System.EventHandler(this.btnMyCalcSub_Click);
            // 
            // btnMyCalcMult
            // 
            this.btnMyCalcMult.Location = new System.Drawing.Point(174, 142);
            this.btnMyCalcMult.Name = "btnMyCalcMult";
            this.btnMyCalcMult.Size = new System.Drawing.Size(40, 40);
            this.btnMyCalcMult.TabIndex = 9;
            this.btnMyCalcMult.Text = "＊";
            this.btnMyCalcMult.UseVisualStyleBackColor = true;
            this.btnMyCalcMult.Click += new System.EventHandler(this.btnMyCalcMult_Click);
            // 
            // btnMyCalcDiv
            // 
            this.btnMyCalcDiv.Location = new System.Drawing.Point(228, 143);
            this.btnMyCalcDiv.Name = "btnMyCalcDiv";
            this.btnMyCalcDiv.Size = new System.Drawing.Size(40, 40);
            this.btnMyCalcDiv.TabIndex = 10;
            this.btnMyCalcDiv.Text = "/";
            this.btnMyCalcDiv.UseVisualStyleBackColor = true;
            this.btnMyCalcDiv.Click += new System.EventHandler(this.btnMyCalcDiv_Click);
            // 
            // FrmMyCalc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 312);
            this.Controls.Add(this.btnMyCalcDiv);
            this.Controls.Add(this.btnMyCalcMult);
            this.Controls.Add(this.btnMyCalcSub);
            this.Controls.Add(this.butMyCalcAdd);
            this.Controls.Add(this.txtMyClassAns);
            this.Controls.Add(this.frmMyCalcAns);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMyClalcNum2);
            this.Controls.Add(this.txtMyClalcNum1);
            this.Controls.Add(this.FrmMyCalcNum2);
            this.Controls.Add(this.FrmMyClacNum1);
            this.Name = "FrmMyCalc";
            this.Text = "MyCalc";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label FrmMyClacNum1;
        private System.Windows.Forms.Label FrmMyCalcNum2;
        private System.Windows.Forms.TextBox txtMyClalcNum1;
        private System.Windows.Forms.TextBox txtMyClalcNum2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label frmMyCalcAns;
        private System.Windows.Forms.Label txtMyClassAns;
        private System.Windows.Forms.Button butMyCalcAdd;
        private System.Windows.Forms.Button btnMyCalcSub;
        private System.Windows.Forms.Button btnMyCalcMult;
        private System.Windows.Forms.Button btnMyCalcDiv;
    }
}