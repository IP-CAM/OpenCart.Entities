namespace OpenCart.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("oc_filter_description")]
    public class oc_filter_description : Localizable
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int filter_id { get; set; }

        public int filter_group_id { get; set; }

        [Required]
        [StringLength(64)]
        [Column("name")]
        public string Name { get; set; }
    }
}
