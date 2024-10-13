using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace komponentova_tvorba.Migrations
{
    /// <inheritdoc />
    public partial class UpdateUserModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Email",
                table: "Authors");

            migrationBuilder.RenameColumn(
                name: "Username",
                table: "Authors",
                newName: "Surname");

            migrationBuilder.RenameColumn(
                name: "PasswordHash",
                table: "Authors",
                newName: "Firstname");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Surname",
                table: "Authors",
                newName: "Username");

            migrationBuilder.RenameColumn(
                name: "Firstname",
                table: "Authors",
                newName: "PasswordHash");

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Authors",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }
    }
}
