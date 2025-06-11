using DotaNerf.Entities;

namespace DotaNerf.Data.SeededData;

public static class MockData
{
    // Define GUIDs for players, teams, and games
    public static readonly Guid RadiantTeamId = new Guid("d4f49d5e-4f4b-4d8a-9e4e-4f4b7d8a9e4e");
    public static readonly Guid DireTeamId = new Guid("e5f59d5e-5f5b-4e8a-9f5e-5f5b8e8a9f5e");

    public static readonly Guid Game1Id = new Guid("f6f69d5e-6f6b-4f8a-9f6e-6f6b9f8a9f6e");
    public static readonly Guid Game2Id = new Guid("b5f59d5e-5f5b-4e8a-9f5e-5f5b8e8a9f5e");

    public static List<Hero> SeedHeroes()
    {
        return new List<Hero>
        {
            new Hero { Id = 1, Name = "Abaddon" },
            new Hero { Id = 2, Name = "Alchemist" },
            new Hero { Id = 3, Name = "Ancient Apparition" },
            new Hero { Id = 4, Name = "Anti-Mage" },
            new Hero { Id = 5, Name = "Arc Warden" },
            new Hero { Id = 6, Name = "Axe" },
            new Hero { Id = 7, Name = "Bane" },
            new Hero { Id = 8, Name = "Batrider" },
            new Hero { Id = 9, Name = "Beastmaster" },
            new Hero { Id = 10, Name = "Bloodseeker" },
            new Hero { Id = 11, Name = "Bounty Hunter" },
            new Hero { Id = 12, Name = "Brewmaster" },
            new Hero { Id = 13, Name = "Bristleback" },
            new Hero { Id = 14, Name = "Broodmother" },
            new Hero { Id = 15, Name = "Centaur Warrunner" },
            new Hero { Id = 16, Name = "Chaos Knight" },
            new Hero { Id = 17, Name = "Chen" },
            new Hero { Id = 18, Name = "Clinkz" },
            new Hero { Id = 19, Name = "Clockwerk" },
            new Hero { Id = 20, Name = "Crystal Maiden" },
            new Hero { Id = 21, Name = "Dark Seer" },
            new Hero { Id = 22, Name = "Dark Willow" },
            new Hero { Id = 23, Name = "Dawnbreaker" },
            new Hero { Id = 24, Name = "Dazzle" },
            new Hero { Id = 25, Name = "Death Prophet" },
            new Hero { Id = 26, Name = "Disruptor" },
            new Hero { Id = 27, Name = "Doom" },
            new Hero { Id = 28, Name = "Dragon Knight" },
            new Hero { Id = 29, Name = "Drow Ranger" },
            new Hero { Id = 30, Name = "Earth Spirit" },
            new Hero { Id = 31, Name = "Earthshaker" },
            new Hero { Id = 32, Name = "Elder Titan" },
            new Hero { Id = 33, Name = "Ember Spirit" },
            new Hero { Id = 34, Name = "Enchantress" },
            new Hero { Id = 35, Name = "Enigma" },
            new Hero { Id = 36, Name = "Faceless Void" },
            new Hero { Id = 37, Name = "Grimstroke" },
            new Hero { Id = 38, Name = "Gyrocopter" },
            new Hero { Id = 39, Name = "Hoodwink" },
            new Hero { Id = 40, Name = "Huskar" },
            new Hero { Id = 41, Name = "Invoker" },
            new Hero { Id = 42, Name = "Io" },
            new Hero { Id = 43, Name = "Jakiro" },
            new Hero { Id = 44, Name = "Juggernaut" },
            new Hero { Id = 45, Name = "Keeper of the Light" },
            new Hero { Id = 46, Name = "Kunkka" },
            new Hero { Id = 121, Name = "Kez" },
            new Hero { Id = 47, Name = "Legion Commander" },
            new Hero { Id = 48, Name = "Leshrac" },
            new Hero { Id = 49, Name = "Lich" },
            new Hero { Id = 50, Name = "Lifestealer" },
            new Hero { Id = 51, Name = "Lina" },
            new Hero { Id = 52, Name = "Lion" },
            new Hero { Id = 53, Name = "Lone Druid" },
            new Hero { Id = 54, Name = "Luna" },
            new Hero { Id = 55, Name = "Lycan" },
            new Hero { Id = 56, Name = "Magnus" },
            new Hero { Id = 57, Name = "Marci" },
            new Hero { Id = 58, Name = "Mars" },
            new Hero { Id = 59, Name = "Medusa" },
            new Hero { Id = 60, Name = "Meepo" },
            new Hero { Id = 61, Name = "Mirana" },
            new Hero { Id = 62, Name = "Monkey King" },
            new Hero { Id = 63, Name = "Morphling" },
            new Hero { Id = 64, Name = "Muerta" },
            new Hero { Id = 65, Name = "Naga Siren" },
            new Hero { Id = 66, Name = "Nature's Prophet" },
            new Hero { Id = 67, Name = "Necrophos" },
            new Hero { Id = 68, Name = "Night Stalker" },
            new Hero { Id = 69, Name = "Nyx Assassin" },
            new Hero { Id = 70, Name = "Ogre Magi" },
            new Hero { Id = 71, Name = "Omniknight" },
            new Hero { Id = 72, Name = "Oracle" },
            new Hero { Id = 73, Name = "Outworld Destroyer" },
            new Hero { Id = 74, Name = "Pangolier" },
            new Hero { Id = 75, Name = "Phantom Assassin" },
            new Hero { Id = 76, Name = "Phantom Lancer" },
            new Hero { Id = 77, Name = "Phoenix" },
            new Hero { Id = 78, Name = "Primal Beast" },
            new Hero { Id = 79, Name = "Puck" },
            new Hero { Id = 80, Name = "Pudge" },
            new Hero { Id = 81, Name = "Pugna" },
            new Hero { Id = 82, Name = "Queen of Pain" },
            new Hero { Id = 83, Name = "Razor" },
            new Hero { Id = 84, Name = "Riki" },
            new Hero { Id = 85, Name = "Rubick" },
            new Hero { Id = 120, Name = "Ringmaster" },
            new Hero { Id = 86, Name = "Sand King" },
            new Hero { Id = 87, Name = "Shadow Demon" },
            new Hero { Id = 88, Name = "Shadow Fiend" },
            new Hero { Id = 89, Name = "Shadow Shaman" },
            new Hero { Id = 90, Name = "Silencer" },
            new Hero { Id = 91, Name = "Skywrath Mage" },
            new Hero { Id = 92, Name = "Slardar" },
            new Hero { Id = 93, Name = "Slark" },
            new Hero { Id = 94, Name = "Snapfire" },
            new Hero { Id = 95, Name = "Sniper" },
            new Hero { Id = 96, Name = "Spectre" },
            new Hero { Id = 97, Name = "Spirit Breaker" },
            new Hero { Id = 98, Name = "Storm Spirit" },
            new Hero { Id = 99, Name = "Sven" },
            new Hero { Id = 100, Name = "Techies" },
            new Hero { Id = 101, Name = "Templar Assassin" },
            new Hero { Id = 102, Name = "Terrorblade" },
            new Hero { Id = 103, Name = "Tidehunter" },
            new Hero { Id = 104, Name = "Timbersaw" },
            new Hero { Id = 105, Name = "Tinker" },
            new Hero { Id = 106, Name = "Tiny" },
            new Hero { Id = 107, Name = "Treant Protector" },
            new Hero { Id = 108, Name = "Troll Warlord" },
            new Hero { Id = 109, Name = "Tusk" },
            new Hero { Id = 110, Name = "Underlord" },
            new Hero { Id = 111, Name = "Undying" },
            new Hero { Id = 112, Name = "Ursa" },
            new Hero { Id = 113, Name = "Vengeful Spirit" },
            new Hero { Id = 114, Name = "Venomancer" },
            new Hero { Id = 115, Name = "Viper" },
            new Hero { Id = 116, Name = "Void Spirit" },
            new Hero { Id = 117, Name = "Warlock" },
            new Hero { Id = 118, Name = "Wraith King" },
            new Hero { Id = 119, Name = "Zeus" }
        };

    }
    public static List<Game> SeedGames()
    {
        return new List<Game>
        {
            new Game
            {
                Id = Game1Id,
                WinningTeam = TeamName.Radiant,
                RadiantTeamId = RadiantTeamId,
                DireTeamId = DireTeamId,
            }
        };
    }
    public static List<Player> SeedPlayers()
    {
        return new List<Player>
        {
            new Player { Id = PlayerIds.VeniPlayerId, Name = "Veni", PlayerDetailsId = new Guid("bbbbbbbb-bbbb-bbbb-bbbb-000000000002") },
            new Player { Id = PlayerIds.RetarDioPlayerId, Name = "Retar Dio ( kolega )", PlayerDetailsId = new Guid("bbbbbbbb-bbbb-bbbb-bbbb-000000000003") },
            new Player { Id = PlayerIds.SteliPlayerId, Name = "Steli", PlayerDetailsId = new Guid("bbbbbbbb-bbbb-bbbb-bbbb-000000000004") },
            new Player { Id = PlayerIds.KriskataPlayerId, Name = "Kriskata", PlayerDetailsId = new Guid("bbbbbbbb-bbbb-bbbb-bbbb-000000000005") },
            new Player { Id = PlayerIds.DJMishoPlayerId, Name = "DJ misho", PlayerDetailsId = new Guid("bbbbbbbb-bbbb-bbbb-bbbb-000000000006") },
            new Player { Id = PlayerIds.StoqnPlayerId, Name = "Stoqn (kolega )", PlayerDetailsId = new Guid("bbbbbbbb-bbbb-bbbb-bbbb-000000000007") },
            new Player { Id = PlayerIds.KunchoPlayerId, Name = "Kuncho", PlayerDetailsId = new Guid("bbbbbbbb-bbbb-bbbb-bbbb-000000000008") },
            new Player { Id = PlayerIds.SofianecaPlayerId, Name = "Sofianeca", PlayerDetailsId = new Guid("bbbbbbbb-bbbb-bbbb-bbbb-000000000009") },
            new Player { Id = PlayerIds.MartoPlayerId, Name = "Marto", PlayerDetailsId = new Guid("bbbbbbbb-bbbb-bbbb-bbbb-000000000001") },
            new Player { Id = PlayerIds.RumenPlayerId, Name = "Rumen", PlayerDetailsId = new Guid("bbbbbbbb-bbbb-bbbb-bbbb-000000000010") },
            new Player { Id = PlayerIds.BoburKurvaPlayerId, Name = "Bobur Kurva", PlayerDetailsId = new Guid("bbbbbbbb-bbbb-bbbb-bbbb-000000000011") },
            new Player { Id = PlayerIds.VanetoPlayerId, Name = "Vaneto", PlayerDetailsId = new Guid("bbbbbbbb-bbbb-bbbb-bbbb-000000000012") },
            new Player { Id = PlayerIds.MarioPlayerId, Name = "Mario", PlayerDetailsId = new Guid("bbbbbbbb-bbbb-bbbb-bbbb-000000000013") },
            new Player { Id = PlayerIds.PanicPlayerId, Name = "Panic", PlayerDetailsId = new Guid("bbbbbbbb-bbbb-bbbb-bbbb-000000000014") },
            new Player { Id = PlayerIds.TheJokerPlayerId, Name = "The Joker", PlayerDetailsId = new Guid("bbbbbbbb-bbbb-bbbb-bbbb-000000000015") },
            new Player { Id = PlayerIds.DanithedogPlayerId, Name = "Danithedog", PlayerDetailsId = new Guid("bbbbbbbb-bbbb-bbbb-bbbb-000000000016") },
            new Player { Id = PlayerIds.NevermorePlayerId, Name = "Nevermore", PlayerDetailsId = new Guid("bbbbbbbb-bbbb-bbbb-bbbb-000000000017") },
            new Player { Id = PlayerIds.ModeTopuriaPlayerId, Name = "Mode : topuria", PlayerDetailsId = new Guid("bbbbbbbb-bbbb-bbbb-bbbb-000000000018") },
            new Player { Id = PlayerIds.ZlotoKuchePlayerId, Name = "Zloto kuche", PlayerDetailsId = new Guid("bbbbbbbb-bbbb-bbbb-bbbb-000000000019") },
            new Player { Id = PlayerIds.BabaYagaPlayerId, Name = "Baba Yaga", PlayerDetailsId = new Guid("bbbbbbbb-bbbb-bbbb-bbbb-000000000020") },
            new Player { Id = PlayerIds.SmurfPlayerId, Name = "Smurf", PlayerDetailsId = new Guid("bbbbbbbb-bbbb-bbbb-bbbb-000000000021") },
            new Player { Id = PlayerIds.PeacelockPlayerId, Name = "Peacelock", PlayerDetailsId = new Guid("bbbbbbbb-bbbb-bbbb-bbbb-000000000022") },
            new Player { Id = PlayerIds.VeePlayerId, Name = "Vee", PlayerDetailsId = new Guid("bbbbbbbb-bbbb-bbbb-bbbb-000000000023") },
            new Player { Id = PlayerIds.RMZPlayerId, Name = "RMZ", PlayerDetailsId = new Guid("bbbbbbbb-bbbb-bbbb-bbbb-000000000024") },
            new Player { Id = PlayerIds.TeperkulesPlayerId, Name = "teperkules", PlayerDetailsId = new Guid("bbbbbbbb-bbbb-bbbb-bbbb-000000000025") },
            new Player { Id = PlayerIds.VetirinariPlayerId, Name = "Vetirinari", PlayerDetailsId = new Guid("bbbbbbbb-bbbb-bbbb-bbbb-000000000026") },
            new Player { Id = PlayerIds.BoratBGPlayerId, Name = "Borat BG", PlayerDetailsId = new Guid("bbbbbbbb-bbbb-bbbb-bbbb-000000000027") },
            new Player { Id = PlayerIds.Pro1PlayerId, Name = "Pro 1", PlayerDetailsId = new Guid("bbbbbbbb-bbbb-bbbb-bbbb-000000000028") },
            new Player { Id = PlayerIds.FisheyePlayerId, Name = "Fisheye", PlayerDetailsId = new Guid("bbbbbbbb-bbbb-bbbb-bbbb-000000000029") },
            new Player { Id = PlayerIds.BatkoBieSladkoPrimePlayerId, Name = "Batko bie sladko prime", PlayerDetailsId = new Guid("bbbbbbbb-bbbb-bbbb-bbbb-000000000030") },
            new Player { Id = PlayerIds.PitbgrPlayerId, Name = "pitbgr", PlayerDetailsId = new Guid("bbbbbbbb-bbbb-bbbb-bbbb-000000000031") },
            new Player { Id = PlayerIds.SvetorontotokyoPlayerId, Name = "Svetorontotokyo", PlayerDetailsId = new Guid("bbbbbbbb-bbbb-bbbb-bbbb-000000000032") },
            new Player { Id = PlayerIds.ReiPlayerId, Name = "Rei", PlayerDetailsId = new Guid("bbbbbbbb-bbbb-bbbb-bbbb-000000000033") }
        };
    }
    public static List<PlayerDetails> SeedPlayerDetails()
    {
        return new List<PlayerDetails>
        {
            new PlayerDetails { Id = new Guid("bbbbbbbb-bbbb-bbbb-bbbb-000000000001"), PlayerId = PlayerIds.MartoPlayerId, Winrate = 0, TotalGames = 0, GamesWon = 0, GamesLost = 0, PlayerGroup = PlayerGroup.Kulalii },
            new PlayerDetails { Id = new Guid("bbbbbbbb-bbbb-bbbb-bbbb-000000000002"), PlayerId = PlayerIds.VeniPlayerId, Winrate = 0, TotalGames = 0, GamesWon = 0, GamesLost = 0, PlayerGroup = PlayerGroup.Kulalii },
            new PlayerDetails { Id = new Guid("bbbbbbbb-bbbb-bbbb-bbbb-000000000003"), PlayerId = PlayerIds.RetarDioPlayerId, Winrate = 0, TotalGames = 0, GamesWon = 0, GamesLost = 0, PlayerGroup = PlayerGroup.Poznati },
            new PlayerDetails { Id = new Guid("bbbbbbbb-bbbb-bbbb-bbbb-000000000004"), PlayerId = PlayerIds.SteliPlayerId, Winrate = 0, TotalGames = 0, GamesWon = 0, GamesLost = 0, PlayerGroup = PlayerGroup.Poznati },
            new PlayerDetails { Id = new Guid("bbbbbbbb-bbbb-bbbb-bbbb-000000000005"), PlayerId = PlayerIds.KriskataPlayerId, Winrate = 0, TotalGames = 0, GamesWon = 0, GamesLost = 0, PlayerGroup = PlayerGroup.Kulalii },
            new PlayerDetails { Id = new Guid("bbbbbbbb-bbbb-bbbb-bbbb-000000000006"), PlayerId = PlayerIds.DJMishoPlayerId, Winrate = 0, TotalGames = 0, GamesWon = 0, GamesLost = 0, PlayerGroup = PlayerGroup.Kulalii },
            new PlayerDetails { Id = new Guid("bbbbbbbb-bbbb-bbbb-bbbb-000000000007"), PlayerId = PlayerIds.StoqnPlayerId, Winrate = 0, TotalGames = 0, GamesWon = 0, GamesLost = 0, PlayerGroup = PlayerGroup.Poznati },
            new PlayerDetails { Id = new Guid("bbbbbbbb-bbbb-bbbb-bbbb-000000000008"), PlayerId = PlayerIds.KunchoPlayerId, Winrate = 0, TotalGames = 0, GamesWon = 0, GamesLost = 0, PlayerGroup = PlayerGroup.Kulalii },
            new PlayerDetails { Id = new Guid("bbbbbbbb-bbbb-bbbb-bbbb-000000000009"), PlayerId = PlayerIds.SofianecaPlayerId, Winrate = 0, TotalGames = 0, GamesWon = 0, GamesLost = 0, PlayerGroup = PlayerGroup.Kulalii },
            new PlayerDetails { Id = new Guid("bbbbbbbb-bbbb-bbbb-bbbb-000000000010"), PlayerId = PlayerIds.RumenPlayerId, Winrate = 0, TotalGames = 0, GamesWon = 0, GamesLost = 0, PlayerGroup = PlayerGroup.Kulalii },
            new PlayerDetails { Id = new Guid("bbbbbbbb-bbbb-bbbb-bbbb-000000000011"), PlayerId = PlayerIds.BoburKurvaPlayerId, Winrate = 0, TotalGames = 0, GamesWon = 0, GamesLost = 0, PlayerGroup = PlayerGroup.Poznati },
            new PlayerDetails { Id = new Guid("bbbbbbbb-bbbb-bbbb-bbbb-000000000012"), PlayerId = PlayerIds.VanetoPlayerId, Winrate = 0, TotalGames = 0, GamesWon = 0, GamesLost = 0, PlayerGroup = PlayerGroup.Kulalii },
            new PlayerDetails { Id = new Guid("bbbbbbbb-bbbb-bbbb-bbbb-000000000013"), PlayerId = PlayerIds.MarioPlayerId, Winrate = 0, TotalGames = 0, GamesWon = 0, GamesLost = 0, PlayerGroup = PlayerGroup.Kulalii },
            new PlayerDetails { Id = new Guid("bbbbbbbb-bbbb-bbbb-bbbb-000000000014"), PlayerId = PlayerIds.PanicPlayerId, Winrate = 0, TotalGames = 0, GamesWon = 0, GamesLost = 0, PlayerGroup = PlayerGroup.Poznati },
            new PlayerDetails { Id = new Guid("bbbbbbbb-bbbb-bbbb-bbbb-000000000015"), PlayerId = PlayerIds.TheJokerPlayerId, Winrate = 0, TotalGames = 0, GamesWon = 0, GamesLost = 0, PlayerGroup = PlayerGroup.Poznati },
            new PlayerDetails { Id = new Guid("bbbbbbbb-bbbb-bbbb-bbbb-000000000016"), PlayerId = PlayerIds.DanithedogPlayerId, Winrate = 0, TotalGames = 0, GamesWon = 0, GamesLost = 0, PlayerGroup = PlayerGroup.Poznati },
            new PlayerDetails { Id = new Guid("bbbbbbbb-bbbb-bbbb-bbbb-000000000017"), PlayerId = PlayerIds.NevermorePlayerId, Winrate = 0, TotalGames = 0, GamesWon = 0, GamesLost = 0, PlayerGroup = PlayerGroup.Randoms },
            new PlayerDetails { Id = new Guid("bbbbbbbb-bbbb-bbbb-bbbb-000000000018"), PlayerId = PlayerIds.ModeTopuriaPlayerId, Winrate = 0, TotalGames = 0, GamesWon = 0, GamesLost = 0, PlayerGroup = PlayerGroup.Randoms },
            new PlayerDetails { Id = new Guid("bbbbbbbb-bbbb-bbbb-bbbb-000000000019"), PlayerId = PlayerIds.ZlotoKuchePlayerId, Winrate = 0, TotalGames = 0, GamesWon = 0, GamesLost = 0, PlayerGroup = PlayerGroup.Randoms },
            new PlayerDetails { Id = new Guid("bbbbbbbb-bbbb-bbbb-bbbb-000000000020"), PlayerId = PlayerIds.BabaYagaPlayerId, Winrate = 0, TotalGames = 0, GamesWon = 0, GamesLost = 0, PlayerGroup = PlayerGroup.Poznati },
            new PlayerDetails { Id = new Guid("bbbbbbbb-bbbb-bbbb-bbbb-000000000021"), PlayerId = PlayerIds.SmurfPlayerId, Winrate = 0, TotalGames = 0, GamesWon = 0, GamesLost = 0, PlayerGroup = PlayerGroup.Randoms },
            new PlayerDetails { Id = new Guid("bbbbbbbb-bbbb-bbbb-bbbb-000000000022"), PlayerId = PlayerIds.PeacelockPlayerId, Winrate = 0, TotalGames = 0, GamesWon = 0, GamesLost = 0, PlayerGroup = PlayerGroup.Randoms },
            new PlayerDetails { Id = new Guid("bbbbbbbb-bbbb-bbbb-bbbb-000000000023"), PlayerId = PlayerIds.VeePlayerId, Winrate = 0, TotalGames = 0, GamesWon = 0, GamesLost = 0, PlayerGroup = PlayerGroup.Randoms },
            new PlayerDetails { Id = new Guid("bbbbbbbb-bbbb-bbbb-bbbb-000000000024"), PlayerId = PlayerIds.RMZPlayerId, Winrate = 0, TotalGames = 0, GamesWon = 0, GamesLost = 0, PlayerGroup = PlayerGroup.Randoms },
            new PlayerDetails { Id = new Guid("bbbbbbbb-bbbb-bbbb-bbbb-000000000025"), PlayerId = PlayerIds.TeperkulesPlayerId, Winrate = 0, TotalGames = 0, GamesWon = 0, GamesLost = 0, PlayerGroup = PlayerGroup.Randoms },
            new PlayerDetails { Id = new Guid("bbbbbbbb-bbbb-bbbb-bbbb-000000000026"), PlayerId = PlayerIds.VetirinariPlayerId, Winrate = 0, TotalGames = 0, GamesWon = 0, GamesLost = 0, PlayerGroup = PlayerGroup.Poznati },
            new PlayerDetails { Id = new Guid("bbbbbbbb-bbbb-bbbb-bbbb-000000000027"), PlayerId = PlayerIds.BoratBGPlayerId, Winrate = 0, TotalGames = 0, GamesWon = 0, GamesLost = 0, PlayerGroup = PlayerGroup.Poznati },
            new PlayerDetails { Id = new Guid("bbbbbbbb-bbbb-bbbb-bbbb-000000000028"), PlayerId = PlayerIds.Pro1PlayerId, Winrate = 0, TotalGames = 0, GamesWon = 0, GamesLost = 0, PlayerGroup = PlayerGroup.Randoms },
            new PlayerDetails { Id = new Guid("bbbbbbbb-bbbb-bbbb-bbbb-000000000029"), PlayerId = PlayerIds.FisheyePlayerId, Winrate = 0, TotalGames = 0, GamesWon = 0, GamesLost = 0, PlayerGroup = PlayerGroup.Randoms },
            new PlayerDetails { Id = new Guid("bbbbbbbb-bbbb-bbbb-bbbb-000000000030"), PlayerId = PlayerIds.BatkoBieSladkoPrimePlayerId, Winrate = 0, TotalGames = 0, GamesWon = 0, GamesLost = 0, PlayerGroup = PlayerGroup.Randoms },
            new PlayerDetails { Id = new Guid("bbbbbbbb-bbbb-bbbb-bbbb-000000000031"), PlayerId = PlayerIds.PitbgrPlayerId, Winrate = 0, TotalGames = 0, GamesWon = 0, GamesLost = 0, PlayerGroup = PlayerGroup.Randoms },
            new PlayerDetails { Id = new Guid("bbbbbbbb-bbbb-bbbb-bbbb-000000000032"), PlayerId = PlayerIds.SvetorontotokyoPlayerId, Winrate = 0, TotalGames = 0, GamesWon = 0, GamesLost = 0, PlayerGroup = PlayerGroup.Randoms },
            new PlayerDetails { Id = new Guid("bbbbbbbb-bbbb-bbbb-bbbb-000000000033"), PlayerId = PlayerIds.ReiPlayerId, Winrate = 0, TotalGames = 0, GamesWon = 0, GamesLost = 0, PlayerGroup = PlayerGroup.Randoms }
        };

    }
    public static List<Team> SeedTeams()
    {
        return new List<Team>
        {
            new Team
            {
                Id = RadiantTeamId,
                Name = TeamName.Radiant
            },
            new Team
            {
                Id = DireTeamId,
                Name = TeamName.Dire
            }
        };
    }
    public static List<PlayerStats> SeedPlayerStats()
    {
        return new List<PlayerStats>
        {
            new PlayerStats
            {
                Id = new Guid("88889d5e-888b-488a-988e-888b188a988e"),
                HeroPlayedId = 1,
                Kills = 5,
                Deaths = 3,
                Assists = 10,
                PlayerId = PlayerIds.RetarDioPlayerId,
                GameId = Game1Id,
                TeamId = RadiantTeamId,
            },
            new PlayerStats
            {
                Id = new Guid("99999d5e-999b-499a-999e-999b399a999e"),
                HeroPlayedId = 3,
                Kills = 12,
                Deaths = 4,
                Assists = 8,
                PlayerId = PlayerIds.VeniPlayerId,
                GameId = Game1Id,
                TeamId = DireTeamId,
            },
        };
    }

