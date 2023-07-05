﻿using System;
using Domain.Common;

namespace Domain.Models
{
	public class About: BaseEntity
	{
		public string Image { get; set; }
		public string Title { get; set; }
		public string Description { get; set; }
	}
}