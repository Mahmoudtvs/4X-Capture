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
    public partial class FRM_FullScreen : Form
    {
        public FRM_FullScreen()
        {
            InitializeComponent();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "ملفات الصور |*.jpg; *.png; *.gif";
            if (sfd.ShowDialog() == DialogResult.OK)
                pictureBox1.Image.Save(sfd.FileName);
            MessageBox.Show("تم الحفظ بنجاح", "حفظ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
