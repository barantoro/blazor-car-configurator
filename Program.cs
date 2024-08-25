using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using blazor_car_configurator;
using blazor_car_configurator.Services;

using Microsoft.JSInterop;
using System;
using System.Net.Http;
using System.Threading.Tasks;
using Blazored.LocalStorage;
using DinkToPdf;
using DinkToPdf.Contracts;


var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

builder.Services.AddBlazorBootstrap();
builder.Services.AddScoped<CarDataService>();
builder.Services.AddBlazoredLocalStorage();
builder.Services.AddSingleton(typeof(IConverter), new SynchronizedConverter(new PdfTools()));

await builder.Build().RunAsync();
