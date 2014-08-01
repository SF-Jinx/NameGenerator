using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NameGenerator
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            characterNameGen charGen = new characterNameGen();
            charGen.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
//            MessageBox.Show("Coming soon!");
            mapNameGen map = new mapNameGen();
            map.Show();
        }
    }
}
