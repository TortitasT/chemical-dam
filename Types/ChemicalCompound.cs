namespace chemical_dam.Types;

internal struct ChemicalCompound
{
    public ChemicalCompound(string casNumber, string compoundName)
    {
        CasNumber = casNumber;
        CompoundName = compoundName;
    }

    private string CasNumber { get; }
    private string CompoundName { get; }
    private string[] ComposedBy { get; } = new string[7];
    private int[] ElementsCount { get; } = new int[7];
}