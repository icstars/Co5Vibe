using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EvaluatePro.Migrations
{
    /// <inheritdoc />
    public partial class PossFinalBuild : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Category_User_UserId",
                table: "Category");

            migrationBuilder.DropIndex(
                name: "IX_Category_UserId",
                table: "Category");

            migrationBuilder.RenameColumn(
                name: "SupervisiorName",
                table: "User",
                newName: "SupervisorName");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Convention",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "CommentType",
                table: "Comment",
                newName: "CommentId");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Category",
                newName: "User");

            migrationBuilder.AddColumn<int>(
                name: "CategoryId",
                table: "User",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ConventionId",
                table: "Convention",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_User_CategoryId",
                table: "User",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_User_Category_CategoryId",
                table: "User",
                column: "CategoryId",
                principalTable: "Category",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_User_Category_CategoryId",
                table: "User");

            migrationBuilder.DropIndex(
                name: "IX_User_CategoryId",
                table: "User");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "User");

            migrationBuilder.RenameColumn(
                name: "SupervisorName",
                table: "User",
                newName: "SupervisiorName");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Convention",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "CommentId",
                table: "Comment",
                newName: "CommentType");

            migrationBuilder.RenameColumn(
                name: "User",
                table: "Category",
                newName: "UserId");

            migrationBuilder.AlterColumn<string>(
                name: "ConventionId",
                table: "Convention",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_Category_UserId",
                table: "Category",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Category_User_UserId",
                table: "Category",
                column: "UserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
