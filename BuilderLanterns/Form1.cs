using Builder;
using Microsoft.VisualBasic.ApplicationServices;
using Prototype;
using System;

namespace BuilderLanterns
{
    public partial class Form1 : Form
    {
        private LanternBuilder builder;
        private LanternPrototype savedLanternPrototype;

        public Form1()
        {
            InitializeComponent();
            builder = new LanternBuilder();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string baseImage = "img\\hama-basic-fl-92.jpg";
            string bulbImage = "img\\lantern-light-bulb-600x600.jpg";
            string standImage = "img\\xScreenshot_35-420x340.png.pagespeed.ic.v5gKnwfZ6C.png";

            builder.BuildBase(baseImage);
            builder.BuildBulb(bulbImage);
            builder.BuildStand(standImage);

            pictureBox2.Image = Image.FromFile(baseImage);
            pictureBox1.Image = Image.FromFile(bulbImage);
            pictureBox3.Image = Image.FromFile(standImage);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string baseImage = "img\\ceb888cf83040db76fd5a38b1e7cb12fde47c09d_original.jpeg";
            string bulbImage = "img\\svitlodiodnij-lihtarik-munkees-led-tent-lamp-blue-10286.1000x1000.jpg";
            string standImage = "img\\fonarik-led-teleskopicheskiy-s-magnitom-sturm-4050-01-2s-96300926587869.jpg";

            builder.BuildBase(baseImage);
            builder.BuildBulb(bulbImage);
            builder.BuildStand(standImage);

            pictureBox2.Image = Image.FromFile(baseImage);
            pictureBox1.Image = Image.FromFile(bulbImage);
            pictureBox3.Image = Image.FromFile(standImage);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            savedLanternPrototype = builder.GetPrototype();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (savedLanternPrototype != null)
            {
                pictureBox2.Image = Image.FromFile(savedLanternPrototype.BaseImage);
                pictureBox1.Image = Image.FromFile(savedLanternPrototype.BulbImage);
                pictureBox3.Image = Image.FromFile(savedLanternPrototype.StandImage);
            }
            else
            {
                MessageBox.Show("Фанарик не був скопійований. Спочатку скопіюйте його за допомогою кнопки Copy.");
            }
        }
    }
}