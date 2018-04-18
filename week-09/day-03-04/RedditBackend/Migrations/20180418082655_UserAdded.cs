using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace RedditBackend.Migrations
{
    public partial class UserAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "UserId",
                table: "PostList",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "UserList",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserList", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PostList_UserId",
                table: "PostList",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_PostList_UserList_UserId",
                table: "PostList",
                column: "UserId",
                principalTable: "UserList",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PostList_UserList_UserId",
                table: "PostList");

            migrationBuilder.DropTable(
                name: "UserList");

            migrationBuilder.DropIndex(
                name: "IX_PostList_UserId",
                table: "PostList");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "PostList");
        }
    }
}
