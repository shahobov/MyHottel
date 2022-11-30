
using MyHottel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyHottel.Models
{
    public class Booking : EntityBase
    {
        public Client Client { get; set; }
        public Room Room { get; set; }
        public DateTime DateOfComing { get; set; }
        public DateTime DateOfOut { get; set; }

    }
}
