using Builder;

namespace BuilderLanterns
{
    public partial class Form1 : Form
    {
        LanternBuilder builder;
        LanternDirector director;
        public Form1()
        {
            InitializeComponent();
            builder = new LanternBuilder();
            director = new LanternDirector(builder);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            director.ConstructStandardLantern();
            listBox1.Items.Add("Standard Lantern: ");
            listBox1.Items.Add(builder.GetLantern().GetConfiguration());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            director.ConstructCustomLantern();
            listBox1.Items.Add("Custom Lantern: ");
            listBox1.Items.Add(builder.GetLantern().GetConfiguration());
        }
    }
}