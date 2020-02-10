using Microsoft.EntityFrameworkCore.Migrations;

namespace SmartHome.Web.Migrations
{
    public partial class added_author : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Listings_AspNetUsers_AppUserId",
                table: "Listings");

            migrationBuilder.DropIndex(
                name: "IX_Listings_AppUserId",
                table: "Listings");

            migrationBuilder.DropColumn(
                name: "AppUserId",
                table: "Listings");

            migrationBuilder.AddColumn<int>(
                name: "AuthorId",
                table: "Listings",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Listings_AuthorId",
                table: "Listings",
                column: "AuthorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Listings_AspNetUsers_AuthorId",
                table: "Listings",
                column: "AuthorId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Listings_AspNetUsers_AuthorId",
                table: "Listings");

            migrationBuilder.DropIndex(
                name: "IX_Listings_AuthorId",
                table: "Listings");

            migrationBuilder.DropColumn(
                name: "AuthorId",
                table: "Listings");

            migrationBuilder.AddColumn<int>(
                name: "AppUserId",
                table: "Listings",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Listings_AppUserId",
                table: "Listings",
                column: "AppUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Listings_AspNetUsers_AppUserId",
                table: "Listings",
                column: "AppUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
