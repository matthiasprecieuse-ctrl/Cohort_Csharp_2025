using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Footballers
{
    public int Number { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Role { get; set; }

    public static List<Footballers> GetAll()
    {
        return new List<Footballers>
            {
                new Footballers { Number = 24, FirstName = "André",   LastName = "Onana",   Role = "Goalkeeper" },
                new Footballers { Number = 20, FirstName = "Diogo",   LastName = "Dalot",   Role = "Defender" },
                new Footballers { Number = 19, FirstName = "Raphaël", LastName = "Varane",  Role = "Defender" },
                new Footballers { Number = 6,  FirstName = "Lisandro",LastName = "Martínez",Role = "Defender" },
                new Footballers { Number = 18, FirstName = "Casemiro",LastName = "Silva",   Role = "Midfielder" },
                new Footballers { Number = 8,  FirstName = "Bruno",   LastName = "Fernandes",Role = "Midfielder" },
                new Footballers { Number = 21, FirstName = "Antony",  LastName = "Matheus", Role = "Forward" },
                new Footballers { Number = 10, FirstName = "Marcus",  LastName = "Rashford",Role = "Forward" },
                new Footballers { Number = 11, FirstName = "Rasmus",  LastName = "Højlund", Role = "Forward" },
                new Footballers { Number = 7,  FirstName = "Mason",   LastName = "Mount",   Role = "Midfielder" }
            };
    }
}
