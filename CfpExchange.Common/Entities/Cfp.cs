﻿using System;

using Microsoft.Azure.Cosmos.Table;

namespace CfpExchange.Common.Entities
{
	public class Cfp : TableEntity
	{
		public Guid Id { get; set; }
		public string EventName { get; set; }
		public string EventDescription { get; set; }
		public string EventLocationName { get; set; }
		public double EventLocationLat { get; set; }
		public double EventLocationLng { get; set; }
		public string EventUrl { get; set; } = string.Empty;
		public string EventTags { get; set; } = String.Empty;
		public string EventImage { get; set; }
		public DateTime EventStartDate { get; set; }
		public DateTime EventEndDate { get; set; }
		public string EventTimezone { get; set; }
		public DateTime CfpStartDate { get; set; }
		public DateTime CfpEndDate { get; set; }
		public DateTime CfpDecisionDate { get; set; }
		public DateTime CfpAdded { get; set; }
		public bool? ProvidesAccommodation { get; set; }
		public bool? ProvidesTravelAssistance { get; set; }
		public string CfpUrl { get; set; } = string.Empty;
		public string Remarks { get; set; }
		public int Views { get; set; }
		public int ClicksToCfpUrl { get; set; }
		public string SubmittedByName { get; set; }
		public string EventTwitterHandle { get; set; }
		public string Slug { get; set; }
		public bool IsVirtual { get; set; }
	}
}