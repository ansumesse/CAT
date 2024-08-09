using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks.Part_2
{
    public class Meeting
    {
        public string Title { get; set; }

        public DateOnly Date { get; set; } // yyyy-MM-dd

        public TimeOnly StartAt { get; set; } // hh:mm:ss PM/AM

        public TimeOnly EndAt { get; set; }

        public List<Employee> Participants { get; set; } = new();

    }
}
