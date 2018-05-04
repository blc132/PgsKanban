using System;
using System.Collections.Generic;
using System.Text;
using Pgs.Kanban.Domain.Models;

namespace Pgs.Kanban.Domain.Dtos
{
    public class ListDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int BoardId { get; set; }
        public List<CardDto> Cards { get; set; }
    }
}
