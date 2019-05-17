using System;
using System.Collections.Generic;
using System.Linq;
using Isen.DotNet.Library.Models;
using Isen.DotNet.Library.Repositories.Base;
using Isen.DotNet.Library.Repositories.Interfaces;

namespace Isen.DotNet.Library.Repositories.InMemory
{
    public class InMemoryClubRepository :
        BaseInMemoryRepository<Club>,
        IClubRepository
    {      
        public override List<Club> SampleData =>
            new List<Club>()
            {
                new Club() { Id = 1, Name = "Olympique Lyonnais", Adress = "Parc OL, 10 avenue Simone Veil, 69150 Décines-Charpieu", Logo = "https://fr.wikipedia.org/wiki/Olympique_lyonnais_(f%C3%A9minines)#/media/File:Olympique_lyonnais_(logo_1996).jpg", Longitude = 45.765328, Latitude = 4.982029 },
                new Club() { Id = 2, Name = "EA Guingamp", Adress = "15, boulevard Clemenceau, 22202 Guingamp", Logo = "https://fr.wikipedia.org/wiki/En_avant_de_Guingamp_(f%C3%A9minines)#/media/File:En_Avant_de_Guingamp_logo.svg", Longitude = 48.556562, Latitude = -3.143622 },
                new Club() { Id = 3, Name = "Montpellier HSC", Adress = "	Domaine de Grammont, Avenue Albert Einstein, 34070 Montpellier", Logo = "https://fr.wikipedia.org/wiki/Montpellier_H%C3%A9rault_Sport_Club_(f%C3%A9minines)#/media/File:Montpellier_H%C3%A9rault_Sport_Club_(logo,_2000).svg", Longitude = 43.615978, Latitude = 3.930642 }
            };
    }
}