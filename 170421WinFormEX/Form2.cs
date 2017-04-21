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
    public partial class Form2 : Form
    {
        public int PosX { get; set; }
        public int PosY { get; set; }
        public Color Co { get; set; }
        public string Str { get; set; }
        public Form2()
        {
            InitializeComponent();
            CB_COLOR.Items.Add("빨간색");
            CB_COLOR.Items.Add("녹　색");
            CB_COLOR.Items.Add("파란색");
        }

        public Form2(int px,int py,Color co, string str) : this()
        {
            PosX = px;
            PosY = py;
            Co = co;
            Str = str;

            TB_POSX.Text = PosX.ToString();
            TB_POSY.Text = PosY.ToString();


            // 이걸 Color.Red 하고 비교하니 안된다. 255,0,0으로 초기화했으면
            // 비교할때도 255,0,0으로 해야하는듯. A값 때문인가?...
            if (Co == Color.FromArgb(255,0,0))
                CB_COLOR.SelectedIndex = 0;
            else if (Co == Color.FromArgb(0, 255, 0))
                CB_COLOR.SelectedIndex = 1;
            else if (Co == Color.FromArgb(0, 0, 255))
                CB_COLOR.SelectedIndex = 2;
            else
                CB_COLOR.Text = "";

            TB_STR.Text = Str;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;

            PosX = int.Parse(TB_POSX.Text);
            PosY = int.Parse(TB_POSY.Text);

            if (CB_COLOR.SelectedIndex == 0)
                Co = Color.FromArgb(255, 0, 0);
            else if (CB_COLOR.SelectedIndex == 1)
                Co = Color.FromArgb(0, 255, 0);
            else if (CB_COLOR.SelectedIndex == 2)
                Co = Color.FromArgb(0, 0, 255);

            Str = TB_STR.Text;
        }
    }
}
