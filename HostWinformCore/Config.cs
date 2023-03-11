using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace HostWinformCore
{
    [Table("Config")]
    public class Config
    {
        [Key]
        [Column("Id")]
        public int Id { get; set; }
        [Required]
        [Column("Name")]
        [MaxLength(20)]
        public int Name { get; set; }
        [Required]
        [Column("Value")]
        [MaxLength(20)]
        public int Value { get; set; }
        [Column("Note")]
        [MaxLength(200)]
        public int Note { get; set; }
    }
}
