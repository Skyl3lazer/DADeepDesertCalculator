using DuneData.Data;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using MudBlazor.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

builder.Services.AddSingleton<DuneDataService>();
builder.Services.AddMudServices();

await builder.Build().RunAsync();
