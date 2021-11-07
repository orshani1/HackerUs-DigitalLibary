using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Library.Entities;
namespace Library.UI
{
    public partial class BorrowUserControl : UserControl
    {
        RentManagament borowing = new RentManagament();
        public BorrowUserControl()
        {
            InitializeComponent();
        }

        private void BorrowUserControl_Load(object sender, EventArgs e)
        {
            BrwdateTimePicker1.MinDate = DateTime.Now;
        }

        private void BrwdateTimePicker1_ValueChanged(object sender, EventArgs e)
        { borowing.BorowingDate = BrwdateTimePicker1.Value;
            dueReturningDate.Text = borowing.DueReturningDate.ToString("dd/MM/yyyy");
        }
    }
}
