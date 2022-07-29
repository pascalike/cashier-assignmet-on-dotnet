using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cashier_assignmet_on_dotnet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("login details");

            Console.WriteLine("enter username");
            string user_input = Console.ReadLine();
            Console.WriteLine("enter password");
            string password_input = Console.ReadLine();

            cashierLogins cashlogin = new cashierLogins (user_input, password_input);
            cashlogin.login();
            //cashlogin.productadd();
        }
    }
}
