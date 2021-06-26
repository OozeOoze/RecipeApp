using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RecipeApp.Migrations
{
    public partial class FreshDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Recipes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Details = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ing001 = table.Column<bool>(type: "bit", nullable: false),
                    Ing002 = table.Column<bool>(type: "bit", nullable: false),
                    Ing003 = table.Column<bool>(type: "bit", nullable: false),
                    Ing004 = table.Column<bool>(type: "bit", nullable: false),
                    Ing005 = table.Column<bool>(type: "bit", nullable: false),
                    Ing006 = table.Column<bool>(type: "bit", nullable: false),
                    Ing007 = table.Column<bool>(type: "bit", nullable: false),
                    Ing008 = table.Column<bool>(type: "bit", nullable: false),
                    Ing009 = table.Column<bool>(type: "bit", nullable: false),
                    Ing010 = table.Column<bool>(type: "bit", nullable: false),
                    Ing011 = table.Column<bool>(type: "bit", nullable: false),
                    Ing012 = table.Column<bool>(type: "bit", nullable: false),
                    Ing013 = table.Column<bool>(type: "bit", nullable: false),
                    Ing014 = table.Column<bool>(type: "bit", nullable: false),
                    Ing015 = table.Column<bool>(type: "bit", nullable: false),
                    Ing016 = table.Column<bool>(type: "bit", nullable: false),
                    Ing017 = table.Column<bool>(type: "bit", nullable: false),
                    Ing018 = table.Column<bool>(type: "bit", nullable: false),
                    Ing019 = table.Column<bool>(type: "bit", nullable: false),
                    Ing020 = table.Column<bool>(type: "bit", nullable: false),
                    Ing021 = table.Column<bool>(type: "bit", nullable: false),
                    Ing022 = table.Column<bool>(type: "bit", nullable: false),
                    Ing023 = table.Column<bool>(type: "bit", nullable: false),
                    Ing024 = table.Column<bool>(type: "bit", nullable: false),
                    Ing025 = table.Column<bool>(type: "bit", nullable: false),
                    Ing026 = table.Column<bool>(type: "bit", nullable: false),
                    Ing027 = table.Column<bool>(type: "bit", nullable: false),
                    Ing028 = table.Column<bool>(type: "bit", nullable: false),
                    Ing029 = table.Column<bool>(type: "bit", nullable: false),
                    Ing030 = table.Column<bool>(type: "bit", nullable: false),
                    Ing031 = table.Column<bool>(type: "bit", nullable: false),
                    Ing032 = table.Column<bool>(type: "bit", nullable: false),
                    Ing033 = table.Column<bool>(type: "bit", nullable: false),
                    Ing034 = table.Column<bool>(type: "bit", nullable: false),
                    Ing035 = table.Column<bool>(type: "bit", nullable: false),
                    Ing036 = table.Column<bool>(type: "bit", nullable: false),
                    Ing037 = table.Column<bool>(type: "bit", nullable: false),
                    Ing038 = table.Column<bool>(type: "bit", nullable: false),
                    Ing039 = table.Column<bool>(type: "bit", nullable: false),
                    Ing040 = table.Column<bool>(type: "bit", nullable: false),
                    Ing041 = table.Column<bool>(type: "bit", nullable: false),
                    Ing042 = table.Column<bool>(type: "bit", nullable: false),
                    Ing043 = table.Column<bool>(type: "bit", nullable: false),
                    Ing044 = table.Column<bool>(type: "bit", nullable: false),
                    Ing045 = table.Column<bool>(type: "bit", nullable: false),
                    Ing046 = table.Column<bool>(type: "bit", nullable: false),
                    Ing047 = table.Column<bool>(type: "bit", nullable: false),
                    Ing048 = table.Column<bool>(type: "bit", nullable: false),
                    Ing049 = table.Column<bool>(type: "bit", nullable: false),
                    Ing050 = table.Column<bool>(type: "bit", nullable: false),
                    Ing051 = table.Column<bool>(type: "bit", nullable: false),
                    Ing052 = table.Column<bool>(type: "bit", nullable: false),
                    Ing053 = table.Column<bool>(type: "bit", nullable: false),
                    Ing054 = table.Column<bool>(type: "bit", nullable: false),
                    Ing055 = table.Column<bool>(type: "bit", nullable: false),
                    Ing056 = table.Column<bool>(type: "bit", nullable: false),
                    Ing057 = table.Column<bool>(type: "bit", nullable: false),
                    Ing058 = table.Column<bool>(type: "bit", nullable: false),
                    Ing059 = table.Column<bool>(type: "bit", nullable: false),
                    Ing060 = table.Column<bool>(type: "bit", nullable: false),
                    Ing061 = table.Column<bool>(type: "bit", nullable: false),
                    Ing062 = table.Column<bool>(type: "bit", nullable: false),
                    Ing063 = table.Column<bool>(type: "bit", nullable: false),
                    Ing064 = table.Column<bool>(type: "bit", nullable: false),
                    Ing065 = table.Column<bool>(type: "bit", nullable: false),
                    Ing066 = table.Column<bool>(type: "bit", nullable: false),
                    Ing067 = table.Column<bool>(type: "bit", nullable: false),
                    Ing068 = table.Column<bool>(type: "bit", nullable: false),
                    Ing069 = table.Column<bool>(type: "bit", nullable: false),
                    Ing070 = table.Column<bool>(type: "bit", nullable: false),
                    Ing071 = table.Column<bool>(type: "bit", nullable: false),
                    Ing072 = table.Column<bool>(type: "bit", nullable: false),
                    Ing073 = table.Column<bool>(type: "bit", nullable: false),
                    Ing074 = table.Column<bool>(type: "bit", nullable: false),
                    Ing075 = table.Column<bool>(type: "bit", nullable: false),
                    Ing076 = table.Column<bool>(type: "bit", nullable: false),
                    Ing077 = table.Column<bool>(type: "bit", nullable: false),
                    Ing078 = table.Column<bool>(type: "bit", nullable: false),
                    Ing079 = table.Column<bool>(type: "bit", nullable: false),
                    Ing080 = table.Column<bool>(type: "bit", nullable: false),
                    Ing081 = table.Column<bool>(type: "bit", nullable: false),
                    Ing082 = table.Column<bool>(type: "bit", nullable: false),
                    Ing083 = table.Column<bool>(type: "bit", nullable: false),
                    Ing084 = table.Column<bool>(type: "bit", nullable: false),
                    Ing085 = table.Column<bool>(type: "bit", nullable: false),
                    Ing086 = table.Column<bool>(type: "bit", nullable: false),
                    Ing087 = table.Column<bool>(type: "bit", nullable: false),
                    Ing088 = table.Column<bool>(type: "bit", nullable: false),
                    Ing089 = table.Column<bool>(type: "bit", nullable: false),
                    Ing090 = table.Column<bool>(type: "bit", nullable: false),
                    Ing091 = table.Column<bool>(type: "bit", nullable: false),
                    Ing092 = table.Column<bool>(type: "bit", nullable: false),
                    Ing093 = table.Column<bool>(type: "bit", nullable: false),
                    Ing094 = table.Column<bool>(type: "bit", nullable: false),
                    Ing095 = table.Column<bool>(type: "bit", nullable: false),
                    Ing096 = table.Column<bool>(type: "bit", nullable: false),
                    Ing097 = table.Column<bool>(type: "bit", nullable: false),
                    Ing098 = table.Column<bool>(type: "bit", nullable: false),
                    Ing099 = table.Column<bool>(type: "bit", nullable: false),
                    Ing100 = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Recipes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Recipes");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
