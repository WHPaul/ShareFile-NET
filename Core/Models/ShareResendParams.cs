// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
//     
//	   Copyright (c) 2015 Citrix ShareFile. All rights reserved.
// </auto-generated>
// ------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using ShareFile.Api.Client.Extensions;

namespace ShareFile.Api.Models 
{
	public class ShareResendParams : ODataObject 
	{

		public string ShareId { get; set; }

		public IEnumerable<string> Recipients { get; set; }

		public string Subject { get; set; }

		public string Body { get; set; }

		public bool CcSender { get; set; }

		public bool NotifyOnUse { get; set; }

		public override void Copy(ODataObject source, JsonSerializer serializer)
		{
			if(source == null || serializer == null) return;
			base.Copy(source, serializer);

			var typedSource = source as ShareResendParams;
			if(typedSource != null)
			{
				ShareId = typedSource.ShareId;
				Recipients = typedSource.Recipients;
				Subject = typedSource.Subject;
				Body = typedSource.Body;
				CcSender = typedSource.CcSender;
				NotifyOnUse = typedSource.NotifyOnUse;
			}
			else
			{
				JToken token;
				if(source.TryGetProperty("ShareId", out token) && token.Type != JTokenType.Null)
				{
					ShareId = (string)serializer.Deserialize(token.CreateReader(), typeof(string));
				}
				if(source.TryGetProperty("Recipients", out token) && token.Type != JTokenType.Null)
				{
					Recipients = (IEnumerable<string>)serializer.Deserialize(token.CreateReader(), typeof(IEnumerable<string>));
				}
				if(source.TryGetProperty("Subject", out token) && token.Type != JTokenType.Null)
				{
					Subject = (string)serializer.Deserialize(token.CreateReader(), typeof(string));
				}
				if(source.TryGetProperty("Body", out token) && token.Type != JTokenType.Null)
				{
					Body = (string)serializer.Deserialize(token.CreateReader(), typeof(string));
				}
				if(source.TryGetProperty("CcSender", out token) && token.Type != JTokenType.Null)
				{
					CcSender = (bool)serializer.Deserialize(token.CreateReader(), typeof(bool));
				}
				if(source.TryGetProperty("NotifyOnUse", out token) && token.Type != JTokenType.Null)
				{
					NotifyOnUse = (bool)serializer.Deserialize(token.CreateReader(), typeof(bool));
				}
			}
		}
	}
}