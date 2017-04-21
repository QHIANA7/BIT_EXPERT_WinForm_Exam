namespace _170421WinFormEX
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.TB_POSX = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TB_POSY = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CB_COLOR = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TB_STR = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "X좌표";
            // 
            // TB_POSX
            // 
            this.TB_POSX.Location = new System.Drawing.Point(83, 46);
            this.TB_POSX.Name = "TB_POSX";
            this.TB_POSX.Size = new System.Drawing.Size(212, 25);
            this.TB_POSX.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Y좌표";
            // 
            // TB_POSY
            // 
            this.TB_POSY.Location = new System.Drawing.Point(83, 89);
            this.TB_POSY.Name = "TB_POSY";
            this.TB_POSY.Size = new System.Drawing.Size(212, 25);
            this.TB_POSY.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "색상";
            // 
            // CB_COLOR
            // 
            this.CB_COLOR.FormattingEnabled = true;
            this.CB_COLOR.Location = new System.Drawing.Point(83, 178);
            this.CB_COLOR.Name = "CB_COLOR";
            this.CB_COLOR.Size = new System.Drawing.Size(212, 23);
            this.CB_COLOR.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 246);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "문자열";
            // 
            // TB_STR
            // 
            this.TB_STR.Location = new System.Drawing.Point(83, 243);
            this.TB_STR.Name = "TB_STR";
            this.TB_STR.Size = new System.Drawing.Size(212, 25);
            this.TB_STR.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(83, 282);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 44);
            this.button1.TabIndex = 3;
            this.button1.Text = "확인";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(203, 282);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(92, 44);
            this.button2.TabIndex = 3;
            this.button2.Text = "취소";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 338);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.CB_COLOR);
            this.Controls.Add(this.TB_STR);
            this.Controls.Add(this.TB_POSY);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TB_POSX);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TB_POSX;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TB_POSY;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CB_COLOR;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TB_STR;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}