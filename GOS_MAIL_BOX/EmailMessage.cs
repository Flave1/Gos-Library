﻿using System.Collections.Generic;
using System.IO;

namespace GOSLibraries.GOS_MAIL_BOX
{
	public class EmailMessage
	{
		public EmailMessage()
		{
			ToAddresses = new List<EmailAddress>();
			FromAddresses = new List<EmailAddress>();
			Attachments = new List<MemoryStream>();
		}

		public List<EmailAddress> ToAddresses { get; set; }
		public List<EmailAddress> FromAddresses { get; set; }
		public List<MemoryStream> Attachments { get; set; }
		public string Subject { get; set; }
		public string Content { get; set; }
		public bool SendIt {get; set;}
	}
}
