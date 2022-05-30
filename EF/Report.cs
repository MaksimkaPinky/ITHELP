namespace ITHelpWinFrm.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Report")]
    public partial class Report
    {
        [Key]
        public int ID_Report { get; set; }

        public int? ID_Quest { get; set; }

        [StringLength(50)]
        public string Описание { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ДатаНаписания { get; set; }

        public int? ID_IT_Employees { get; set; }

        public virtual IT_Employees IT_Employees { get; set; }

        public virtual Quest Quest { get; set; }
    }
}
