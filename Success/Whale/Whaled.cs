﻿
namespace Whaled;
public class Whale( string name, double weight, double length, string species, int age, int birthYear, string habitat, bool isFamale)
{
    public string Name { get; private set; } = name;
    public string Species { get; private set; } = species;
    public int Age { get; private set; } = age;

    public double Weight { get; private set; } = weight;
    public double Length { get; private set; } = length;

    public int BirthYear { get; private set; } = birthYear;
    public string Habitat { get; private set; } = habitat;
    public bool IsFemale { get; private set; } = isFamale;
}