using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotet_System.Models
{
    public class Room
    {
        public int RoomId { get; set; }
        public string RoomName { get; set; }
        public string RoomType { get; set; }
        public string Status { get; set; }
        public double Quantity { get; set; }
        public double Price { get; set; }
        
        public byte[] Image { get; set; }

           

    }
}
