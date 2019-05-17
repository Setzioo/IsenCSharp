using System;
using System.Collections.Generic;
using System.Linq;
using Isen.DotNet.Library.Models;
using Isen.DotNet.Library.Repositories.Base;
using Isen.DotNet.Library.Repositories.Interfaces;

namespace Isen.DotNet.Library.Repositories.InMemory
{
    public class InMemoryContractRepository :
        BaseInMemoryRepository<Contract>,
        IContractRepository
    {   
        private readonly IClubRepository _ClubRepository;

        private readonly IPlayerRepository _PlayerRepository;
        
        // Pattern d'Injection de Dépendance
        // aka IoC : Inversion of Control
        // aka DI : Dependency Injection
        public InMemoryContractRepository(
            IClubRepository ClubRepository, IPlayerRepository PlayerRepository)
        {
            _ClubRepository = ClubRepository;
            _PlayerRepository = PlayerRepository;
        }

        public override List<Contract> SampleData =>
            new List<Contract>()
            {
                new Contract()
                { 
                    Id = 1, 
                    BeginningDate = new DateTime(2018, 1, 1), 
                    FinishingDate = new DateTime(2019, 1, 1), 
                    Name = _ClubRepository.Single("Olympique Lyonnais").Name,
                    Club = _ClubRepository.Single("Olympique Lyonnais"),
                    Player = _PlayerRepository.Single("BOUHADDI Sarah")
                },
                new Contract()
                { 
                    Id = 2, 
                    BeginningDate = new DateTime(2017, 1, 1), 
                    FinishingDate = new DateTime(2018, 1, 1), 
                    Name = _ClubRepository.Single("Olympique Lyonnais").Name,
                    Club = _ClubRepository.Single("Olympique Lyonnais"),
                    Player = _PlayerRepository.Single("BOUHADDI Sarah")
                },
                new Contract()
                { 
                    Id = 3, 
                    BeginningDate = new DateTime(2016, 1, 1), 
                    FinishingDate = new DateTime(2017, 1, 1), 
                    Name = _ClubRepository.Single("Olympique Lyonnais").Name,
                    Club = _ClubRepository.Single("Olympique Lyonnais"),
                    Player = _PlayerRepository.Single("BOUHADDI Sarah")
                },
                new Contract()
                { 
                    Id = 4, 
                    BeginningDate = new DateTime(2011, 1, 1), 
                    FinishingDate = new DateTime(2012, 1, 1), 
                    Name = _ClubRepository.Single("Montpellier HSC").Name,
                    Club = _ClubRepository.Single("Montpellier HSC"),
                    Player = _PlayerRepository.Single("DURAND Solene")
                },
                new Contract()
                { 
                    Id = 5, 
                    BeginningDate = new DateTime(2012, 1, 1), 
                    FinishingDate = new DateTime(2013, 1, 1), 
                    Name = _ClubRepository.Single("Montpellier HSC").Name,
                    Club = _ClubRepository.Single("Montpellier HSC"),
                    Player = _PlayerRepository.Single("DURAND Solene")
                },
                new Contract()
                { 
                    Id = 6, 
                    BeginningDate = new DateTime(2018, 1, 1), 
                    FinishingDate = new DateTime(2019, 1, 1), 
                    Name = _ClubRepository.Single("EA Guingamp").Name,
                    Club = _ClubRepository.Single("EA Guingamp"),
                    Player = _PlayerRepository.Single("DURAND Solene")
                },
                new Contract()
                { 
                    Id = 7, 
                    BeginningDate = new DateTime(2018, 1, 1), 
                    FinishingDate = new DateTime(2019, 1, 1), 
                    Name = _ClubRepository.Single("EA Guingamp").Name,
                    Club = _ClubRepository.Single("EA Guingamp"),
                    Player = _PlayerRepository.Single("DEBEVER Julie")
                },
                new Contract()
                { 
                    Id = 8, 
                    BeginningDate = new DateTime(2018, 1, 1), 
                    FinishingDate = new DateTime(2019, 1, 1), 
                    Name = _ClubRepository.Single("Montpellier HSC").Name,
                    Club = _ClubRepository.Single("Montpellier HSC"),
                    Player = _PlayerRepository.Single("KARCHAOUI Sakina")
                }
            };
    }
}