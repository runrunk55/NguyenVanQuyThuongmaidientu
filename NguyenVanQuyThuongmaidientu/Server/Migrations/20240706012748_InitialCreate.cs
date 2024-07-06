using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NguyenVanQuyThuongmaidientu.Server.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
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
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name", "Url" },
                values: new object[] { 1, "Books", "books" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name", "Url" },
                values: new object[] { 2, "Movies", "movies" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name", "Url" },
                values: new object[] { 3, "Video Games", "video-games" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "ImageUrl", "Price", "Title" },
                values: new object[,]
                {
                    { 1, 1, "The Hitchhiker's Guide to the Galaxy[note 1] (đôi khi được gọi là HG2G,[1] HHGTTG,[2] H2G2,[3] hoặc tHGttG) là một loạt phim hài khoa học viễn tưởng do Douglas Adams tạo ra. Ban đầu là một chương trình hài kịch radio năm 1978 trên BBC Radio 4, nó sau đó được chuyển thể sang các định dạng khác, bao gồm các buổi biểu diễn trên sân khấu, tiểu thuyết, truyện tranh, một loạt phim truyền hình năm 1981, một trò chơi máy tính dựa trên văn bản năm 1984, và một bộ phim chiếu rạp năm 2005.", "https://upload.wikimedia.org/wikipedia/en/b/bd/H2G2_UK_front_cover.jpg", 9.99m, "The Hitchhiker's Guide to the Galaxy" },
                    { 2, 1, "Ready Player One là một tiểu thuyết khoa học viễn tưởng năm 2011 và là tiểu thuyết đầu tay của tác giả người Mỹ Ernest Cline. Câu chuyện, lấy bối cảnh năm 2045 trong một thế giới loạn lạc, kể về nhân vật chính Wade Watts trong cuộc tìm kiếm một quả trứng phục sinh trong một trò chơi thực tế ảo toàn cầu, việc phát hiện ra nó sẽ giúp cậu thừa kế tài sản của người tạo ra trò chơi. Cline đã bán quyền xuất bản tiểu thuyết này vào tháng 6 năm 2010, trong một cuộc đấu giá với Crown Publishing Group (một chi nhánh của Random House).[1] Cuốn sách được xuất bản vào ngày 16 tháng 8 năm 2011.[2] Một phiên bản audiobook được phát hành cùng ngày; nó được kể bởi Wil Wheaton, người đã được nhắc đến ngắn gọn trong một trong các chương.[3][4]Ch. 20 Năm 2012, cuốn sách nhận được giải Alex từ Hiệp hội Dịch vụ Thư viện Thanh niên của Hiệp hội Thư viện Hoa Kỳ[5] và giành giải Prometheus năm 2011.[6]", "https://upload.wikimedia.org/wikipedia/en/a/a4/Ready_Player_One_cover.jpg", 7.99m, "Ready Player One" },
                    { 3, 1, "Nineteen Eighty-Four (cũng được viết là 1984) là một tiểu thuyết khoa học viễn tưởng xã hội loạn lạc và là câu chuyện cảnh báo được viết bởi nhà văn Anh George Orwell. Nó được xuất bản vào ngày 8 tháng 6 năm 1949 bởi Secker & Warburg và là cuốn sách thứ chín và cuối cùng của Orwell hoàn thành trong cuộc đời của ông. Chủ đề chính, nó tập trung vào hậu quả của chế độ toàn trị, giám sát hàng loạt và sự áp chế quy định của con người và hành vi trong xã hội.[2][3] Orwell, một người xã hội dân chủ, đã mô hình hóa chính phủ toàn trị trong tiểu thuyết này theo Liên Xô Stalin và Đức Quốc xã.[2][3][4] Nói rộng ra, tiểu thuyết này nghiên cứu vai trò của sự thật và sự thật trong chính trị và cách chúng bị thao túng.", "https://upload.wikimedia.org/wikipedia/commons/c/c3/1984first.jpg", 6.99m, "Nineteen Eighty-Four" },
                    { 4, 2, "The Matrix là một bộ phim hành động khoa học viễn tưởng năm 1999 do Wachowskis viết kịch bản và đạo diễn, và được sản xuất bởi Joel Silver. Với sự tham gia của Keanu Reeves, Laurence Fishburne, Carrie-Anne Moss, Hugo Weaving, và Joe Pantoliano, đây là phần đầu tiên trong loạt phim Ma Trận, miêu tả một tương lai loạn lạc trong đó nhân loại bị mắc kẹt bên trong một thực tế ảo, Ma Trận, do máy móc thông minh tạo ra để đánh lạc hướng con người trong khi sử dụng cơ thể họ như một nguồn năng lượng. Khi lập trình viên máy tính Thomas Anderson, dưới biệt danh hacker \"Neo\", phát hiện ra sự thật, anh bị cuốn vào một cuộc nổi loạn chống lại máy móc cùng với những người khác đã được giải thoát khỏi Ma Trận.", "https://upload.wikimedia.org/wikipedia/en/c/c1/The_Matrix_Poster.jpg", 4.99m, "The Matrix" },
                    { 5, 2, "Back to the Future là một bộ phim khoa học viễn tưởng năm 1985 của Mỹ do Robert Zemeckis đạo diễn. Viết kịch bản bởi Zemeckis và Bob Gale, phim có sự tham gia của Michael J. Fox, Christopher Lloyd, Lea Thompson, Crispin Glover, và Thomas F. Wilson. Đặt bối cảnh năm 1985, câu chuyện kể về Marty McFly (Fox), một thiếu niên vô tình bị đưa trở lại năm 1955 trong một chiếc xe DeLorean du hành thời gian do người bạn khoa học lập dị của mình, Tiến sĩ Emmett \"Doc\" Brown (Lloyd), chế tạo. Mắc kẹt trong quá khứ, Marty vô tình ngăn cản cuộc gặp gỡ của bố mẹ mình trong tương lai, đe dọa sự tồn tại của chính mình, và buộc phải hòa giải đôi uyên ương và bằng cách nào đó quay trở lại tương lai.", "https://upload.wikimedia.org/wikipedia/en/d/d2/Back_to_the_Future.jpg", 3.99m, "Back to the Future" },
                    { 6, 2, "Toy Story là một bộ phim hài hoạt hình máy tính của Mỹ năm 1995 do Pixar Animation Studios sản xuất và Walt Disney Pictures phát hành. Là phần đầu tiên trong loạt phim Toy Story, đây là bộ phim hoạt hình máy tính hoàn toàn đầu tiên, cũng như bộ phim đầu tiên của Pixar. Bộ phim được đạo diễn bởi John Lasseter (trong lần đầu đạo diễn phim truyện), và được viết kịch bản bởi Joss Whedon, Andrew Stanton, Joel Cohen, và Alec Sokolow từ một câu chuyện của Lasseter, Stanton, Pete Docter, và Joe Ranft. Bộ phim có âm nhạc của Randy Newman, được sản xuất bởi Bonnie Arnold và Ralph Guggenheim, và được Steve Jobs và Edwin Catmull điều hành sản xuất. Bộ phim có sự tham gia lồng tiếng của Tom Hanks, Tim Allen, Don Rickles, Wallace Shawn, John Ratzenberger, Jim Varney, Annie Potts, R. Lee Ermey, John Morris, Laurie Metcalf, và Erik von Detten. Lấy bối cảnh trong một thế giới nơi đồ chơi có tính cách con người sống động khi con người không có mặt, cốt truyện tập trung vào mối quan hệ giữa một búp bê cao bồi cổ điển có dây kéo tên là Woody và một nhân vật hành động phi hành gia, Buzz Lightyear, khi họ từ đối thủ cạnh tranh cho tình cảm của chủ nhân, Andy Davis, trở thành bạn bè hợp tác cùng nhau để tái hợp với Andy sau khi bị tách ra khỏi cậu.", "https://upload.wikimedia.org/wikipedia/en/1/13/Toy_Story.jpg", 2.99m, "Toy Story" },
                    { 7, 3, "Half-Life 2 là một trò chơi bắn súng góc nhìn thứ nhất năm 2004 do Valve phát triển và phát hành. Giống như Half-Life gốc, nó kết hợp bắn súng, giải đố, và kể chuyện, và thêm các tính năng như phương tiện và lối chơi dựa trên vật lý.", "https://upload.wikimedia.org/wikipedia/en/2/25/Half-Life_2_cover.jpg", 49.99m, "Half-Life 2" },
                    { 8, 3, "Diablo II là một trò chơi hành động nhập vai chém giết được phát triển bởi Blizzard North và phát hành bởi Blizzard Entertainment năm 2000 cho Microsoft Windows, Classic Mac OS, và macOS.", "https://upload.wikimedia.org/wikipedia/en/d/d5/Diablo_II_Coverart.png", 9.99m, "Diablo II" },
                    { 9, 3, "Day of the Tentacle, còn được biết đến với tên gọi Maniac Mansion II: Day of the Tentacle, là một trò chơi phiêu lưu đồ họa năm 1993 được phát triển và phát hành bởi LucasArts. Đây là phần tiếp theo của trò chơi Maniac Mansion năm 1987.", "https://upload.wikimedia.org/wikipedia/en/7/79/Day_of_the_Tentacle_artwork.jpg", 14.99m, "Day of the Tentacle" },
                    { 10, 3, "Xbox là một máy chơi trò chơi video gia đình và là phần đầu tiên trong loạt máy chơi trò chơi video Xbox do Microsoft sản xuất.", "https://upload.wikimedia.org/wikipedia/commons/4/43/Xbox-console.jpg", 159.99m, "Xbox" },
                    { 11, 3, "Super Nintendo Entertainment System (SNES), còn được biết đến với tên gọi Super NES hoặc Super Nintendo, là một máy chơi trò chơi video gia đình 16-bit được phát triển bởi Nintendo, được phát hành năm 1990 tại Nhật Bản và Hàn Quốc.", "https://upload.wikimedia.org/wikipedia/commons/e/ee/Nintendo-Super-Famicom-Set-FL.jpg", 79.99m, "Super Nintendo Entertainment System" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
