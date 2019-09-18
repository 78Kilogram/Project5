namespace Models.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Slides
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SlideID { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        [StringLength(250)]
        public string Description { get; set; }

        [Column(TypeName = "text")]
        public string Image { get; set; }

        [Column(TypeName = "text")]
        public string Url { get; set; }
    }
}
