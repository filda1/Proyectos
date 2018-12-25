namespace WinFormsSQLSERVER.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Data
    {
        public int DataID { get; set; }

        public int VirtualCounter { get; set; }
    }
}
