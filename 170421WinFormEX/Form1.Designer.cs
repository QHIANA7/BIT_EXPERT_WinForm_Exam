namespace _170421WinFormEX
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.MENUSTRIP_1 = new System.Windows.Forms.MenuStrip();
            this.파일FToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.종료XToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.색상CToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.빨간색RToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.녹색GToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.파란색BToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.색상공통다이얼로그DToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.옵션OToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.모달MToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TM_1 = new System.Windows.Forms.Timer(this.components);
            this.MENUSTRIP_1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MENUSTRIP_1
            // 
            this.MENUSTRIP_1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MENUSTRIP_1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.파일FToolStripMenuItem,
            this.색상CToolStripMenuItem,
            this.옵션OToolStripMenuItem});
            this.MENUSTRIP_1.Location = new System.Drawing.Point(0, 0);
            this.MENUSTRIP_1.Name = "MENUSTRIP_1";
            this.MENUSTRIP_1.Size = new System.Drawing.Size(1026, 28);
            this.MENUSTRIP_1.TabIndex = 0;
            this.MENUSTRIP_1.Text = "menuStrip1";
            // 
            // 파일FToolStripMenuItem
            // 
            this.파일FToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.종료XToolStripMenuItem});
            this.파일FToolStripMenuItem.Name = "파일FToolStripMenuItem";
            this.파일FToolStripMenuItem.Size = new System.Drawing.Size(68, 24);
            this.파일FToolStripMenuItem.Text = "파일(F)";
            // 
            // 종료XToolStripMenuItem
            // 
            this.종료XToolStripMenuItem.Name = "종료XToolStripMenuItem";
            this.종료XToolStripMenuItem.Size = new System.Drawing.Size(133, 26);
            this.종료XToolStripMenuItem.Text = "종료(X)";
            this.종료XToolStripMenuItem.Click += new System.EventHandler(this.종료XToolStripMenuItem_Click);
            // 
            // 색상CToolStripMenuItem
            // 
            this.색상CToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.빨간색RToolStripMenuItem,
            this.녹색GToolStripMenuItem,
            this.파란색BToolStripMenuItem,
            this.색상공통다이얼로그DToolStripMenuItem});
            this.색상CToolStripMenuItem.Name = "색상CToolStripMenuItem";
            this.색상CToolStripMenuItem.Size = new System.Drawing.Size(71, 24);
            this.색상CToolStripMenuItem.Text = "색상(C)";
            // 
            // 빨간색RToolStripMenuItem
            // 
            this.빨간색RToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.빨간색RToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.빨간색RToolStripMenuItem.Name = "빨간색RToolStripMenuItem";
            this.빨간색RToolStripMenuItem.Size = new System.Drawing.Size(259, 26);
            this.빨간색RToolStripMenuItem.Text = "빨간색(R)";
            this.빨간색RToolStripMenuItem.Click += new System.EventHandler(this.빨간색RToolStripMenuItem_Click);
            // 
            // 녹색GToolStripMenuItem
            // 
            this.녹색GToolStripMenuItem.Name = "녹색GToolStripMenuItem";
            this.녹색GToolStripMenuItem.Size = new System.Drawing.Size(259, 26);
            this.녹색GToolStripMenuItem.Text = "녹   색(G)";
            this.녹색GToolStripMenuItem.Click += new System.EventHandler(this.녹색GToolStripMenuItem_Click);
            // 
            // 파란색BToolStripMenuItem
            // 
            this.파란색BToolStripMenuItem.Name = "파란색BToolStripMenuItem";
            this.파란색BToolStripMenuItem.Size = new System.Drawing.Size(259, 26);
            this.파란색BToolStripMenuItem.Text = "파란색(B)";
            this.파란색BToolStripMenuItem.Click += new System.EventHandler(this.파란색BToolStripMenuItem_Click);
            // 
            // 색상공통다이얼로그DToolStripMenuItem
            // 
            this.색상공통다이얼로그DToolStripMenuItem.Name = "색상공통다이얼로그DToolStripMenuItem";
            this.색상공통다이얼로그DToolStripMenuItem.Size = new System.Drawing.Size(259, 26);
            this.색상공통다이얼로그DToolStripMenuItem.Text = "색상 공통 다이얼로그(D)...";
            this.색상공통다이얼로그DToolStripMenuItem.Click += new System.EventHandler(this.색상공통다이얼로그DToolStripMenuItem_Click);
            // 
            // 옵션OToolStripMenuItem
            // 
            this.옵션OToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.모달MToolStripMenuItem});
            this.옵션OToolStripMenuItem.Name = "옵션OToolStripMenuItem";
            this.옵션OToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.옵션OToolStripMenuItem.Text = "옵션(O)";
            // 
            // 모달MToolStripMenuItem
            // 
            this.모달MToolStripMenuItem.Name = "모달MToolStripMenuItem";
            this.모달MToolStripMenuItem.Size = new System.Drawing.Size(147, 26);
            this.모달MToolStripMenuItem.Text = "모달(M)...";
            this.모달MToolStripMenuItem.Click += new System.EventHandler(this.모달MToolStripMenuItem_Click);
            // 
            // TM_1
            // 
            this.TM_1.Enabled = true;
            this.TM_1.Interval = 1000;
            this.TM_1.Tick += new System.EventHandler(this.TM_1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1026, 500);
            this.Controls.Add(this.MENUSTRIP_1);
            this.MainMenuStrip = this.MENUSTRIP_1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MENUSTRIP_1.ResumeLayout(false);
            this.MENUSTRIP_1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MENUSTRIP_1;
        private System.Windows.Forms.ToolStripMenuItem 파일FToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 종료XToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 색상CToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 빨간색RToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 녹색GToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 파란색BToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 옵션OToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 모달MToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 색상공통다이얼로그DToolStripMenuItem;
        private System.Windows.Forms.Timer TM_1;
    }
}

