using Builder;

namespace BuilderLanterns
{
    public partial class Form1 : Form
    {
        LanternDirector director = new LanternDirector();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ILanternBuilder simpleBuilder = new SimpleLanternBuilder();
            Lantern simpleLantern = director.Construct(simpleBuilder);
            listBox1.Items.Add("Simple Lantern: ");
            listBox1.Items.Add(simpleLantern.Display());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ILanternBuilder complexBuilder = new ComplexLanternBuilder();
            Lantern complexLantern = director.Construct(complexBuilder);
            listBox1.Items.Add("Complex Lantern: ");
            listBox1.Items.Add(complexLantern.Display());
        }
    }
}