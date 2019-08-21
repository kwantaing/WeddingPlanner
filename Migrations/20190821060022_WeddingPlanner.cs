using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WeddingPlanner.Migrations
{
    public partial class WeddingPlanner : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Guests",
                columns: table => new
                {
                    guest_id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    first_name = table.Column<string>(nullable: false),
                    last_name = table.Column<string>(nullable: false),
                    email = table.Column<string>(nullable: false),
                    password = table.Column<string>(nullable: false),
                    created_at = table.Column<DateTime>(nullable: false),
                    updated_at = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Guests", x => x.guest_id);
                });

            migrationBuilder.CreateTable(
                name: "Weddings",
                columns: table => new
                {
                    wedding_id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    bride_name = table.Column<string>(nullable: false),
                    groom_name = table.Column<string>(nullable: false),
                    wedding_date = table.Column<DateTime>(nullable: false),
                    wedding_address = table.Column<string>(nullable: false),
                    Creatorguest_id = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Weddings", x => x.wedding_id);
                    table.ForeignKey(
                        name: "FK_Weddings_Guests_Creatorguest_id",
                        column: x => x.Creatorguest_id,
                        principalTable: "Guests",
                        principalColumn: "guest_id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "RSVPs",
                columns: table => new
                {
                    rsvp_id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    wedding_id = table.Column<int>(nullable: false),
                    guest_id = table.Column<int>(nullable: false),
                    RSVPed = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RSVPs", x => x.rsvp_id);
                    table.ForeignKey(
                        name: "FK_RSVPs_Guests_guest_id",
                        column: x => x.guest_id,
                        principalTable: "Guests",
                        principalColumn: "guest_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RSVPs_Weddings_wedding_id",
                        column: x => x.wedding_id,
                        principalTable: "Weddings",
                        principalColumn: "wedding_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_RSVPs_guest_id",
                table: "RSVPs",
                column: "guest_id");

            migrationBuilder.CreateIndex(
                name: "IX_RSVPs_wedding_id",
                table: "RSVPs",
                column: "wedding_id");

            migrationBuilder.CreateIndex(
                name: "IX_Weddings_Creatorguest_id",
                table: "Weddings",
                column: "Creatorguest_id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RSVPs");

            migrationBuilder.DropTable(
                name: "Weddings");

            migrationBuilder.DropTable(
                name: "Guests");
        }
    }
}
