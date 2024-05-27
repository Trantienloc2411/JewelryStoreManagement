﻿namespace DataLayer.Entities

{
#pragma warning disable
    public class Warranty
    {
        public Guid WarrantyId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string OrderDetailId { get; set; }

        public virtual OrderDetail OrderDetail { get; set; }
        
    }
}

