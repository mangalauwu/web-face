using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Image img;
        private void button1_Click(object sender, EventArgs e)
        {
           
            OpenFileDialog dlg = new OpenFileDialog();

            dlg.Title = "Open Image";
            dlg.Filter = "jpg files (*.jpg)|*.jpg|All files (*.*)|*.*";

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                imgPhoto.Image = new Bitmap(dlg.OpenFile());
                img = imgPhoto.Image;

            }

            dlg.Dispose();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("sssssss");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = img;
        }
    }
}
