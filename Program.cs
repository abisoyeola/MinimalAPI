using Microsoft.AspNetCore.Components;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();

builder.Services.AddSwaggerGen(options =>
{
    options.SwaggerDoc("v1", new OpenApiInfo
    {
        Version = "v1",
        Title = "Click Harvest",
        Description = "Welcome to Click Havest, a brand new way to make money",
        TermsOfService = new Uri("https://example.com/terms"),
        Contact = new OpenApiContact
        {
            Name = "Example Contact",
            Url = new Uri("https://example.com/contact")
        },
        License = new OpenApiLicense
        {
            Name = "Example License",
            Url = new Uri("https://example.com/license")
        }
    });
});



var app = builder.Build();

if(app.Environment.IsDevelopment()){
    app.UseSwagger();
    app.UseSwaggerUI(options => // UseSwaggerUI is called only in Development.
    {
        options.SwaggerEndpoint("/swagger/v1/swagger.json", "v1");
        options.RoutePrefix = string.Empty;
    });
}

RegisterServices registerServices = new RegisterServices();
List<Register> register = new List<Register>(){new Register{DateRegistered=DateTime.Now, Email="olaabisoye@gmail.com",FirstName="Abisoye",Gender="Male", Id=1, LastName="Ola",Password="ola",Username = "abisoyeola"}};

//// This end point get the list of users
app.MapGet("/v1/getallusers",()=>{
    return registerServices.getAllUser(register);
});
///end get the list of users
///

//Get 1 user

app.MapGet("v1/getUser",(int id)=>{
    return registerServices.getUser(id,register);
});

app.MapPost("v1/createuser",(Register user)=>{
    var isRegistered =  registerServices.RegisterUser(user, register);
    if(isRegistered){
        return StatusCodes.Status200OK;
    }else{
        return StatusCodes.Status400BadRequest;
    }
});


app.Run();
