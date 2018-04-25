using System;
using System.Collections.Generic;
using System.Text;

namespace Pgs.Kanban.Domain.Dtos
{
    public class EditCardDescriptionDto
    {
        public int Id { get; set; }
        public string Description { get; set; }
    }
}
