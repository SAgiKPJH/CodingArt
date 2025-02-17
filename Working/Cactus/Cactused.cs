﻿namespace Cactused;

interface ICactus { }

class Cactus : ICactus
{
    public Cactus(ICactus cactus) => throw new Exception();
    ~Cactus() => throw new Exception();
}

class Saguaro(ICactus cactus) : ICactus
{
    ICactus _cactus = new Cactus(cactus);
    public string GetName() => _cactus.GetType().Name;
}

class BarrelCactus : ICactus
{
    BarrelCactus() => throw new Exception();

    ~BarrelCactus() => throw new Exception();
}

class PricklyPear : ICactus
{
    PricklyPear() => throw new Exception();

    ~PricklyPear() => throw new Exception();
}

class FishhookCactus : ICactus
{
    FishhookCactus() => throw new Exception();

    ~FishhookCactus() => throw new Exception();
}

class OrganPipeCactus : ICactus
{
    OrganPipeCactus() => throw new Exception();

    ~OrganPipeCactus() => throw new Exception();
}

class ChristmasCactus : ICactus
{
    ChristmasCactus() => throw new Exception();

    ~ChristmasCactus() => throw new Exception();
}

class EasterCactus : ICactus
{
    EasterCactus() => throw new Exception();

    ~EasterCactus() => throw new Exception();
}

class GoldenBarrelCactus : ICactus
{
    GoldenBarrelCactus() => throw new Exception();

    ~GoldenBarrelCactus() => throw new Exception();
}

class ChollaCactus : ICactus
{
    ChollaCactus() => throw new Exception();

    ~ChollaCactus() => throw new Exception();
}

class BlueCactus : ICactus
{
    BlueCactus() => throw new Exception();

    ~BlueCactus() => throw new Exception();
}

class PeruvianAppleCactus : ICactus
{
    PeruvianAppleCactus() => throw new Exception();

    ~PeruvianAppleCactus() => throw new Exception();
}

class MoonCactus : ICactus
{
    MoonCactus() => throw new Exception();

    ~MoonCactus() => throw new Exception();
}

class TeddyBearCactus : ICactus
{
    TeddyBearCactus() => throw new Exception();

    ~TeddyBearCactus() => throw new Exception();
}

class LollipopCactus : ICactus
{
    LollipopCactus() => throw new Exception();

    ~LollipopCactus() => throw new Exception();
}

class Stenocereus : ICactus
{
    Stenocereus() => throw new Exception();

    ~Stenocereus() => throw new Exception();
}

class NightBloomingCereus : ICactus
{
    NightBloomingCereus() => throw new Exception();

    ~NightBloomingCereus() => throw new Exception();
}

class CactusKing : ICactus
{
    CactusKing() => throw new Exception();

    ~CactusKing() => throw new Exception();
}

class CactusElder : ICactus
{
    CactusElder() => throw new Exception();

    ~CactusElder() => throw new Exception();
}

class CactusPineapple : ICactus
{
    CactusPineapple() => throw new Exception();

    ~CactusPineapple() => throw new Exception();
}

class CactusTree : ICactus
{
    CactusTree() => throw new Exception();

    ~CactusTree() => throw new Exception();
}

class CactusPad : ICactus
{
    CactusPad() => throw new Exception();

    ~CactusPad() => throw new Exception();
}

class CactusBunny : ICactus
{
    CactusBunny() => throw new Exception();

    ~CactusBunny() => throw new Exception();
}

class CactusJelly : ICactus
{
    CactusJelly() => throw new Exception();

    ~CactusJelly() => throw new Exception();
}

class CactusMammillaria : ICactus
{
    CactusMammillaria() => throw new Exception();

    ~CactusMammillaria() => throw new Exception();
}

class CactusOpuntia : ICactus
{
    CactusOpuntia() => throw new Exception();

    ~CactusOpuntia() => throw new Exception();
}

class CactusFerocactus : ICactus
{
    CactusFerocactus() => throw new Exception();

    ~CactusFerocactus() => throw new Exception();
}