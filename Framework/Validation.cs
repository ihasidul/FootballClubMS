using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FootballClubMS.Entity;
using FootballClubMS.Repository;
using System.Text.RegularExpressions;
namespace FootballClubMS.Framework
{
    public static class Validation
    {
        public static bool IsStringValid(string value)
        {
            if (string.IsNullOrWhiteSpace(value) || string.IsNullOrEmpty(value))
                return false;

            return true;
        }

        public static bool IsUserInDB(LoginEntity l)//serach for the loginEntity object in login table
        {
            if (LoginRepository.SearchUser(l) == true)
            {
                return true;
            }
            else
                return false;
        }
        
        public static bool IsStringMail(string text)
        {
            //stringOrNumber@stringOrNumber.nameOrNumber 
            Regex rx = new Regex("^[a-zA-Z0-9]{1,40}@[a-zA-Z0-9]{1,40}.[a-zA-Z]{2,4}$");
            if (rx.IsMatch(text))
            {
                return true;
            }
            else
            {
                return false;
            }
                
        }

        public static bool IsStringNumber(string text)
        {
            Regex rx = new Regex("^[0-9]{1,7}.[0-9]{1,5}$");
            Regex rxor = new Regex("^[0-9]{1,7}$");
            if (rx.IsMatch(text) == true ||rxor.IsMatch(text) == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool IsStringAName(string text)
        {

            Regex rx = new Regex("^[a-zA-Z]{1,20}$");
            if (rx.IsMatch(text))
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
