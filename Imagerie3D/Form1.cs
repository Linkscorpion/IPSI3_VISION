using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace Imagerie3D
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string[] files;     
        private void button_ouvrir_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    files = Directory.GetFiles(fbd.SelectedPath);

                    System.Windows.Forms.MessageBox.Show("Files found: " + files.Length.ToString(), "Message");
                }
            }

        }

        private void button_afficher_coupe_Click(object sender, EventArgs e)
        {
            if (!(files[0] == null))
            {
                double doubleValue=0;
                bool ret = double.TryParse(textBox_Z_coord.Text, out doubleValue);
                int  i = (int)(files.Length * doubleValue / 929.5)-1;
                Bitmap bmp = new Bitmap(files[i].ToString());
                pictureBox1.Size = bmp.Size;
                pictureBox1.Image = bmp;
                //z_min: 410.5 mm
                //z_max : 929.5mm
                //pas de 9mm entre chaque image
            }
                
        }
    }
}
