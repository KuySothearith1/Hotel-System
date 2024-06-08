using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotet_System.Models
{
    public class ReservationDetail
    {
        public int ReservationDetailId { get; set; }
        public int ReservationId { get; set; }
        public int RoomId { get; set; }
        public string RoomType { get; set; }
        public string Status { get; set; }
        public double Quantity { get; set; }
        public double Price { get; set; }
        public double Amount { get; set; }
    }
        
}
