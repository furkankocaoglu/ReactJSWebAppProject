namespace ReactJSApiProject.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Members
    {
        public int ID { get; set; }

        [Required]
        [StringLength(75)]
        public string Name { get; set; }

        [Required]
        [StringLength(75)]
        public string Surname { get; set; }

        [Required]
        [StringLength(200)]
        public string Mail { get; set; }

        [Required]
        [StringLength(30)]
        public string Password { get; set; }

        public DateTime CreationTime { get; set; }

        public bool IsActive { get; set; }

        public bool IsDeleted { get; set; }
    }
}
