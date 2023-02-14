namespace chemical_dam.Types;

    internal struct ChemicalElement
    {
        public ChemicalElement(string name, string symbol, int atomicNumber, double atomicMass, int neutronCount, int protonCount, int electronCount)
        {
            Name = name;
            Symbol = symbol;
            AtomicNumber = atomicNumber;
            AtomicMass = atomicMass;
            NeutronCount = neutronCount;
            ProtonCount = protonCount;
            ElectronCount = electronCount;
        }
        
        private string Name { get; set; }
        private string Symbol { get; set; }
        private int AtomicNumber { get; set; }
        private double AtomicMass { get; set; }
        private int NeutronCount { get; set; }
        private int ProtonCount { get; set; }
        private int ElectronCount { get; set; }
    }