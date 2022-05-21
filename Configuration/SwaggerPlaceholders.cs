using FitnessApp.Database.DTO;
using Microsoft.OpenApi.Any;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace FitnessApp.Configuration
{
    public class SwaggerPlaceholders: ISchemaFilter
    {
        public void Apply(OpenApiSchema schema, SchemaFilterContext context)
        {
            if(context.Type == typeof(FoodRecordDtoForm))
            {
                schema.Example = new OpenApiObject()
                {
                    ["name"] = new OpenApiString("Whole Grain Bread"),
                    ["calories"] = new OpenApiFloat(209.3f),
                    ["proteins"] = new OpenApiFloat(12.0f),
                    ["carbohydrates"] = new OpenApiFloat(41.4f),
                    ["fats"] = new OpenApiFloat(3.3f),
                    ["ImageUrl"] = new OpenApiString("https://www.thespruceeats.com/thmb/ZJyWw36nZ1lLNi5FHOKRy9daQqs=/940x0/filters:no_upscale():max_bytes(150000):strip_icc():format(webp)/loaf-of-bread-182835505-58a7008c5f9b58a3c91c9a14.jpg"),

                };
            }
            if(context.Type == typeof(UserDtoLogin))
            {
                schema.Example = new OpenApiObject()
                {
                    ["username"] = new OpenApiString("user@example.com"),
                    ["password"] = new OpenApiString("String123!"),
                    ["rememberPassword"] = new OpenApiBoolean(true),
                };   
            }
        }
    }
}
