using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotet_System.Models
{
    public class Reservation
    {
        public int ReservationId { get; set; }
        public int CustomerId { get; set; }
        public DateTime CheckInDate { get; set; }
        public string IsCheckIn { get; set; }
        public double NumberOfDay { get; set; }
        public double NumberOfAdult { get; set; }
        public double NumberOfChildrens { get; set; }
        public string Memo { get; set; }
        public DateTime CheckOutDate { get; set; }
        public string IsPay { get; set; }
        public string IsCheckOut { get; set; }
        public int AppUserId { get; set; }
       
    }
}
