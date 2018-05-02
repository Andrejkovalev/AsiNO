using System;
using System.Collections.Generic;
using System.Text;

namespace AsiNO_DAL.Entities
{
    public class Rate
    {
        public int Id { get; set; }
        public double RateValue { get; set; }
        public int Percent { get; set; }
        public ICollection<ClientProfile> ClientProfiles { get; set; }
    }
}
