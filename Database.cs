using chemical_dam.Types;

namespace chemical_dam;

internal class Database
{
    public static ChemicalElement[] PeriodicTable = new ChemicalElement[118];
    public static ChemicalCompound[] ChemicalCompounds = new ChemicalCompound[500];
    public static ChemicalReaction[] ChemicalReactions = new ChemicalReaction[200];

    public static void LoadPeriodicTable(String content, Action onLoaded)
    {   
        String[] lines = content.Split("\n");
        
        for (int i = 1; i < lines.Length; i++)
        { 
            String[] line = lines[i].Split(",");

            if (line.Length <= 1) // Line is empty
            {
                break;
            }

            PeriodicTable[i-1] = new ChemicalElement(
                // "aaa",
                // "aaa",
                // 0,
                // 0f,
                // 0,
                // 0,
                // 0
                line[1], 
                line[2], 
                int.Parse(line[0]), 
                double.Parse(line[3]), 
                int.Parse(line[4]), 
                int.Parse(line[5]), 
                int.Parse(line[6])
                );
        }
        
        onLoaded();
    }
}