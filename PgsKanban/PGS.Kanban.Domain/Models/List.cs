using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace PGS.Kanban.Domain.Models
{
    public class List
    {
        [Key]
        public int Id { get; set; }

        public int BoardId { get; set; }

        public Board Board { get; set; }

        [Required]
        public string Name { get; set; }
    }
}
