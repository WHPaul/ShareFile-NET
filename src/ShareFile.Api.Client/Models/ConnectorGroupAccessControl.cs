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
	public class ConnectorGroupAccessControl : ODataObject 
	{

		public Principal Principal { get; set; }

		public bool? CanManage { get; set; }

		public bool? CanCreate { get; set; }

		public override void Copy(ODataObject source, JsonSerializer serializer)
		{
			if(source == null || serializer == null) return;
			base.Copy(source, serializer);

			var typedSource = source as ConnectorGroupAccessControl;
			if(typedSource != null)
			{
				Principal = typedSource.Principal;
				CanManage = typedSource.CanManage;
				CanCreate = typedSource.CanCreate;
			}
			else
			{
				JToken token;
				if(source.TryGetProperty("Principal", out token) && token.Type != JTokenType.Null)
				{
					Principal = (Principal)serializer.Deserialize(token.CreateReader(), typeof(Principal));
				}
				if(source.TryGetProperty("CanManage", out token) && token.Type != JTokenType.Null)
				{
					CanManage = (bool?)serializer.Deserialize(token.CreateReader(), typeof(bool?));
				}
				if(source.TryGetProperty("CanCreate", out token) && token.Type != JTokenType.Null)
				{
					CanCreate = (bool?)serializer.Deserialize(token.CreateReader(), typeof(bool?));
				}
			}
		}
	}
}