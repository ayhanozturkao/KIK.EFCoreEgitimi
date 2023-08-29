using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Relationship.Migrations
{
    /// <inheritdoc />
    public partial class mg5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Users",
                newName: "SharedUserInformation_Name");

            migrationBuilder.AddColumn<string>(
                name: "SharedUserInformation_City",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "SharedUserInformation_FullAddress",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "SharedUserInformation_Street",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "SharedUserInformation_ZipCode",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "Products",
                type: "decimal(6,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "money");

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SharedUserInformation_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SharedUserInformation_City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SharedUserInformation_Street = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SharedUserInformation_ZipCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SharedUserInformation_FullAddress = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropColumn(
                name: "SharedUserInformation_City",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "SharedUserInformation_FullAddress",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "SharedUserInformation_Street",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "SharedUserInformation_ZipCode",
                table: "Users");

            migrationBuilder.RenameColumn(
                name: "SharedUserInformation_Name",
                table: "Users",
                newName: "Name");

            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "Products",
                type: "money",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(6,2)");

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[] { 1, "tanersaydam@gmail.com", "Taner Saydam" });
        }
    }
}
