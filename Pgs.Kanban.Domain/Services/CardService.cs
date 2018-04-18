﻿using System.Linq;
using Microsoft.EntityFrameworkCore;
using Pgs.Kanban.Domain.Dtos;
using Pgs.Kanban.Domain.Models;

namespace Pgs.Kanban.Domain.Services
{
    public class CardService
    {
        private readonly KanbanContext _context;

        public CardService()
        {
            _context = new KanbanContext();
        }

        public CardDto AddCard(AddCardDto addCardDto)
        {
            if (!_context.Lists.Any(x => x.Id == addCardDto.ListId))
            {
                return null;
            }

            var card = new Card
            {
                Name = addCardDto.Name,
                ListId = addCardDto.ListId
            };

            _context.Cards.Add(card);
            _context.SaveChanges();

            var cardDto = new CardDto
            {
                Id = card.Id,
                ListId = card.ListId,
                Name = card.Name
            };

            return cardDto;
        }
    }
}