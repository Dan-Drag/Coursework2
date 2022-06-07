using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using DAL.Users;

namespace BLL
{
    internal class OtherMethods
    {
        public User authorization()
        {
            string strcheck = null;
            string str = null;
            bool logn = false;
            string log;
            string pswd;
            User ControledUser = null;
            while (true)
            {
                Console.WriteLine("write login: ");
                log = Console.ReadLine();
                Console.WriteLine("write password: ");
                pswd = Console.ReadLine();
                string FileName = "Users.json";

                using (StreamReader reader = new StreamReader(FileName))
                {
                    Regex regex = new Regex("\\b" + log + "\\b", RegexOptions.IgnoreCase);
                    while ((strcheck = reader.ReadLine()) != null)
                    {
                        if (regex.IsMatch(strcheck))
                        {
                            str = strcheck;
                            logn = true;
                        }
                    }
                }

                if (logn == true && str.Contains(pswd))
                {
                    ControledUser = JsonSerializer.Deserialize<User>(str);
                    Console.Clear();
                    break;
                }
                else
                {
                    Console.WriteLine("wrong login or password");
                }
            }
            return ControledUser;
        }

        public void Search(string keyword)
        {
            string path = @$"C:\Users\fahsh\source\repos\Coursework1";
            string[] allFoundFiles = Directory.GetFiles(path, keyword, SearchOption.AllDirectories);

            foreach (string discovered in allFoundFiles)
            {
                Console.WriteLine(discovered);
            }
        }

        
    }
}
