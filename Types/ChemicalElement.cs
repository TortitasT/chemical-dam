namespace chemical_dam.Types
{
    internal class ChemicalElement
    {
        string Name { get; set; }
        string Symbol { get; set; }
        int AtomicNumber { get; set; }
        double AtomicMass { get; set; }
        int NeutronCount { get; set; }
        int ProtonCount { get; set; }
        int ElectronCount { get; set; }
    }
}
