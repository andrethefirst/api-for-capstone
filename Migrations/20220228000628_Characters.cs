using Microsoft.EntityFrameworkCore.Migrations;

namespace apiforcapstone.Migrations
{
    public partial class Characters : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Characters",
                columns: new[] { "CharacterId", "Combat", "Durability", "Intelligence", "Name", "Power", "SecretID", "Speed", "Strength" },
                values: new object[,]
                {
                    { 1, 30, 85, 90, "Raven", 92, "Raven", 62, 50 },
                    { 2, 50, 70, 55, "Human Torch", 81, "Johnny Storm", 87, 70 },
                    { 3, 50, 40, 96, "Dr Strange", 99, "Stephen Strange", 76, 80 },
                    { 4, 89, 87, 87, "Spider Man 2099", 45, "Miguel O'Hara", 77, 88 },
                    { 5, 95, 40, 50, "Green Arrow", 20, "Oliver Queen", 48, 60 },
                    { 6, 68, 66, 78, "Zatanna", 89, "Zatanna Zatara", 50, 58 },
                    { 7, 84, 60, 80, "Capt. of Heart Pirates", 93, "Trafalgar Law", 35, 70 },
                    { 8, 10, 35, 95, "Yami Yugi", 90, "Yami Yugi", 10, 40 },
                    { 9, 85, 95, 80, "Darth Vader", 94, "Anakin Skywalker", 50, 90 },
                    { 10, 84, 70, 60, "The Last Air Bender", 87, "Aang", 89, 60 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: 10);
        }
    }
}
