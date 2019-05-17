using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Isen.DotNet.Library.Models;
using Isen.DotNet.Library.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore.Internal;

namespace Isen.DotNet.Library.Context
{
    public class SeedData
    {
        private readonly ApplicationDbContext _dbContext;
        private readonly IClubRepository _ClubRepository;
        private readonly IPlayerRepository _PlayerRepository;
        private readonly IContractRepository _ContractRepository;

        public SeedData(
            ApplicationDbContext dbContext,
            IClubRepository ClubRepository,
            IPlayerRepository PlayerRepository,
            IContractRepository ContractRepository)
        {
            _dbContext = dbContext;
            _ClubRepository = ClubRepository;
            _PlayerRepository = PlayerRepository;
            _ContractRepository = ContractRepository;
        }

        public void DropCreateDatabase()
        {
            _dbContext.Database.EnsureDeleted();
            _dbContext.Database.EnsureCreated();
        }

        public void AddClubs()
        {
            // Ne rien faire s'il y a déjà des clubs
            if (_dbContext.ClubCollection.Any()) return;

            var clubs = new List<Club>
            {
                new Club() { Name = "Olympique Lyonnais", Adress = "Parc OL, 10 avenue Simone Veil, 69150 Décines-Charpieu", Logo = "https://upload.wikimedia.org/wikipedia/fr/f/fc/Olympique_lyonnais_%28logo_1996%29.jpg", Longitude = 45.765328, Latitude = 4.982029 },
                new Club() { Name = "EA Guingamp", Adress = "15, boulevard Clemenceau, 22202 Guingamp", Logo = "https://upload.wikimedia.org/wikipedia/fr/9/99/En_Avant_de_Guingamp_logo.svg", Longitude = 48.556562, Latitude = -3.143622 },
                new Club() { Name = "Montpellier HSC", Adress = "	Domaine de Grammont, Avenue Albert Einstein, 34070 Montpellier", Logo = "https://upload.wikimedia.org/wikipedia/commons/9/99/Montpellier_H%C3%A9rault_Sport_Club_%28logo%2C_2000%29.svg", Longitude = 43.615978, Latitude = 3.930642 },
            };
            clubs.ForEach(Club => _ClubRepository.Update(Club));
            _ClubRepository.SaveChanges();
        }

        public void AddPlayers()
        {
            // Ne rien faire si non vide
            if(_dbContext.PlayerCollection.Any()) return;

            var players = new List<Player>
            {
                new Player()
                {
                    FirstName = "Sarah", 
                    LastName = "BOUHADDI", 
                    Name = "BOUHADDI Sarah",
                    DateOfBirth = new DateTime(1986,10, 17),
                },
                new Player()
                {  
                    FirstName = "Solene", 
                    LastName = "DURAND", 
                    Name = "DURAND Solene",
                    DateOfBirth = new DateTime(1994,11, 20),
                },
                new Player()
                { 
                    FirstName = "Julie", 
                    LastName = "DEBEVER", 
                    Name = "DEBEVER Julie",
                    DateOfBirth = new DateTime(1988, 4, 18),
                },
                new Player()
                { 
                    FirstName = "Sakina", 
                    LastName = "KARCHAOUI", 
                    Name = "KARCHAOUI Sakina",
                    DateOfBirth = new DateTime(1996, 1, 26),
                }
            };
            players.ForEach(Club => _PlayerRepository.Update(Club));
            _PlayerRepository.SaveChanges();
        }

        public void AddContracts()
        {
            // Ne rien faire s'il y a déjà des contrats
            if (_dbContext.ContractCollection.Any()) return;

            var contracts = new List<Contract>
            {
                new Contract()
                { 
                    BeginningDate = new DateTime(2018, 1, 1), 
                    FinishingDate = new DateTime(2019, 1, 1), 
                    Name = _ClubRepository.Single("Olympique Lyonnais").Name,
                    Club = _ClubRepository.Single("Olympique Lyonnais"),
                    Player = _PlayerRepository.Single("BOUHADDI Sarah")
                },
                new Contract()
                { 
                    BeginningDate = new DateTime(2017, 1, 1), 
                    FinishingDate = new DateTime(2018, 1, 1), 
                    Name = _ClubRepository.Single("Olympique Lyonnais").Name,
                    Club = _ClubRepository.Single("Olympique Lyonnais"),
                    Player = _PlayerRepository.Single("BOUHADDI Sarah")
                },
                new Contract()
                { 
                    BeginningDate = new DateTime(2016, 1, 1), 
                    FinishingDate = new DateTime(2017, 1, 1), 
                    Name = _ClubRepository.Single("Olympique Lyonnais").Name,
                    Club = _ClubRepository.Single("Olympique Lyonnais"),
                    Player = _PlayerRepository.Single("BOUHADDI Sarah")
                },
                new Contract()
                { 
                    BeginningDate = new DateTime(2011, 1, 1), 
                    FinishingDate = new DateTime(2012, 1, 1), 
                    Name = _ClubRepository.Single("Montpellier HSC").Name,
                    Club = _ClubRepository.Single("Montpellier HSC"),
                    Player = _PlayerRepository.Single("DURAND Solene")
                },
                new Contract()
                { 
                    BeginningDate = new DateTime(2012, 1, 1), 
                    FinishingDate = new DateTime(2013, 1, 1), 
                    Name = _ClubRepository.Single("Montpellier HSC").Name,
                    Club = _ClubRepository.Single("Montpellier HSC"),
                    Player = _PlayerRepository.Single("DURAND Solene")
                },
                new Contract()
                { 
                    BeginningDate = new DateTime(2018, 1, 1), 
                    FinishingDate = new DateTime(2019, 1, 1), 
                    Name = _ClubRepository.Single("EA Guingamp").Name,
                    Club = _ClubRepository.Single("EA Guingamp"),
                    Player = _PlayerRepository.Single("DURAND Solene")
                },
                new Contract()
                { 
                    BeginningDate = new DateTime(2018, 1, 1), 
                    FinishingDate = new DateTime(2019, 1, 1), 
                    Name = _ClubRepository.Single("EA Guingamp").Name,
                    Club = _ClubRepository.Single("EA Guingamp"),
                    Player = _PlayerRepository.Single("DEBEVER Julie")
                },
                new Contract()
                { 
                    BeginningDate = new DateTime(2018, 1, 1), 
                    FinishingDate = new DateTime(2019, 1, 1), 
                    Name = _ClubRepository.Single("Montpellier HSC").Name,
                    Club = _ClubRepository.Single("Montpellier HSC"),
                    Player = _PlayerRepository.Single("KARCHAOUI Sakina")
                }
            };
            contracts.ForEach(Club => _ContractRepository.Update(Club));
            _ContractRepository.SaveChanges();
        }
    }
}
