namespace Catalog.API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
            builder.Services.AddSwaggerGen(options =>
            {
                options.SwaggerDoc("v1", new Microsoft.OpenApi.Models.OpenApiInfo
                {
                    Title = "Catalog API",
                    Version = "v1",
                    Description = "This is API for Catalog microservice in ecommerce application",
                    Contact = new Microsoft.OpenApi.Models.OpenApiContact
                    {
                        Name = "Kirollos Mikhail",
                        Email = "kiro766@yahoo.com",
                        Url = new Uri("https://yourwebsite.eg")
                    }
                });
            });
            builder.Services.AddOpenApi();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.MapOpenApi();
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
