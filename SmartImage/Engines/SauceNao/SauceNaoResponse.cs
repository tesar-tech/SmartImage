#region

using System;
using System.Runtime.Serialization;

#endregion

namespace SmartImage.Engines.SauceNao
{
	[DataContract]
	public class SauceNaoResponse
	{
		//ignore
		//[DeserializeAs(Name = "header")]
		//public object Header { get; set; }

		[DataMember(Name = "results")]
		public SauceNaoResult[] Results { get; set; }

		public override string ToString()
		{
			return String.Format("Results: {0}", Results.Length);
		}
	}
}