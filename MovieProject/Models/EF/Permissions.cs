namespace Models.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Permissions
    {
        [Key]
        public int PermissonsID { get; set; }

        [StringLength(10)]
        public string Name { get; set; }
    }
}
