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
    public partial class LoginMenu : Form
    {
        
        public LoginMenu()
        {
            
            InitializeComponent();

           
        }
        SignUpMenu SignUpMenu = null;

        private void Form1_Load(object sender, EventArgs e)
        {
            UsersManagament.SaveUsers();
            PsTxtBx.PasswordChar = '*';

            

            if (this.WindowState == FormWindowState.Minimized)
            {
                this.Hide();
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void xBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #region MouseEvents

        private void xBtn_MouseEnter(object sender, EventArgs e)
        {
            xBtn.BackColor = Color.Red;
        }

        private void xBtn_MouseLeave(object sender, EventArgs e)
        {
            xBtn.BackColor = Color.Transparent;
        }

        private void loginLbl_MouseEnter(object sender, EventArgs e)
        {
            loginLbl.BackColor = Color.FromArgb(0, 80, 115);
        }

        private void loginLbl_MouseLeave(object sender, EventArgs e)
        {
            loginLbl.BackColor = Color.Transparent;
        }

        private void signUpLbl_MouseEnter(object sender, EventArgs e)
        {
            signUpLbl.BackColor = Color.FromArgb(0, 80, 115);
        }

        private void signUpLbl_MouseLeave(object sender, EventArgs e)
        {
            signUpLbl.BackColor = Color.Transparent;

        }

        private void pictureBox2_MouseEnter(object sender, EventArgs e)
        {
            pictureBox2.BackColor = Color.Crimson;
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            pictureBox2.BackColor = Color.Transparent;
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void label4_MouseEnter(object sender, EventArgs e)
        {
            label4.BackColor = Color.Black;
        }

        private void label4_MouseLeave(object sender, EventArgs e)
        {
            label4.BackColor = Color.Transparent;
        }

        #endregion
        private void PsTxtBx_TextChanged(object sender, EventArgs e)
        {
            if (PsTxtBx.Text.Length > 0 )
            {
                loginLbl.Enabled = true;
            }
            else
            {
                loginLbl.Enabled = false;
            }

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox2_MouseDown(object sender, MouseEventArgs e)
        {
            PsTxtBx.PasswordChar = '\0';
        }

        private void pictureBox2_MouseUp(object sender, MouseEventArgs e)
        {
            PsTxtBx.PasswordChar = '*';
        }

        private void loginLbl_MouseDown(object sender, MouseEventArgs e)
        {
            
        }

        private void loginLbl_MouseUp(object sender, MouseEventArgs e)
        {
            
        }

        private void loginLbl_Click(object sender, EventArgs e)
        {
            
            if (DataManager.IsUserExsist(UsTxtBx.Text,PsTxtBx.Text))
            {
               MainMenu main = new MainMenu();
                main.Show();
                LoginMenu login = new LoginMenu();
                login.Close();
              
            }
            else
            {
                MessageBox.Show("lotov");
            }
            

        }

        private void signUpLbl_Click(object sender, EventArgs e)
        {
            if(SignUpMenu == null || SignUpMenu.IsDisposed)
            {
                SignUpMenu = new SignUpMenu();
                SignUpMenu.Show();
            }
            else
            {
                ActivateForm2();
            }
        }
        private void ActivateForm2()
        {
            if (SignUpMenu != null && !SignUpMenu.IsDisposed)
            {
                if (SignUpMenu.WindowState == FormWindowState.Minimized)
                {
                    SignUpMenu.WindowState = FormWindowState.Normal;
                }
                SignUpMenu.Activate();
            }
        }

        private void UsTxtBx_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
