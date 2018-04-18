using System;
using Microsoft.AspNetCore.Mvc;
using Pgs.Kanban.Domain.Dtos;
using Pgs.Kanban.Domain.Services;

namespace Pgs.Kanban.Api.Controllers
{
    [Route("api/[controller]")]
    public class CardController : Controller
    {
        private readonly CardService _cardService;

        public CardController()
        {
            _cardService = new CardService();
        }

        [HttpPost]
        public IActionResult AddCard([FromBody] AddCardDto addCardDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            var result = _cardService.AddCard(addCardDto);

            if (result == null)
            {
                Console.WriteLine("XD");
                return BadRequest();
            }

            return Ok(result);
        }
    }
}
