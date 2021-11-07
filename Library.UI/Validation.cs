using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Library.UI
{
    public static class Validation
    {
        public static bool IsUserName(this TextBox text)
        {
            if(text == null)
                return false;
            if (text.Text.Length < 2)
                return false;
            foreach (var item in text.Text)
            {
                if (char.IsSymbol(item))
                    return false;
            }
            if(text.Text.Contains("@"))
                return false;
            if (text.Text.Contains('*'))
                return false;


                return true;
        }
        public static bool IsPassword(this TextBox text)
        {
            if (text == null)
                return false;
            if(text.Text.Length < 2)
                return false;
            if(text.Text.Contains('*'))
                return false;
            if(text.Text.Contains('@'))
                return false;


            return true;
        }
        public static bool IsEmail(this TextBox text)
        {
            Regex regex = new Regex(@"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$");
            if(regex.IsMatch(text.Text))
                return true;
            return false;
            
        }

        public static bool IsPhoneNumber(this TextBox text)
        {   
            int[] phoneNum = new int[text.Text.Length];
            if (text.Text.Length < 10)
                return false;
            if(phoneNum[0] != 0)
                return false;
            foreach (var item in text.Text)
            {
                if (char.IsLetter(item))
                    return false;
                if (char.IsSymbol(item))
                    return false;
                if (item == '@')
                    return false;
                
            }

            return true;
        }
        public static bool IsID(this TextBox text)
        {
            if(text.Text.Length < 9)
                return false;
            foreach (var item in text.Text)
            {
                if (char.IsLetter(item))
                    return false;
                if (char.IsSymbol(item))
                    return false;
                if (item == '@')
                    return false;

            }
            return true;
        }
    }
}
