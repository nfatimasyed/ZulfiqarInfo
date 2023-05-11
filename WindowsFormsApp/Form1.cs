using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class btn_hello : Form
    {
        public btn_hello()
        {
            InitializeComponent();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Learning WinForms Application  : ", "Error ");
        }
    }
}
