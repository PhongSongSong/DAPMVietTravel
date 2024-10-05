//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace VietTravel.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Booking
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Booking()
        {
            this.Payments = new HashSet<Payment>();
        }
    
        public string MaBooking { get; set; }
        public string MaUser { get; set; }
        public string LoaiDichVu { get; set; }
        public System.DateTime NgayDat { get; set; }
        public decimal TongTien { get; set; }
    
        public virtual User User { get; set; }
        public virtual FlightDetail FlightDetail { get; set; }
        public virtual HotelDetail HotelDetail { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Payment> Payments { get; set; }
        public virtual TourDetail TourDetail { get; set; }
    }
}