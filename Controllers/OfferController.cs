using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OffersAPI.FiberConnection;
using OffersAPI.Service;

namespace OffersAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OfferController : ControllerBase
    {
        static readonly log4net.ILog _log4net = log4net.LogManager.GetLogger(typeof(OfferController));
        private readonly IOfferServ<Offer> o_serv;
        public OfferController(IOfferServ<Offer> _o_serv)
        {
            o_serv = _o_serv;
        }
        [HttpPost]
        public async Task<IActionResult> AddOffer(Offer o)
        {
            _log4net.Info($"{o.OfferId} is added to the list");
            return Ok(await o_serv.AddOffer(o));
        }
        [HttpDelete]
        public async Task<IActionResult> DeleteOffer(int id,Offer o)
        {
            _log4net.Info($"offer:{id} is deleted");
            return Ok(await o_serv.DeleteOffer(o));
        }
        [HttpPut]
        public async Task<IActionResult> EditOffer(int id,Offer o)
        {
            _log4net.Info($"Editing the Offer from {id}");
            return Ok(await o_serv.EditOffer(o));
        }
        [HttpGet]
        public async Task<IActionResult> GetAllOffers()
        {
            _log4net.Info($"Getting All the Offers");
            return Ok(await o_serv.GetAllOffers());
        }
        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> GetOffer(int id)
        {
            _log4net.Info($"Getting the Offer from {id}");
            return Ok(await o_serv.GetOffer(id));
        }
    }
}
