using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class JobStatusLookupsAdd : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "JobStatusLookupId",
                table: "Jobs",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "JobStatusLookups",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    JobStatusCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    JobStatusDescription = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobStatusLookups", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Jobs_JobStatusLookupId",
                table: "Jobs",
                column: "JobStatusLookupId");

            migrationBuilder.AddForeignKey(
                name: "FK_Jobs_JobStatusLookups_JobStatusLookupId",
                table: "Jobs",
                column: "JobStatusLookupId",
                principalTable: "JobStatusLookups",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Jobs_JobStatusLookups_JobStatusLookupId",
                table: "Jobs");

            migrationBuilder.DropTable(
                name: "JobStatusLookups");

            migrationBuilder.DropIndex(
                name: "IX_Jobs_JobStatusLookupId",
                table: "Jobs");

            migrationBuilder.DropColumn(
                name: "JobStatusLookupId",
                table: "Jobs");
        }
    }
}
