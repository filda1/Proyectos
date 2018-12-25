namespace WinFormsSQLSERVER.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Contacts
    {
        public int ContactsId { get; set; }

        [Required]
        [StringLength(50)]
        public string Company { get; set; }

        [StringLength(150)]
        public string Description { get; set; }

        [Required]
        [StringLength(100)]
        public string Email { get; set; }

        [StringLength(20)]
        public string Telephone { get; set; }

        [Required]
        [StringLength(300)]
        public string Address { get; set; }

        [Required]
        [StringLength(50)]
        public string Location { get; set; }

        public int Code { get; set; }

        public int Door { get; set; }

        public bool Active { get; set; }

        public string Horary { get; set; }

        public string Image { get; set; }
    }
}
