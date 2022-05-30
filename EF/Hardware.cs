namespace ITHelpWinFrm.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Hardware")]
    public partial class Hardware
    {
        [Key]
        public int ID_Hardware { get; set; }

        [Required]
        [StringLength(150)]
        public string Наименование { get; set; }

        [Column(TypeName = "date")]
        public DateTime ДатаУстановки { get; set; }

        public int ID_IT_Employees { get; set; }

        public int ID_Repair { get; set; }

        [Required]
        [StringLength(50)]
        public string ДатаПоследнегоРемонта { get; set; }

        public virtual IT_Employees IT_Employees { get; set; }

        public virtual Repair Repair { get; set; }
    }
}
