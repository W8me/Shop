using Microsoft.EntityFrameworkCore.Migrations;

namespace Pizza_Shop.Server.Migrations
{
    public partial class MorePizzaAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Pizzas",
                columns: new[] { "Id", "CategoryId", "Description", "ImageUrl", "Price", "Title" },
                values: new object[,]
                {
                    { 4, 2, "Sicilia pizza description", "http://4.bp.blogspot.com/-cXJNdO0Fris/UvldtuI4nJI/AAAAAAAABQg/29wVM7OhR6U/s1600/03-Margherita-Pizza-Totale-Pizza-Napoletana.jpg", 9.99m, "Sicilia" },
                    { 5, 2, "Paperoni pizza description", "http://4.bp.blogspot.com/-cXJNdO0Fris/UvldtuI4nJI/AAAAAAAABQg/29wVM7OhR6U/s1600/03-Margherita-Pizza-Totale-Pizza-Napoletana.jpg", 8.99m, "Paperoni" },
                    { 6, 1, "Поживна, з насиченим м’ясним смаком, Баварська піца стане гарною закускою до міцного німецького пива. У складі — смачнючі баварські ковбаски, вкриті скориночкою з пармезана та моцарелли. Смакота!", "http://4.bp.blogspot.com/-cXJNdO0Fris/UvldtuI4nJI/AAAAAAAABQg/29wVM7OhR6U/s1600/03-Margherita-Pizza-Totale-Pizza-Napoletana.jpg", 7.99m, "Bavarian" },
                    { 7, 3, "Mexicano pizza description", "http://4.bp.blogspot.com/-cXJNdO0Fris/UvldtuI4nJI/AAAAAAAABQg/29wVM7OhR6U/s1600/03-Margherita-Pizza-Totale-Pizza-Napoletana.jpg", 9.99m, "Mexicano" },
                    { 8, 1, "Mashrooms Pizza pizza description", "http://4.bp.blogspot.com/-cXJNdO0Fris/UvldtuI4nJI/AAAAAAAABQg/29wVM7OhR6U/s1600/03-Margherita-Pizza-Totale-Pizza-Napoletana.jpg", 11.99m, "Mashrooms Pizza" },
                    { 9, 1, "Hawaiian pizza pizza description", "http://4.bp.blogspot.com/-cXJNdO0Fris/UvldtuI4nJI/AAAAAAAABQg/29wVM7OhR6U/s1600/03-Margherita-Pizza-Totale-Pizza-Napoletana.jpg", 7.99m, "Hawaiian pizza" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Pizzas",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Pizzas",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Pizzas",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Pizzas",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Pizzas",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Pizzas",
                keyColumn: "Id",
                keyValue: 9);
        }
    }
}
