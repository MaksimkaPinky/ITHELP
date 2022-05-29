namespace ITHelpWinFrm.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("EmpPost")]
    public partial class EmpPost
    {
        [Key]
        public int ID_Emp_Post { get; set; }

        [StringLength(50)]
        public string Наименование { get; set; }
    }
}
