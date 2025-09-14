using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace P01_StudentSystem.Migrations
{
    /// <inheritdoc />
    public partial class RelationBetweenCourseAndResource : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CourseId",
                table: "Resources",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Resources_CourseId",
                table: "Resources",
                column: "CourseId");

            migrationBuilder.AddForeignKey(
                name: "FK_Resources_Courses_CourseId",
                table: "Resources",
                column: "CourseId",
                principalTable: "Courses",
                principalColumn: "CourseId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Resources_Courses_CourseId",
                table: "Resources");

            migrationBuilder.DropIndex(
                name: "IX_Resources_CourseId",
                table: "Resources");

            migrationBuilder.DropColumn(
                name: "CourseId",
                table: "Resources");
        }
    }
}
