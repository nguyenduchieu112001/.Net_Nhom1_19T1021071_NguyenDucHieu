namespace KiemTra.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DanhBa")]
    public partial class DanhBa
    {
        public int ID { get; set; }

        [StringLength(50)]
        public string TenGoi { get; set; }

        [StringLength(50)]
        public string Email { get; set; }

        [StringLength(50)]
        public string SoDienThoai { get; set; }

        public int? IDNhom { get; set; }

        [StringLength(50)]
        public string DiaChi { get; set; }

        public virtual Nhom Nhom { get; set; }
    }
}
