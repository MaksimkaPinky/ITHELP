namespace ITHelpWinFrm.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class IT_Employees
    {
        [Key]
        public int ID_IT_Employees { get; set; }

        [StringLength(50)]
        public string Фамилия { get; set; }

        [StringLength(50)]
        public string Имя { get; set; }

        [StringLength(50)]
        public string Отчество { get; set; }

        public int ID_Emp_Post { get; set; }
    }
}
