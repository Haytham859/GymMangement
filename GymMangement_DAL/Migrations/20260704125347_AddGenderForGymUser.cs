using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GymMangement_DAL.Migrations
{
    /// <inheritdoc />
    public partial class AddGenderForGymUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Gender",
                table: "Trainers",
                type: "varchar(6)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Gender",
                table: "Members",
                type: "varchar(6)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Gender",
                table: "Trainers");

            migrationBuilder.DropColumn(
                name: "Gender",
                table: "Members");
        }
    }
}
