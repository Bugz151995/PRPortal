namespace PRPortal.Client
{
    public class CorsDelegatingHandler : DelegatingHandler
    {
        public CorsDelegatingHandler() : base(new HttpClientHandler())
        {  
        }

        protected override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            request.Headers.Add("Accept", "text/html,application/xhtml+xml,application/xml;q=0.9,image/avif,image/webp,*/*;q=0.8");
            request.Headers.Add("Access-Control-Allow-Origin", "https://172.31.24.203:50000");
            return base.SendAsync(request, cancellationToken);
        }
    }
}