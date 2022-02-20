using SampleWcfApp.WcfServices;
using SoapCore;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddSoapCore();
builder.Services.AddSingleton<IAccelerationService, AccelerationService>();
builder.Services.AddMvc();
var app = builder.Build();
app.UseRouting();
app.UseEndpoints(endpoints =>
{
    endpoints.UseSoapEndpoint<IAccelerationService>("/Service.svc", new SoapEncoderOptions(), SoapSerializer.DataContractSerializer);
    endpoints.UseSoapEndpoint<IAccelerationService>("/Service.asmx", new SoapEncoderOptions(), SoapSerializer.XmlSerializer);
});



app.Run();
