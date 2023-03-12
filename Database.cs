using System.Diagnostics;
using chemical_dam.Types;

namespace chemical_dam;

internal class Database
{
    public static ChemicalElement[] PeriodicTable = new ChemicalElement[118];
    public static ChemicalCompound[] ChemicalCompounds = new ChemicalCompound[500];
    public static ChemicalReaction[] ChemicalReactions = new ChemicalReaction[200];

    public static void LoadPeriodicTable(string content, Action onLoaded)
    {
        string[] lines = content.Split("\n");

        try
        {
            for (int i = 1; i < lines.Length; i++)
            {
                string[] line = lines[i].Split(",");

                if (i == lines.Length - 1)
                {
                    break;
                } // Last line is empty.

                if (line.Length < 28)
                {
                    throw new Exception($"Invalid file format at line {i + 1}");
                } // 28 columns in the file, not accurate.

                PeriodicTable[i - 1] = new ChemicalElement(
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
        catch (Exception e)
        {
            MessageBox.Show(
                $"Error while loading periodic table:\n{e.Message}",
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            );
        }
    }

    public static void LoadChemicalCompounds(String content, Action onLoaded)
    {
        String[] lines = content.Split("\n");

        try
        {
            for (int i = 5, j = 0; i < lines.Length; i += 5, j++)
                ChemicalCompounds[j] = new ChemicalCompound(
                    lines[i - 5],
                    lines[i - 4],
                    lines[i - 2].Split(","),
                    lines[i - 1].Split(",").Select(int.Parse).ToArray());

            onLoaded();
        }
        catch (Exception e)
        {
            MessageBox.Show(
                $"Error while loading chemical compounds:\n{e.Message}",
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            );
        }
    }
    
    public static void LoadChemicalReactions(String content, Action onLoaded)
    {
        String[] lines = content.Split("\n");

        try
        {
            for (int i = 13, j = 0; i < lines.Length; i += 13, j++)
                ChemicalReactions[j] = new ChemicalReaction(
                    int.Parse(lines[i - 13]),
                    lines[i - 12],
                    lines[i - 11],
                    int.Parse(lines[i - 10]) == 0
                        ? ChemicalReactionEnergyRelationship.Endothermic
                        : ChemicalReactionEnergyRelationship.Exothermic,
                    float.Parse(lines[i - 3]),
                    float.Parse(lines[i - 2]),
                    float.Parse(lines[i - 1])
                );
            
            onLoaded();
        }
        catch (Exception e)
        {
            MessageBox.Show(
                $"Error while loading chemical reactions on line:\n{e.Message}",
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            );
        }
    }

    public static int GetLastIndex<T>(T[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            // Doesnt work for structs
            // if (array[i] == null)
            //     return i - 1;
            
            // Works for structs
            if (array[i].Equals(default(T)))
                return i - 1;
        }

        return array.Length - 1;
    }
}