namespace chemical_dam.Types;

internal struct ChemicalCompound
{
    public ChemicalCompound(
        string casNumber,
        string compoundName,
        string[] composedBy,
        int[] elementsCount
    )
    {
        CasNumber = casNumber;
        CompoundName = compoundName;
        ComposedBy = composedBy;
        ElementsCount = elementsCount;
    }

    private string CasNumber { get; }
    private string CompoundName { get; }
    private string[] ComposedBy { get; } = new string[7];
    private int[] ElementsCount { get; } = new int[7];
}