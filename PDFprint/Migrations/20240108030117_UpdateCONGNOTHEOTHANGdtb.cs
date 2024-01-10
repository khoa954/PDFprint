using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PDFprint.Migrations
{
    /// <inheritdoc />
    public partial class UpdateCONGNOTHEOTHANGdtb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CONGNOTHEOTHANG",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ChiNhanh = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Thang = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nam = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MaKhachHang = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TenKhachHang = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DiaChi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TaiKhoan = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NgayKhaiTruong = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CongNoConLai = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CongNoConLaiTheoChu = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CongNoThangTruoc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TongPhatSinhTang = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TongPhatSinhGiam = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CONGNOTHEOTHANG", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "MAKH",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaKH = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MAKH", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "CHITIETCONGNO",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SOCHUNGTU = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NGAYCHUNGTU = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KENHPHANPHOI = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DIENGIAI = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PHATSINHTANG = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PHATSINHGIAM = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CONGNOTHEOTHANGId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CHITIETCONGNO", x => x.id);
                    table.ForeignKey(
                        name: "FK_CHITIETCONGNO_CONGNOTHEOTHANG_CONGNOTHEOTHANGId",
                        column: x => x.CONGNOTHEOTHANGId,
                        principalTable: "CONGNOTHEOTHANG",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CHITIETCONGNO_CONGNOTHEOTHANGId",
                table: "CHITIETCONGNO",
                column: "CONGNOTHEOTHANGId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CHITIETCONGNO");

            migrationBuilder.DropTable(
                name: "MAKH");

            migrationBuilder.DropTable(
                name: "CONGNOTHEOTHANG");
        }
    }
}
