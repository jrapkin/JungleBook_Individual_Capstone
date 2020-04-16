﻿using System;

namespace JungleBook.Models
{
	public class Trip
	{
		public int TripId { get; set; }
		public double EstimatedCost { get; set; }
		public DateTime StartDate { get; set; }
		public DateTime EndDate { get; set; }
	}
}
