using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuardarImagen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Guardamos la imagen
            saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Title = "Guardar como...";
            saveFileDialog1.FileName = "imagen";

            saveFileDialog1.Filter = "imagenes(*.png)|*.png;";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
               

            pictureBox1.Image.Save(saveFileDialog1.FileName);

            //fin del guardado
        }
    }
}
