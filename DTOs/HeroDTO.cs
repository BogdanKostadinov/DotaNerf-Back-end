﻿namespace DotaNerf.DTOs;

public class HeroDTO
{
    public int Id { get; set; }
    public required string Name { get; set; }
}

public class CreateHeroDTO
{
    public required string Name { get; set; }
}