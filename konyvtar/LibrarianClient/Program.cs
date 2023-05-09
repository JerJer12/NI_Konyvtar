global using LibrarianClient.Service.LibraryService;
global using LibraryApplication.Contracts;
using LibrarianClient;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddScoped<ILibraryService, LibraryService>();

builder.Logging.SetMinimumLevel(LogLevel.Information);
await builder.Build().RunAsync();
