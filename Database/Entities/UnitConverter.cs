using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Przelicznikk.Database.Entities
{
    class UnitConverter
    {
        public int Id { get; set; }
        public float ConvertValue { get; set; }

        public int SourceUnitId { get; set; }
        public Unit SourceUnit { get; set; }

        public int TargetUnitId { get; set; }
        public Unit TargetUnit { get; set; }
    }
}
