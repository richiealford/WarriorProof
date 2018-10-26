using System;
using System.Collections.Generic;

namespace WarriorProof.Contracts.Models
{
    public class Trucks
    {
        public int Id { get; set; }
        public int NumberOfTrucks { get; set; }
        public ICollection<TrucksLineOfBusiness> TrucksLineOfBusinesses { get; set; }
    }
}

