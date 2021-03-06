namespace OpenCart.Entities
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("oc_attribute_group_description")]
    public class AttributeGroupDescription : Localizable, IEntityWithName
    {
        [Key, Column("attribute_group_id", Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int AttributeGroupId { get; set; }

        public virtual AttributeGroup AttributeGroup { get; set; }

        [Required, StringLength(64), Column("name")]
        public string Name { get; set; }
    }
}
