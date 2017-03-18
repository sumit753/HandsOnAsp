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

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != String.Empty && textBox2.Text != String.Empty)
            {
                System.Diagnostics.EventLog.CreateEventSource(textBox2.Text, textBox1.Text);
                MessageBox.Show("Event Source Created");
            }
            else {
                MessageBox.Show("Event Source not Created");
            }
        }
    }
}
