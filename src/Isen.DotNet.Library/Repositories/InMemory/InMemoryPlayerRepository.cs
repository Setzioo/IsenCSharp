using System;
using System.Collections.Generic;
using System.Linq;
using Isen.DotNet.Library.Models;
using Isen.DotNet.Library.Repositories.Base;
using Isen.DotNet.Library.Repositories.Interfaces;

namespace Isen.DotNet.Library.Repositories.InMemory
{
    public class InMemoryPlayerRepository :
        BaseInMemoryRepository<Player>,
        IPlayerRepository
    {   

        public override List<Player> SampleData =>
            new List<Player>()
            {
                new Player()
                { 
                    Id = 1, 
                    FirstName = "Sarah", 
                    LastName = "BOUHADDI", 
                    Name = "BOUHADDI Sarah",
                    DateOfBirth = new DateTime(1986,10, 17),
                },
                new Player()
                { 
                    Id = 2, 
                    FirstName = "Solene", 
                    LastName = "DURAND", 
                    Name = "DURAND Solene",
                    DateOfBirth = new DateTime(1994,11, 20),
                },
                new Player()
                { 
                    Id = 3, 
                    FirstName = "Julie", 
                    LastName = "DEBEVER", 
                    Name = "DEBEVER Julie",
                    DateOfBirth = new DateTime(1988, 4, 18),
                },
                new Player()
                { 
                    Id = 4, 
                    FirstName = "Sakina", 
                    LastName = "KARCHAOUI", 
                    Name = "KARCHAOUI Sakina",
                    DateOfBirth = new DateTime(1996, 1, 26),
                }
            };
    }
}