using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EvaluatePro.Migrations
{
    /// <inheritdoc />
    public partial class FinalUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_User_Role_RoleId1",
                table: "User");

            migrationBuilder.DropIndex(
                name: "IX_User_RoleId1",
                table: "User");

            migrationBuilder.DropColumn(
                name: "RoleId1",
                table: "User");

            migrationBuilder.DropColumn(
                name: "IsAdmin",
                table: "Role");

            migrationBuilder.DropColumn(
                name: "IsEmpoyee",
                table: "Role");

            migrationBuilder.DropColumn(
                name: "IsManager",
                table: "Role");

            migrationBuilder.AlterColumn<int>(
                name: "RoleId",
                table: "Role",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Role",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Role_UserId",
                table: "Role",
                column: "UserId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Role_User_UserId",
                table: "Role",
                column: "UserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Role_User_UserId",
                table: "Role");

            migrationBuilder.DropIndex(
                name: "IX_Role_UserId",
                table: "Role");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Role");

            migrationBuilder.AddColumn<int>(
                name: "RoleId1",
                table: "User",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "RoleId",
                table: "Role",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<int>(
                name: "IsAdmin",
                table: "Role",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IsEmpoyee",
                table: "Role",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IsManager",
                table: "Role",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_User_RoleId1",
                table: "User",
                column: "RoleId1");

            migrationBuilder.AddForeignKey(
                name: "FK_User_Role_RoleId1",
                table: "User",
                column: "RoleId1",
                principalTable: "Role",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
