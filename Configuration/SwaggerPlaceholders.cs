using FitnessApp.Database.DTO;
using FitnessApp.Database.DTO.EatingActivityRecord;
using Microsoft.OpenApi.Any;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace FitnessApp.Configuration
{
    public class SwaggerPlaceholders: ISchemaFilter
    {
        public void Apply(OpenApiSchema schema, SchemaFilterContext context)
        {
            if(context.Type == typeof(FoodProductDtoForm))
            {
                schema.Example = new OpenApiObject()
                {
                    ["name"] = new OpenApiString("Whole Wheat Bread"),
                    ["proteins100g"] = new OpenApiFloat(12.0f),
                    ["carbohydrates100g"] = new OpenApiFloat(41.4f),
                    ["fats100g"] = new OpenApiFloat(3.3f),
                    ["ImageUrl"] = new OpenApiString("https://www.thespruceeats.com/thmb/ZJyWw36nZ1lLNi5FHOKRy9daQqs=/940x0/filters:no_upscale():max_bytes(150000):strip_icc():format(webp)/loaf-of-bread-182835505-58a7008c5f9b58a3c91c9a14.jpg"),

                };
            }
            if(context.Type == typeof(EatingActivityRecordDtoForm))
            {
                schema.Example = new OpenApiObject()
                {
                    ["grams"] = new OpenApiInteger(123),
                    ["foodProductId"] = new OpenApiInteger(1)
                };
            }
        }
    }
}
