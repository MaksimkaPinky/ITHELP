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
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Hardware()
        {
            Quest = new HashSet<Quest>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID_Hardware { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ДатаУстановки { get; set; }

        public int? ID_IT_Employees { get; set; }

        [StringLength(10)]
        public string КоличествоРемонтов { get; set; }

        [StringLength(10)]
        public string ПричинаРемонта { get; set; }

        [StringLength(10)]
        public string ДатаПоследнегоРемонта { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ДатаОбследования { get; set; }

        public virtual IT_Employees IT_Employees { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Quest> Quest { get; set; }
    }
}
