using System;
using System.Collections.Generic;

#nullable disable

namespace OffersAPI.FiberConnection
{
    public partial class FiberPlan
    {
        public int PlanId { get; set; }
        public string PlanName { get; set; }
        public string PlanPrice { get; set; }
        public string PlanSpeed { get; set; }
        public string Validity { get; set; }
        public int? OfferId { get; set; }
        public string Image { get; set; }

        public virtual Offer Offer { get; set; }
    }
}
