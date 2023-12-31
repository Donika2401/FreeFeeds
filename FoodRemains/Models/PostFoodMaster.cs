//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FoodRemains.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class PostFoodMaster
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PostFoodMaster()
        {
            this.OrderDetails = new HashSet<OrderDetail>();
        }
    
        public int PostedFoodID { get; set; }

        [Required(ErrorMessage = "Food Item is required")]
        public string FoodItem { get; set; }

        [Required(ErrorMessage = "Quantity is required")]
        public Nullable<int> Quantity { get; set; }

        [Required(ErrorMessage = "Serves Person is required")]
        public Nullable<int> ServesPerson { get; set; }

        [Required(ErrorMessage = "Description is required")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Select Restaurant")]
        public Nullable<int> RestaurantID { get; set; }
        public string RestaurantName { get; set; }
        public string Photo { get; set; }

        public Nullable<System.TimeSpan> OpeningHour { get; set; }
        public Nullable<System.TimeSpan> ClosingHour { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
        public virtual RestaurantMaster RestaurantMaster { get; set; }
    }
}
