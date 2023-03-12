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

    public string ChemicalForm()
    {
        if(Database.GetLastIndex(Database.PeriodicTable) == -1)
        {
            Alert.show("Please load the periodic table first.");
            return "";
        }
        
        var form = "";
            
        var chemicalElements = ComposedBy.Select(
            element => Database.PeriodicTable.ToList()
                .Where(x => {
                    return x.AtomicNumber == int.Parse(element);  
                }).First()
        ).ToList();
        var chemicalElementsCount = ElementsCount;
        
        chemicalElements.ForEach(
            element =>
            {
                var symbol = element.Symbol;
                var count = chemicalElementsCount[chemicalElements.IndexOf(element)] == 1
                    ? ""
                    : chemicalElementsCount[chemicalElements.IndexOf(element)].ToString();
                    
                // form += $"{symbol}<sub>{count}</sub>"; Subscript not supported in alert.
                form += $"{symbol}{count}";
            }
        );
        
        return form;
    }
}