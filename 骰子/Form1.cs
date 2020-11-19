using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 骰子
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGO_Click(object sender, EventArgs e)
        {
            int randomNum = new Random().Next(100)%6+1; //0-100
            MessageBox.Show($"{randomNum}","Random Num",MessageBoxButtons.OK);
        }
    }
}
