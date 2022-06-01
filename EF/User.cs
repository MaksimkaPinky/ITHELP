namespace ITHelpWinFrm.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("User")]
    public partial class User
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID_User { get; set; }

        [StringLength(50)]
        public string Фамилия { get; set; }

        [StringLength(50)]
        public string Имя { get; set; }

        [StringLength(50)]
        public string Отчество { get; set; }

        public int ID_Office { get; set; }

        public int ID_Role { get; set; }

        [StringLength(50)]
        public string Дата_Рождения { get; set; }

        [StringLength(50)]
        public string Почта { get; set; }

        public int ID_Gender { get; set; }

        [Key]
        [StringLength(50)]
        public string Логин { get; set; }

        [Required]
        [StringLength(50)]
        public string Пароль { get; set; }

        [StringLength(50)]
        public string Телефон { get; set; }

        public virtual Gender Gender { get; set; }

        public virtual Office Office { get; set; }

        public virtual Role Role { get; set; }
    }
}
