using System;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.Windows.Forms;

namespace Client.WindowApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "Sample Text";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            StudentClient client = new StudentClient("tcpEP");
            string text = client.GetUpperCaseText(textBox1.Text);

            label1.Text = $"From Response: {text}";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ChannelFactory<IStudentService> channelFactory = new ChannelFactory<IStudentService>("tcpEP");
            var client = channelFactory.CreateChannel();

            label1.Text = client.GetUpperCaseText(textBox1.Text);

        }
    }
}
