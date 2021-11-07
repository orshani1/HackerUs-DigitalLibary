using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library.UI
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
            var myControl = new BorrowUserControl();
            myControl.Parent = panel2;
            myControl.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label6_Enter(object sender, EventArgs e)
        {
           
        }

        private void label6_MouseEnter(object sender, EventArgs e)
        {
            label6.BackColor = Color.Crimson;

        }

        private void label6_MouseLeave(object sender, EventArgs e)
        {
         
            label6.BackColor = Color.Transparent;
        }
    }
}
