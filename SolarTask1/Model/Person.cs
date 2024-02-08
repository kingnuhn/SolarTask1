using SolarTask1.Model.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolarTask1.Model
{
    internal class Person : IEntity
    {
        
        
            public int Id { get; set; }
            public string Name { get; set; }
            public DateTime Birthday { get; set; }

       
    }
}
