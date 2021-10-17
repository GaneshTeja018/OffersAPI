using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OffersAPI.FiberConnection;

namespace OffersAPI.Repository
{
    public class OfferRepo : IOfferRepo<Offer>
    {
        private readonly IOffer<Offer> o_obj;
        public OfferRepo(IOffer<Offer> _o_obj)
        {
            o_obj = _o_obj;
        }
        public async Task<int> AddOffer(Offer o)
        {
            return await o_obj.AddOffer(o);
        }

        public async Task<int> DeleteOffer(Offer o)
        {
            return await o_obj.DeleteOffer(o);
        }

        public async Task<int> EditOffer(Offer o)
        {
            return await o_obj.EditOffer(o);
        }

        public async Task<List<Offer>> GetAllOffers()
        {
            return await o_obj.GetAllOffers();
        }

        public async Task<Offer> GetOffer(int id)
        {
            return await o_obj.GetOffer(id);
        }
    }
}
