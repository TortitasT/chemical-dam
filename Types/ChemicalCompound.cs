namespace chemical_dam.Types;

internal struct ChemicalCompound
{
    public ChemicalCompound(string casNumber, string compoundName, string[] composedBy, int[] elementsCount)
    {
        CasNumber = casNumber;
        CompoundName = compoundName;
        ComposedBy = composedBy;
        ElementsCount = elementsCount;
    }

    public string CasNumber { get; }
    public string CompoundName { get; }
    public string[] ComposedBy { get; } = new string[7];
    public int[] ElementsCount { get; } = new int[7];
}