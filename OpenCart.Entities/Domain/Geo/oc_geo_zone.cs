namespace JustWatch.OpenCart
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("oc_geo_zone")]
    public class oc_geo_zone
    {
        [Key]
        public int geo_zone_id { get; set; }

        [Required]
        [StringLength(32)]
        [Column("name")]
        public string Name { get; set; }

        [Required]
        [StringLength(255)]
        [Column("description")]
        public string Description { get; set; }

        [Column("date_modified")]
        public DateTime DateModified { get; set; }

        [Column("date_added")]
        public DateTime DateAdded { get; set; }
    }
}
