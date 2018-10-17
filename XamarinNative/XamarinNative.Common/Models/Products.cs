

namespace XamarinNative.Common.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    class Products
    {
        [Key]
        public int ProductId { get; set; }

        [Required]
        public string Description { get; set; }

        public Decimal Price { get; set; }

        public bool IsAvailable { get; set; }

        public DateTime PublishOn { get; set; }
    }
}
