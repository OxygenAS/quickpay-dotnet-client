using System.Threading.Tasks;
using Quickpay.Models.Account;

namespace Quickpay.Services
{
    public class AccountService : QuickPayRestClient
    {
		public AccountService(string username, string password, string overrideBaseUri = "") : base(username, password, overrideBaseUri)
		{
		}

		public AccountService(string apikey, string overrideBaseUri = "") : base(apikey, overrideBaseUri)
		{
		}


		public Task<Merchant> GetMerchantAccount()
		{
			return CallEndpointAsync<Merchant>("account");
		}

		public Task<PrivateKey> GetPrivateKeyOfMerchant()
        {
			return CallEndpointAsync<PrivateKey>("account/private-key");
        }

	}
}
