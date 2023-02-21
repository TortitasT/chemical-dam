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

    //  public static void LoadChemicalCompounds(String content , Action onLoaded)
    // {
    //  String[] lines = content.Split("\n");
    //
    //   int index = 0;

    //  for (int i = 0; i < lines.Length; i++)


    //  ChemicalCompounds[index] = new ChemicalCompound(
    //                   
    //              )
    //  }
    //}
}