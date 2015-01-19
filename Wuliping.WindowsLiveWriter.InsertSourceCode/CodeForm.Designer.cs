namespace Wuliping.WindowsLiveWriter.InsertSourceCode
{
    partial class CodeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CodeForm));
            this.btn_ok = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tb_code = new System.Windows.Forms.RichTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_linenumber = new System.Windows.Forms.NumericUpDown();
            this.cb_showlinenumber = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_language = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_linenumber)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_ok
            // 
            this.btn_ok.Location = new System.Drawing.Point(711, 541);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(75, 23);
            this.btn_ok.TabIndex = 1;
            this.btn_ok.Text = "OK";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tb_code);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(8, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(8, 5, 8, 8);
            this.groupBox1.Size = new System.Drawing.Size(778, 506);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Source Code";
            // 
            // tb_code
            // 
            this.tb_code.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_code.Location = new System.Drawing.Point(8, 19);
            this.tb_code.Name = "tb_code";
            this.tb_code.Size = new System.Drawing.Size(762, 479);
            this.tb_code.TabIndex = 1;
            this.tb_code.Text = "";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_linenumber);
            this.groupBox2.Controls.Add(this.cb_showlinenumber);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.cb_language);
            this.groupBox2.Location = new System.Drawing.Point(8, 520);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(505, 44);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Options";
            // 
            // txt_linenumber
            // 
            this.txt_linenumber.Location = new System.Drawing.Point(407, 13);
            this.txt_linenumber.Name = "txt_linenumber";
            this.txt_linenumber.Size = new System.Drawing.Size(85, 21);
            this.txt_linenumber.TabIndex = 6;
            this.txt_linenumber.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cb_showlinenumber
            // 
            this.cb_showlinenumber.AutoSize = true;
            this.cb_showlinenumber.Checked = true;
            this.cb_showlinenumber.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_showlinenumber.Location = new System.Drawing.Point(162, 16);
            this.cb_showlinenumber.Name = "cb_showlinenumber";
            this.cb_showlinenumber.Size = new System.Drawing.Size(120, 16);
            this.cb_showlinenumber.TabIndex = 5;
            this.cb_showlinenumber.Text = "show line number";
            this.cb_showlinenumber.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(288, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "line number start:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "language:";
            // 
            // cb_language
            // 
            this.cb_language.FormattingEnabled = true;
            this.cb_language.Location = new System.Drawing.Point(71, 14);
            this.cb_language.Name = "cb_language";
            this.cb_language.Size = new System.Drawing.Size(85, 20);
            this.cb_language.TabIndex = 0;
            this.cb_language.SelectedIndexChanged += new System.EventHandler(this.cb_language_SelectedIndexChanged);
            // 
            // CodeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(794, 575);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CodeForm";
            this.Padding = new System.Windows.Forms.Padding(8);
            this.Text = "InsertCode";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_linenumber)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cb_language;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cb_showlinenumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown txt_linenumber;
        private System.Windows.Forms.RichTextBox tb_code;
    }
}