namespace sales.common.models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    
    public class Product
    {
        [Key] 
        public int productId { get; set; }

        [Required] 
        public string Description { get; set; }

        public decimal Price { get; set; }
        public bool IsAvailable { get; set; }
       public DateTime PublishOn { get; set; }
        public override string ToString()
        {
            return this.Description;
        }

    }

}
