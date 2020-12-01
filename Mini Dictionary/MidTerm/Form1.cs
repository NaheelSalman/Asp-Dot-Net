using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MidTerm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }
        

        private void btnPhrase_Click(object sender, EventArgs e)
        {
            Phrases ph = new Phrases();
            ph.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Idioms ido = new Idioms();
            ido.Show();
            this.Hide();
            
        }
    }
}
