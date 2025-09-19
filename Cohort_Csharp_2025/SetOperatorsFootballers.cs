using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cohort_Csharp_2025
{
    
    public static class SetOperatorsFootballers
    {
       
        public static void SelectValue()
        {
            
            var data = (from f in Footballers.GetAll()
                        select new { f.FirstName, f.LastName })
                       .ToList();

            Console.WriteLine("Manchester United Players (First and Last Names):");
            foreach (var player in data)
            {
                Console.WriteLine($"{player.FirstName} {player.LastName}");
            }
        }
    }
}