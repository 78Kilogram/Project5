namespace Models.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Comments
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CommentID { get; set; }

        public int? MovieID { get; set; }

        public DateTime? Date { get; set; }

        [StringLength(10)]
        public string Content { get; set; }

        public int? UserID { get; set; }
    }
}
