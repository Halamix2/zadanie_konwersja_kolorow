using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rysowanie
{
    public partial class ColorConverter : Form
    {
        public int r { get; set; }
        public int g { get; set; }
        public int b { get; set; }

        private float c { get; set; }
        private float m { get; set; }
        private float y { get; set; }
        private float k { get; set; }

        private int initial_r { get; set; }
        private int initial_g { get; set; }
        private  int initial_b { get; set; }
        public ColorConverter(int r, int g, int b)
        {
            this.r = r;
            this.g = g;
            this.b = b;

            initial_r = r;
            initial_g = g;
            initial_b = b;

            InitializeComponent();
            SetInitialValues();
        }

        private void SetInitialValues()
        {
            SetRgbViewValues();
            ConvertRgbToCmyk();
        }

        private void AcceptButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            r = initial_r;
            g = initial_g;
            b = initial_b;
            this.Close();
        }

        private void ConvertCmykToRgb()
        {
            r = Convert.ToInt32(255 * (1 - c) * (1 - k));
            g = Convert.ToInt32(255 * (1 - m) * (1 - k));
            b = Convert.ToInt32(255 * (1 - y) * (1 - k));

            SetRgbViewValues();
        }

        private void ConvertRgbToCmyk()
        {
            float rf, gf, bf;
            rf = r / 255F;
            gf = g / 255F;
            bf = b / 255F;
 
            k = CmykClamp(1 - Math.Max(Math.Max(rf, gf), bf));
            c = CmykClamp((1 - rf - k) / (1 - k));
            m = CmykClamp((1 - gf - k) / (1 - k));
            y = CmykClamp((1 - bf - k) / (1 - k));

            slider_key.Value = Convert.ToInt32(k * 100);
            slider_cyan.Value = Convert.ToInt32(c * 100);
            slider_magenta.Value = Convert.ToInt32(m * 100);
            slider_yellow.Value = Convert.ToInt32(y * 100);

            label_key.Text = (Math.Round(k * 100)).ToString()+"%";
            label_cyan.Text = (Math.Round(c * 100)).ToString() + "%";
            label_magenta.Text = (Math.Round(m * 100)).ToString() + "%";
            label_yellow.Text = (Math.Round(y * 100)).ToString() + "%";

            label_cmyk.Text = "cmyk(" + slider_cyan.Value.ToString() + "%," + slider_magenta.Value.ToString() + "%," + slider_yellow.Value.ToString() + "%," + slider_key.Value.ToString() + "%)";
        }
        private static float CmykClamp(float value)
        {
            if (value < 0 || float.IsNaN(value))
            {
                value = 0;
            }

            return value;
        }

        private void RgbSlide(object sender, EventArgs e)
        {
            r = slider_red.Value;
            g = slider_green.Value;
            b = slider_blue.Value;

            SetRgbViewValues();
            ConvertRgbToCmyk();
        }

        private void cmykSlide(object sender, EventArgs e)
        {
            c = slider_cyan.Value / 100F;
            m = slider_magenta.Value / 100F;
            y = slider_yellow.Value / 100F;
            k = slider_key.Value / 100F;

            label_cyan.Text = slider_cyan.Value.ToString() + "%";
            label_magenta.Text = slider_magenta.Value.ToString() + "%";
            label_yellow.Text = slider_yellow.Value.ToString() + "%";
            label_key.Text = slider_key.Value.ToString() + "%";
            label_cmyk.Text = "cmyk(" + slider_cyan.Value.ToString() + "%," + slider_magenta.Value.ToString() + "%," + slider_yellow.Value.ToString() + "%," + slider_key.Value.ToString() + "%)";

            ConvertCmykToRgb();
        }

        private void SetRgbViewValues()
        {
            color_panel.BackColor = Color.FromArgb(r, g, b);
            label_red.Text = r.ToString();
            label_green.Text = g.ToString();
            label_blue.Text = b.ToString();
            slider_red.Value = r;
            slider_blue.Value = b;
            slider_green.Value = g;
            label_rgb.Text = "rgb(" + r.ToString() + "," + g.ToString() + "," + b.ToString() + ")";
        }
    }
}
