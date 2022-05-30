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
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Repair()
        {
            Hardware = new HashSet<Hardware>();
        }

        [Key]
        public int ID_Repair { get; set; }

        [Required]
        [StringLength(150)]
        public string ПричинаРемонта { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Hardware> Hardware { get; set; }
    }
}
