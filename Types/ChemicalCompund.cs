namespace chemical_dam.Types
{
    internal struct ChemicalCompound
    {
        int CASNumber { get; set; }
        string CompoundName { get; set; }
        string[] ComposedBy { get; set; } = new string[7];
        int[] ElementsCount { get; set; } = new int[7];
    }
}

