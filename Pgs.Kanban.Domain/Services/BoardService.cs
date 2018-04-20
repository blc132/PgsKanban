﻿using System.Linq;
using Microsoft.EntityFrameworkCore;
using Pgs.Kanban.Domain.Dtos;
using Pgs.Kanban.Domain.Models;

namespace Pgs.Kanban.Domain.Services
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
            var board = _context.Boards
                .Include(b => b.Lists)
                .ThenInclude(x => x.Cards)
                .LastOrDefault();

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
                    Cards = l.Cards.Select(c => new CardDto()
                    {
                        Id = c.Id,
                        ListId = c.ListId,
                        Name = c.Name,
                    }).ToList(),
                }).ToList()
            };

            return boardDto;
        }

        public BoardDto CreateBoard(CreateBoardDto createBoardDto)
        {
            var board = new Board()
            {
                Name = createBoardDto.Name
            };

            _context.Boards.Add(board);
            _context.SaveChanges();

            var boardDto = new BoardDto()
            {
                Id = board.Id,
                Name = board.Name
            };

            return boardDto;
        }
    }
}