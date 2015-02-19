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
	public class DeviceUserWipe : ODataObject 
	{

		/// <summary>
		/// Wipe token
		/// </summary>
		public string WipeToken { get; set; }

		/// <summary>
		/// Success
		/// </summary>
		public string Success { get; set; }

		/// <summary>
		/// Error message
		/// </summary>
		public string ErrorMessage { get; set; }

		public override void Copy(ODataObject source, JsonSerializer serializer)
		{
			if(source == null || serializer == null) return;
			base.Copy(source, serializer);

			var typedSource = source as DeviceUserWipe;
			if(typedSource != null)
			{
				WipeToken = typedSource.WipeToken;
				Success = typedSource.Success;
				ErrorMessage = typedSource.ErrorMessage;
			}
			else
			{
				JToken token;
				if(source.TryGetProperty("WipeToken", out token) && token.Type != JTokenType.Null)
				{
					WipeToken = (string)serializer.Deserialize(token.CreateReader(), typeof(string));
				}
				if(source.TryGetProperty("Success", out token) && token.Type != JTokenType.Null)
				{
					Success = (string)serializer.Deserialize(token.CreateReader(), typeof(string));
				}
				if(source.TryGetProperty("ErrorMessage", out token) && token.Type != JTokenType.Null)
				{
					ErrorMessage = (string)serializer.Deserialize(token.CreateReader(), typeof(string));
				}
			}
		}
	}
}