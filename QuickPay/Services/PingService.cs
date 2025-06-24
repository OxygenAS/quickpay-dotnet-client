using Quickpay.Models.Ping;
using RestSharp;
using System;

namespace Quickpay.Services
{
    public class PingService : QuickPayRestClient
    {
		public PingService(string username, string password, string overrideBaseUri = "") : base(username, password, overrideBaseUri)
		{
		}

		public PingService(string apikey, string overrideBaseUri = "") : base(apikey, overrideBaseUri)
		{
		}

		public Pong ping()
        {
			Action<RestRequest> prepareRequest = (RestRequest request) => {
				request.Method = Method.Get;
			};

			return CallEndpointAsync<Pong>("ping", prepareRequest).GetAwaiter().GetResult();
		}
    }
}
