using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VacationPlanner.Entity.Model
{
    public class VacationHistory
    {
        public long Id { get; set; }
        public long UserId { get; set; }
        public DateTime DateStart { get; set; }
        public DateTime DateEnd { get; set; }
        public long VacationStatusId { get; set; }
        public long VacationTypeId { get; set; }
    }
}
