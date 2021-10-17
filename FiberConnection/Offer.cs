using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using OffersAPI.FiberConnection;

#nullable disable

namespace OffersAPI.FiberConnection
{
    public partial class Offer : IOffer<Offer>
    {
        private readonly fiber_connectionContext fcc = new fiber_connectionContext();
        public Offer()
        {
            FiberPlans = new HashSet<FiberPlan>();
        }

        public int OfferId { get; set; }
        public string Voot { get; set; }
        public string Lionplay { get; set; }
        public string Hungamaplay { get; set; }
        public string Ultra { get; set; }
        public string Hotstar { get; set; }
        public string Netflix { get; set; }
        public string Others { get; set; }

        public virtual ICollection<FiberPlan> FiberPlans { get; set; }
        public async Task<int> AddOffer(Offer o)
        {
            fcc.Offers.Add(o);
            return await fcc.SaveChangesAsync();
        }

        public async Task<int> DeleteOffer(Offer o)
        {
            fcc.Offers.Remove(o);
            return await fcc.SaveChangesAsync();
        }

        public async Task<int> EditOffer(Offer o)
        {
            using(var fc=new fiber_connectionContext())
            {
                fc.Entry(o).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                return (await fc.SaveChangesAsync());
            }
        }

        public async Task<List<Offer>> GetAllOffers()
        {
            return await fcc.Offers.ToListAsync();
        }

        public async Task<Offer> GetOffer(int id)
        {
            return await fcc.Offers.FindAsync(id);
        }

    }
}
