using System.Linq;
using Microsoft.EntityFrameworkCore;
using PGS.Kanban.Domain.Dtos;

namespace PGS.Kanban.Domain.Services
{
    public class BoardService
    {
        private readonly KanbanContext _context;

        public BoardService()
        {
            _context = new KanbanContext();

        }

        public BoardDto GetBoard()
        {
            var board = _context.Boards.Include(b => b.Lists).FirstOrDefault();

            if (board == null)
            {
                return null;
            }

            var boardDto = new BoardDto()
            {
                Id = board.Id,
                Name = board.Name,
                Lists = board.Lists.Select(l => new ListDto()
                {
                    Id = l.Id,
                    BoardId = l.BoardId,
                    Name = l.Name,
                }).ToList()
            };

            return boardDto;
        }
    }
}
