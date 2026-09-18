using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ZombieParty.Migrations
{
    /// <inheritdoc />
    public partial class AjoutZombieForce_Seed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Force",
                table: "Zombies",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Zombies",
                keyColumn: "Id",
                keyValue: 1,
                column: "Force",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Zombies",
                keyColumn: "Id",
                keyValue: 2,
                column: "Force",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Zombies",
                keyColumn: "Id",
                keyValue: 3,
                column: "Force",
                value: 12);

            migrationBuilder.UpdateData(
                table: "Zombies",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Force", "ShortDesc" },
                values: new object[] { 5, "Vivant dans sa tombe gardant son trésor" });

            migrationBuilder.UpdateData(
                table: "Zombies",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Force", "Name" },
                values: new object[] { 20, "Ragamuffin " });

            migrationBuilder.UpdateData(
                table: "Zombies",
                keyColumn: "Id",
                keyValue: 6,
                column: "Force",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Zombies",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Force", "Name" },
                values: new object[] { 12, "Taxidermy " });

            migrationBuilder.UpdateData(
                table: "Zombies",
                keyColumn: "Id",
                keyValue: 8,
                column: "Force",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Zombies",
                keyColumn: "Id",
                keyValue: 9,
                column: "Force",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Zombies",
                keyColumn: "Id",
                keyValue: 10,
                column: "Force",
                value: 23);

            migrationBuilder.UpdateData(
                table: "Zombies",
                keyColumn: "Id",
                keyValue: 11,
                column: "Force",
                value: 15);

            migrationBuilder.UpdateData(
                table: "Zombies",
                keyColumn: "Id",
                keyValue: 12,
                column: "Force",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Zombies",
                keyColumn: "Id",
                keyValue: 13,
                column: "Force",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Zombies",
                keyColumn: "Id",
                keyValue: 14,
                column: "Force",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Zombies",
                keyColumn: "Id",
                keyValue: 15,
                column: "Force",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Zombies",
                keyColumn: "Id",
                keyValue: 16,
                column: "Force",
                value: 12);

            migrationBuilder.UpdateData(
                table: "Zombies",
                keyColumn: "Id",
                keyValue: 17,
                column: "Force",
                value: 20);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Force",
                table: "Zombies");

            migrationBuilder.UpdateData(
                table: "Zombies",
                keyColumn: "Id",
                keyValue: 4,
                column: "ShortDesc",
                value: "Vivant dans sa tombe grandant son trésor");

            migrationBuilder.UpdateData(
                table: "Zombies",
                keyColumn: "Id",
                keyValue: 5,
                column: "Name",
                value: "Ragamuffin ");

            migrationBuilder.UpdateData(
                table: "Zombies",
                keyColumn: "Id",
                keyValue: 7,
                column: "Name",
                value: "Taxidermy ");
        }
    }
}
