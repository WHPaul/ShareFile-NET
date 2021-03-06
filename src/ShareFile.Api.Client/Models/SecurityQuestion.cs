// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
//     
//	   Copyright (c) 2016 Citrix ShareFile. All rights reserved.
// </auto-generated>
// ------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Net;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using ShareFile.Api.Client.Extensions;
using ShareFile.Api.Client.Exceptions;

namespace ShareFile.Api.Models 
{
	public class SecurityQuestion : ODataObject 
	{

		public string Question { get; set; }

		public string Answer { get; set; }

		public bool? IsResetRequired { get; set; }

		public override void Copy(ODataObject source, JsonSerializer serializer)
		{
			if(source == null || serializer == null) return;
			base.Copy(source, serializer);

			var typedSource = source as SecurityQuestion;
			if(typedSource != null)
			{
				Question = typedSource.Question;
				Answer = typedSource.Answer;
				IsResetRequired = typedSource.IsResetRequired;
			}
			else
			{
				JToken token;
				if(source.TryGetProperty("Question", out token) && token.Type != JTokenType.Null)
				{
					Question = (string)serializer.Deserialize(token.CreateReader(), typeof(string));
				}
				if(source.TryGetProperty("Answer", out token) && token.Type != JTokenType.Null)
				{
					Answer = (string)serializer.Deserialize(token.CreateReader(), typeof(string));
				}
				if(source.TryGetProperty("IsResetRequired", out token) && token.Type != JTokenType.Null)
				{
					IsResetRequired = (bool?)serializer.Deserialize(token.CreateReader(), typeof(bool?));
				}
			}
		}
	}
}