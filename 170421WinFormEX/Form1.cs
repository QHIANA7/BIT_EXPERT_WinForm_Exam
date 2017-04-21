using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _170421WinFormEX
{
    public partial class Form1 : Form
    {
        Data dt = null;
        Form2 fdlg = null;

        public Form1()
        {
            InitializeComponent();
            dt = new Data()
            {
                Co = Color.FromArgb(255, 0, 0),
                Str = "초기화된 문자열",
                FontSize = 10,
                Pt = new Point(0, 0)
            };

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            using (Graphics gp = this.CreateGraphics())
            {
                gp.TranslateTransform(0, 30);
                Font font = new Font(this.Font.Name, dt.FontSize, FontStyle.Bold);
                gp.DrawString(dt.Str, font, new SolidBrush(dt.Co), dt.Pt);
                this.BackColor = Color.FromArgb(dt.Co.R ^ 255, dt.Co.G ^ 255, dt.Co.B ^ 255);

                Bitmap bmp = new Bitmap(25, 25);
                Rectangle rect = new Rectangle(0, 0, 25, 25);

                using (Graphics gpbmp = Graphics.FromImage(bmp))
                {
                    gpbmp.FillRectangle(Brushes.Red, rect);
                    this.빨간색RToolStripMenuItem.Image = new Bitmap(bmp);
                    gpbmp.FillRectangle(Brushes.Green, rect);
                    this.녹색GToolStripMenuItem.Image = new Bitmap(bmp);
                    gpbmp.FillRectangle(Brushes.Blue, rect);
                    this.파란색BToolStripMenuItem.Image = new Bitmap(bmp);
                    gpbmp.FillRectangle(new SolidBrush(Color.FromArgb(dt.Co.R ^ 255, dt.Co.G ^ 255, dt.Co.B ^ 255)), rect);
                    gpbmp.DrawRectangle(new Pen(Color.Black,4), rect);
                    gpbmp.DrawString("U", new Font(this.Font.Name, 15,FontStyle.Bold), new SolidBrush(dt.Co), 2, 2.5f);
                    this.색상공통다이얼로그DToolStripMenuItem.Image = new Bitmap(bmp);
                }
            }
        }

        private void 종료XToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void 모달MToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fdlg = new Form2(dt.Pt.X, dt.Pt.Y, dt.Co, dt.Str);
            if(fdlg.ShowDialog() == DialogResult.OK)
            {
                dt.Pt = new Point(fdlg.PosX, fdlg.PosY);
                dt.Co = fdlg.Co;
                dt.Str = fdlg.Str;
                Invalidate();
            }
        }

        private void 빨간색RToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dt.Co = Color.FromArgb(255, 0, 0);
            Invalidate();
        }

        private void 녹색GToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dt.Co = Color.FromArgb(0, 255, 0);
            Invalidate();
        }

        private void 파란색BToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dt.Co = Color.FromArgb(0, 0, 255);
            Invalidate();
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                dt.Pt = new Point(e.X,e.Y-30);
                Invalidate();
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Up)
            {
                dt.FontSize += 2;
                Invalidate();
            }
            else if (e.KeyCode == Keys.Down)
            {
                if (dt.FontSize <= 2)
                    return;
                dt.FontSize -= 2;
                Invalidate();
            }
        }

        private void 색상공통다이얼로그DToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog cdlg = new ColorDialog();

            if (cdlg.ShowDialog() == DialogResult.OK)
            {
                dt.Co = cdlg.Color;
                Invalidate();
            }
        }

        private void TM_1_Tick(object sender, EventArgs e)
        {
            this.Text = DateTime.Now.ToString();
        }
    }
}
