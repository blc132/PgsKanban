using System.Collections.Generic;

namespace PGS.Kanban.Domain.Dtos
{
    public class BoardDto
    {
        public BoardDto()
        {
            Lists = new List<ListDto>();
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public virtual List<ListDto> Lists { get; set; }
    }
}
