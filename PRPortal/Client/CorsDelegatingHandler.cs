namespace PRPortal.Client
{
    public class CorsDelegatingHandler : DelegatingHandler
    {
        public CorsDelegatingHandler() : base(new HttpClientHandler())
        {  
        }

        protected override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            request.Headers.Add("Access-Control-Allow-Origin", "*");
            request.Headers.Add("Access-Control-Max-Age", "600");
            return base.SendAsync(request, cancellationToken);
        }
    }
}