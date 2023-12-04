﻿namespace PackIT.Infrastructure.EF.Models
{
	internal class PackingItemReadModel
	{
		public Guid Id { get; set; }
		public string Name { get; set; }
		public uint Quantity { get; set; }
		public bool IsPacked { get; set; }

		public virtual PackingItemReadModel PackingList { get; set; }
	}
}
