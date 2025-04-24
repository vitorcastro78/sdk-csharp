using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using Microsoft.OpenApi.Models;
using Zuora.WebAPI.Middleware;
using Zuora.Api;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.Extensions.Configuration;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();

// Configuração do Swagger
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo
    {
        Title = "Zuora API",
        Version = "v1",
        Description = "API para integração com o sistema Zuora",
        Contact = new OpenApiContact
        {
            Name = "Sua Empresa",
            Email = "contato@suaempresa.com"
        }
    });

    // Configuração para autenticação JWT no Swagger
    c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
    {
        Description = "JWT Authorization header using the Bearer scheme. Example: \"Authorization: Bearer {token}\"",
        Name = "Authorization",
        In = ParameterLocation.Header,
        Type = SecuritySchemeType.ApiKey,
        Scheme = "Bearer"
    });

    c.AddSecurityRequirement(new OpenApiSecurityRequirement
    {
        {
            new OpenApiSecurityScheme
            {
                Reference = new OpenApiReference
                {
                    Type = ReferenceType.SecurityScheme,
                    Id = "Bearer"
                }
            },
            Array.Empty<string>()
        }
    });
});

// Configuração do CORS
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowSpecificOrigins", options =>
    {
        options.WithOrigins(builder.Configuration.GetValue<string[]>("Cors:AllowedOrigins"))
               .WithMethods(builder.Configuration.GetValue<string[]>("Cors:AllowedMethods"))
               .WithHeaders(builder.Configuration.GetValue<string[]>("Cors:AllowedHeaders"))
               .AllowCredentials();
    });
});

// Configuração da autenticação JWT
builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
    .AddJwtBearer(options =>
    {
        options.TokenValidationParameters = new TokenValidationParameters
        {
            ValidateIssuer = true,
            ValidateAudience = true,
            ValidateLifetime = true,
            ValidateIssuerSigningKey = true,
            ValidIssuer = builder.Configuration["Jwt:Issuer"],
            ValidAudience = builder.Configuration["Jwt:Audience"],
            IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration["Jwt:Key"]))
        };
    });

// Configuração de autorização
builder.Services.AddAuthorization(options =>
{
    options.AddPolicy("AdminOnly", policy => policy.RequireRole("Admin"));
    options.AddPolicy("UserOnly", policy => policy.RequireRole("User"));
});

// Registrar as APIs
builder.Services.AddScoped<AccountsApi>();
builder.Services.AddScoped<SubscriptionsApi>();
builder.Services.AddScoped<PaymentsApi>();
builder.Services.AddScoped<InvoicesApi>();
builder.Services.AddScoped<ProductsApi>();
builder.Services.AddScoped<PlansApi>();
builder.Services.AddScoped<PricesApi>();
builder.Services.AddScoped<ContactsApi>();
builder.Services.AddScoped<PaymentMethodsApi>();
builder.Services.AddScoped<OrdersApi>();
builder.Services.AddScoped<OrderLineItemsApi>();
builder.Services.AddScoped<SubscriptionItemsApi>();
builder.Services.AddScoped<SubscriptionPlansApi>();
builder.Services.AddScoped<UsageRecordsApi>();
builder.Services.AddScoped<TaxationItemsApi>();
builder.Services.AddScoped<RefundsApi>();
builder.Services.AddScoped<QueryRunsApi>();
builder.Services.AddScoped<PaymentSchedulesApi>();
builder.Services.AddScoped<PaymentScheduleItemsApi>();
builder.Services.AddScoped<PaymentRunsApi>();
builder.Services.AddScoped<FulfillmentsApi>();
builder.Services.AddScoped<FulfillmentItemsApi>();
builder.Services.AddScoped<DebitMemosApi>();
builder.Services.AddScoped<CustomObjectsApi>();
builder.Services.AddScoped<CreditMemosApi>();
builder.Services.AddScoped<BillingDocumentsApi>();
builder.Services.AddScoped<BillingDocumentItemsApi>();
builder.Services.AddScoped<BillRunsApi>();
builder.Services.AddScoped<BillRunPreviewsApi>();
builder.Services.AddScoped<WorkflowsApi>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "Zuora API v1");
        c.RoutePrefix = string.Empty;
    });
}

app.UseMiddleware<ExceptionHandlingMiddleware>();
app.UseHttpsRedirection();
app.UseCors("AllowSpecificOrigins");
app.UseAuthentication();
app.UseAuthorization();
app.MapControllers();

app.Run(); 