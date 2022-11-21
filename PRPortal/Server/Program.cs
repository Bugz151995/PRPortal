using Microsoft.AspNetCore.Cors.Infrastructure;
using Microsoft.AspNetCore.Hosting.StaticWebAssets;
using Microsoft.AspNetCore.ResponseCompression;
using Microsoft.Net.Http.Headers;

var MyAllowSpecificOrigins = "_myAllowSpecificOrigins";

var builder = WebApplication.CreateBuilder(args);

StaticWebAssetsLoader.UseStaticWebAssets(builder.Environment, builder.Configuration);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();

//THIS IS FOR ALLOWING REQUEST TO A DIFFERENT DOMAIN
//DO NOT REMOVE THIS PART FOR CORS POLICIES NG NEW BROWSERS
builder.Services.AddCors(options =>
{
    options.AddPolicy(MyAllowSpecificOrigins,
        policy =>
        {
            policy.WithOrigins("http://172.31.24.203", 
                "https://172.31.24.203", 
                "http://172.31.24.203:50000", 
                "https://172.31.24.203:50000",
                "http://localhost",
                "https://localhost",
                "http://localhost:5000",
                "https://localhost:5001"
                )
            .WithExposedHeaders("WWW-Authenticate")
            .AllowAnyMethod()
            .AllowCredentials();
        });
});
//END CORS POLICIES



var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseWebAssemblyDebugging();
}
else
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseBlazorFrameworkFiles();
app.UseStaticFiles();

app.UseRouting();
app.UseCors(MyAllowSpecificOrigins);

// PROXY TEST
// for CORS request avoiding preflight
app.MapWhen(
    context => context.Request.Path.StartsWithSegments("/b1s/v1"),
    builder => builder.RunProxy(new ProxyOptions
    {
        Scheme = "https",
        Host = "172.31.24.203",
        Port = "50000",
    })
);

app.MapRazorPages();
app.MapControllers();
app.MapFallbackToFile("index.html");

app.Run();