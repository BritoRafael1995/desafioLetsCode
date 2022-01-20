using BACK.Business.Implementation;
using BACK.Business.Interface;
using BACK.Model.Models;
using BACK.Repository;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BACK.API.Controllers
{
    [Authorize("Bearer", AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    [Route("[controller]")]
    [ApiController]
    public class CardsController : ControllerBase
    {
        private readonly ICardsBusiness _cardsBusiness;

        public CardsController(Context context)
        {
            _cardsBusiness = new CardsBusiness(context);
        }

        // GET: Cards
        [HttpGet]
        public ActionResult Get()
        {
            try
            {
                return Ok(_cardsBusiness.GetCards());
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        // POST Cards
        [HttpPost]
        public ActionResult Post([FromBody] Card card)
        {
            try
            {
                var createdCard = _cardsBusiness.AddCard(card);

                return StatusCode(201, createdCard);
            }
            catch(Exception ex)
            {
                return StatusCode(400, ex.Message);
            }
            
        }

        // PUT Cards/5
        [HttpPut("{id}")]
        public ActionResult Put(Guid id, [FromBody] Card card)
        {
            try
            {
                var updatedCard = _cardsBusiness.UpdateCard(id, card);

                return Ok(updatedCard);
            }
            catch (Exception ex)
            {
                return StatusCode(400, ex.Message);
            }

        }

        // DELETE Cards/5
        [HttpDelete("{id}")]
        public ActionResult Delete(Guid id)
        {
            try
            {
                var cards = _cardsBusiness.DeleteCard(id);

                return Ok(cards);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }

        }
    }
}
