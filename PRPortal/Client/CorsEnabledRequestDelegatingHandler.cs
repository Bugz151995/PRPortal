namespace PRPortal.Client
{
    public class CorsEnabledRequestDelegatingHandler : DelegatingHandler
    {
        public CorsEnabledRequestDelegatingHandler() : base(new HttpClientHandler())
        {  
        }

        protected override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            request.Headers.Add("Access-Control-Allow-Origin", "http:172.31.24.203");
            return base.SendAsync(request, cancellationToken);
        }
    }
}
