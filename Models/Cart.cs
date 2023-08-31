﻿namespace Store.Models
{
    public class Cart
    {
        public int CartId { get; set; }

        //navigation:
        //each cart own 1 customer and has many orders
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }

        public List<Order> Order { get; set; }
    }
}
