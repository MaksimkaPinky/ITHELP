namespace ITHelpWinFrm.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Repair")]
    public partial class Repair
    {
        [Key]
        public int ID_Repair { get; set; }

        [Required]
        [StringLength(150)]
        public string ПричинаРемонта { get; set; }
    }
}
