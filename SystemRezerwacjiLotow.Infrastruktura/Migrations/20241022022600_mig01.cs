using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SystemRezerwacjiLotow.Infrastruktura.Migrations
{
    /// <inheritdoc />
    public partial class mig01 : Migration
    {
        /// <inheritdoc />
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
                    Imie = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nazwisko = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DataUrodzenia = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TenantKind = table.Column<int>(type: "int", nullable: false),
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
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
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
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
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

            migrationBuilder.CreateTable(
                name: "Flights",
                columns: table => new
                {
                    FlightId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    TrasaOd = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TrasaDo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    GodzinaWylotu = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DataDodania = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TenantId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Flights", x => x.FlightId);
                    table.ForeignKey(
                        name: "FK_Flights_AspNetUsers_TenantId",
                        column: x => x.TenantId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "DniWylotow",
                columns: table => new
                {
                    DzieWylotuId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Dzien = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FlightId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DniWylotow", x => x.DzieWylotuId);
                    table.ForeignKey(
                        name: "FK_DniWylotow_Flights_FlightId",
                        column: x => x.FlightId,
                        principalTable: "Flights",
                        principalColumn: "FlightId");
                });

            migrationBuilder.CreateTable(
                name: "FlightBuys",
                columns: table => new
                {
                    FlightBuyId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    IloscBiletow = table.Column<int>(type: "int", nullable: false),
                    PriceSuma = table.Column<double>(type: "float", nullable: false),
                    DataZakupu = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FlightId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    TenantId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FlightBuys", x => x.FlightBuyId);
                    table.ForeignKey(
                        name: "FK_FlightBuys_AspNetUsers_TenantId",
                        column: x => x.TenantId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_FlightBuys_Flights_FlightId",
                        column: x => x.FlightId,
                        principalTable: "Flights",
                        principalColumn: "FlightId");
                });

            migrationBuilder.CreateTable(
                name: "KryteriaZnizek",
                columns: table => new
                {
                    KryteriaZnizkiId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FlightBuyId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KryteriaZnizek", x => x.KryteriaZnizkiId);
                    table.ForeignKey(
                        name: "FK_KryteriaZnizek_FlightBuys_FlightBuyId",
                        column: x => x.FlightBuyId,
                        principalTable: "FlightBuys",
                        principalColumn: "FlightBuyId");
                });

            migrationBuilder.CreateTable(
                name: "FlightBuysKryteriaZnizkis",
                columns: table => new
                {
                    FlightBuyId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    KryteriaZnizkiId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FlightBuysKryteriaZnizkis", x => new { x.FlightBuyId, x.KryteriaZnizkiId });
                    table.ForeignKey(
                        name: "FK_FlightBuysKryteriaZnizkis_FlightBuys_FlightBuyId",
                        column: x => x.FlightBuyId,
                        principalTable: "FlightBuys",
                        principalColumn: "FlightBuyId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FlightBuysKryteriaZnizkis_KryteriaZnizek_KryteriaZnizkiId",
                        column: x => x.KryteriaZnizkiId,
                        principalTable: "KryteriaZnizek",
                        principalColumn: "KryteriaZnizkiId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DataUrodzenia", "Email", "EmailConfirmed", "Imie", "LockoutEnabled", "LockoutEnd", "Nazwisko", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TenantKind", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "123f9c8a-4496-4e1b-9dcb-ca5c3cc80f75", 0, "520ae055-028f-4838-8b4b-37f6007f29e0", "22.10.1998 12:12:12", "ImieNazwisko_7@gmail.com", true, "Imie_7", false, null, "Nazwisko_7", "IMIENAZWISKO_7@GMAIL.COM", "IMIENAZWISKO_7@GMAIL.COM", "AQAAAAIAAYagAAAAEJK78Z6r3y90/cPdxkaCjwkQIWU47qYAsk4sdTD1SlZmP7DLuEuOLXVWh8ZBeJKxqg==", null, false, "07b2ce29-5cf7-445e-8ffc-16d5be5dccf3", 0, false, "ImieNazwisko_7@gmail.com" },
                    { "2cb6fc90-12a2-49b1-aeee-712161095eea", 0, "986648da-a913-4bed-9163-5333bd62bcc3", "22.10.1998 12:12:12", "ImieNazwisko_6@gmail.com", true, "Imie_6", false, null, "Nazwisko_6", "IMIENAZWISKO_6@GMAIL.COM", "IMIENAZWISKO_6@GMAIL.COM", "AQAAAAIAAYagAAAAECIND+sWdHKN5JrLWqGXB7aUTlx3sbkbcxJ1QhORoOcBiW8b5VhZ4xLpHuUHlZYe9g==", null, false, "b85f0aed-8bf0-4465-81de-8ccca5935664", 0, false, "ImieNazwisko_6@gmail.com" },
                    { "67965e5f-8df1-4711-93a6-fb6d1dbdf7de", 0, "b1c48a39-7583-486c-8643-bc84902743ce", "22.10.1998 12:12:12", "ImieNazwisko_9@gmail.com", true, "Imie_9", false, null, "Nazwisko_9", "IMIENAZWISKO_9@GMAIL.COM", "IMIENAZWISKO_9@GMAIL.COM", "AQAAAAIAAYagAAAAED7o2rIBOyRwWJ3Am7DASuTFzObp+0iNWvotOxL52NO9WJAxylJe7cZpBugoTgyghA==", null, false, "72cdf20f-dd3b-41cd-97a3-43abf1186c39", 0, false, "ImieNazwisko_9@gmail.com" },
                    { "6f9980e0-3645-4965-a237-8c9b5e3824bd", 0, "9b5d9e04-1f56-48b4-93bd-f70f190bffb0", "22.10.1998 12:12:12", "ImieNazwisko_2@gmail.com", true, "Imie_2", false, null, "Nazwisko_2", "IMIENAZWISKO_2@GMAIL.COM", "IMIENAZWISKO_2@GMAIL.COM", "AQAAAAIAAYagAAAAENzG+nKGfDSu305KO850D3D7tFTUAi+wI76/XU5ns1i18sCtQA26PTJ9o6Y/zCjCDg==", null, false, "4b0a6ef6-283c-4910-a006-e6d23fd43799", 0, false, "ImieNazwisko_2@gmail.com" },
                    { "726206e3-e379-4f35-b454-4c78b9ab0450", 0, "27f7d941-db05-4938-93fa-cf72ac9432fd", "22.10.1998 12:12:12", "ImieNazwisko_5@gmail.com", true, "Imie_5", false, null, "Nazwisko_5", "IMIENAZWISKO_5@GMAIL.COM", "IMIENAZWISKO_5@GMAIL.COM", "AQAAAAIAAYagAAAAEHQtsGCw7QUy/h2/BLPnVNF0CMyWNDlJ2AcYMMGKMdyAzW/eNSN2qOOtn+seD5zIHA==", null, false, "29da015d-7208-4558-83a4-a2419caefba8", 0, false, "ImieNazwisko_5@gmail.com" },
                    { "7c985a76-a1f6-426c-8f11-d6cc989aa9ce", 0, "dd973b33-a50f-4d55-a05a-b29537448032", "22.10.1998 12:12:12", "ImieNazwisko_0@gmail.com", true, "Imie_0", false, null, "Nazwisko_0", "IMIENAZWISKO_0@GMAIL.COM", "IMIENAZWISKO_0@GMAIL.COM", "AQAAAAIAAYagAAAAEBp2HfWa+hwGrzG9K01FuCPw5wqH+Dn53cqoLWP18wriNmgpfuwUUuWDubft1pdtig==", null, false, "611020ac-5fee-40a2-9334-a4ab3c3fa152", 0, false, "ImieNazwisko_0@gmail.com" },
                    { "98258545-9700-4ee8-83e3-f020f586bac0", 0, "4230e3d8-86a8-43fe-b704-40ea1e47f45d", "22.10.1998 12:12:12", "ImieNazwisko_8@gmail.com", true, "Imie_8", false, null, "Nazwisko_8", "IMIENAZWISKO_8@GMAIL.COM", "IMIENAZWISKO_8@GMAIL.COM", "AQAAAAIAAYagAAAAENIuFT4SabXrzZ6tTzWh7A3zO/jb67FgFmRQn+VDWOM5E4Vs0TFzcwR71z4nkIYtag==", null, false, "191f9971-8808-466f-95b8-3ad8c7a2e19c", 0, false, "ImieNazwisko_8@gmail.com" },
                    { "c59a8c3b-f99f-4e57-a166-7a953a02b62f", 0, "37908c09-c6fe-4d8a-a904-2bc4328c5323", "22.10.1998 12:12:12", "ImieNazwisko_4@gmail.com", true, "Imie_4", false, null, "Nazwisko_4", "IMIENAZWISKO_4@GMAIL.COM", "IMIENAZWISKO_4@GMAIL.COM", "AQAAAAIAAYagAAAAELnUtYlZKluTJf4Aa2Q7/ylLkgO82J6cP3yG88FhGSoSpJu6yV1GVljWy/WG2FXGCg==", null, false, "5fb5cfb9-ac17-41bd-bda3-4b2430ec2000", 0, false, "ImieNazwisko_4@gmail.com" },
                    { "dce115bb-e8fc-42eb-8f17-896ee7ebdff6", 0, "2047a458-a48b-4693-bb82-26cbae45b675", "22.10.1998 12:12:12", "admin@admin.pl", true, "Jan", false, null, "Kowalski", "ADMIN@ADMIN.PL", "ADMIN@ADMIN.PL", "AQAAAAIAAYagAAAAEEwEy3NssAli+e99eP8D6/4QRoVGxNYNVOn/sJ8RRW4PQRNo8w4sS4AxHg9RvKZCNw==", null, false, "49572596-007a-47c5-a041-63a97c2a7731", 0, false, "admin@admin.pl" },
                    { "e6c9e8da-d179-4e75-bd2e-07f1c6353d98", 0, "b24a44a8-aa17-4a63-8a07-437defe8eb88", "22.10.1998 12:12:12", "manager@manager.pl", true, "Janina", false, null, "Kowalska", "MANAGER@MANAGER.PL", "MANAGER@MANAGER.PL", "AQAAAAIAAYagAAAAEA4JX1xKIBJOw619dralm29R5FbD47MdLsRD70Qj6KWXS4xdHinyWqlq/DeDmJFYqw==", null, false, "e6fdeac4-f058-4530-b43b-fea1c5b6817d", 0, false, "manager@manager.pl" },
                    { "eddf7e57-6773-4cc4-888c-fff20f782fcb", 0, "a44a778f-5ed1-462d-89b9-ac3ee45909fc", "22.10.1998 12:12:12", "ImieNazwisko_1@gmail.com", true, "Imie_1", false, null, "Nazwisko_1", "IMIENAZWISKO_1@GMAIL.COM", "IMIENAZWISKO_1@GMAIL.COM", "AQAAAAIAAYagAAAAEAQfbMX4OkAxQ2U7n1rY8YUxRSYDnSUc881lRJCI+VMKMWHdvYyrMvDM3e6hplAdVg==", null, false, "79043146-cb10-4dc4-9734-ea68c747e960", 0, false, "ImieNazwisko_1@gmail.com" },
                    { "fb933f31-9716-4d3f-a6e4-15206253145e", 0, "c3282f16-1cce-4359-a30f-2f1aede6c0d7", "22.10.1998 12:12:12", "ImieNazwisko_3@gmail.com", true, "Imie_3", false, null, "Nazwisko_3", "IMIENAZWISKO_3@GMAIL.COM", "IMIENAZWISKO_3@GMAIL.COM", "AQAAAAIAAYagAAAAEOHEldUXPlJpDY/jkB33p5Ws1VETaSs8BXUDwtQBnZJDZSPapvnk4aV/z68Y+jW8/Q==", null, false, "d5cea101-cbea-46ef-b7c8-7d16bd73fa39", 0, false, "ImieNazwisko_3@gmail.com" }
                });

            migrationBuilder.InsertData(
                table: "KryteriaZnizek",
                columns: new[] { "KryteriaZnizkiId", "FlightBuyId", "Name" },
                values: new object[,]
                {
                    { "2ee2e556-254e-4bc6-b546-0b0a74e07120", null, "Urodziny kupującego" },
                    { "497258eb-6f6b-4df0-b544-3e7814be9699", null, "Lot do Afryki" }
                });

            migrationBuilder.InsertData(
                table: "Flights",
                columns: new[] { "FlightId", "DataDodania", "GodzinaWylotu", "Price", "TenantId", "TrasaDo", "TrasaOd" },
                values: new object[,]
                {
                    { "KLM 10018 BCA", "22.10.2024 04:26:00", "2:56", 134.0, "6f9980e0-3645-4965-a237-8c9b5e3824bd", "Afryka", "Horwacja" },
                    { "KLM 10732 BCA", "22.10.2024 04:26:00", "8:55", 172.0, "eddf7e57-6773-4cc4-888c-fff20f782fcb", "USA", "Horwacja" },
                    { "KLM 15602 BCA", "22.10.2024 04:26:00", "3:25", 154.0, "6f9980e0-3645-4965-a237-8c9b5e3824bd", "Afryka", "Chiny" },
                    { "KLM 19500 BCA", "22.10.2024 04:26:00", "16:53", 190.0, "fb933f31-9716-4d3f-a6e4-15206253145e", "USA", "Rosja" },
                    { "KLM 20804 BCA", "22.10.2024 04:26:00", "6:20", 134.0, "2cb6fc90-12a2-49b1-aeee-712161095eea", "Afryka", "Rosja" },
                    { "KLM 25281 BCA", "22.10.2024 04:26:00", "21:7", 126.0, "2cb6fc90-12a2-49b1-aeee-712161095eea", "Londyn", "Horwacja" },
                    { "KLM 28509 BCA", "22.10.2024 04:26:00", "8:25", 135.0, "67965e5f-8df1-4711-93a6-fb6d1dbdf7de", "USA", "Chiny" },
                    { "KLM 32558 BCA", "22.10.2024 04:26:00", "6:34", 136.0, "67965e5f-8df1-4711-93a6-fb6d1dbdf7de", "Londyn", "Horwacja" },
                    { "KLM 35165 BCA", "22.10.2024 04:26:00", "9:31", 181.0, "7c985a76-a1f6-426c-8f11-d6cc989aa9ce", "Londyn", "Horwacja" },
                    { "KLM 37147 BCA", "22.10.2024 04:26:00", "21:45", 158.0, "123f9c8a-4496-4e1b-9dcb-ca5c3cc80f75", "Londyn", "Hiszpania" },
                    { "KLM 38120 BCA", "22.10.2024 04:26:00", "8:51", 113.0, "7c985a76-a1f6-426c-8f11-d6cc989aa9ce", "USA", "Chiny" },
                    { "KLM 38542 BCA", "22.10.2024 04:26:00", "14:22", 171.0, "c59a8c3b-f99f-4e57-a166-7a953a02b62f", "USA", "Chiny" },
                    { "KLM 46927 BCA", "22.10.2024 04:26:00", "20:53", 139.0, "6f9980e0-3645-4965-a237-8c9b5e3824bd", "USA", "Horwacja" },
                    { "KLM 48056 BCA", "22.10.2024 04:26:00", "12:9", 112.0, "726206e3-e379-4f35-b454-4c78b9ab0450", "USA", "Chiny" },
                    { "KLM 48610 BCA", "22.10.2024 04:26:00", "8:29", 138.0, "eddf7e57-6773-4cc4-888c-fff20f782fcb", "Londyn", "Chiny" },
                    { "KLM 49708 BCA", "22.10.2024 04:26:00", "8:54", 177.0, "6f9980e0-3645-4965-a237-8c9b5e3824bd", "USA", "Chiny" },
                    { "KLM 52799 BCA", "22.10.2024 04:26:00", "11:50", 167.0, "c59a8c3b-f99f-4e57-a166-7a953a02b62f", "USA", "Rosja" },
                    { "KLM 60776 BCA", "22.10.2024 04:26:00", "11:33", 103.0, "c59a8c3b-f99f-4e57-a166-7a953a02b62f", "Afryka", "Rosja" },
                    { "KLM 60967 BCA", "22.10.2024 04:26:00", "18:50", 107.0, "98258545-9700-4ee8-83e3-f020f586bac0", "Londyn", "Chiny" },
                    { "KLM 61459 BCA", "22.10.2024 04:26:00", "9:27", 140.0, "98258545-9700-4ee8-83e3-f020f586bac0", "Afryka", "Horwacja" },
                    { "KLM 73425 BCA", "22.10.2024 04:26:00", "13:16", 145.0, "123f9c8a-4496-4e1b-9dcb-ca5c3cc80f75", "USA", "Chiny" },
                    { "KLM 82346 BCA", "22.10.2024 04:26:00", "3:43", 107.0, "eddf7e57-6773-4cc4-888c-fff20f782fcb", "Londyn", "Horwacja" },
                    { "KLM 88139 BCA", "22.10.2024 04:26:00", "1:21", 165.0, "eddf7e57-6773-4cc4-888c-fff20f782fcb", "USA", "Horwacja" },
                    { "KLM 96196 BCA", "22.10.2024 04:26:00", "20:55", 140.0, "67965e5f-8df1-4711-93a6-fb6d1dbdf7de", "Londyn", "Horwacja" },
                    { "KLM 98909 BCA", "22.10.2024 04:26:00", "19:51", 127.0, "7c985a76-a1f6-426c-8f11-d6cc989aa9ce", "Londyn", "Hiszpania" }
                });

            migrationBuilder.InsertData(
                table: "DniWylotow",
                columns: new[] { "DzieWylotuId", "Dzien", "FlightId" },
                values: new object[,]
                {
                    { "01636c0c-256c-45c0-8f71-23f1d05bf365", "Poniedziałek", "KLM 98909 BCA" },
                    { "02ff9820-9e40-4f97-bd23-2327b103ed7a", "Wtorek", "KLM 88139 BCA" },
                    { "0437512d-95e8-4ab4-a33d-9a5311f592f8", "Sobota", "KLM 37147 BCA" },
                    { "080d13cf-d475-4160-b0ab-3b26f3711ad9", "Piątek", "KLM 61459 BCA" },
                    { "084b1839-2f30-465b-9c6b-5e9d4f634c03", "Piątek", "KLM 37147 BCA" },
                    { "10dba906-eba0-49c2-9254-243a7c88b7f5", "Sobota", "KLM 73425 BCA" },
                    { "12aa4e4d-1e67-4ee5-a4b5-e44693d4a483", "Piątek", "KLM 35165 BCA" },
                    { "17c39ca8-fe21-4996-8a9c-a949c0bb7ef9", "Środa", "KLM 15602 BCA" },
                    { "198c7afa-719b-4f3b-9537-fd15b5e1fc57", "Środa", "KLM 32558 BCA" },
                    { "1a36b2ce-359f-41bd-b99a-0921c348534e", "Środa", "KLM 52799 BCA" },
                    { "2c745425-1500-4b52-8d60-c877ebb52a78", "Środa", "KLM 73425 BCA" },
                    { "2dc6ed16-b1ac-4536-a832-fd93a839d2bf", "Środa", "KLM 32558 BCA" },
                    { "33132add-a023-4511-9c64-bf8aad3eb6e5", "Czwartek", "KLM 60776 BCA" },
                    { "3725d787-dbd0-491a-b7ea-8a1122ec26d6", "Czwartek", "KLM 46927 BCA" },
                    { "374ec421-5dbd-43f7-ab49-c2d3e30e0981", "Wtorek", "KLM 82346 BCA" },
                    { "387e979a-150c-4622-a933-e3f1e24d092d", "Czwartek", "KLM 10018 BCA" },
                    { "3b8a53fa-a65e-493b-b0d8-a1fd96250b82", "Wtorek", "KLM 98909 BCA" },
                    { "42c4b0d1-e711-4c7b-8360-751a24a46575", "Sobota", "KLM 49708 BCA" },
                    { "5249062b-13b0-4e46-87b7-3be45d622261", "Piątek", "KLM 35165 BCA" },
                    { "5845395b-5769-49ea-a3ed-0ccb3cb2b718", "Sobota", "KLM 10018 BCA" },
                    { "5af8e11c-b40c-422e-90d4-75d7b1bae117", "Środa", "KLM 48610 BCA" },
                    { "62e6fc2d-b500-4fba-8000-ca3c048da91b", "Środa", "KLM 60967 BCA" },
                    { "63cf9a82-e728-4245-9af4-8a51bbc36b29", "Poniedziałek", "KLM 52799 BCA" },
                    { "65abd746-1754-46ba-9f2e-1bb1a182cf31", "Poniedziałek", "KLM 48056 BCA" },
                    { "785c0718-16d5-447c-9322-541d2c3417bb", "Wtorek", "KLM 60967 BCA" },
                    { "7dc05fc0-1a08-4194-909e-7d90d9716acd", "Czwartek", "KLM 38542 BCA" },
                    { "86221cba-bff5-4e60-93c3-0b6afb44fff6", "Środa", "KLM 15602 BCA" },
                    { "91a194d8-2d46-4e25-a496-81678009f92f", "Czwartek", "KLM 25281 BCA" },
                    { "96a5aff8-27fa-41c2-9bb8-7c011bf2e5db", "Piątek", "KLM 48610 BCA" },
                    { "a9e2d8bd-7c02-4d15-9ebc-1d67828731ff", "Piątek", "KLM 96196 BCA" },
                    { "aca57ddc-adb5-4a4b-b52f-82840ae301b2", "Sobota", "KLM 19500 BCA" },
                    { "b7b61857-ceb6-46ba-ac9d-24c3132a011f", "Piątek", "KLM 28509 BCA" },
                    { "baeff050-87e2-4020-812f-f3cab5cd545c", "Poniedziałek", "KLM 38120 BCA" },
                    { "be53a751-3bfa-4636-ae11-4cdc7a2025fb", "Czwartek", "KLM 60776 BCA" },
                    { "c0481e83-0854-460c-ab9c-1e614d434721", "Czwartek", "KLM 20804 BCA" },
                    { "c320a3bb-9999-4585-823f-ba08f725d7a2", "Poniedziałek", "KLM 38120 BCA" },
                    { "cb60f0f7-8010-4f06-bf78-8c2152726310", "Środa", "KLM 48056 BCA" },
                    { "cdb652c5-63ad-43a6-99ea-9414b32f71c2", "Środa", "KLM 10732 BCA" },
                    { "cee15194-799d-48e7-8524-8021991fc6d4", "Poniedziałek", "KLM 96196 BCA" },
                    { "d36241a7-d573-40fd-b658-f7af380cdd69", "Czwartek", "KLM 46927 BCA" },
                    { "d4e456a8-babc-46e5-b22e-c6549d38cd17", "Poniedziałek", "KLM 20804 BCA" },
                    { "d5a11206-112a-4a25-8474-d52eb9c49711", "Wtorek", "KLM 19500 BCA" },
                    { "e4bb26ce-cebb-4564-b42a-4e6e090cae33", "Sobota", "KLM 88139 BCA" },
                    { "e89711bc-ac08-4131-ba5f-1ee3d4e72230", "Poniedziałek", "KLM 61459 BCA" },
                    { "ea5af771-9d57-47d7-a260-9d9172406824", "Poniedziałek", "KLM 25281 BCA" },
                    { "eb9b5bfc-1fda-4c09-b545-d99071feb520", "Środa", "KLM 49708 BCA" },
                    { "ee2662a0-d568-4b1c-8ea3-00c62abbabbb", "Poniedziałek", "KLM 82346 BCA" },
                    { "f6e224a3-0a61-493a-bf71-85c4227569ce", "Poniedziałek", "KLM 38542 BCA" },
                    { "faacff0a-baa8-45d9-bea8-7d8040b382c2", "Poniedziałek", "KLM 28509 BCA" },
                    { "fedb4394-74b1-4f17-9c64-dcd10fba5510", "Środa", "KLM 10732 BCA" }
                });

            migrationBuilder.InsertData(
                table: "FlightBuys",
                columns: new[] { "FlightBuyId", "DataZakupu", "FlightId", "IloscBiletow", "PriceSuma", "TenantId" },
                values: new object[,]
                {
                    { "02c1cb30-b262-4afa-baf6-35a4fe7bd6bc", "22.10.2024 04:26:00", "KLM 60776 BCA", 1, 125.0, "123f9c8a-4496-4e1b-9dcb-ca5c3cc80f75" },
                    { "0e969e68-fbe0-450e-969c-352b73324ae9", "22.10.2024 04:26:00", "KLM 88139 BCA", 1, 125.0, "eddf7e57-6773-4cc4-888c-fff20f782fcb" },
                    { "294338d5-6950-4dcf-b3ab-b01f23f93cb0", "22.10.2024 04:26:00", "KLM 20804 BCA", 1, 125.0, "726206e3-e379-4f35-b454-4c78b9ab0450" },
                    { "5bdd3748-7506-4f76-bf49-d740e9b3dde7", "22.10.2024 04:26:00", "KLM 98909 BCA", 1, 125.0, "123f9c8a-4496-4e1b-9dcb-ca5c3cc80f75" },
                    { "61cbad08-d1d6-4b68-9f75-4e07c910d2be", "22.10.2024 04:26:00", "KLM 28509 BCA", 1, 125.0, "2cb6fc90-12a2-49b1-aeee-712161095eea" },
                    { "c621ad8a-1299-4475-b603-641fc6376190", "22.10.2024 04:26:00", "KLM 10018 BCA", 1, 125.0, "7c985a76-a1f6-426c-8f11-d6cc989aa9ce" },
                    { "c9c33b7a-b46e-43e1-9e4e-06af6602d5a9", "22.10.2024 04:26:00", "KLM 10732 BCA", 1, 125.0, "123f9c8a-4496-4e1b-9dcb-ca5c3cc80f75" },
                    { "db81ee59-94cd-4f34-81a2-44101ffa4bb4", "22.10.2024 04:26:00", "KLM 38542 BCA", 1, 125.0, "6f9980e0-3645-4965-a237-8c9b5e3824bd" },
                    { "e9388170-0835-434c-bb52-b52e721a0dcd", "22.10.2024 04:26:00", "KLM 25281 BCA", 1, 125.0, "6f9980e0-3645-4965-a237-8c9b5e3824bd" },
                    { "fab8a91e-ef3d-488a-a3ca-81e7392f1d17", "22.10.2024 04:26:00", "KLM 10732 BCA", 1, 125.0, "726206e3-e379-4f35-b454-4c78b9ab0450" }
                });

            migrationBuilder.InsertData(
                table: "FlightBuysKryteriaZnizkis",
                columns: new[] { "FlightBuyId", "KryteriaZnizkiId" },
                values: new object[,]
                {
                    { "02c1cb30-b262-4afa-baf6-35a4fe7bd6bc", "2ee2e556-254e-4bc6-b546-0b0a74e07120" },
                    { "294338d5-6950-4dcf-b3ab-b01f23f93cb0", "2ee2e556-254e-4bc6-b546-0b0a74e07120" },
                    { "db81ee59-94cd-4f34-81a2-44101ffa4bb4", "2ee2e556-254e-4bc6-b546-0b0a74e07120" },
                    { "e9388170-0835-434c-bb52-b52e721a0dcd", "2ee2e556-254e-4bc6-b546-0b0a74e07120" },
                    { "fab8a91e-ef3d-488a-a3ca-81e7392f1d17", "497258eb-6f6b-4df0-b544-3e7814be9699" }
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

            migrationBuilder.CreateIndex(
                name: "IX_DniWylotow_FlightId",
                table: "DniWylotow",
                column: "FlightId");

            migrationBuilder.CreateIndex(
                name: "IX_FlightBuys_FlightId",
                table: "FlightBuys",
                column: "FlightId");

            migrationBuilder.CreateIndex(
                name: "IX_FlightBuys_TenantId",
                table: "FlightBuys",
                column: "TenantId");

            migrationBuilder.CreateIndex(
                name: "IX_FlightBuysKryteriaZnizkis_KryteriaZnizkiId",
                table: "FlightBuysKryteriaZnizkis",
                column: "KryteriaZnizkiId");

            migrationBuilder.CreateIndex(
                name: "IX_Flights_TenantId",
                table: "Flights",
                column: "TenantId");

            migrationBuilder.CreateIndex(
                name: "IX_KryteriaZnizek_FlightBuyId",
                table: "KryteriaZnizek",
                column: "FlightBuyId");
        }

        /// <inheritdoc />
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
                name: "DniWylotow");

            migrationBuilder.DropTable(
                name: "FlightBuysKryteriaZnizkis");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "KryteriaZnizek");

            migrationBuilder.DropTable(
                name: "FlightBuys");

            migrationBuilder.DropTable(
                name: "Flights");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
