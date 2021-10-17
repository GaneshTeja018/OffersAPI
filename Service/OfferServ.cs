using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OffersAPI.FiberConnection;
using OffersAPI.Repository;

namespace OffersAPI.Service
{
    public class OfferServ : IOfferServ<Offer>
    {
        private readonly IOfferRepo<Offer> o_repo;
        public OfferServ(IOfferRepo<Offer> _o_repo)
        {
            o_repo = _o_repo;
        }
        public async Task<int> AddOffer(Offer o)
        {
            return await o_repo.AddOffer(o);
        }

        public async Task<int> DeleteOffer(Offer o)
        {
            return await o_repo.DeleteOffer(o);
        }

        public async Task<int> EditOffer(Offer o)
        {
            return await o_repo.EditOffer(o);
        }

        public async Task<List<Offer>> GetAllOffers()
        {
            return await o_repo.GetAllOffers();
        }

        public async Task<Offer> GetOffer(int id)
        {
            return await o_repo.GetOffer(id);
        }
    }
}
