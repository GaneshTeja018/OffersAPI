using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OffersAPI.FiberConnection
{
    public interface IOffer<Offer>
    {
        public Task<int> AddOffer(Offer o);
        public Task<Offer> GetOffer(int id);
        public Task<int> EditOffer(Offer o);
        public Task<int> DeleteOffer(Offer o);
        public Task<List<Offer>> GetAllOffers();

    }
}
