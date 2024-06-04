#pragma warning disable
namespace DataLayer.Entities
{
    public class OrderDetail
    {
        public string OrderDetailId { get; set; }
        public string OrderId { get; set; }
        public Guid ProductId { get; set; }
        public int Quantity { get; set; }
        public double UnitPrice { get; set; }
        public double ManufactureCost { get; set; }

        public virtual Order Order { get; set; }    
        public virtual Product Product { get; set; }
        public virtual Warranty Warranty { get; set; }



        

    }
}
