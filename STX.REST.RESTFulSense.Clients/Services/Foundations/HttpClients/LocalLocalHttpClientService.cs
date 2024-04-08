// ----------------------------------------------------------------------------------
// Copyright (c) The Standard Organization: A coalition of the Good-Hearted Engineers
// ----------------------------------------------------------------------------------

using System.Threading;
using System.Threading.Tasks;
using STX.REST.RESTFulSense.Clients.Brokers.Https;
using STX.REST.RESTFulSense.Clients.Models.LocalHttpClients;

namespace STX.REST.RESTFulSense.Clients.Services.Foundations.HttpClients
{
    internal class LocalHttpClientService : ILocalHttpClientService
    {
        private readonly IHttpClientBroker httpClientBroker;

        internal LocalHttpClientService(IHttpClientBroker httpClientBroker)
        {
            this.httpClientBroker = httpClientBroker;
        }

        public ValueTask<LocalHttpClients> GetAsync(LocalHttpClients localHttpClients, CancellationToken cancellationToken = default)
        {
            throw new System.NotImplementedException();
        }
    }
}