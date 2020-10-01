using Microsoft.EntityFrameworkCore.Migrations;

namespace DiscordWeb.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DiscordEntries",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ChannelName = table.Column<string>(nullable: true),
                    Username = table.Column<string>(nullable: true),
                    Message = table.Column<string>(nullable: true),
                    MessageLink = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DiscordEntries", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DiscordEntries_ChannelName",
                table: "DiscordEntries",
                column: "ChannelName");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DiscordEntries");
        }
    }
}
