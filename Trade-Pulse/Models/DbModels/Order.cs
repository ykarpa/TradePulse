﻿namespace Trade_Pulse.Models.DbModels
{
	public class Order
	{
		public int Id { get; set; }
		public DateTime CreatedAt { get; set; }
		public decimal OrderPrice { get; set; }
		public decimal DropPrice { get; set; }
		public string PaymentType { get; set; } = null!;
		public string DeliveryType { get; set; } = null!;
		public string Status { get; set; } = null!;
		public uint ProductsCount { get; set; }
		public User Receiver { get; set; } = null!;
	}
}
