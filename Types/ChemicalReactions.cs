

using System.Numerics;

namespace chemical_dam.Types
{
     enum Type
    {
        synthesis,
        decomposition, 
        displacement,
        acidBase, 
        redox, 
        others

    }

    enum EnergyticRelationship
    {
        endothermic,
        exothermic
    }

    internal class ChemicalReactions
    {
        int id { get; set; }
        string name { get; set; }
        string description { get; set; }
        Type type { get; set; }
        string energyRelationship { get; set; }

        EnergyticRelationship energyticRelationship { get; set; }

        int[] reactivesList { get; set; } = new int[10];

        int[] productsList { get; set; } = new int[10];

        int temperature { get; set; }

        String entaenthalpy { get; set; }

        int performance { get; set; }


        //Vector<ChemicalCompounds> chemicalCompunds { get; set; }



    }
}
