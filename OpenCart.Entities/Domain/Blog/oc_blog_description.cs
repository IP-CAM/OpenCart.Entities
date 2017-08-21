namespace OpenCart.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("oc_blog_description")]
    public class oc_blog_description : Localizable
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int blog_id { get; set; }

        [Required]
        [StringLength(64)]
        public string title { get; set; }

        [Column("description", TypeName = "text")]
        [Required]
        [StringLength(65535)]
        public string Description { get; set; }

        [Required]
        [StringLength(255)]
        public string meta_title { get; set; }

        [Required]
        [StringLength(255)]
        public string meta_description { get; set; }

        [Required]
        [StringLength(255)]
        public string meta_keyword { get; set; }
    }
}