using Microsoft.AspNetCore.SignalR;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MapGet("/D4/{roll}", (int roll) => new Random().Next(1, 5) * roll);
app.MapGet("/D6/{roll}", (int roll) => new Random().Next(1, 7) * roll);
app.MapGet("/D8/{roll}", (int roll) => new Random().Next(1, 9) * roll);
app.MapGet("/D10/{roll}", (int roll) => new Random().Next(1, 11) * roll);
app.MapGet("/D12/{roll}", (int roll) => new Random().Next(1, 13) * roll);
app.MapGet("/D20/{roll}", (int roll) => new Random().Next(1, 21) * roll);
app.MapGet("/D100/{roll}", (int roll) => new Random().Next(1, 101) * roll);

app.Run();
