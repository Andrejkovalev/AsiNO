using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AsiNO_DAL.Entities
{
    public class ClientProfile
    {
        [Key]
        [ForeignKey("ApplicationUser")]
        public string Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }

        public int IdAccount { get; set; }

        public int RateId { get; set; }
        public Rate Rate { get; set; }

        public DateTime Date { get; set; }

        public virtual ApplicationUser ApplicationUser { get; set; }

    }
}
