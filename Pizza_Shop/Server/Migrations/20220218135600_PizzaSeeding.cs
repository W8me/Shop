using Microsoft.EntityFrameworkCore.Migrations;

namespace Pizza_Shop.Server.Migrations
{
    public partial class PizzaSeeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Pizzas",
                columns: new[] { "Id", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 1, "Neopolitano pizza description", "http://4.bp.blogspot.com/-cXJNdO0Fris/UvldtuI4nJI/AAAAAAAABQg/29wVM7OhR6U/s1600/03-Margherita-Pizza-Totale-Pizza-Napoletana.jpg", 9.99m, "Neopolitano" });

            migrationBuilder.InsertData(
                table: "Pizzas",
                columns: new[] { "Id", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 2, "4Cheese pizza description", "http://4.bp.blogspot.com/-cXJNdO0Fris/UvldtuI4nJI/AAAAAAAABQg/29wVM7OhR6U/s1600/03-Margherita-Pizza-Totale-Pizza-Napoletana.jpg", 8.99m, "4Cheese" });

            migrationBuilder.InsertData(
                table: "Pizzas",
                columns: new[] { "Id", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 3, "Chicago Pizza pizza description", "http://4.bp.blogspot.com/-cXJNdO0Fris/UvldtuI4nJI/AAAAAAAABQg/29wVM7OhR6U/s1600/03-Margherita-Pizza-Totale-Pizza-Napoletana.jpg", 7.99m, "Chicago Pizza" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Pizzas",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Pizzas",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Pizzas",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
