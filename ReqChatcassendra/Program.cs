using Microsoft.EntityFrameworkCore;
using ReqChat.Interface;
using ReqChatRepository;
using ReqChatRepository.Repository;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Server.Kestrel.Core;
using System.Net;
using Apache.NMS.ActiveMQ.Transport;
using Apache.NMS.ActiveMQ.Transport.Tcp;
using Microsoft.Bot.Streaming.Transport.NamedPipes;
//using System.Data.Entity;
//using re

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<appContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("ReqChatDB")));
//builder.Services.AddScoped<IDbContextFactory,appContext>();
builder.Services.AddControllers();
builder.Services.AddScoped<ICandidateListRepository, CandidateListRepository>();
builder.Services.AddScoped<IconversationRepository, ConversationRepository>();
builder.Services.AddScoped<IAllMessageRepository, AllMessageRepository>();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddCors(options =>
{
    options.AddPolicy("CorsPolicy",
        builder => builder.WithOrigins("http://localhost:4200")
            .AllowAnyMethod()
            .AllowAnyHeader()
            .AllowCredentials());
});


var app = builder.Build();
app.UseCors("CorsPolicy");
// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
