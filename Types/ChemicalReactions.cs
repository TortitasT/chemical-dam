namespace chemical_dam.Types;

internal enum ChemicalReactionType
{
    Synthesis,
    Decomposition,
    Displacement,
    AcidBase,
    Redox,
    Others
}

internal enum ChemicalReactionEnergyRelationship
{
    Endothermic,
    Exothermic
}

internal struct ChemicalReaction
{
    public ChemicalReaction(
        int id,
        string name,
        string type,
        ChemicalReactionEnergyRelationship energyRelationship,
        float kelvinOptimalTemperature,
        float enthalpyKjPerMolecule,
        float performancePercentage
        )
    {
        Id = id;
        Name = name;

        // Reactions.txt is not enum friendly :/
        if (type.Contains("Acid-base"))
        {
            type = "AcidBase";
        }
        Type = (ChemicalReactionType) Enum.Parse(typeof(ChemicalReactionType), type);
        
        EnergyRelationship = energyRelationship;
        KelvinOptimalTemperature = kelvinOptimalTemperature;
        EnthalpyKjPerMolecule = enthalpyKjPerMolecule;
        PerformancePercentage = performancePercentage;
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
}