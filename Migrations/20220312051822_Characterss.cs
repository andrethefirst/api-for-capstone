using Microsoft.EntityFrameworkCore.Migrations;

namespace apiforcapstone.Migrations
{
    public partial class Characterss : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Characters",
                columns: new[] { "CharacterId", "Combat", "Durability", "Intelligence", "Name", "Power", "SecretID", "Speed", "Strength" },
                values: new object[,]
                {
                    { 11, 86, 90, 90, "Spawn", 92, "Albert Simmons", 80, 76 },
                    { 28, 84, 60, 96, "Spider-Man", 87, "Peter Parker", 89, 83 },
                    { 27, 87, 77, 80, "Darth Maul", 87, "Maul", 80, 78 },
                    { 26, 70, 86, 80, "Dani Moonstar", 89, "Dani Moonstar", 80, 80 },
                    { 25, 78, 74, 78, "Kingpin", 80, "Wilson Fisk", 40, 84 },
                    { 24, 70, 67, 86, "Psylocke", 80, "Betsy Braddock", 68, 79 },
                    { 23, 0, 99, 0, "console.log", 99, "Microsoft Documentation", 0, 99 },
                    { 22, 70, 91, 80, "Pain", 92, "Nagato Uzumaki", 60, 80 },
                    { 21, 97, 94, 70, "Super Man", 95, "Clark Kent", 90, 98 },
                    { 20, 90, 99, 40, "Wolverine", 80, "James Howlett", 70, 90 },
                    { 19, 100, 100, 100, "The Enlightened One", 100, "Andre Velasquez", 100, 100 },
                    { 18, 80, 80, 80, "Enlightened Apprentice", 80, "Shaun Kent", 80, 80 },
                    { 17, 35, 35, 35, "Unenlightened", 35, "Amerik Velasquez", 35, 35 },
                    { 16, 70, 70, 70, "Master Chief", 70, "John 117", 70, 70 },
                    { 15, 60, 89, 94, "Dr.Doom", 93, "Victor Von Doom", 30, 70 },
                    { 14, 30, 60, 99, "Professor X", 94, "Charles Xavier", 1, 86 },
                    { 13, 60, 79, 50, "Green Lantern", 93, "Hal Jordan", 70, 60 },
                    { 12, 83, 99, 30, "Deadpool", 25, "Wade Wilson", 65, 80 },
                    { 29, 94, 95, 50, "Darkseid", 90, "Uxas", 70, 89 },
                    { 30, 99, 99, 99, "Exodia Kanye", 99, "Kanye West", 99, 99 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: 30);
        }
    }
}
