namespace Models.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class News
    {
        public int NewsID { get; set; }

        [Column(TypeName = "text")]
        public string Name { get; set; }

        [Column(TypeName = "text")]
        public string Image { get; set; }

        [Column(TypeName = "text")]
        public string Description { get; set; }

        public int? Year { get; set; }

        [Column(TypeName = "text")]
        public string Country { get; set; }

        [Column(TypeName = "text")]
        public string MovieLink { get; set; }

        [Column(TypeName = "text")]
        public string TrailerLink { get; set; }

        public int? CategoryID { get; set; }

        public int? Rate { get; set; }

        public int? TrailerID { get; set; }

        public int Viewed { get; set; }

        public DateTime? CreatedDate { get; set; }

        [StringLength(50)]
        public string CreatedBy { get; set; }

        public DateTime? ModifiedDate { get; set; }

        [StringLength(50)]
        public string ModifiedBy { get; set; }

        [StringLength(250)]
        public string MetaKeywords { get; set; }

        [StringLength(250)]
        public string MetaDescriptions { get; set; }

        public bool? Status { get; set; }

        public DateTime? TopHot { get; set; }

        [StringLength(500)]
        public string Tags { get; set; }
    }
}
