﻿using System;
using Newtonsoft.Json;
using toms_tests.Helpers;

namespace toms_tests.Models
{
	public class Item : ObservableObject
	{
		string id = string.Empty;

		[JsonIgnore]
		public string Id
		{
			get { return id; }
			set { SetProperty(ref id, value); }
		}

		string text = string.Empty;
		public string Text
		{
			get { return text; }
			set { SetProperty(ref text, value); }
		}

		string description = string.Empty;
		public string Description
		{
			get { return description; }
			set { SetProperty(ref description, value); }
		}
	}
}
