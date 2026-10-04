using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TalabatClone.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class SecondMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderGroups_AspNetUsers_CustomerId",
                table: "OrderGroups");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderGroups_AspNetUsers_RiderId",
                table: "OrderGroups");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderGroups_AspNetUsers_CustomerId",
                table: "OrderGroups",
                column: "CustomerId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderGroups_AspNetUsers_RiderId",
                table: "OrderGroups",
                column: "RiderId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderGroups_AspNetUsers_CustomerId",
                table: "OrderGroups");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderGroups_AspNetUsers_RiderId",
                table: "OrderGroups");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderGroups_AspNetUsers_CustomerId",
                table: "OrderGroups",
                column: "CustomerId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderGroups_AspNetUsers_RiderId",
                table: "OrderGroups",
                column: "RiderId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }
    }
}
