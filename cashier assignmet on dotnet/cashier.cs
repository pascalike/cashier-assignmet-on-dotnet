using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cashier_assignmet_on_dotnet
{
    internal class cashierLogins
    {
        public string cashier_username;
        public string cashier_password;
        public string username_input;
        public string password_input;
        bool keeprunning = true;

        public List <string> Product_list;
        public List<int> Product_price;

        public cashierLogins(string userName, string passWord)
        {
            this.Product_price = new List<int> { 20000, 28000, 13000, 68000 };
            this.Product_list = new List<string> { "butter", "sugar", "popcorn", "milk" };

            this.cashier_username = "cashier";
            this.cashier_password = "cashier001";
            this.username_input = userName;
            this.password_input   = passWord; 
        }
        public void login()
        {
            if(cashier_username == username_input && cashier_password == password_input)
            {
                Console.WriteLine("login succesfull");
                
                
                
                while (keeprunning)
                {
                    

                    Console.WriteLine("What do you want to add");
                string Userinput = Console.ReadLine();

                    Console.WriteLine($"What is the price of {Userinput}");
                    int ItemPrice =Convert.ToInt32( Console.ReadLine()); 

                    productadd(Userinput,ItemPrice);
                    }
            
            
            
            
            }
            else
            {
                Console.WriteLine("wrong username or password input");    
            }
        }
        
        
        public void productadd(string item,int ItemPrice )
        {
            Console.WriteLine($"youve added {item}");
            Product_list.Add(item);
            Product_price.Add(ItemPrice);
            Console.WriteLine();


            
        }
    }
}
