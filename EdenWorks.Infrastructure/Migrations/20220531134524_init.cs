using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EdenWorks.Infrastructure.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
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
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedIpAddress = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    CreatedMachineName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedIpAddress = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    UpdatedMachineName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedIpAddress = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    DeletedMachineName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
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
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedIpAddress = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    CreatedMachineName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedIpAddress = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    UpdatedMachineName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedIpAddress = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    DeletedMachineName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<int>(type: "int", nullable: false),
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
                    UserId = table.Column<int>(type: "int", nullable: false),
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
                    UserId = table.Column<int>(type: "int", nullable: false)
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
                    UserId = table.Column<int>(type: "int", nullable: false),
                    RoleId = table.Column<int>(type: "int", nullable: false)
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
                    UserId = table.Column<int>(type: "int", nullable: false),
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

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18,1)", precision: 18, scale: 1, nullable: false),
                    ImagePath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedIpAddress = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    CreatedMachineName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedIpAddress = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    UpdatedMachineName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedIpAddress = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    DeletedMachineName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CreatedDate", "CreatedIpAddress", "CreatedMachineName", "DeletedDate", "DeletedIpAddress", "DeletedMachineName", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "Status", "TwoFactorEnabled", "UpdatedDate", "UpdatedIpAddress", "UpdatedMachineName", "UserName" },
                values: new object[] { 9, 0, "4717874c-5334-4464-afdf-8599b8732ab8", new DateTime(2022, 5, 31, 16, 45, 23, 914, DateTimeKind.Local).AddTicks(6641), "192.168.1.241", "DESKTOP-SCCLTAH", null, null, null, "admin@gmail.com", false, false, null, null, "ADMIN", "AQAAAAEAACcQAAAAEO50A63NXZzBeoiT4LmBlD8JJF/aINhAMgLGYoJXZDfpjv030ACstRlPXf5lNg4vXQ==", null, false, "b21d2971-26e6-4544-b641-f3ad74574c79", 1, false, null, null, null, "admin" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CategoryName", "CreatedDate", "CreatedIpAddress", "CreatedMachineName", "DeletedDate", "DeletedIpAddress", "DeletedMachineName", "Status", "UpdatedDate", "UpdatedIpAddress", "UpdatedMachineName" },
                values: new object[,]
                {
                    { 1, "SALATALAR / SALADS", new DateTime(2022, 5, 31, 16, 45, 23, 915, DateTimeKind.Local).AddTicks(948), "192.168.1.241", "DESKTOP-SCCLTAH", null, null, null, 1, null, null, null },
                    { 2, "APERATİFLER / SNACKS", new DateTime(2022, 5, 31, 16, 45, 23, 915, DateTimeKind.Local).AddTicks(2979), "192.168.1.241", "DESKTOP-SCCLTAH", null, null, null, 1, null, null, null },
                    { 3, "TOSTLAR / TOASTS", new DateTime(2022, 5, 31, 16, 45, 23, 915, DateTimeKind.Local).AddTicks(4803), "192.168.1.241", "DESKTOP-SCCLTAH", null, null, null, 1, null, null, null },
                    { 4, "BURGERLER / BURGERS", new DateTime(2022, 5, 31, 16, 45, 23, 915, DateTimeKind.Local).AddTicks(6597), "192.168.1.241", "DESKTOP-SCCLTAH", null, null, null, 1, null, null, null },
                    { 5, "PİDELER / PIDES", new DateTime(2022, 5, 31, 16, 45, 23, 915, DateTimeKind.Local).AddTicks(8377), "192.168.1.241", "DESKTOP-SCCLTAH", null, null, null, 1, null, null, null },
                    { 6, "PİZZALAR / PIZZAS", new DateTime(2022, 5, 31, 16, 45, 23, 916, DateTimeKind.Local).AddTicks(125), "192.168.1.241", "DESKTOP-SCCLTAH", null, null, null, 1, null, null, null },
                    { 7, "QUESADILLAS & WRAPS", new DateTime(2022, 5, 31, 16, 45, 23, 916, DateTimeKind.Local).AddTicks(1878), "192.168.1.241", "DESKTOP-SCCLTAH", null, null, null, 1, null, null, null },
                    { 8, "MEZELER / MEZZES", new DateTime(2022, 5, 31, 16, 45, 23, 916, DateTimeKind.Local).AddTicks(3664), "192.168.1.241", "DESKTOP-SCCLTAH", null, null, null, 1, null, null, null },
                    { 9, "IZGARALAR / GRILLS", new DateTime(2022, 5, 31, 16, 45, 23, 916, DateTimeKind.Local).AddTicks(7225), "192.168.1.241", "DESKTOP-SCCLTAH", null, null, null, 1, null, null, null },
                    { 10, "MAKARNALAR / PASTAS", new DateTime(2022, 5, 31, 16, 45, 23, 917, DateTimeKind.Local).AddTicks(2), "192.168.1.241", "DESKTOP-SCCLTAH", null, null, null, 1, null, null, null },
                    { 11, "KAHVELER / COFFEES", new DateTime(2022, 5, 31, 16, 45, 23, 917, DateTimeKind.Local).AddTicks(4333), "192.168.1.241", "DESKTOP-SCCLTAH", null, null, null, 1, null, null, null },
                    { 12, "SOFT DRINKS", new DateTime(2022, 5, 31, 16, 45, 23, 917, DateTimeKind.Local).AddTicks(7461), "192.168.1.241", "DESKTOP-SCCLTAH", null, null, null, 1, null, null, null },
                    { 13, "BİRALAR / BEERS", new DateTime(2022, 5, 31, 16, 45, 23, 918, DateTimeKind.Local).AddTicks(3182), "192.168.1.241", "DESKTOP-SCCLTAH", null, null, null, 1, null, null, null },
                    { 14, "RAKILAR / RAKI", new DateTime(2022, 5, 31, 16, 45, 23, 918, DateTimeKind.Local).AddTicks(5388), "192.168.1.241", "DESKTOP-SCCLTAH", null, null, null, 1, null, null, null },
                    { 15, "ŞARAPLAR / VINES", new DateTime(2022, 5, 31, 16, 45, 23, 918, DateTimeKind.Local).AddTicks(7422), "192.168.1.241", "DESKTOP-SCCLTAH", null, null, null, 1, null, null, null },
                    { 16, "DİĞER İÇKİLER / HARD LIQUORS", new DateTime(2022, 5, 31, 16, 45, 23, 918, DateTimeKind.Local).AddTicks(9315), "192.168.1.241", "DESKTOP-SCCLTAH", null, null, null, 1, null, null, null }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "CreatedDate", "CreatedIpAddress", "CreatedMachineName", "DeletedDate", "DeletedIpAddress", "DeletedMachineName", "Description", "ImagePath", "Name", "Price", "Status", "UpdatedDate", "UpdatedIpAddress", "UpdatedMachineName" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2022, 5, 31, 16, 45, 23, 919, DateTimeKind.Local).AddTicks(1756), "192.168.1.241", "DESKTOP-SCCLTAH", null, null, null, "Kırmızı lahana, havuç, yeşil zeytin, mısır, cherry domates ve taze mevsim yeşillikleri ile servis edilir. / Contains red cabbage, carrot, green olive, corn, tomato and seasonal fresh ingredients.", "/image/products/8c600f0b-ea06-4880-9f05-f419c32c3b94.jpg", "Akdeniz Salatası / Mediterranean Salad", 35m, 1, null, null, null },
                    { 2, 1, new DateTime(2022, 5, 31, 16, 45, 23, 919, DateTimeKind.Local).AddTicks(3618), "192.168.1.241", "DESKTOP-SCCLTAH", null, null, null, "Izg. tavuk, domates, salatalık, kornişon turşu ve karışık taze yeşillik ile servis edilir. / Contains grilled chicken, tomato, cucumber, pickle and seasonal fresh ingredients.", "/image/products/fe52f4fa-966f-4fb3-a206-025aa2ab1802.jpg", "Izg. Tavuk Salata / Grilled Chicken Salad ", 35m, 1, null, null, null },
                    { 3, 1, new DateTime(2022, 5, 31, 16, 45, 23, 919, DateTimeKind.Local).AddTicks(5568), "192.168.1.241", "DESKTOP-SCCLTAH", null, null, null, "Ton balığı, dilim siyah zeytin, dilim yeşil zeytin, mısır, domates, salatalık, soğan, kornişon turşu ve karışk taze yeşillikler ile servis edilir / Contains tuna, black and green olive, corn, tomato, cucumber, onion, pickle and seasonal fresh ingredients.", "/image/products/fe73ccae-b72d-48e3-a988-34603c2f05f1.jpg", "Ton Balıkh Salata / Tuna Salad ", 40m, 1, null, null, null },
                    { 4, 1, new DateTime(2022, 5, 31, 16, 45, 23, 919, DateTimeKind.Local).AddTicks(7417), "192.168.1.241", "DESKTOP-SCCLTAH", null, null, null, "Izgarada kızartılmış hellim peyniri, domates, salatalık, yeşil biber ve karışık taze yeşillikler ile servis edilir / Contains grilled halomi cheese, tomato, cucumber, green pepper and seasonal fresh ingredients.", null, "Izg. Hellim Salata / Grilled Halloumi Salad ", 40m, 1, null, null, null },
                    { 5, 2, new DateTime(2022, 5, 31, 16, 45, 23, 919, DateTimeKind.Local).AddTicks(9197), "192.168.1.241", "DESKTOP-SCCLTAH", null, null, null, "Patates, Patlıcan, papya Biber, Kavrulmuş kuru acı biber ve Şanmsaklı süzme yoğurt ile servis edilir / Contains Fried potato, eggplant, capia pepper, hot dry pepper and yoghurt with garlic.", null, "Yoğurtlu Kızartma / Fried food with yoghurt ", 30m, 1, null, null, null },
                    { 6, 2, new DateTime(2022, 5, 31, 16, 45, 23, 931, DateTimeKind.Local).AddTicks(3564), "192.168.1.241", "DESKTOP-SCCLTAH", null, null, null, "Parmak dilim patates, sosis, soğan halkaları kizartılarak servis edilir / Roasting Of potato, sausage and onion rings.", "/image/products/4c2050a8-a31f-4a4e-b4fd-796903a5c0aa.jpg", "Bira Tabağı / Beer Plate ", 35m, 1, null, null, null },
                    { 7, 2, new DateTime(2022, 5, 31, 16, 45, 23, 931, DateTimeKind.Local).AddTicks(6821), "192.168.1.241", "DESKTOP-SCCLTAH", null, null, null, "200 Gr tavuk göğsü içinde, jambon içerisine sarılmış tel peynir ile galeta ununda kızartılarak, patates kızartması ile servis edilir / Contains 200Gr chickhen breast and beef jam rolled up with cheese inside of it, fried in oil with french fries.", "/image/products/dba35200-a1eb-4cfd-8a37-f7ed4739fb17.jpg", "Cordon Bleu", 40m, 1, null, null, null },
                    { 8, 2, new DateTime(2022, 5, 31, 16, 45, 23, 931, DateTimeKind.Local).AddTicks(8772), "192.168.1.241", "DESKTOP-SCCLTAH", null, null, null, "Balık fileto, karides, mantar, kaşar peyniri, sarımsak, maydanoz, galeta unu ve baharatlar ile servis edilir / Contains fillet fish, shrimp, mushroom, cheese, garlic, parsley, bread crumbs with spices.", null, "Balık Köftesi / Fish Balls", 40m, 1, null, null, null },
                    { 9, 2, new DateTime(2022, 5, 31, 16, 45, 23, 932, DateTimeKind.Local).AddTicks(652), "192.168.1.241", "DESKTOP-SCCLTAH", null, null, null, "Galeta ununda kızartılmış Mezgit fileto, ev yapımı kızartılmış patates ile servis edilir / Contains fried North Atlantic whiting with french fries.", null, "Fish and Chips", 45m, 1, null, null, null },
                    { 10, 3, new DateTime(2022, 5, 31, 16, 45, 23, 932, DateTimeKind.Local).AddTicks(2475), "192.168.1.241", "DESKTOP-SCCLTAH", null, null, null, "Kepek ekmeğinde kaşar pey. ve köz. domates yanında yeşil ve siyah zeytin ile servis edilir / Contains cheese and tomato inside of bran bread with green and black olive.", null, "Kepek Ekmeğinde Tost / Bran Bread Toast", 25m, 1, null, null, null },
                    { 11, 3, new DateTime(2022, 5, 31, 16, 45, 23, 932, DateTimeKind.Local).AddTicks(4260), "192.168.1.241", "DESKTOP-SCCLTAH", null, null, null, "Bazlama ekmeğinde kasap syucuğu ve Kaşar peyniri yanında patates kızartması ile servis edilir / Contains sausage with cheese with french fries.", "/image/products/b67b0113-550f-4223-8c0f-038558e80b93.jpg", "Kasap Sucuklu Kaşarlı Tost / Toast with sausage and cheese", 35m, 1, null, null, null },
                    { 12, 3, new DateTime(2022, 5, 31, 16, 45, 23, 932, DateTimeKind.Local).AddTicks(6058), "192.168.1.241", "DESKTOP-SCCLTAH", null, null, null, "Bazlama ekmeğinde Ezine Peyniri, Kaşar peyniri, İzmir tulum ve Tel peyniri yanında patates kızartması ile servis edilir / Contains mixture of 4 different type of cheese with french fries.", "/image/products/6f601cc6-7b59-4f21-a3e5-fd20d8cbb77d.jpg", "4 Peynirli Tost / Mix of  Cheese Toast", 35m, 1, null, null, null },
                    { 13, 3, new DateTime(2022, 5, 31, 16, 45, 23, 932, DateTimeKind.Local).AddTicks(7818), "192.168.1.241", "DESKTOP-SCCLTAH", null, null, null, "Bazlama ekmeğinde kaşar peyniri, tel peyniri, kasap sucuğu, közlenmiş domates, biber ve turşu yanında patates kızartması ile servis edilir / Contains sausage, cheese, roasted tomato, pepper and pickle with french fries.", null, "Karışık Tost / Mixed Toast", 40m, 1, null, null, null },
                    { 14, 4, new DateTime(2022, 5, 31, 16, 45, 23, 932, DateTimeKind.Local).AddTicks(9552), "192.168.1.241", "DESKTOP-SCCLTAH", null, null, null, "180 gr ev yapımı köfte, karamelize soğan, közlenmiş domates, barbekü sos, turşu ve patates kızartması ile servis edilir / Contains 180 gr handmate meatball, caramelized onion, roasted tomato, barbeque sauce and pickle with french fries.", "/image/products/f2e14afe-5c91-4ec5-a9a5-a718c26b4552.jpg", "Kasap Burger / Hamburger", 40m, 1, null, null, null },
                    { 15, 4, new DateTime(2022, 5, 31, 16, 45, 23, 933, DateTimeKind.Local).AddTicks(1282), "192.168.1.241", "DESKTOP-SCCLTAH", null, null, null, "180 gr ev yapımı köfte, karamelize soğan, közlenmiş domates, turşu, barbekü sos, cheddar peynir ve patates kızartması ile servis edilir / Contains 180 gr handmade meatball, caramelized onion, roasted tomato, barbeque sauce, chedddar and pickle with french fries.", "/image/products/cf32dddf-5237-40df-9978-abda40b777b1.jpg", "Cheese Burger", 45m, 1, null, null, null },
                    { 16, 5, new DateTime(2022, 5, 31, 16, 45, 23, 933, DateTimeKind.Local).AddTicks(3016), "192.168.1.241", "DESKTOP-SCCLTAH", null, null, null, "İnce hamur, dana kıyma, mevsim yeşillikleri eklenerek servis edilir / Contains thin pide dough, mince, with seasonal fresh ingredients.", null, "Lahmacun", 20m, 1, null, null, null },
                    { 17, 5, new DateTime(2022, 5, 31, 16, 45, 23, 933, DateTimeKind.Local).AddTicks(4735), "192.168.1.241", "DESKTOP-SCCLTAH", null, null, null, "İnce pide hamuru, İzmir tulum, Kaşar, Ezine ve Tel peyniri ile servis edilir / Contains thin pide dough, 4 different type of cheese.", null, "4 Peynirli Pide / Mix of 4 Cheese Pide", 33m, 1, null, null, null },
                    { 18, 5, new DateTime(2022, 5, 31, 16, 45, 23, 943, DateTimeKind.Local).AddTicks(3250), "192.168.1.241", "DESKTOP-SCCLTAH", null, null, null, "İnce pide hamuru, dana kıyma, mevsim yeşillikleri eklenerek servis edilir / Contains thin pide dough, mince with seasonal fresh ingredients.", "/image/products/b7fab8d0-aed8-4826-9eff-19548f0fc524.jpg", "Kıymalı Pide / Minced Pide", 35m, 1, null, null, null },
                    { 19, 5, new DateTime(2022, 5, 31, 16, 45, 23, 943, DateTimeKind.Local).AddTicks(5693), "192.168.1.241", "DESKTOP-SCCLTAH", null, null, null, "İnce pide hamuru, kasap sucuk ve kaşar peyniri ile servis edilir / Contains thin pide dough, fermented sausage with cheese.", "/image/products/9eeca60a-918a-4195-ac9c-f9b8fd4080ee.jpg", "Kasap Sucuklu Kaşarlı Pide / Sausage Pide with Cheese", 37m, 1, null, null, null },
                    { 20, 5, new DateTime(2022, 5, 31, 16, 45, 23, 943, DateTimeKind.Local).AddTicks(7676), "192.168.1.241", "DESKTOP-SCCLTAH", null, null, null, "Pide Hamuru, Dana kuşbaşı ve Kaşar peyniri ile servis edilir / Contains thin pide dough, meat with cheese.", "/image/products/22aca5b5-2c90-491b-a3fb-c1cf023ced97.jpg", "Kuşbaşılı Kaşarlı Pide / Pide with meat and cheese", 40m, 1, null, null, null },
                    { 21, 6, new DateTime(2022, 5, 31, 16, 45, 23, 944, DateTimeKind.Local).AddTicks(180), "192.168.1.241", "DESKTOP-SCCLTAH", null, null, null, "Pizza hamuru, Mozzarella peyniri, domates, siyah zeytin, mantar, mısır ile servis edilir / Pizza dough contains Mozzarella , tomato, black olive, mushroom and corn.", null, "Vejeteryan Pizza / Vegetarian Pizza", 30m, 1, null, null, null },
                    { 22, 6, new DateTime(2022, 5, 31, 16, 45, 23, 944, DateTimeKind.Local).AddTicks(9784), "192.168.1.241", "DESKTOP-SCCLTAH", null, null, null, "Pizza hamuru, Mozzarella peyniri, ton balığı, siyah zeytin, yeşil zeytin, mısır ve kekik ile servis edilir / Pizza dough contains Mozzarella, tuna, black and green olive, corn with thyme.", null, "Ton Balıklı Pizza / Tuna Fish Pizza", 40m, 1, null, null, null },
                    { 23, 6, new DateTime(2022, 5, 31, 16, 45, 23, 945, DateTimeKind.Local).AddTicks(2460), "192.168.1.241", "DESKTOP-SCCLTAH", null, null, null, "Pizza hamuru, Mozzarella peyniri, kasap sucuk, sosis, domates,mısır, siyah zeytin, yeşil zeytin ve mantar ile servis edilir / Pizza dough contains Mozzarella, corn, tomato, black olive, green olive and mushroom.", "/image/products/bb0f9322-e90e-4e47-b5bf-4dc759904031.jpg", "Eden Special Pizza", 45m, 1, null, null, null },
                    { 24, 7, new DateTime(2022, 5, 31, 16, 45, 23, 945, DateTimeKind.Local).AddTicks(4419), "192.168.1.241", "DESKTOP-SCCLTAH", null, null, null, "Tortilla ekmeği, tavuk eti, yeşil biber, kırmızı biber, domates, soğan, peynir, baharatlar ve cips ile servis edilir / Contains tortilla bread, beef, green pepper, red pepper, tomato, onion, cheese, species and french fries.", "/image/products/ae81fa43-5564-461f-aa04-367eca9759c8.jpg", "Tavuklu / Chicken Quesadilla & Wrap", 30m, 1, null, null, null },
                    { 25, 7, new DateTime(2022, 5, 31, 16, 45, 23, 945, DateTimeKind.Local).AddTicks(6860), "192.168.1.241", "DESKTOP-SCCLTAH", null, null, null, "Tortilla ekmeği, dana eti, yeşil biber, kırmızı biber, domates, soğan, peynir, baharatlar ve cips ile servis edilir / Contains tortilla bread, beef, green pepper, red pepper, tomato, onion, cheese, species and french fries.", "/image/products/0c6cc40a-749c-464c-b5e5-1c17f6ded018.jpg", "Etli / Beef Quesadilla & Wrap", 35m, 1, null, null, null },
                    { 26, 7, new DateTime(2022, 5, 31, 16, 45, 23, 945, DateTimeKind.Local).AddTicks(8730), "192.168.1.241", "DESKTOP-SCCLTAH", null, null, null, "Tortilla ekmeği, balık, yeşil biber, kırmızı biber, domates, soğan, peynir, baharatlar, limon ve cips ile servis edilir / Contains tortilla bread, beef, green pepper, red pepper, tomato, onion, cheese, spices, lemoın and french fries", null, "Balıklı / Fish Quesadilla", 40m, 1, null, null, null },
                    { 27, 8, new DateTime(2022, 5, 31, 16, 45, 23, 946, DateTimeKind.Local).AddTicks(523), "192.168.1.241", "DESKTOP-SCCLTAH", null, null, null, "Ezine peyniri, ceviz içi, sarımsak, sızma zeytinyağı, maydanoz, kekik ve pul biber ile servis edilir / Contains Ezine cheese, walnut, garlic, olive oil, parsley, thyme and chili pepper.", "/image/products/d266ef17-93b4-4d23-92c4-60c7ddec3758.jpg", "Girit Ezmesi / Crete Paste ", 20m, 1, null, null, null },
                    { 28, 8, new DateTime(2022, 5, 31, 16, 45, 23, 946, DateTimeKind.Local).AddTicks(2331), "192.168.1.241", "DESKTOP-SCCLTAH", null, null, null, "Tereyağında kavrulmuş acı kuru biber, pul biber, süzme yoğurt ile servis edilir / contains roasted hot dry pepper in butter, chili pepper and yoghurt.", "/image/products/5346297c-d9c2-45ed-8bd7-d85d01e6a4d7.jpg", "Atom", 20m, 1, null, null, null },
                    { 29, 8, new DateTime(2022, 5, 31, 16, 45, 23, 946, DateTimeKind.Local).AddTicks(4137), "192.168.1.241", "DESKTOP-SCCLTAH", null, null, null, "Közlenmiş patlıcan, süzme yoğurt, sarımsak ve zeytinyağı ile servis edilir / Contains roasted eggplant, yoghurt, garlic and olive oil.", null, "Yoğurtlu Közlenmiş Patlıcan (Köpoğlu) / Eggplant Salad", 30m, 1, null, null, null },
                    { 30, 8, new DateTime(2022, 5, 31, 16, 45, 23, 946, DateTimeKind.Local).AddTicks(6397), "192.168.1.241", "DESKTOP-SCCLTAH", null, null, null, "Ezine peyniri, tel peyniri, közlenmiş hellim peyniri, tulum peyniri, domates ve roka ile servis edilir / Contains mixture of 4 different type of cheese served with rocket.", "/image/products/7d091183-18e4-4951-9a2e-25e6ba56193d.jpg", "Peynir Tabağı / Cheese Plate", 30m, 1, null, null, null },
                    { 31, 8, new DateTime(2022, 5, 31, 16, 45, 23, 946, DateTimeKind.Local).AddTicks(8168), "192.168.1.241", "DESKTOP-SCCLTAH", null, null, null, "Karides, sivri biber, tereyağ, sarımsak, domates, mantar, kaşar peyniri, tuz ve kekik ile servis edilir / Contains shrimp, pointed pepper, butter, garlic, tomato, mushroom, cheese, salt and thyme", null, "Karides Güveç / Shrimp Stew", 40m, 1, null, null, null },
                    { 32, 8, new DateTime(2022, 5, 31, 16, 45, 23, 946, DateTimeKind.Local).AddTicks(9966), "192.168.1.241", "DESKTOP-SCCLTAH", null, null, null, "Özel ununda kızartılmış Kalamar, sos, limon ve roka ile servis edilir / Contains Fried Calamari, served with special sauce, lemon and arugula.", null, "Kalamar Tava / Fried Calamari", 40m, 1, null, null, null },
                    { 33, 9, new DateTime(2022, 5, 31, 16, 45, 23, 947, DateTimeKind.Local).AddTicks(1734), "192.168.1.241", "DESKTOP-SCCLTAH", null, null, null, "Marine edilmiş kemiksiz tavuk but, közlenmiş domates, barbekü sosu ve patates kızartması ile servis edilir / Contains marinated chicked, roasted tomato with barbeque sauce and french fries.", null, "Barbekü Soslu Tavuk Izgara / Grilled Chicken with Barbecue Souce", 35m, 1, null, null, null },
                    { 34, 9, new DateTime(2022, 5, 31, 16, 45, 23, 947, DateTimeKind.Local).AddTicks(3483), "192.168.1.241", "DESKTOP-SCCLTAH", null, null, null, "200 gr. ev yapımı köfte, közlenmiş domates, biber, karamelize soğan ve patates kızartması ile servis edilir / Contains 200 gr handmade meatballs, roasted tomato, pepper, caramelized onion with french fries.", null, "Izgara Kasap Köfte / Grilled Meatballs", 40m, 1, null, null, null },
                    { 35, 9, new DateTime(2022, 5, 31, 16, 45, 23, 947, DateTimeKind.Local).AddTicks(5239), "192.168.1.241", "DESKTOP-SCCLTAH", null, null, null, "200 gr. özel yapım köfte, yoğurt, yeşil biber, kuru kırmızı biber, domates, tereyağ ve tuz ile servis edilir / Contains 200 gr special meatballs, yoghurt, green pepper, dry red pepper, tomato, butter and salt. ", null, "Yoğurtlu Tire Köftesi / Tire Kebab with yoghurt", 40m, 1, null, null, null },
                    { 36, 9, new DateTime(2022, 5, 31, 16, 45, 23, 947, DateTimeKind.Local).AddTicks(6945), "192.168.1.241", "DESKTOP-SCCLTAH", null, null, null, "200 gr. marine edilmiş Kuzey Atlantik mezgiti, soğan, cherry domates, roka ve kızarmış limon ile servis edilir / Contains 200 gr marin North Atlantic whiting, onion, cherry tomato, arugula and grilled lemon", null, "Izgara Mezgit Marin / Grilled Whiting Marin", 45m, 1, null, null, null },
                    { 37, 9, new DateTime(2022, 5, 31, 16, 45, 23, 947, DateTimeKind.Local).AddTicks(8668), "192.168.1.241", "DESKTOP-SCCLTAH", null, null, null, "200 gr Kuzu eti, karamelize soğan, közlenmiş biber, domates ve cips ile servis edilir / Contains 200 gr slim sliced lamb, caramelized onion, roasted pepper, tomato with french fries.", null, "Külbastı / Grilled Cotlet", 60m, 1, null, null, null },
                    { 38, 10, new DateTime(2022, 5, 31, 16, 45, 23, 948, DateTimeKind.Local).AddTicks(381), "192.168.1.241", "DESKTOP-SCCLTAH", null, null, null, "Bolonez sos, kıyma, doamtes ve sarımsak ile servis edilir / Contains bolognese sauce, mince, tomato and garlic", null, "Spagetti Bolognese", 35m, 1, null, null, null },
                    { 39, 10, new DateTime(2022, 5, 31, 16, 45, 23, 948, DateTimeKind.Local).AddTicks(2081), "192.168.1.241", "DESKTOP-SCCLTAH", null, null, null, "Krema, köri sos, peynir ve mantar ile servis edilir / Contains curry sauce, cheese, mushroom and cream.", null, "Köri Soslu Penne / Penne with Curry Sauce", 35m, 1, null, null, null },
                    { 40, 10, new DateTime(2022, 5, 31, 16, 45, 23, 948, DateTimeKind.Local).AddTicks(3780), "192.168.1.241", "DESKTOP-SCCLTAH", null, null, null, "Fettucini makarna, krema, tereyağ, mantar, tavuk göğsü, sarımsak, fesleğen, peynir, karabiber ve tuz ile servis edilir / Fettucine, heavy cream, butter, mushroom, chicken breast, garlic, basil, cheese, salt and pepper.", null, "Fettucini Alfredo", 40m, 1, null, null, null },
                    { 41, 11, new DateTime(2022, 5, 31, 16, 45, 23, 948, DateTimeKind.Local).AddTicks(6017), "192.168.1.241", "DESKTOP-SCCLTAH", null, null, null, "", null, "Türk Kahvesi / Turkish Coffee", 12m, 1, null, null, null },
                    { 42, 11, new DateTime(2022, 5, 31, 16, 45, 23, 948, DateTimeKind.Local).AddTicks(8177), "192.168.1.241", "DESKTOP-SCCLTAH", null, null, null, "", null, "Espresso", 15m, 1, null, null, null }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "CreatedDate", "CreatedIpAddress", "CreatedMachineName", "DeletedDate", "DeletedIpAddress", "DeletedMachineName", "Description", "ImagePath", "Name", "Price", "Status", "UpdatedDate", "UpdatedIpAddress", "UpdatedMachineName" },
                values: new object[,]
                {
                    { 43, 11, new DateTime(2022, 5, 31, 16, 45, 23, 949, DateTimeKind.Local).AddTicks(44), "192.168.1.241", "DESKTOP-SCCLTAH", null, null, null, "", null, "French Press Filter Coffee", 20m, 1, null, null, null },
                    { 44, 11, new DateTime(2022, 5, 31, 16, 45, 23, 949, DateTimeKind.Local).AddTicks(1889), "192.168.1.241", "DESKTOP-SCCLTAH", null, null, null, "", null, "Americano", 20m, 1, null, null, null },
                    { 45, 11, new DateTime(2022, 5, 31, 16, 45, 23, 949, DateTimeKind.Local).AddTicks(3690), "192.168.1.241", "DESKTOP-SCCLTAH", null, null, null, "", null, "Cafe Latte / Café Con Leche", 20m, 1, null, null, null },
                    { 46, 12, new DateTime(2022, 5, 31, 16, 45, 23, 949, DateTimeKind.Local).AddTicks(5744), "192.168.1.241", "DESKTOP-SCCLTAH", null, null, null, "", null, "Taze Sıkılmış Portakal / Orange Juice", 15m, 1, null, null, null },
                    { 47, 12, new DateTime(2022, 5, 31, 16, 45, 23, 949, DateTimeKind.Local).AddTicks(7901), "192.168.1.241", "DESKTOP-SCCLTAH", null, null, null, "", null, "Nar Suyu / Pomegranate Juice", 17m, 1, null, null, null },
                    { 48, 12, new DateTime(2022, 5, 31, 16, 45, 23, 949, DateTimeKind.Local).AddTicks(9831), "192.168.1.241", "DESKTOP-SCCLTAH", null, null, null, "", null, "Coca Cola / Light / Zero", 8m, 1, null, null, null },
                    { 49, 12, new DateTime(2022, 5, 31, 16, 45, 23, 950, DateTimeKind.Local).AddTicks(1705), "192.168.1.241", "DESKTOP-SCCLTAH", null, null, null, "", null, "Sprite / Fanta", 8m, 1, null, null, null },
                    { 50, 12, new DateTime(2022, 5, 31, 16, 45, 23, 950, DateTimeKind.Local).AddTicks(3583), "192.168.1.241", "DESKTOP-SCCLTAH", null, null, null, "", null, "Meyve Suyu Vişne / Şeftali / Karışık (Cherry Juice / Peach / Mixed Juice)", 8m, 1, null, null, null },
                    { 51, 12, new DateTime(2022, 5, 31, 16, 45, 23, 950, DateTimeKind.Local).AddTicks(5607), "192.168.1.241", "DESKTOP-SCCLTAH", null, null, null, "", null, "Ayran", 6m, 1, null, null, null },
                    { 52, 12, new DateTime(2022, 5, 31, 16, 45, 23, 950, DateTimeKind.Local).AddTicks(7435), "192.168.1.241", "DESKTOP-SCCLTAH", null, null, null, "", null, "Soda", 6m, 1, null, null, null },
                    { 53, 12, new DateTime(2022, 5, 31, 16, 45, 23, 950, DateTimeKind.Local).AddTicks(9241), "192.168.1.241", "DESKTOP-SCCLTAH", null, null, null, "", null, "Su", 4m, 1, null, null, null },
                    { 54, 13, new DateTime(2022, 5, 31, 16, 45, 23, 951, DateTimeKind.Local).AddTicks(2947), "192.168.1.241", "DESKTOP-SCCLTAH", null, null, null, "", null, "Efes / Efes Malt 50 cl", 23m, 1, null, null, null },
                    { 55, 13, new DateTime(2022, 5, 31, 16, 45, 23, 951, DateTimeKind.Local).AddTicks(4968), "192.168.1.241", "DESKTOP-SCCLTAH", null, null, null, "", null, "Bomonti", 23m, 1, null, null, null },
                    { 56, 13, new DateTime(2022, 5, 31, 16, 45, 23, 951, DateTimeKind.Local).AddTicks(6890), "192.168.1.241", "DESKTOP-SCCLTAH", null, null, null, "", null, "Bomonti Filtresiz", 25m, 1, null, null, null },
                    { 57, 13, new DateTime(2022, 5, 31, 16, 45, 23, 951, DateTimeKind.Local).AddTicks(8698), "192.168.1.241", "DESKTOP-SCCLTAH", null, null, null, "", null, "Tuborg Gold", 23m, 1, null, null, null },
                    { 58, 13, new DateTime(2022, 5, 31, 16, 45, 23, 952, DateTimeKind.Local).AddTicks(469), "192.168.1.241", "DESKTOP-SCCLTAH", null, null, null, "", null, "Tuborg Amber / Bud", 25m, 1, null, null, null },
                    { 59, 13, new DateTime(2022, 5, 31, 16, 45, 23, 952, DateTimeKind.Local).AddTicks(2283), "192.168.1.241", "DESKTOP-SCCLTAH", null, null, null, "", null, "Carlsberg / Miller / Beck's", 27m, 1, null, null, null },
                    { 60, 13, new DateTime(2022, 5, 31, 16, 45, 23, 952, DateTimeKind.Local).AddTicks(4070), "192.168.1.241", "DESKTOP-SCCLTAH", null, null, null, "", null, "Corona Extra / Sol", 30m, 1, null, null, null },
                    { 61, 13, new DateTime(2022, 5, 31, 16, 45, 23, 952, DateTimeKind.Local).AddTicks(5864), "192.168.1.241", "DESKTOP-SCCLTAH", null, null, null, "", null, "Desperado / Amsterdam", 35m, 1, null, null, null },
                    { 62, 13, new DateTime(2022, 5, 31, 16, 45, 23, 952, DateTimeKind.Local).AddTicks(7623), "192.168.1.241", "DESKTOP-SCCLTAH", null, null, null, "", null, "Guinness", 37m, 1, null, null, null },
                    { 63, 14, new DateTime(2022, 5, 31, 16, 45, 23, 952, DateTimeKind.Local).AddTicks(9345), "192.168.1.241", "DESKTOP-SCCLTAH", null, null, null, "", null, "Tekirdağ (Tek)", 25m, 1, null, null, null },
                    { 64, 14, new DateTime(2022, 5, 31, 16, 45, 23, 953, DateTimeKind.Local).AddTicks(2433), "192.168.1.241", "DESKTOP-SCCLTAH", null, null, null, "", null, "Tekirdağ (Duble)", 35m, 1, null, null, null },
                    { 65, 14, new DateTime(2022, 5, 31, 16, 45, 23, 953, DateTimeKind.Local).AddTicks(4278), "192.168.1.241", "DESKTOP-SCCLTAH", null, null, null, "", null, "Tekirdağ 35 cl", 125m, 1, null, null, null },
                    { 66, 14, new DateTime(2022, 5, 31, 16, 45, 23, 953, DateTimeKind.Local).AddTicks(8037), "192.168.1.241", "DESKTOP-SCCLTAH", null, null, null, "", null, "Tekirdağ 70 cl", 205m, 1, null, null, null },
                    { 67, 14, new DateTime(2022, 5, 31, 16, 45, 23, 954, DateTimeKind.Local).AddTicks(8878), "192.168.1.241", "DESKTOP-SCCLTAH", null, null, null, "", null, "Tekirdağ T.Serisi 35 cl", 145m, 1, null, null, null },
                    { 68, 14, new DateTime(2022, 5, 31, 16, 45, 23, 955, DateTimeKind.Local).AddTicks(1186), "192.168.1.241", "DESKTOP-SCCLTAH", null, null, null, "", null, "Tekirdağ T.Serisi 70 cl", 240m, 1, null, null, null },
                    { 69, 15, new DateTime(2022, 5, 31, 16, 45, 23, 955, DateTimeKind.Local).AddTicks(4286), "192.168.1.241", "DESKTOP-SCCLTAH", null, null, null, "Şişe 130 TL / Bottle 130 TL", null, "White Wine", 35m, 1, null, null, null },
                    { 70, 15, new DateTime(2022, 5, 31, 16, 45, 23, 955, DateTimeKind.Local).AddTicks(6444), "192.168.1.241", "DESKTOP-SCCLTAH", null, null, null, "Şişe 35 TL / Bottle 130 TL", null, "Red Wine", 35m, 1, null, null, null },
                    { 71, 15, new DateTime(2022, 5, 31, 16, 45, 23, 955, DateTimeKind.Local).AddTicks(9572), "192.168.1.241", "DESKTOP-SCCLTAH", null, null, null, "Şişe 35 TL / Bottle 130 TL", null, "Blush", 35m, 1, null, null, null },
                    { 72, 16, new DateTime(2022, 5, 31, 16, 45, 23, 956, DateTimeKind.Local).AddTicks(1441), "192.168.1.241", "DESKTOP-SCCLTAH", null, null, null, "", null, "Gordon Gin", 45m, 1, null, null, null },
                    { 73, 16, new DateTime(2022, 5, 31, 16, 45, 23, 956, DateTimeKind.Local).AddTicks(3237), "192.168.1.241", "DESKTOP-SCCLTAH", null, null, null, "", null, "Beefeather Gin", 50m, 1, null, null, null },
                    { 74, 16, new DateTime(2022, 5, 31, 16, 45, 23, 956, DateTimeKind.Local).AddTicks(5057), "192.168.1.241", "DESKTOP-SCCLTAH", null, null, null, "", null, "Absolut / Smirnoff Vodka", 45m, 1, null, null, null },
                    { 75, 16, new DateTime(2022, 5, 31, 16, 45, 23, 956, DateTimeKind.Local).AddTicks(8053), "192.168.1.241", "DESKTOP-SCCLTAH", null, null, null, "", null, "Jim Beam Bourbon", 50m, 1, null, null, null },
                    { 76, 16, new DateTime(2022, 5, 31, 16, 45, 23, 956, DateTimeKind.Local).AddTicks(9900), "192.168.1.241", "DESKTOP-SCCLTAH", null, null, null, "", null, "Jack Daniels Tennesee Whiskey", 50m, 1, null, null, null },
                    { 77, 16, new DateTime(2022, 5, 31, 16, 45, 23, 957, DateTimeKind.Local).AddTicks(1933), "192.168.1.241", "DESKTOP-SCCLTAH", null, null, null, "", null, "Chivas Regal (12 years)", 55m, 1, null, null, null },
                    { 78, 15, new DateTime(2022, 5, 31, 16, 45, 23, 957, DateTimeKind.Local).AddTicks(3860), "192.168.1.241", "DESKTOP-SCCLTAH", null, null, null, "", null, "Black Label", 55m, 1, null, null, null }
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
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");
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
                name: "Products");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
