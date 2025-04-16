using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DotaNerf.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Heroes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Heroes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Players",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PlayerDetailsId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Players", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PlayerDetails",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Winrate = table.Column<double>(type: "float", nullable: false),
                    TotalGames = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    GamesWon = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    GamesLost = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    PlayerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlayerDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PlayerDetails_Players_PlayerId",
                        column: x => x.PlayerId,
                        principalTable: "Players",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Games",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    WinningTeam = table.Column<int>(type: "int", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RadiantTeamId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DireTeamId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Games", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PlayerGames",
                columns: table => new
                {
                    GameId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PlayerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlayerGames", x => new { x.GameId, x.PlayerId });
                    table.ForeignKey(
                        name: "FK_PlayerGames_Games_GameId",
                        column: x => x.GameId,
                        principalTable: "Games",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PlayerGames_Players_PlayerId",
                        column: x => x.PlayerId,
                        principalTable: "Players",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Teams",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<int>(type: "int", nullable: false),
                    GameId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teams", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Teams_Games_GameId",
                        column: x => x.GameId,
                        principalTable: "Games",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "PlayerStats",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    HeroPlayedId = table.Column<int>(type: "int", nullable: false),
                    Kills = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    Deaths = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    Assists = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    PlayerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    GameId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TeamId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlayerStats", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PlayerStats_Games_GameId",
                        column: x => x.GameId,
                        principalTable: "Games",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PlayerStats_Heroes_HeroPlayedId",
                        column: x => x.HeroPlayedId,
                        principalTable: "Heroes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PlayerStats_Players_PlayerId",
                        column: x => x.PlayerId,
                        principalTable: "Players",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PlayerStats_Teams_TeamId",
                        column: x => x.TeamId,
                        principalTable: "Teams",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PlayerTeams",
                columns: table => new
                {
                    PlayersId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TeamsId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlayerTeams", x => new { x.PlayersId, x.TeamsId });
                    table.ForeignKey(
                        name: "FK_PlayerTeams_Players_PlayersId",
                        column: x => x.PlayersId,
                        principalTable: "Players",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PlayerTeams_Teams_TeamsId",
                        column: x => x.TeamsId,
                        principalTable: "Teams",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Heroes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Abaddon" },
                    { 2, "Alchemist" },
                    { 3, "Ancient Apparition" },
                    { 4, "Anti-Mage" },
                    { 5, "Arc Warden" },
                    { 6, "Axe" },
                    { 7, "Bane" },
                    { 8, "Batrider" },
                    { 9, "Beastmaster" },
                    { 10, "Bloodseeker" },
                    { 11, "Bounty Hunter" },
                    { 12, "Brewmaster" },
                    { 13, "Bristleback" },
                    { 14, "Broodmother" },
                    { 15, "Centaur Warrunner" },
                    { 16, "Chaos Knight" },
                    { 17, "Chen" },
                    { 18, "Clinkz" },
                    { 19, "Clockwerk" },
                    { 20, "Crystal Maiden" },
                    { 21, "Dark Seer" },
                    { 22, "Dark Willow" },
                    { 23, "Dawnbreaker" },
                    { 24, "Dazzle" },
                    { 25, "Death Prophet" },
                    { 26, "Disruptor" },
                    { 27, "Doom" },
                    { 28, "Dragon Knight" },
                    { 29, "Drow Ranger" },
                    { 30, "Earth Spirit" },
                    { 31, "Earthshaker" },
                    { 32, "Elder Titan" },
                    { 33, "Ember Spirit" },
                    { 34, "Enchantress" },
                    { 35, "Enigma" },
                    { 36, "Faceless Void" },
                    { 37, "Grimstroke" },
                    { 38, "Gyrocopter" },
                    { 39, "Hoodwink" },
                    { 40, "Huskar" },
                    { 41, "Invoker" },
                    { 42, "Io" },
                    { 43, "Jakiro" },
                    { 44, "Juggernaut" },
                    { 45, "Keeper of the Light" },
                    { 46, "Kunkka" },
                    { 47, "Legion Commander" },
                    { 48, "Leshrac" },
                    { 49, "Lich" },
                    { 50, "Lifestealer" },
                    { 51, "Lina" },
                    { 52, "Lion" },
                    { 53, "Lone Druid" },
                    { 54, "Luna" },
                    { 55, "Lycan" },
                    { 56, "Magnus" },
                    { 57, "Marci" },
                    { 58, "Mars" },
                    { 59, "Medusa" },
                    { 60, "Meepo" },
                    { 61, "Mirana" },
                    { 62, "Monkey King" },
                    { 63, "Morphling" },
                    { 64, "Muerta" },
                    { 65, "Naga Siren" },
                    { 66, "Nature's Prophet" },
                    { 67, "Necrophos" },
                    { 68, "Night Stalker" },
                    { 69, "Nyx Assassin" },
                    { 70, "Ogre Magi" },
                    { 71, "Omniknight" },
                    { 72, "Oracle" },
                    { 73, "Outworld Destroyer" },
                    { 74, "Pangolier" },
                    { 75, "Phantom Assassin" },
                    { 76, "Phantom Lancer" },
                    { 77, "Phoenix" },
                    { 78, "Primal Beast" },
                    { 79, "Puck" },
                    { 80, "Pudge" },
                    { 81, "Pugna" },
                    { 82, "Queen of Pain" },
                    { 83, "Razor" },
                    { 84, "Riki" },
                    { 85, "Rubick" },
                    { 86, "Sand King" },
                    { 87, "Shadow Demon" },
                    { 88, "Shadow Fiend" },
                    { 89, "Shadow Shaman" },
                    { 90, "Silencer" },
                    { 91, "Skywrath Mage" },
                    { 92, "Slardar" },
                    { 93, "Slark" },
                    { 94, "Snapfire" },
                    { 95, "Sniper" },
                    { 96, "Spectre" },
                    { 97, "Spirit Breaker" },
                    { 98, "Storm Spirit" },
                    { 99, "Sven" },
                    { 100, "Techies" },
                    { 101, "Templar Assassin" },
                    { 102, "Terrorblade" },
                    { 103, "Tidehunter" },
                    { 104, "Timbersaw" },
                    { 105, "Tinker" },
                    { 106, "Tiny" },
                    { 107, "Treant Protector" },
                    { 108, "Troll Warlord" },
                    { 109, "Tusk" },
                    { 110, "Underlord" },
                    { 111, "Undying" },
                    { 112, "Ursa" },
                    { 113, "Vengeful Spirit" },
                    { 114, "Venomancer" },
                    { 115, "Viper" },
                    { 116, "Void Spirit" },
                    { 117, "Warlock" },
                    { 118, "Wraith King" },
                    { 119, "Zeus" },
                    { 120, "Ringmaster" },
                    { 121, "Kez" }
                });

            migrationBuilder.InsertData(
                table: "Players",
                columns: new[] { "Id", "Name", "PlayerDetailsId" },
                values: new object[,]
                {
                    { new Guid("013986ba-03a2-4e5f-a54e-1e1a677c5593"), "Marto", new Guid("bbbbbbbb-bbbb-bbbb-bbbb-000000000001") },
                    { new Guid("0de33ebf-6f2d-4f37-a41f-c92a8387a16f"), "Veni", new Guid("bbbbbbbb-bbbb-bbbb-bbbb-000000000002") },
                    { new Guid("158f0cd7-315a-4d60-8a4a-3537766b2958"), "Retar Dio ( kolega )", new Guid("bbbbbbbb-bbbb-bbbb-bbbb-000000000003") },
                    { new Guid("2637179a-65b0-4af7-b7b2-0dc0b044a9c6"), "Steli", new Guid("bbbbbbbb-bbbb-bbbb-bbbb-000000000004") },
                    { new Guid("2f08b795-c2ee-460f-9102-489dcb034a59"), "Kriskata", new Guid("bbbbbbbb-bbbb-bbbb-bbbb-000000000005") },
                    { new Guid("2f25fdca-7016-4c2b-904e-154813b60210"), "DJ misho", new Guid("bbbbbbbb-bbbb-bbbb-bbbb-000000000006") },
                    { new Guid("2f3ab1f0-f334-4239-8793-87d92239d5bb"), "Stoqn (kolega )", new Guid("bbbbbbbb-bbbb-bbbb-bbbb-000000000007") },
                    { new Guid("32830ea1-39ad-469c-96bd-3040f2d49f6a"), "Kuncho", new Guid("bbbbbbbb-bbbb-bbbb-bbbb-000000000008") },
                    { new Guid("35b0e246-4545-4079-b258-8ba67ac756fa"), "Sofianeca", new Guid("bbbbbbbb-bbbb-bbbb-bbbb-000000000009") },
                    { new Guid("3d6a9560-592d-49e5-bfe6-29d2fe589d42"), "Rumen", new Guid("bbbbbbbb-bbbb-bbbb-bbbb-000000000010") },
                    { new Guid("3e85b928-0684-4300-9a23-c4d3c64ab59f"), "Bobur Kurva", new Guid("bbbbbbbb-bbbb-bbbb-bbbb-000000000011") },
                    { new Guid("40270ce1-9235-4720-9097-b26fcd7ebdc3"), "Vaneto", new Guid("bbbbbbbb-bbbb-bbbb-bbbb-000000000012") },
                    { new Guid("45193089-0738-40c2-951b-ec481ca21786"), "Mario", new Guid("bbbbbbbb-bbbb-bbbb-bbbb-000000000013") },
                    { new Guid("4f1f9cac-418b-4356-94c6-144eac70c0a9"), "Panic", new Guid("bbbbbbbb-bbbb-bbbb-bbbb-000000000014") },
                    { new Guid("5514f903-232a-4866-9e0b-4740b56de8fc"), "The Joker", new Guid("bbbbbbbb-bbbb-bbbb-bbbb-000000000015") },
                    { new Guid("6119f1a3-884c-4f22-9fa4-401e55917378"), "Danithedog", new Guid("bbbbbbbb-bbbb-bbbb-bbbb-000000000016") },
                    { new Guid("617747ee-a832-47be-aa30-c99310456113"), "Nevermore", new Guid("bbbbbbbb-bbbb-bbbb-bbbb-000000000017") },
                    { new Guid("632691d7-db1b-4fb5-9e83-893250e14474"), "Mode : topuria", new Guid("bbbbbbbb-bbbb-bbbb-bbbb-000000000018") },
                    { new Guid("71e4bb90-31dd-4cf7-9628-9eb8462e8a03"), "Zloto kuche", new Guid("bbbbbbbb-bbbb-bbbb-bbbb-000000000019") },
                    { new Guid("75c32438-809f-4f31-9ae3-d79ad2b56c29"), "Baba Yaga", new Guid("bbbbbbbb-bbbb-bbbb-bbbb-000000000020") },
                    { new Guid("8441c8de-e7e7-4faa-9869-99e95fa0791b"), "Smurf", new Guid("bbbbbbbb-bbbb-bbbb-bbbb-000000000021") },
                    { new Guid("90eae6b2-6395-49a8-9bfa-df51eac66c90"), "Peacelock", new Guid("bbbbbbbb-bbbb-bbbb-bbbb-000000000022") },
                    { new Guid("a7af794d-dbdc-4a05-a4f4-ebbb1ef0a0fb"), "Vee", new Guid("bbbbbbbb-bbbb-bbbb-bbbb-000000000023") },
                    { new Guid("a807403e-9e93-4a3b-9a4b-6eb9a6406687"), "RMZ", new Guid("bbbbbbbb-bbbb-bbbb-bbbb-000000000024") },
                    { new Guid("c3219456-5c5d-4d18-9980-032627844744"), "teperkules", new Guid("bbbbbbbb-bbbb-bbbb-bbbb-000000000025") },
                    { new Guid("cce185ad-c8d0-48ba-ad96-2ed4508b7dad"), "Vetirinari", new Guid("bbbbbbbb-bbbb-bbbb-bbbb-000000000026") },
                    { new Guid("d226779e-6c47-46a2-96cf-89f6c7502018"), "Borat BG", new Guid("bbbbbbbb-bbbb-bbbb-bbbb-000000000027") },
                    { new Guid("d5d3d965-f59c-46ce-8bb4-929cc261491a"), "Pro 1", new Guid("bbbbbbbb-bbbb-bbbb-bbbb-000000000028") },
                    { new Guid("d68b00ec-3ee2-4069-aa06-c74dce1946ce"), "Fisheye", new Guid("bbbbbbbb-bbbb-bbbb-bbbb-000000000029") },
                    { new Guid("e7cc43a2-1eb1-4df4-837a-e264d386a235"), "Batko bie sladko prime", new Guid("bbbbbbbb-bbbb-bbbb-bbbb-000000000030") },
                    { new Guid("eb3228bc-8b90-41b5-8a5a-e9faaf5e9048"), "pitbgr", new Guid("bbbbbbbb-bbbb-bbbb-bbbb-000000000031") },
                    { new Guid("f5071dec-ea3e-4106-8d52-bb3f59fdb3aa"), "Svetorontotokyo", new Guid("bbbbbbbb-bbbb-bbbb-bbbb-000000000032") },
                    { new Guid("f6f06957-a84d-4071-87d0-4b08e29888c5"), "Rei", new Guid("bbbbbbbb-bbbb-bbbb-bbbb-000000000033") }
                });

            migrationBuilder.InsertData(
                table: "PlayerDetails",
                columns: new[] { "Id", "PlayerId", "Winrate" },
                values: new object[,]
                {
                    { new Guid("bbbbbbbb-bbbb-bbbb-bbbb-000000000001"), new Guid("013986ba-03a2-4e5f-a54e-1e1a677c5593"), 0.0 },
                    { new Guid("bbbbbbbb-bbbb-bbbb-bbbb-000000000002"), new Guid("0de33ebf-6f2d-4f37-a41f-c92a8387a16f"), 0.0 },
                    { new Guid("bbbbbbbb-bbbb-bbbb-bbbb-000000000003"), new Guid("158f0cd7-315a-4d60-8a4a-3537766b2958"), 0.0 },
                    { new Guid("bbbbbbbb-bbbb-bbbb-bbbb-000000000004"), new Guid("2637179a-65b0-4af7-b7b2-0dc0b044a9c6"), 0.0 },
                    { new Guid("bbbbbbbb-bbbb-bbbb-bbbb-000000000005"), new Guid("2f08b795-c2ee-460f-9102-489dcb034a59"), 0.0 },
                    { new Guid("bbbbbbbb-bbbb-bbbb-bbbb-000000000006"), new Guid("2f25fdca-7016-4c2b-904e-154813b60210"), 0.0 },
                    { new Guid("bbbbbbbb-bbbb-bbbb-bbbb-000000000007"), new Guid("2f3ab1f0-f334-4239-8793-87d92239d5bb"), 0.0 },
                    { new Guid("bbbbbbbb-bbbb-bbbb-bbbb-000000000008"), new Guid("32830ea1-39ad-469c-96bd-3040f2d49f6a"), 0.0 },
                    { new Guid("bbbbbbbb-bbbb-bbbb-bbbb-000000000009"), new Guid("35b0e246-4545-4079-b258-8ba67ac756fa"), 0.0 },
                    { new Guid("bbbbbbbb-bbbb-bbbb-bbbb-000000000010"), new Guid("3d6a9560-592d-49e5-bfe6-29d2fe589d42"), 0.0 },
                    { new Guid("bbbbbbbb-bbbb-bbbb-bbbb-000000000011"), new Guid("3e85b928-0684-4300-9a23-c4d3c64ab59f"), 0.0 },
                    { new Guid("bbbbbbbb-bbbb-bbbb-bbbb-000000000012"), new Guid("40270ce1-9235-4720-9097-b26fcd7ebdc3"), 0.0 },
                    { new Guid("bbbbbbbb-bbbb-bbbb-bbbb-000000000013"), new Guid("45193089-0738-40c2-951b-ec481ca21786"), 0.0 },
                    { new Guid("bbbbbbbb-bbbb-bbbb-bbbb-000000000014"), new Guid("4f1f9cac-418b-4356-94c6-144eac70c0a9"), 0.0 },
                    { new Guid("bbbbbbbb-bbbb-bbbb-bbbb-000000000015"), new Guid("5514f903-232a-4866-9e0b-4740b56de8fc"), 0.0 },
                    { new Guid("bbbbbbbb-bbbb-bbbb-bbbb-000000000016"), new Guid("6119f1a3-884c-4f22-9fa4-401e55917378"), 0.0 },
                    { new Guid("bbbbbbbb-bbbb-bbbb-bbbb-000000000017"), new Guid("617747ee-a832-47be-aa30-c99310456113"), 0.0 },
                    { new Guid("bbbbbbbb-bbbb-bbbb-bbbb-000000000018"), new Guid("632691d7-db1b-4fb5-9e83-893250e14474"), 0.0 },
                    { new Guid("bbbbbbbb-bbbb-bbbb-bbbb-000000000019"), new Guid("71e4bb90-31dd-4cf7-9628-9eb8462e8a03"), 0.0 },
                    { new Guid("bbbbbbbb-bbbb-bbbb-bbbb-000000000020"), new Guid("75c32438-809f-4f31-9ae3-d79ad2b56c29"), 0.0 },
                    { new Guid("bbbbbbbb-bbbb-bbbb-bbbb-000000000021"), new Guid("8441c8de-e7e7-4faa-9869-99e95fa0791b"), 0.0 },
                    { new Guid("bbbbbbbb-bbbb-bbbb-bbbb-000000000022"), new Guid("90eae6b2-6395-49a8-9bfa-df51eac66c90"), 0.0 },
                    { new Guid("bbbbbbbb-bbbb-bbbb-bbbb-000000000023"), new Guid("a7af794d-dbdc-4a05-a4f4-ebbb1ef0a0fb"), 0.0 },
                    { new Guid("bbbbbbbb-bbbb-bbbb-bbbb-000000000024"), new Guid("a807403e-9e93-4a3b-9a4b-6eb9a6406687"), 0.0 },
                    { new Guid("bbbbbbbb-bbbb-bbbb-bbbb-000000000025"), new Guid("c3219456-5c5d-4d18-9980-032627844744"), 0.0 },
                    { new Guid("bbbbbbbb-bbbb-bbbb-bbbb-000000000026"), new Guid("cce185ad-c8d0-48ba-ad96-2ed4508b7dad"), 0.0 },
                    { new Guid("bbbbbbbb-bbbb-bbbb-bbbb-000000000027"), new Guid("d226779e-6c47-46a2-96cf-89f6c7502018"), 0.0 },
                    { new Guid("bbbbbbbb-bbbb-bbbb-bbbb-000000000028"), new Guid("d5d3d965-f59c-46ce-8bb4-929cc261491a"), 0.0 },
                    { new Guid("bbbbbbbb-bbbb-bbbb-bbbb-000000000029"), new Guid("d68b00ec-3ee2-4069-aa06-c74dce1946ce"), 0.0 },
                    { new Guid("bbbbbbbb-bbbb-bbbb-bbbb-000000000030"), new Guid("e7cc43a2-1eb1-4df4-837a-e264d386a235"), 0.0 },
                    { new Guid("bbbbbbbb-bbbb-bbbb-bbbb-000000000031"), new Guid("eb3228bc-8b90-41b5-8a5a-e9faaf5e9048"), 0.0 },
                    { new Guid("bbbbbbbb-bbbb-bbbb-bbbb-000000000032"), new Guid("f5071dec-ea3e-4106-8d52-bb3f59fdb3aa"), 0.0 },
                    { new Guid("bbbbbbbb-bbbb-bbbb-bbbb-000000000033"), new Guid("f6f06957-a84d-4071-87d0-4b08e29888c5"), 0.0 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Games_DireTeamId",
                table: "Games",
                column: "DireTeamId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Games_RadiantTeamId",
                table: "Games",
                column: "RadiantTeamId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_PlayerDetails_PlayerId",
                table: "PlayerDetails",
                column: "PlayerId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_PlayerGames_PlayerId",
                table: "PlayerGames",
                column: "PlayerId");

            migrationBuilder.CreateIndex(
                name: "IX_PlayerStats_GameId",
                table: "PlayerStats",
                column: "GameId");

            migrationBuilder.CreateIndex(
                name: "IX_PlayerStats_HeroPlayedId",
                table: "PlayerStats",
                column: "HeroPlayedId");

            migrationBuilder.CreateIndex(
                name: "IX_PlayerStats_PlayerId",
                table: "PlayerStats",
                column: "PlayerId");

            migrationBuilder.CreateIndex(
                name: "IX_PlayerStats_TeamId",
                table: "PlayerStats",
                column: "TeamId");

            migrationBuilder.CreateIndex(
                name: "IX_PlayerTeams_TeamsId",
                table: "PlayerTeams",
                column: "TeamsId");

            migrationBuilder.CreateIndex(
                name: "IX_Teams_GameId",
                table: "Teams",
                column: "GameId");

            migrationBuilder.AddForeignKey(
                name: "FK_Games_Teams_DireTeamId",
                table: "Games",
                column: "DireTeamId",
                principalTable: "Teams",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Games_Teams_RadiantTeamId",
                table: "Games",
                column: "RadiantTeamId",
                principalTable: "Teams",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Games_Teams_DireTeamId",
                table: "Games");

            migrationBuilder.DropForeignKey(
                name: "FK_Games_Teams_RadiantTeamId",
                table: "Games");

            migrationBuilder.DropTable(
                name: "PlayerDetails");

            migrationBuilder.DropTable(
                name: "PlayerGames");

            migrationBuilder.DropTable(
                name: "PlayerStats");

            migrationBuilder.DropTable(
                name: "PlayerTeams");

            migrationBuilder.DropTable(
                name: "Heroes");

            migrationBuilder.DropTable(
                name: "Players");

            migrationBuilder.DropTable(
                name: "Teams");

            migrationBuilder.DropTable(
                name: "Games");
        }
    }
}
