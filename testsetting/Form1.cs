using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testsetting
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Width = Properties.Settings.Default.width;
            Height = Properties.Settings.Default.height;
            textBox1.Text = Properties.Settings.Default.text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.text = textBox1.Text;
            Properties.Settings.Default.Save();
        }
    }
}
