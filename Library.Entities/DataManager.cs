using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace Library.Entities
{
    public static class DataManager
    {
        public static bool IsUserExsist(string username,string password)
        {
            int count = 0;
            string path = @"C:\Users\user\Desktop\softwaredev\Projects Folder\HackerUs DigitalLibary\Users.txt";
            foreach (var line in File.ReadAllLines(path))
            {
                if (line.Contains(username))
                {
                    count++;
                }
                if (line.Contains(password))
                {
                    count++;
                }

            }
        
            if (count > 2)
                return true;
            return false;
        }
    }
}
