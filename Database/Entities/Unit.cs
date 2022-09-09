using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Przelicznikk.Database.Entities
{
    class Unit
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Symbol { get; set; }

        public int UnitTypeId { get; set; }
        public UnitType unitType { get; set; }


    }
}
