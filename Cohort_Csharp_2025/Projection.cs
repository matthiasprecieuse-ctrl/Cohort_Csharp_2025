using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cohort_Csharp_2025
{
    public static class projection
    {
        //query syntax
        public static void SelectValue()
        {
            var data = (from emp in Users.GetUser()
                        select emp.FirstName).ToList();

            //method syntax
            var data2 = Users.GetUser().ToList();
            var values = data2.OrderByDescending(x => x.FirstName);

            foreach (var value in values)
            {
                Console.WriteLine(value.FirstName + " " + value.LastName + " " + value.Salary);
            }


        }
    }
    

    public class Users
    {
        public int id { get; set; }
        public string FirstName { get; set; } 
        public string LastName { get; set; } 
        public int Salary { get; set; }

        public static List<Users> GetUser()
        {
            List<Users> user = new List<Users>
            {
                 new Users {id = 101, FirstName="Precious", LastName="Matthias", Salary = 2000000 },
                 new Users {id = 101, FirstName="Joyce", LastName="Eke", Salary = 5000000 },
                 new Users {id = 101, FirstName="Dayo",     LastName="Glory",    Salary = 39000000 },
                 new Users {id = 101, FirstName="Chidima",  LastName="Francis",  Salary = 1000000 },
                 new Users {id = 101,  FirstName="Miracle",  LastName="Jacob",    Salary = 85000000},
                 new Users {id = 101, FirstName="Cy",       LastName="Sandra",   Salary = 7000000 },
                 new Users {id = 101, FirstName="Nkem",     LastName="Micheal",  Salary = 55000000},
                 new Users {id = 101, FirstName="Pascal",   LastName="Chijioke", Salary = 12000000} ,
                 new Users {id = 101, FirstName="Temi",     LastName="Chika",    Salary = 3000000 } ,
                 new Users {id = 101, FirstName="Brolow",   LastName="Onome",    Salary = 6000000 } ,
                 new Users {id = 101, FirstName="Fad",      LastName="Esther",   Salary = 89000000} ,
                 new Users {id = 101, FirstName="Macy",     LastName="Favour",   Salary = 67000000 }
            }; 

            return user;

        }

    }
}
