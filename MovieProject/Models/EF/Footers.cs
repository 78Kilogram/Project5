namespace Models.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Footers
    {
        [StringLength(250)]
        public string ID { get; set; }

        [Column(TypeName = "text")]
        public string Content { get; set; }

        public bool? Status { get; set; }
    }
}
