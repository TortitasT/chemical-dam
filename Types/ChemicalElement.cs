namespace chemical_dam.Types;

public struct ChemicalElement
{
    public ChemicalElement(string name, string symbol, int atomicNumber, double atomicMass, int neutronCount,
        int protonCount, int electronCount)
    {
        Name = name;
        Symbol = symbol;
        AtomicNumber = atomicNumber;
        AtomicMass = atomicMass;
        NeutronCount = neutronCount;
        ProtonCount = protonCount;
        ElectronCount = electronCount;
    }

    public string Name { get; set; }
    public string Symbol { get; set; }
    public int AtomicNumber { get; set; }
    public double AtomicMass { get; set; }
    public int NeutronCount { get; set; }
    public int ProtonCount { get; set; }
    public int ElectronCount { get; set; }
}