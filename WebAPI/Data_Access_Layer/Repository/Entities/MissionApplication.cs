﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Data_Access_Layer.Repository.Entities
{
    public class MissionApplication : BaseEntity
    {
        [Key]
        public int Id { get; set; }
        public int MissionId { get; set; }
        [NotMapped]
        public string MissionTitle { get; set;}
        public int UserId { get; set; }
        [NotMapped]
        public string UserName { get; set; } 
        [NotMapped]
        public string UserImage { get; set; }

        [Column(TypeName = "timestamp without time zone")]
        public DateTime AppliedDate { get; set; }
        public bool Status { get; set; }
        public int Sheet { get; set; }

    }
}
