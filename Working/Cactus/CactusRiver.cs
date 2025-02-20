namespace CactusRiver;

class  Cactust : ICactus {
public Cactust (ICactus cactus) => throw new Exception(); ~Cactust() => throw new Exception(); }

public interface ICactus{}
public sealed class Cactus : ICactus{public Cactus(ICactus cactus) => throw new Exception();~Cactus() => throw new Exception();}
public sealed class Saguaro(ICactus cactus) : ICactus{ICactus _cactus = new Cactus(cactus);public string GetName() => _cactus.GetType().Name;}
public sealed class CactusPad : ICactus{CactusPad() => throw new Exception();~CactusPad() => throw new Exception();}
public sealed class PricklyPear : ICactus{PricklyPear() => throw new Exception();~PricklyPear() => throw new Exception();}
public sealed class BarrelCactus : ICactus{BarrelCactus() => throw new Exception();~BarrelCactus() => throw new Exception();}
public sealed class FishhookCactus : ICactus{FishhookCactus() => throw new Exception();~FishhookCactus() => throw new Exception();}
public sealed class OrganPipeCactus : ICactus{OrganPipeCactus() => throw new Exception();~OrganPipeCactus() => throw new Exception();}
public sealed class ChristmasCactus : ICactus{ChristmasCactus() => throw new Exception();~ChristmasCactus() => throw new Exception();}
public sealed class EasterCactus : ICactus{EasterCactus() => throw new Exception();~EasterCactus() => throw new Exception();}
public sealed class ChollaCactus : ICactus{ChollaCactus() => throw new Exception();~ChollaCactus() => throw new Exception();}
public sealed class BlueCactus : ICactus{BlueCactus() => throw new Exception();~BlueCactus() => throw new Exception();}
public sealed class MoonCactus : ICactus{MoonCactus() => throw new Exception();~MoonCactus() => throw new Exception();}
public sealed class LollipopCactus : ICactus{LollipopCactus() => throw new Exception();~LollipopCactus() => throw new Exception();}
public sealed class TeddyBearCactus : ICactus{TeddyBearCactus() => throw new Exception();~TeddyBearCactus() => throw new Exception();}
public sealed class GoldenBarrelCactus : ICactus{GoldenBarrelCactus() => throw new Exception();~GoldenBarrelCactus() => throw new Exception();}
public sealed class PeruvianAppleCactus : ICactus{PeruvianAppleCactus() => throw new Exception();~PeruvianAppleCactus() => throw new Exception();}
public sealed class NightBloomingCereus : ICactus{NightBloomingCereus() => throw new Exception();~NightBloomingCereus() => throw new Exception();}
public sealed class CactusMammillaria : ICactus{CactusMammillaria() => throw new Exception();~CactusMammillaria() => throw new Exception();}
public sealed class CactusFerocactus : ICactus{CactusFerocactus() => throw new Exception();~CactusFerocactus() => throw new Exception();}
public sealed class CactusPineapple : ICactus{CactusPineapple() => throw new Exception();~CactusPineapple() => throw new Exception();}
public sealed class CactusOpuntia : ICactus{CactusOpuntia() => throw new Exception();~CactusOpuntia() => throw new Exception();}
public sealed class Stenocereus : ICactus{Stenocereus() => throw new Exception();~Stenocereus() => throw new Exception();}
public sealed class CactusBunny : ICactus{CactusBunny() => throw new Exception();~CactusBunny() => throw new Exception();}
public sealed class CactusElder : ICactus{CactusElder() => throw new Exception();~CactusElder() => throw new Exception();}
public sealed class CactusKing : ICactus{CactusKing() => throw new Exception();~CactusKing() => throw new Exception();}
public sealed class CactusTree : ICactus{CactusTree() => throw new Exception();~CactusTree() => throw new Exception();}
public sealed class CactusJelly : ICactus{CactusJelly() => throw new Exception();~CactusJelly() => throw new Exception();}