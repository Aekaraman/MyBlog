using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BlogInstance.Migrations
{
    public partial class BlogMigrationDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    CreatedByName = table.Column<string>(maxLength: 50, nullable: false),
                    CategoryName = table.Column<string>(maxLength: 50, nullable: false),
                    CategoryDescription = table.Column<string>(maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryID);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    RoleId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    CreatedByName = table.Column<string>(maxLength: 50, nullable: false),
                    RoleName = table.Column<string>(maxLength: 30, nullable: false),
                    RoleDescription = table.Column<string>(maxLength: 250, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.RoleId);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    CreatedByName = table.Column<string>(maxLength: 50, nullable: true),
                    UserFirstName = table.Column<string>(maxLength: 30, nullable: false),
                    UserLastName = table.Column<string>(maxLength: 50, nullable: false),
                    UserName = table.Column<string>(maxLength: 20, nullable: false),
                    UserEmail = table.Column<string>(maxLength: 50, nullable: false),
                    UserDescription = table.Column<string>(maxLength: 500, nullable: true),
                    UserThumbnail = table.Column<string>(nullable: true),
                    UserPassword = table.Column<byte[]>(type: "VARBINARY(500)", nullable: false),
                    RoleId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserID);
                    table.ForeignKey(
                        name: "FK_Users_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "RoleId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Articles",
                columns: table => new
                {
                    ArticleID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    CreatedByName = table.Column<string>(maxLength: 50, nullable: true),
                    Title = table.Column<string>(maxLength: 100, nullable: false),
                    Content = table.Column<string>(type: "NVARCHAR(MAX)", nullable: false),
                    ThumbNail = table.Column<string>(maxLength: 250, nullable: true),
                    Date = table.Column<DateTime>(nullable: false),
                    ViewsCount = table.Column<int>(nullable: false),
                    CommentCount = table.Column<int>(nullable: false),
                    UserID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Articles", x => x.ArticleID);
                    table.ForeignKey(
                        name: "FK_Articles_Users_UserID",
                        column: x => x.UserID,
                        principalTable: "Users",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserAndCategories",
                columns: table => new
                {
                    UserID = table.Column<int>(nullable: false),
                    CategoryID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserAndCategories", x => new { x.UserID, x.CategoryID });
                    table.ForeignKey(
                        name: "FK_UserAndCategories_Categories_CategoryID",
                        column: x => x.CategoryID,
                        principalTable: "Categories",
                        principalColumn: "CategoryID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserAndCategories_Users_UserID",
                        column: x => x.UserID,
                        principalTable: "Users",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ArticleAndCategories",
                columns: table => new
                {
                    ArticleID = table.Column<int>(nullable: false),
                    CategoryID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArticleAndCategories", x => new { x.ArticleID, x.CategoryID });
                    table.ForeignKey(
                        name: "FK_ArticleAndCategories_Articles_ArticleID",
                        column: x => x.ArticleID,
                        principalTable: "Articles",
                        principalColumn: "ArticleID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ArticleAndCategories_Categories_CategoryID",
                        column: x => x.CategoryID,
                        principalTable: "Categories",
                        principalColumn: "CategoryID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryID", "CategoryDescription", "CategoryName", "CreatedByName", "CreatedDate", "IsActive", "IsDeleted", "ModifiedDate" },
                values: new object[] { 1, "C# Programlama Dili ile İlgili En Güncel Bilgiler ", "C#", "InitialCreate", new DateTime(2021, 4, 13, 0, 23, 41, 47, DateTimeKind.Local).AddTicks(4640), true, false, new DateTime(2021, 4, 13, 0, 23, 41, 47, DateTimeKind.Local).AddTicks(4645) });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryID", "CategoryDescription", "CategoryName", "CreatedByName", "CreatedDate", "IsActive", "IsDeleted", "ModifiedDate" },
                values: new object[] { 2, "JavaScript Programlama Dili ile İlgili En Güncel Bilgiler ", "JavaScript", "InitialCreate", new DateTime(2021, 4, 13, 0, 23, 41, 47, DateTimeKind.Local).AddTicks(4676), true, false, new DateTime(2021, 4, 13, 0, 23, 41, 47, DateTimeKind.Local).AddTicks(4677) });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "RoleId", "CreatedByName", "CreatedDate", "IsActive", "IsDeleted", "ModifiedDate", "RoleDescription", "RoleName" },
                values: new object[] { 1, "InitialCreate", new DateTime(2021, 4, 13, 0, 23, 41, 50, DateTimeKind.Local).AddTicks(6700), true, false, new DateTime(2021, 4, 13, 0, 23, 41, 50, DateTimeKind.Local).AddTicks(6706), "Admin Rolü, Tüm Haklara Sahiptir.", "Admin" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserID", "CreatedByName", "CreatedDate", "IsActive", "IsDeleted", "ModifiedDate", "RoleId", "UserDescription", "UserEmail", "UserFirstName", "UserLastName", "UserName", "UserPassword", "UserThumbnail" },
                values: new object[] { 1, "InitialCreate", new DateTime(2021, 4, 13, 0, 23, 41, 45, DateTimeKind.Local).AddTicks(2198), true, false, new DateTime(2021, 4, 13, 0, 23, 41, 45, DateTimeKind.Local).AddTicks(2485), 1, "İlk admin Kullanıcı", "aekaramanofficial@gmail.com", "Emre", "Karaman", "aekaraman", new byte[] { 102, 49, 98, 51, 99, 49, 98, 52, 99, 48, 51, 51, 53, 101, 54, 57, 48, 54, 101, 101, 48, 100, 99, 102, 57, 54, 100, 48, 98, 54, 49, 55 }, null });

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "ArticleID", "CommentCount", "Content", "CreatedByName", "CreatedDate", "Date", "IsActive", "IsDeleted", "ModifiedDate", "ThumbNail", "Title", "UserID", "ViewsCount" },
                values: new object[] { 1, 0, "Yaygın inancın tersine, Lorem Ipsum rastgele sözcüklerden oluşmaz. Kökleri M.Ö. 45 tarihinden bu yana klasik Latin edebiyatına kadar uzanan 2000 yıllık bir geçmişi vardır. Virginia'daki Hampden-Sydney College'dan Latince profesörü Richard McClintock, bir Lorem Ipsum pasajında geçen ve anlaşılması en güç sözcüklerden biri olan 'consectetur' sözcüğünün klasik edebiyattaki örneklerini incelediğinde kesin bir kaynağa ulaşmıştır. Lorm Ipsum, Çiçero tarafından M.Ö. 45 tarihinde kaleme alınan de Finibus Bonorum et Malorum (İyi ve Kötünün Uç Sınırları) eserinin 1.10.32 ve 1.10.33 sayılı bölümlerinden gelmektedir. Bu kitap, ahlak kuramı üzerine bir tezdir ve Rönesans döneminde çok popüler olmuştur. Lorem Ipsum pasajının ilk satırı olan Lorem ipsum dolor sit amet 1.10.32 sayılı bölümdeki bir satırdan gelmektedir.", "InitialCreate", new DateTime(2021, 4, 13, 0, 23, 41, 49, DateTimeKind.Local).AddTicks(3357), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, false, new DateTime(2021, 4, 13, 0, 23, 41, 49, DateTimeKind.Local).AddTicks(3361), "Default.jpg", "C# 9.0 ve .NET 5 Yenilikleri", 1, 35 });

            migrationBuilder.CreateIndex(
                name: "IX_ArticleAndCategories_CategoryID",
                table: "ArticleAndCategories",
                column: "CategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_Articles_UserID",
                table: "Articles",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_UserAndCategories_CategoryID",
                table: "UserAndCategories",
                column: "CategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_Users_RoleId",
                table: "Users",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_UserEmail",
                table: "Users",
                column: "UserEmail",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Users_UserName",
                table: "Users",
                column: "UserName",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ArticleAndCategories");

            migrationBuilder.DropTable(
                name: "UserAndCategories");

            migrationBuilder.DropTable(
                name: "Articles");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Roles");
        }
    }
}
