﻿namespace PRPortal.Client
{
    public class CorsDelegatingHandler : DelegatingHandler
    {
        public CorsDelegatingHandler() : base(new HttpClientHandler())
        {  
        }

        protected override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            request.Headers.Add("Access-Control-Allow-Origin", "https://172.31.24.203");
            return base.SendAsync(request, cancellationToken);
        }
    }
}