    public static List<User> SeedUsers()
    {
        return new List<User>
        {
            new User
            {
                Id = Guid.Parse("550e8400-e29b-41d4-a716-446655440000"),
                UserName = "admin",
                Email = "admin@dotanerf.com",
                Password = "admin"
            }
        };
    }
}

//public static List<PlayerDetails> SeedPlayerDetails()
//{
//    return new List<PlayerDetails>
//    {
//        new PlayerDetails
//        {
//            Id = new Guid("d5f49d5e-4f4b-4c8a-9e4e-4f4b7c8a9e4e"),
//            PlayerId = DummyPlayerId,
//            Winrate = 60,
//            TotalGames = 15,
//            GamesWon = 9,
//            GamesLost = 6
//        },
//        new PlayerDetails
//        {
//            Id = new Guid("e6f59d5e-5f4b-4c8a-9f5e-5f4b8c8a9f5e"),
//            PlayerId = VeniPlayerId,
//            Winrate = 59,
//            TotalGames = 17,
//            GamesWon = 10,
//            GamesLost = 7
//        },
//        new PlayerDetails
//        {
//            Id = new Guid("d4f49d5e-5f4b-4c8a-9e4e-5f4b7c8a9e4e"),
//            PlayerId = new Guid("d4f49d5e-4f4b-4c8a-9e4e-4f4b7c8a9e4e"),
//            Winrate = 60,
//            TotalGames = 15,
//            GamesWon = 9,
//            GamesLost = 6
//        },
//        new PlayerDetails
//        {
//            Id = new Guid("e5f59d5e-5f4b-4c8a-9f5e-5f4b8c8a9f5e"),
//            PlayerId = new Guid("e5f59d5e-5f4b-4c8a-9f5e-5f4b8c8a9f5e"),
//            Winrate = 59,
//            TotalGames = 17,
//            GamesWon = 10,
//            GamesLost = 7
//        },
//        new PlayerDetails
//        {
//            Id = new Guid("f6f69d5e-6f4b-4c8a-9f6e-6f4b9c8a9f6e"),
//            PlayerId = new Guid("f6f69d5e-6f4b-4c8a-9f6e-6f4b9c8a9f6e"),
//            Winrate = 50,
//            TotalGames = 14,
//            GamesWon = 7,
//            GamesLost = 7
//        },
//        new PlayerDetails
//        {
//            Id = new Guid("07f79d5e-7f4b-4c8a-9f7e-7f4b0c8a9f7e"),
//            PlayerId = new Guid("07f79d5e-7f4b-4c8a-9f7e-7f4b0c8a9f7e"),
//            Winrate = 52,
//            TotalGames = 19,
//            GamesWon = 10,
//            GamesLost = 9
//        },
//        new PlayerDetails
//        {
//            Id = new Guid("18f89d5e-8f4b-4c8a-9f8e-8f4b1c8a9f8e"),
//            PlayerId = new Guid("18f89d5e-8f4b-4c8a-9f8e-8f4b1c8a9f8e"),
//            Winrate = 40,
//            TotalGames = 15,
//            GamesWon = 6,
//            GamesLost = 9
//        },
//        new PlayerDetails
//        {
//            Id = new Guid("29f99d5e-9f4b-4c8a-9f9e-9f4b2c8a9f9e"),
//            PlayerId = new Guid("29f99d5e-9f4b-4c8a-9f9e-9f4b2c8a9f9e"),
//            Winrate = 38,
//            TotalGames = 16,
//            GamesWon = 6,
//            GamesLost = 10
//        },
//        new PlayerDetails
//        {
//            Id = new Guid("30f09d5e-0f4b-4c8a-9f0e-0f4b3c8a9f0e"),
//            PlayerId = new Guid("30f09d5e-0f4b-4c8a-9f0e-0f4b3c8a9f0e"),
//            Winrate = 37,
//            TotalGames = 19,
//            GamesWon = 7,
//            GamesLost = 12
//        },
//        new PlayerDetails
//        {
//            Id = new Guid("41f19d5e-1f4b-4c8a-9f1e-1f4b4c8a9f1e"),
//            PlayerId = new Guid("41f19d5e-1f4b-4c8a-9f1e-1f4b4c8a9f1e"),
//            Winrate = 20,
//            TotalGames = 5,
//            GamesWon = 1,
//            GamesLost = 4
//        },
//        new PlayerDetails
//        {
//            Id = new Guid("52f29d5e-2f4b-4c8a-9f2e-2f4b5c8a9f2e"),
//            PlayerId = new Guid("52f29d5e-2f4b-4c8a-9f2e-2f4b5c8a9f2e"),
//            Winrate = 25,
//            TotalGames = 8,
//            GamesWon = 2,
//            GamesLost = 6
//        },
//        new PlayerDetails
//        {
//            Id = new Guid("63f39d5e-3f4b-4c8a-9f3e-3f4b6c8a9f3e"),
//            PlayerId = new Guid("63f39d5e-3f4b-4c8a-9f3e-3f4b6c8a9f3e"),
//            Winrate = 0,
//            TotalGames = 6,
//            GamesWon = 0,
//            GamesLost = 6
//        },
//        new PlayerDetails
//        {
//            Id = new Guid("74f49d5e-4f4b-4c8a-9f4e-4f4b7c8a9f4e"),
//            PlayerId = new Guid("74f49d5e-4f4b-4c8a-9f4e-4f4b7c8a9f4e"),
//            Winrate = 62,
//            TotalGames = 8,
//            GamesWon = 5,
//            GamesLost = 3
//        },
//        new PlayerDetails
//        {
//            Id = new Guid("85f59d5e-5f4b-4c8a-9f5e-5f4b8c8a9f5e"),
//            PlayerId = new Guid("85f59d5e-5f4b-4c8a-9f5e-5f4b8c8a9f5e"),
//            Winrate = 0,
//            TotalGames = 0,
//            GamesWon = 0,
//            GamesLost = 0
//        },
//        new PlayerDetails
//        {
//            Id = new Guid("96f69d5e-6f4b-4c8a-9f6e-6f4b9c8a9f6e"),
//            PlayerId = new Guid("96f69d5e-6f4b-4c8a-9f6e-6f4b9c8a9f6e"),
//            Winrate = 0,
//            TotalGames = 0,
//            GamesWon = 0,
//            GamesLost = 0
//        },
//        new PlayerDetails
//        {
//            Id = new Guid("a7f79d5e-7f4b-4c8a-9f7e-7f4b0c8a9f7e"),
//            PlayerId = new Guid("a7f79d5e-7f4b-4c8a-9f7e-7f4b0c8a9f7e"),
//            Winrate = 0,
//            TotalGames = 0,
//            GamesWon = 0,
//            GamesLost = 0
//        },
//        new PlayerDetails
//        {
//            Id = new Guid("b8f89d5e-8f4b-4c8a-9f8e-8f4b1c8a9f8e"),
//            PlayerId = new Guid("b8f89d5e-8f4b-4c8a-9f8e-8f4b1c8a9f8e"),
//            Winrate = 0,
//            TotalGames = 0,
//            GamesWon = 0,
//            GamesLost = 0
//        }
//    };
//}
public static class PlayerIds
{
    public static readonly Guid VeniPlayerId = new Guid("0de33ebf-6f2d-4f37-a41f-c92a8387a16f");
    public static readonly Guid RetarDioPlayerId = new Guid("158f0cd7-315a-4d60-8a4a-3537766b2958");
    public static readonly Guid SteliPlayerId = new Guid("2637179a-65b0-4af7-b7b2-0dc0b044a9c6");
    public static readonly Guid KriskataPlayerId = new Guid("2f08b795-c2ee-460f-9102-489dcb034a59");
    public static readonly Guid DJMishoPlayerId = new Guid("2f25fdca-7016-4c2b-904e-154813b60210");
    public static readonly Guid StoqnPlayerId = new Guid("2f3ab1f0-f334-4239-8793-87d92239d5bb");
    public static readonly Guid KunchoPlayerId = new Guid("32830ea1-39ad-469c-96bd-3040f2d49f6a");
    public static readonly Guid SofianecaPlayerId = new Guid("35b0e246-4545-4079-b258-8ba67ac756fa");
    public static readonly Guid RumenPlayerId = new Guid("3d6a9560-592d-49e5-bfe6-29d2fe589d42");
    public static readonly Guid BoburKurvaPlayerId = new Guid("3e85b928-0684-4300-9a23-c4d3c64ab59f");
    public static readonly Guid VanetoPlayerId = new Guid("40270ce1-9235-4720-9097-b26fcd7ebdc3");
    public static readonly Guid MartoPlayerId = new Guid("013986ba-03a2-4e5f-a54e-1e1a677c5593");
    public static readonly Guid MarioPlayerId = new Guid("45193089-0738-40c2-951b-ec481ca21786");
    public static readonly Guid PanicPlayerId = new Guid("4f1f9cac-418b-4356-94c6-144eac70c0a9");
    public static readonly Guid TheJokerPlayerId = new Guid("5514f903-232a-4866-9e0b-4740b56de8fc");
    public static readonly Guid DanithedogPlayerId = new Guid("6119f1a3-884c-4f22-9fa4-401e55917378");
    public static readonly Guid NevermorePlayerId = new Guid("617747ee-a832-47be-aa30-c99310456113");
    public static readonly Guid ModeTopuriaPlayerId = new Guid("632691d7-db1b-4fb5-9e83-893250e14474");
    public static readonly Guid ZlotoKuchePlayerId = new Guid("71e4bb90-31dd-4cf7-9628-9eb8462e8a03");
    public static readonly Guid BabaYagaPlayerId = new Guid("75c32438-809f-4f31-9ae3-d79ad2b56c29");
    public static readonly Guid SmurfPlayerId = new Guid("8441c8de-e7e7-4faa-9869-99e95fa0791b");
    public static readonly Guid PeacelockPlayerId = new Guid("90eae6b2-6395-49a8-9bfa-df51eac66c90");
    public static readonly Guid VeePlayerId = new Guid("a7af794d-dbdc-4a05-a4f4-ebbb1ef0a0fb");
    public static readonly Guid RMZPlayerId = new Guid("a807403e-9e93-4a3b-9a4b-6eb9a6406687");
    public static readonly Guid TeperkulesPlayerId = new Guid("c3219456-5c5d-4d18-9980-032627844744");
    public static readonly Guid VetirinariPlayerId = new Guid("cce185ad-c8d0-48ba-ad96-2ed4508b7dad");
    public static readonly Guid BoratBGPlayerId = new Guid("d226779e-6c47-46a2-96cf-89f6c7502018");
    public static readonly Guid Pro1PlayerId = new Guid("d5d3d965-f59c-46ce-8bb4-929cc261491a");
    public static readonly Guid FisheyePlayerId = new Guid("d68b00ec-3ee2-4069-aa06-c74dce1946ce");
    public static readonly Guid BatkoBieSladkoPrimePlayerId = new Guid("e7cc43a2-1eb1-4df4-837a-e264d386a235");
    public static readonly Guid PitbgrPlayerId = new Guid("eb3228bc-8b90-41b5-8a5a-e9faaf5e9048");
    public static readonly Guid SvetorontotokyoPlayerId = new Guid("f5071dec-ea3e-4106-8d52-bb3f59fdb3aa");
    public static readonly Guid ReiPlayerId = new Guid("f6f06957-a84d-4071-87d0-4b08e29888c5");
    public static readonly Guid UnknownPlayerId = new Guid("b8f89d5e-8f4b-4c8a-9f8e-8f4b1c8a9f8e");
}


