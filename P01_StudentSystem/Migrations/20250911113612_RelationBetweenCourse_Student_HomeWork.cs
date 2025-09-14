using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace P01_StudentSystem.Migrations
{
    /// <inheritdoc />
    public partial class RelationBetweenCourse_Student_HomeWork : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CourseId",
                table: "HomeWorks",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "StudentId",
                table: "HomeWorks",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_HomeWorks_CourseId",
                table: "HomeWorks",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_HomeWorks_StudentId",
                table: "HomeWorks",
                column: "StudentId");

            migrationBuilder.AddForeignKey(
                name: "FK_HomeWorks_Courses_CourseId",
                table: "HomeWorks",
                column: "CourseId",
                principalTable: "Courses",
                principalColumn: "CourseId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_HomeWorks_Students_StudentId",
                table: "HomeWorks",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "StudentId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HomeWorks_Courses_CourseId",
                table: "HomeWorks");

            migrationBuilder.DropForeignKey(
                name: "FK_HomeWorks_Students_StudentId",
                table: "HomeWorks");

            migrationBuilder.DropIndex(
                name: "IX_HomeWorks_CourseId",
                table: "HomeWorks");

            migrationBuilder.DropIndex(
                name: "IX_HomeWorks_StudentId",
                table: "HomeWorks");

            migrationBuilder.DropColumn(
                name: "CourseId",
                table: "HomeWorks");

            migrationBuilder.DropColumn(
                name: "StudentId",
                table: "HomeWorks");
        }
    }
}
