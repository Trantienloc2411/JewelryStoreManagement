using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#pragma warning disable
namespace DataLayer.Entities
{
    public class Product
    {
        public Guid ProductId { get; set; }
        public string? Name { get; set; }
        public string? Barcode { get; set; }
        public int ManuafactureCost { get; set; }
        public double Weight { get; set; }
        public int Quantity { get; set; }
        public string? Description { get; set; }
        public int CounterId { get; set; }
        public int TypeId { get; set; }
        public string? Img { get; set; }
        public Statuses Status { get; set; }
        public int Price { get; set; }
        public double MarkupRate { get; set; }

        public enum Statuses
        {
            Active,
            Deactive
        }

        public virtual TypePrice TypePrice { get; set; }
        public virtual Counter Counter { get; set; }
        public ICollection<BuyBack> BuyBacks { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set;}
    }
}
