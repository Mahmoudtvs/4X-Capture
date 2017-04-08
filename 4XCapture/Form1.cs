using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4XCapture
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            string PrintSC = "{PrtSc}";
            PrintSC = "%" + PrintSC;
            SendKeys.SendWait(PrintSC);
            FRM_FullScreen frm = new FRM_FullScreen();
            frm.pictureBox1.Image = Clipboard.GetImage();
            frm.ShowDialog();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            // الزر ده لإلتقاط صورة للشاشة كلها وليش للنافذة النشطة فقط
            this.Opacity = .0;
            string PrintSC = "{PrtSc}";
            SendKeys.SendWait(PrintSC);
            FRM_FullScreen frm = new FRM_FullScreen();
            frm.pictureBox1.Image = Clipboard.GetImage();
            frm.ShowDialog();
            this.Opacity = 1.00;
        }
    }
}
