using System.Text;

namespace chemical_dam.Types;

public struct ChemicalCompound
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

    public string ChemicalForm(bool richText = false)
    {
        if (Database.GetLastIndex(Database.PeriodicTable) == -1)
        {
            Alert.show("Please load the periodic table first.");
            return "";
        }

        var form = "";

        var chemicalElements = ComposedBy.Select(
            element => Database.PeriodicTable.ToList()
                .Where(x => { return x.AtomicNumber == int.Parse(element); }).First()
        ).ToList();
        var chemicalElementsCount = ElementsCount;

        chemicalElements.ForEach(
            element =>
            {
                var symbol = element.Symbol;
                var count = chemicalElementsCount[chemicalElements.IndexOf(element)] == 1
                    ? ""
                    : chemicalElementsCount[chemicalElements.IndexOf(element)].ToString();

                if (richText)
                {
                    form += $"{symbol}";
                    if (count != "")
                        form += $"<sub>{count}</sub>";
                }
                else
                {
                    form += $"{symbol}{count}";
                }
            }
        );

        return form;
    }

    public override string ToString()
    {
        var output = new StringBuilder();

        output.AppendLine($"CAS Number: {CasNumber}\n");
        output.AppendLine($"Compound Name: {CompoundName}\n");
        output.AppendLine($"Composed By: {string.Join(", ", ComposedBy)}\n");
        output.AppendLine($"Elements Count: {string.Join(", ", ElementsCount)}\n");
        output.AppendLine($"Chemical Form: {ChemicalForm(true)}\n");

        return output.ToString();
    }
}