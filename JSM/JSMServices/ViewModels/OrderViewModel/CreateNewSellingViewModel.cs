﻿using JSMServices.ViewModels.OrderDetailViewModel;

namespace JSMServices.ViewModels.OrderViewModel
{
    public class CreateNewSellingViewModel
    {
        public Guid CustomerId { get; set; }
        public double Discount { get; set; }
        public string? PromotionCode { get; set; }
        public Guid? CPId { get; set; }
        public int AccumulatedPoint { get; set; }
        public int CounterId { get; set; }
        public int PaymentId { get; set; }

        public ICollection<CreateOrderDetailViewModel> OrderDetail { get; set; }

    }
}
