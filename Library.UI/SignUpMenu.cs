using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.Json.Serialization;
using System.Text.Json;
using System.Web.Script.Serialization;


namespace Library.UI
{
    public class UserClient
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
    }
    public partial class SignUpMenu : Form
    {
        public SignUpMenu()
        {
            InitializeComponent();
        }
        #region LabelAndStyling
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void SignMe_MouseEnter(object sender, EventArgs e)
        {
            SignMe.BackColor = Color.Crimson;
        }

        private void SignMe_MouseLeave(object sender, EventArgs e)
        {

            SignMe.BackColor = Color.Transparent;
        }

        private void xBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
        private void SignMe_Click(object sender, EventArgs e)
        {

            int flag = 0;
            #region QuickValidation
            if (!UsTxtBx.IsUserName())
                flag++;

            if (!PsTxtBx.IsPassword())
                flag++;
            if (!Emailtxtbx.IsEmail())
                flag++;
            if (!phoneNumTxtBx.IsPhoneNumber())
                flag++;
            if (!IDTxtBx.IsID())
                flag++;
            if (!phoneNumTxtBx.IsPhoneNumber())
                flag++;
            #endregion
            #region MessageBoxForErrors
            MessageBoxButtons button = MessageBoxButtons.OK;
            MessageBoxIcon icon = MessageBoxIcon.Error;
            string caption = "Unsuccsesfull SignUp";
            string txt = $"You have {flag} Fields Wrong ,\nTry Again pls";
            if (flag > 0)
            {
                MessageBox.Show(txt, caption, button, icon);
            }
            #endregion
            #region IfAllGood
            if (flag == 0)
            {
                MessageBoxButtons button1 = MessageBoxButtons.OK;
                MessageBoxIcon icon1 = MessageBoxIcon.Information;
                string caption1 = "succsesfull SignUp";
                string txt1 = $"You login succsesfully\nWelcome! {firstNameTxt.Text + " " + LastNameTxt.Text}";
                MessageBox.Show(txt1, caption1, button1, icon1);
                SaveUser();
                SaveUserJSON();
                
               
            } 
            #endregion
        }
        public void SaveUser()
        {

            string path = @"C:\Users\user\Desktop\softwaredev\Projects Folder\HackerUs DigitalLibary\Users.txt";

           
            StreamReader sr = new StreamReader(path);
            var finaltxt = sr.ReadToEnd();
            sr.Dispose();
            sr.Close();
            StreamWriter streamWriter = new StreamWriter(path);
            finaltxt += "\n" + $"[user : {UsTxtBx.Text}\n" +
                    $"password : {PsTxtBx.Text}\n" +
                    $"Email : {Emailtxtbx.Text}\n" +
                    $"PhoneNumber : {phoneNumTxtBx.Text}\n" +
                    $"ID : {IDTxtBx.Text}\n" +
                    $"First Name : {firstNameTxt.Text}\n" +
                    $"Last Name : {LastNameTxt.Text}]\n\n";
            Library.Entities.UsersManagament.ClientsList.Add(new Entities.Client()
            {
                FirstName = firstNameTxt.Text,
                LastName = LastNameTxt.Text,
                Id = int.Parse(IDTxtBx.Text),
                Email = Emailtxtbx.Text,
                PhoneNumber = phoneNumTxtBx.Text,
                UserName = UsTxtBx.Text,
                Password = PsTxtBx.Text,
            });

            streamWriter.WriteLine(finaltxt);
            streamWriter.Dispose();
            
            streamWriter.Close();
            
        }


        public void SaveUserJSON()
        {

            string path = @"C:\Users\user\Desktop\softwaredev\Projects Folder\UserJson.json";
             var client = new UserClient()
             {
                 FirstName = firstNameTxt.Text,
                 LastName = LastNameTxt.Text,
                 Id = int.Parse(IDTxtBx.Text),
                 Email = Emailtxtbx.Text,
                 PhoneNumber = phoneNumTxtBx.Text,
                 UserName = UsTxtBx.Text,
                 Password = PsTxtBx.Text,
             };
            var options = new JsonSerializerOptions
            {
                WriteIndented = true,
            };
            var jsonString = JsonSerializer.Serialize<UserClient>(client, options);
            FileInfo file = new FileInfo(path);
            using (StreamWriter stream = file.AppendText())
            {

                stream.WriteLine(jsonString);
                stream.Flush();
                stream.Close();
            }




        }
    }
}



