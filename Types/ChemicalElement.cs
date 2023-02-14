namespace chemical_dam.Types;

internal class ChemicalElement
{
    private string Name { get; set; }
    private string Symbol { get; set; }
    private int AtomicNumber { get; set; }
    private double AtomicMass { get; set; }
    private int NeutronCount { get; set; }
    private int ProtonCount { get; set; }
    private int ElectronCount { get; set; }
}