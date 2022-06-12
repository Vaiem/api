using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReservateAPI.Models
{
    public class Resrvation
    {
        public int ReservationId { get; set; }
        public string AutoNumber { get; set; }
        public string ClientName { get; set; }
    }
}
