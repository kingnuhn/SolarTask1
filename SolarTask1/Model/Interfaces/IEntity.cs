using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SolarTask1.Model.Interfaces;

namespace SolarTask1.Model.Interfaces
{
    internal interface IEntity
    {
       
        
            public int Id { get; set; }

            public string Name { get; set; }

        
    }
}
