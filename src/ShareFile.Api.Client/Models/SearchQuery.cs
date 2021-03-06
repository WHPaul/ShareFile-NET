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
	public class SearchQuery : ODataObject 
	{

		/// <summary>
		/// Information about the query to run
		/// </summary>
		public Query Query { get; set; }

		/// <summary>
		/// Paging info about the search results
		/// </summary>
		public QueryPaging Paging { get; set; }

		/// <summary>
		/// How the search results should be sorted
		/// </summary>
		public QuerySorting Sort { get; set; }

		/// <summary>
		/// Timeout for the search request in seconds
		/// </summary>
		public int TimeoutInSeconds { get; set; }

		public override void Copy(ODataObject source, JsonSerializer serializer)
		{
			if(source == null || serializer == null) return;
			base.Copy(source, serializer);

			var typedSource = source as SearchQuery;
			if(typedSource != null)
			{
				Query = typedSource.Query;
				Paging = typedSource.Paging;
				Sort = typedSource.Sort;
				TimeoutInSeconds = typedSource.TimeoutInSeconds;
			}
			else
			{
				JToken token;
				if(source.TryGetProperty("Query", out token) && token.Type != JTokenType.Null)
				{
					Query = (Query)serializer.Deserialize(token.CreateReader(), typeof(Query));
				}
				if(source.TryGetProperty("Paging", out token) && token.Type != JTokenType.Null)
				{
					Paging = (QueryPaging)serializer.Deserialize(token.CreateReader(), typeof(QueryPaging));
				}
				if(source.TryGetProperty("Sort", out token) && token.Type != JTokenType.Null)
				{
					Sort = (QuerySorting)serializer.Deserialize(token.CreateReader(), typeof(QuerySorting));
				}
				if(source.TryGetProperty("TimeoutInSeconds", out token) && token.Type != JTokenType.Null)
				{
					TimeoutInSeconds = (int)serializer.Deserialize(token.CreateReader(), typeof(int));
				}
			}
		}
	}
}