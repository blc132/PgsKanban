using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Pgs.Kanban.Domain.Dtos
{
    public class DeleteListDto
    {
        public string Name { get; set; }
        public int ListId { get; set; }
        public int BoardId { get; set; }
    }
}
