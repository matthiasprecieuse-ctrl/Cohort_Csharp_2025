using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cohort_Csharp_2025
{   // Linq = language integrated query
    //Query syntax or query expression syntax
    //Method syntax/method expression syntax or fluent syntax

    public class LinqClass
    {
    }

    public class Filtering
    {
        //where
        //oftype
        List<int> intlist = new List<int> { 2, 4, 6, 7, 8, 9, 10, 11, 12, 13, 14 };
        public void WhereValue()
        {
            //method syntax
            var filterdata = intlist.Where(x => x > 5);
            foreach (var filter in filterdata)
                Console.WriteLine(filter);
            
        }

    }
}

