

using System.Numerics;

namespace chemical_dam.Types
{
     enum Type
    {
        synthesis,
        decomposition, 
        displacement,
        acid-base, 
        redox, 
        others

    }

    internal class ChemicalReactions
    {
        int id { get; set; }
        string name { get; set; }
        string description { get; set; }
        Type type { get; set; }
        string energyRelationship { get; set; }

        //Vector<ChemicalCompounds> chemicalCompunds { get; set; }


        
    }
}
