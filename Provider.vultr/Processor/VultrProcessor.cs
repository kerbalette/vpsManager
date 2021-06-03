using System;
using System.Net.Http;
using System.Threading.Tasks;
using ProviderRepository.Interface;
using vpsManager.Helpers;
using vultr.Model;

namespace Provider.vultr.Processor 
{
    public class VultrProcessor : IProviderRepository
    {
        public async Task<AccountWrapper> GetAccount()
        {
            string url = "https://api.vultr.com/v2/account";
            // HttpResponseMessage response = await ApiHelper.ApiClient.GetAsync(url);
            // Account account = null;
            // return account;
            ApiHelper.InitializeClient();
            using (HttpResponseMessage response = await ApiHelper.ApiClient.GetAsync(url))
            {
                if (response.IsSuccessStatusCode)
                {
                    AccountWrapper accountWrapper = await response.Content.ReadAsAsync<AccountWrapper>();
                    return accountWrapper;
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }
        }

        public async Task<OperatingSystems> ListOperatingSystems()
        {
            string url = "https://api.vultr.com/v2/os";
            ApiHelper.InitializeClient();
            using (HttpResponseMessage response = await ApiHelper.ApiClient.GetAsync(url))
            {
                if (response.IsSuccessStatusCode)
                {
                    OperatingSystems operatingSystems = await response.Content.ReadAsAsync<OperatingSystems>();
                    return operatingSystems;
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }
            
        }
    }
}