namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
        /// 修改這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.ofd1 = new System.Windows.Forms.OpenFileDialog();
            this.label2 = new System.Windows.Forms.Label();
            this.cbSheet = new System.Windows.Forms.ComboBox();
            this.txtExcelPath = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnExcelPath = new System.Windows.Forms.Button();
            this.gd1 = new System.Windows.Forms.DataGridView();
            this.btnClear = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbTEL = new System.Windows.Forms.Label();
            this.lbFAX = new System.Windows.Forms.Label();
            this.lbFAXSales = new System.Windows.Forms.Label();
            this.lbNO = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gd1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 12F);
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "選擇公司:";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("新細明體", 12F);
            this.button1.Location = new System.Drawing.Point(15, 49);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 34);
            this.button1.TabIndex = 1;
            this.button1.Text = "查詢";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ofd1
            // 
            this.ofd1.FileName = "openFileDialog1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 12F);
            this.label2.Location = new System.Drawing.Point(12, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "選擇分機表:";
            // 
            // cbSheet
            // 
            this.cbSheet.FormattingEnabled = true;
            this.cbSheet.Items.AddRange(new object[] {
            "元長",
            "分公司",
            "彰濱廠"});
            this.cbSheet.Location = new System.Drawing.Point(94, 23);
            this.cbSheet.Name = "cbSheet";
            this.cbSheet.Size = new System.Drawing.Size(121, 20);
            this.cbSheet.TabIndex = 2;
            // 
            // txtExcelPath
            // 
            this.txtExcelPath.Location = new System.Drawing.Point(128, 29);
            this.txtExcelPath.Name = "txtExcelPath";
            this.txtExcelPath.Size = new System.Drawing.Size(312, 22);
            this.txtExcelPath.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnExcelPath);
            this.groupBox1.Controls.Add(this.txtExcelPath);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(485, 88);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "查詢設定";
            // 
            // btnExcelPath
            // 
            this.btnExcelPath.Location = new System.Drawing.Point(446, 27);
            this.btnExcelPath.Name = "btnExcelPath";
            this.btnExcelPath.Size = new System.Drawing.Size(29, 23);
            this.btnExcelPath.TabIndex = 4;
            this.btnExcelPath.Text = "...";
            this.btnExcelPath.UseVisualStyleBackColor = true;
            this.btnExcelPath.Click += new System.EventHandler(this.btnExcelPath_Click);
            // 
            // gd1
            // 
            this.gd1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gd1.Location = new System.Drawing.Point(12, 116);
            this.gd1.Name = "gd1";
            this.gd1.RowTemplate.Height = 24;
            this.gd1.Size = new System.Drawing.Size(180, 234);
            this.gd1.TabIndex = 5;
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("新細明體", 12F);
            this.btnClear.Location = new System.Drawing.Point(140, 49);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 34);
            this.btnClear.TabIndex = 1;
            this.btnClear.Text = "清空";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbNO);
            this.groupBox2.Controls.Add(this.lbFAXSales);
            this.groupBox2.Controls.Add(this.lbFAX);
            this.groupBox2.Controls.Add(this.lbTEL);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.btnClear);
            this.groupBox2.Controls.Add(this.cbSheet);
            this.groupBox2.Location = new System.Drawing.Point(198, 116);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(299, 234);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("新細明體", 12F);
            this.label3.Location = new System.Drawing.Point(12, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "TEL：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("新細明體", 12F);
            this.label4.Location = new System.Drawing.Point(12, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "FAX：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("新細明體", 12F);
            this.label5.Location = new System.Drawing.Point(12, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 16);
            this.label5.TabIndex = 3;
            this.label5.Text = "FAX(業務)：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("新細明體", 12F);
            this.label6.Location = new System.Drawing.Point(12, 182);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 16);
            this.label6.TabIndex = 3;
            this.label6.Text = "代號：";
            // 
            // lbTEL
            // 
            this.lbTEL.AutoSize = true;
            this.lbTEL.Font = new System.Drawing.Font("新細明體", 12F);
            this.lbTEL.Location = new System.Drawing.Point(69, 101);
            this.lbTEL.Name = "lbTEL";
            this.lbTEL.Size = new System.Drawing.Size(46, 16);
            this.lbTEL.TabIndex = 4;
            this.lbTEL.Text = "label7";
            // 
            // lbFAX
            // 
            this.lbFAX.AutoSize = true;
            this.lbFAX.Font = new System.Drawing.Font("新細明體", 12F);
            this.lbFAX.Location = new System.Drawing.Point(69, 127);
            this.lbFAX.Name = "lbFAX";
            this.lbFAX.Size = new System.Drawing.Size(46, 16);
            this.lbFAX.TabIndex = 4;
            this.lbFAX.Text = "label7";
            // 
            // lbFAXSales
            // 
            this.lbFAXSales.AutoSize = true;
            this.lbFAXSales.Font = new System.Drawing.Font("新細明體", 12F);
            this.lbFAXSales.Location = new System.Drawing.Point(105, 154);
            this.lbFAXSales.Name = "lbFAXSales";
            this.lbFAXSales.Size = new System.Drawing.Size(46, 16);
            this.lbFAXSales.TabIndex = 4;
            this.lbFAXSales.Text = "label7";
            // 
            // lbNO
            // 
            this.lbNO.AutoSize = true;
            this.lbNO.Font = new System.Drawing.Font("新細明體", 12F);
            this.lbNO.Location = new System.Drawing.Point(69, 182);
            this.lbNO.Name = "lbNO";
            this.lbNO.Size = new System.Drawing.Size(46, 16);
            this.lbNO.TabIndex = 4;
            this.lbNO.Text = "label7";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 362);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gd1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "分機查詢";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gd1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.OpenFileDialog ofd1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbSheet;
        private System.Windows.Forms.TextBox txtExcelPath;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnExcelPath;
        private System.Windows.Forms.DataGridView gd1;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbNO;
        private System.Windows.Forms.Label lbFAXSales;
        private System.Windows.Forms.Label lbFAX;
        private System.Windows.Forms.Label lbTEL;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}

