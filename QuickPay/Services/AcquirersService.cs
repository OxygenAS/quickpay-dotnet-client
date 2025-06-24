using Quickpay.Models.Account.Settings;
using System.Threading.Tasks;

namespace Quickpay.Services
{
    public class AcquirersService : QuickPayRestClient
    {
		public AcquirersService(string username, string password, string overrideBaseUri = "") : base(username, password, overrideBaseUri)
		{
		}

		public AcquirersService(string apikey, string overrideBaseUri = "") : base(apikey, overrideBaseUri)
		{
		}

		public Task<AcquirerSettings> FetchAcquirers()
        {
			return CallEndpointAsync<AcquirerSettings>("acquirers");
		}


	}
}
