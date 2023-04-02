using System.Text;

namespace chemical_dam.Types;

public enum ChemicalReactionType
{
    Synthesis,
    Decomposition,
    Displacement,
    AcidBase,
    Redox,
    Others
}

public enum ChemicalReactionEnergyRelationship
{
    Endothermic,
    Exothermic
}

public struct ChemicalReaction
{
    public ChemicalReaction(
        int id,
        string name,
        string type,
        ChemicalReactionEnergyRelationship energyRelationship,
        float kelvinOptimalTemperature,
        float enthalpyKjPerMolecule,
        float performancePercentage,
        ChemicalCompound[] reactiveList,
        int[] reactiveListMoleculesCount,
        ChemicalCompound[] products,
        int[] productsMoleculesCount
    )
    {
        Id = id;
        Name = name;

        // Reactions.txt is not enum friendly :/
        if (type.Contains("Acid-base")) type = "AcidBase";
        Type = (ChemicalReactionType)Enum.Parse(typeof(ChemicalReactionType), type);

        EnergyRelationship = energyRelationship;
        KelvinOptimalTemperature = kelvinOptimalTemperature;
        EnthalpyKjPerMolecule = enthalpyKjPerMolecule;
        PerformancePercentage = performancePercentage;

        ReactiveList = reactiveList;
        ReactiveListMoleculesCount = reactiveListMoleculesCount;
        Products = products;
        ProductsMoleculesCount = productsMoleculesCount;
    }

    public int Id { get; set; }
    public string Name { get; set; }
    public ChemicalReactionType Type { get; set; }

    public ChemicalReactionEnergyRelationship EnergyRelationship { get; set; }

    public ChemicalCompound[] ReactiveList { get; set; } = new ChemicalCompound[10];
    public int[] ReactiveListMoleculesCount { get; set; } = new int[10];

    public ChemicalCompound[] Products { get; set; } = new ChemicalCompound[10];
    public int[] ProductsMoleculesCount { get; set; } = new int[10];

    public float KelvinOptimalTemperature { get; set; }

    public float EnthalpyKjPerMolecule { get; set; }

    public float PerformancePercentage { get; set; }

    public override string ToString()
    {
        var output = new StringBuilder();

        output.Append($"{Name}\n");
        output.Append($"Type: {Type}\n");
        output.Append($"Energy Relationship: {EnergyRelationship}\n");
        output.Append($"Optimal Temperature: {KelvinOptimalTemperature} K\n");
        output.Append($"Enthalpy: {EnthalpyKjPerMolecule} kJ/mol\n");
        output.Append($"Performance: {PerformancePercentage}%\n");
        output.Append($"Reactive List: {ReactiveList.Length}\n");
        output.Append($"Products: {Products.Length}\n");
        output.Append($"Reaction: {Reaction()}\n");

        return output.ToString();
    }

    public string Reaction()
    {
        return EnergyRelationship == ChemicalReactionEnergyRelationship.Endothermic
            ? endothermicEquation()
            : exotermicEquation();
    }

    private string endothermicEquation()
    {
        var output = new StringBuilder();

        for (var i = 0; i < ReactiveList.Length; i++)
        {
            if (ReactiveList[i].Equals(default(ChemicalCompound))) continue;

            output.Append($"{ReactiveListMoleculesCount[i]}{ReactiveList[i].ChemicalForm()}");

            if (i != ReactiveList.Length - 1) output.Append(" + ");
        }

        output.Append($" + {EnthalpyKjPerMolecule} kJ/mol");

        output.Append(" -> ");

        for (var i = 0; i < Products.Length; i++)
        {
            if (Products[i].Equals(default(ChemicalCompound))) continue;

            output.Append($"{ProductsMoleculesCount[i]}{Products[i].ChemicalForm()}");

            if (i != Products.Length - 1) output.Append(" + ");
        }

        return output.ToString();
    }

    private string exotermicEquation()
    {
        var output = new StringBuilder();

        for (var i = 0; i < ReactiveList.Length; i++)
        {
            if (ReactiveList[i].Equals(default(ChemicalCompound))) continue;

            output.Append($"{ReactiveListMoleculesCount[i]}{ReactiveList[i].ChemicalForm()}");

            if (i != ReactiveList.Length - 1) output.Append(" + ");
        }

        output.Append(" -> ");

        for (var i = 0; i < Products.Length; i++)
        {
            if (Products[i].Equals(default(ChemicalCompound))) continue;

            output.Append($"{ProductsMoleculesCount[i]}{Products[i].ChemicalForm()}");

            if (i != Products.Length - 1) output.Append(" + ");
        }

        output.Append($" + {EnthalpyKjPerMolecule} kJ/mol");

        return output.ToString();
    }
}