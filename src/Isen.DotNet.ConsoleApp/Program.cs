﻿using System;
using System.Collections.Generic;
using Isen.DotNet.Library;
using Isen.DotNet.Library.Lists;
using Isen.DotNet.Library.Models;
using Isen.DotNet.Library.Repositories.InMemory;
using Isen.DotNet.Library.Repositories.Interfaces;

namespace Isen.DotNet.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            IClubRepository ClubRepo = 
                new InMemoryClubRepository();
            IPlayerRepository PlayerRepo = 
                new InMemoryPlayerRepository();

            foreach(var p in PlayerRepo.Context)
                Console.WriteLine(p);

            var toulon = ClubRepo.Single("Toulon");
            toulon.Name = "New York";
            ClubRepo.Update(toulon);
            ClubRepo.SaveChanges();

            foreach(var p in PlayerRepo.Context)
                Console.WriteLine(p);
        }
    }
}
