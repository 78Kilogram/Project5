namespace Models.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NewsTag")]
    public partial class NewsTag
    {
        public int NewsID { get; set; }

        [Key]
        [StringLength(50)]
        public string TagID { get; set; }
    }
}
