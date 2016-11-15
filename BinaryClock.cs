using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class frmbinaryclock : Form
    {
        System.Drawing.Color onColor;
        System.Drawing.Color offColor;
        String strseconds;
        String strminutes;
        String strhours;
        int inthoursbig;
        int inthourssmall;
        int intminutesbig;
        int intminutessmall;
        int intsecondsbig;
        int intsecondssmall;
        public void Colorful(int time, int numclolom)
        {
            switch (numclolom)
            {
                case 1:
                    color1columnDots(time, label01, label02, label02, label02);
                    break;
                case 2:
                    color1columnDots(time, label11, label12, label13, label14);
                    break;
                case 3:
                    color1columnDots(time, label21, label22, label23, null);
                    break;
                case 4:
                    color1columnDots(time, label021, label022, label023, label024);
                    break;
                case 5:
                    color1columnDots(time, label31, label32, label33, null);
                    break;
                case 6:
                    color1columnDots(time, label031, label032, label033, label034);
                    break;
            }
        }

        private void color1columnDots(int time, Label lab1, Label lab2, Label lab3, Label lab4)
        {
            string resultBin = Convert.ToString(time, 2).PadLeft(4,'0');
            if (resultBin.Substring(3,1) == "0")
                { lab1.BackColor = offColor; }
            else 
                { lab1.BackColor = onColor; }

            if (resultBin.Substring(2, 1) == "0")
                { lab2.BackColor = offColor; }
            else
                { lab2.BackColor = onColor; }

            if (resultBin.Substring(1, 1) == "0")
                { lab3.BackColor = offColor; }
            else
                { lab3.BackColor = onColor; }

            try
            {
            if (time < 8)
                { lab4.BackColor = offColor; }
            else
                { lab4.BackColor = onColor; }
            }
            catch{}

        }

        public frmbinaryclock()
        {

            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            onColor = Color.Blue;
            offColor = Color.DarkSlateGray;

            Timerbackdetail.Enabled = true;
            Timercolors.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {


        }

        private void lblseconds_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Timercolors_Tick(object sender, EventArgs e)
        {


            strminutes = string.Format("{0:mm}", DateTime.Now);
            strhours = string.Format("{0:HH}", DateTime.Now);
            strseconds = string.Format("{0:ss}", DateTime.Now);
            inthoursbig = Convert.ToInt32(Convert.ToString((strhours[0])));
            inthourssmall = Convert.ToInt32(Convert.ToString((strhours[1])));
            intminutesbig = Convert.ToInt32(Convert.ToString((strminutes[0])));
            intminutessmall = Convert.ToInt32(Convert.ToString((strminutes[1])));
            intsecondsbig = Convert.ToInt32(Convert.ToString(strseconds[0]));
            intsecondssmall = Convert.ToInt32((Convert.ToString(strseconds[1])));

            Colorful(inthoursbig, 1);
            Colorful(inthourssmall, 2);
            Colorful(intminutesbig, 3);
            Colorful(intminutessmall, 4);
            Colorful(intsecondsbig, 5);
            Colorful(intsecondssmall, 6);
        }

        private void lblseconds_TextChanged(object sender, EventArgs e)
        {

        }

        private void Timerconfig_Tick(object sender, EventArgs e)
        {

        }

        private void label024_Click(object sender, EventArgs e)
        {

        }

       

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void themeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog MyDialog = new ColorDialog();
            MyDialog.Color = onColor;

            if (MyDialog.ShowDialog() == DialogResult.OK)
                onColor = MyDialog.Color;

        }

        private void blueToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ColorDialog MyDialog = new ColorDialog();
            MyDialog.Color = offColor;

            if (MyDialog.ShowDialog() == DialogResult.OK)
                offColor = MyDialog.Color;
        }

        private void yellowToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            onColor = Color.Yellow;
        }

        private void greenToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ColorDialog MyDialog = new ColorDialog();
            MyDialog.Color = this.BackColor;

            if (MyDialog.ShowDialog() == DialogResult.OK)
                this.BackColor = MyDialog.Color;

        }

        private void purpleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            onColor = Color.Purple;
        }

        private void trcpyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.tbarOpacity.Visible == true)
                { this.tbarOpacity.Visible = false; return; }
            this.tbarOpacity.Visible = true;
        }

        private void tbarOpacity_Scroll(object sender, EventArgs e)
        {
            double myOpac = this.tbarOpacity.Value;
            this.Opacity = myOpac / 100;
            this.Refresh();
        }


    }

}
