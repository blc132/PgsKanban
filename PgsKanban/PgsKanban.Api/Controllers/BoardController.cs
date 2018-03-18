using Microsoft.AspNetCore.Mvc;
using PGS.Kanban.Domain.Services;

namespace Pgs.Kanban.Api.Controllers
{
    [Route("api/[controller]")]
    public class BoardController : Controller
    {
        private readonly BoardService _boardService;

        public BoardController()
        {
            _boardService = new BoardService();
        }

        [HttpGet]
        public IActionResult GetBoard()
        {
            var response = _boardService.GetBoard();

            if (response == null)
            {
                return NotFound();
            }

            return Ok();
        }
    }
}
