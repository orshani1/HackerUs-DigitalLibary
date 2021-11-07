using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Library.Entities
{

    public  class UsersManagament
    {
        public static List<Client> ClientsList { get; set; } = new List<Client>();
        public static int id = 0;
        public static string ToCSV(Client client)
        {
            string str;
            str = string.Format(" User name = {0},Password = {1},Email = {2},Phone Number = {3},\n\n", client.UserName, client.Password,
                client.Email,client.PhoneNumber);
            return str;
        }
        public static void SaveUsers()
        {
            ClientsList.Add(new Client{ FirstName = "Or", LastName = "Shani", Id = 209546191
                , IdentityNumber = UsersManagament.id.ToString(), Email = "ortheog@gmail.com",
                PhoneNumber = "0506951678", UserName = "orshani1", Password = "orshani1" });
            var s = "";
            foreach (var client in UsersManagament.ClientsList)
            {
                s += UsersManagament.ToCSV(client) + Environment.NewLine;

            }
            s += Environment.NewLine;
            s += id++;
            File.WriteAllText(@"C:\Users\user\Desktop\softwaredev\Projects Folder\HackerUs DigitalLibary\LibraryInfo.txt", s);
        }
        public static bool IsUser(string username,string password)
        {
            foreach (var item in ClientsList)
            {
                int flag = 0;
                if (item.UserName == username)
                {
                    flag++;
                }
                if (item.Password == password)
                    flag++;
                if(flag == 2)
                    return true;
                if (flag < 2)
                    return false;
            }

            return true;
        }
        public override string ToString()
        {
            return String.Format("{0}",id); 
        }
        public void SaveUserJSON()
        {
            string path = @"C:\Users\user\Desktop\softwaredev\Projects Folder\HackerUs DigitalLibary\UsersJSON.json";


  
        }
    }
}
