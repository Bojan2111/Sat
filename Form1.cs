using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sat
{
    public partial class Sat : Form
    {
        public Sat()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = DateTime.Now.ToString("ddd, dd. MMM yyyy.");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.label1.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void izlaz_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
