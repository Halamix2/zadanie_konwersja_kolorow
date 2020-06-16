using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rysowanie
{
    public partial class KernelDialog : Form
    {
        public float[,] kernel { set; get; }
        public KernelDialog(float[,] kernel)
        {
            this.kernel = kernel;
            InitializeComponent();
            for (int x = 0; x < 5; x++)
            {
                for (int y = 0; y < 5; y++)
                {
                    TextBox box = (TextBox)this.Controls.Find("textBox" + (x * 5 + y + 1), true)[0];
                    box.Text = this.kernel[x, y].ToString();
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //set values and quit
            for(int x = 0; x <5; x++)
            {
                for (int y = 0; y < 5; y++)
                {
                    TextBox box = (TextBox)this.Controls.Find("textBox" + (x*5 + y + 1), true)[0];
                    this.kernel[x, y] = float.Parse(box.Text);
                }
            }

            this.Close();
        }
    }
}
