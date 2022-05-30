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
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public EmpPost()
        {
            IT_Employees = new HashSet<IT_Employees>();
        }

        [Key]
        public int ID_Emp_Post { get; set; }

        [StringLength(50)]
        public string Наименование { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IT_Employees> IT_Employees { get; set; }
    }
}
