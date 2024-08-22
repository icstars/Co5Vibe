using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EvaluatePro.Migrations
{
    /// <inheritdoc />
    public partial class AddScore : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "EvalCriteria2",
                table: "Criterias",
                newName: "score");

            migrationBuilder.RenameColumn(
                name: "EvalCriteria1",
                table: "Criterias",
                newName: "Criteria1");

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Criterias",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "FName",
                table: "Criterias",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<bool>(
                name: "IsManager",
                table: "Criterias",
                type: "tinyint(1)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LName",
                table: "Criterias",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "Criterias",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Email",
                table: "Criterias");

            migrationBuilder.DropColumn(
                name: "FName",
                table: "Criterias");

            migrationBuilder.DropColumn(
                name: "IsManager",
                table: "Criterias");

            migrationBuilder.DropColumn(
                name: "LName",
                table: "Criterias");

            migrationBuilder.DropColumn(
                name: "Title",
                table: "Criterias");

            migrationBuilder.RenameColumn(
                name: "score",
                table: "Criterias",
                newName: "EvalCriteria2");

            migrationBuilder.RenameColumn(
                name: "Criteria1",
                table: "Criterias",
                newName: "EvalCriteria1");
        }
    }
}
