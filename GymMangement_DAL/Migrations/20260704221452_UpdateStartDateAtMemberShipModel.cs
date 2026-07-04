using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GymMangement_DAL.Migrations
{
    /// <inheritdoc />
    public partial class UpdateStartDateAtMemberShipModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "StartsDate",
                table: "MemberShips",
                newName: "StartDate");

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "MemberShips",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "MemberShips");

            migrationBuilder.RenameColumn(
                name: "StartDate",
                table: "MemberShips",
                newName: "StartsDate");
        }
    }
}
