using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ExpediteWeb.Models
{
    public class User
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string UserID { get; set; }

        [DataType(DataType.Date)]
        public DateTime InvitedOn { get; set; }
        public DateTime LastActive { get; set; }
        public string Role { get; set; }
        public string Status { get; set; }

    }
}
