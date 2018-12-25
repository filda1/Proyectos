namespace WinFormsSQLSERVER.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Users
    {
        [Key]
        public int UserId { get; set; }

        public int TypeofUserId { get; set; }

        [Required]
        [StringLength(50)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(50)]
        public string LastName { get; set; }

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

        public string ImagePath { get; set; }

        public bool Active { get; set; }

        public int? Reservation_ReservationId { get; set; }
    }
}
