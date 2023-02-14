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
    public ChemicalReaction(string name)
    {
        Id = 0;
        Name = name;
        Type = ChemicalReactionType.Synthesis;
        EnergyRelationship = ChemicalReactionEnergyRelationship.Endothermic;
        KelvinOptimalTemperature = 0;
        EnthalpyKjPerMolecule = 0;
        PerformancePercentage = 0;
    }

    int Id { get; set; }
    string Name { get; set; }
    ChemicalReactionType Type { get; set; }

    ChemicalReactionEnergyRelationship EnergyRelationship { get; set; }

    ChemicalCompound[] ReactiveList { get; set; } = new ChemicalCompound[10];
    int[] ReactiveListMoleculesCount { get; set; } = new int[10];

    ChemicalCompound[] Products { get; set; } = new ChemicalCompound[10];
    int[] ProductsMoleculesCount { get; set; } = new int[10];
    
    float KelvinOptimalTemperature { get; set; }

    float EnthalpyKjPerMolecule { get; set; }

    int PerformancePercentage { get; set; }
}