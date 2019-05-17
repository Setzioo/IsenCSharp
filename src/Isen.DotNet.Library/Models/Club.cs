using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace Isen.DotNet.Library.Models
{
    public class Club : BaseModel<Club>
    {
        public override int Id { get;set; }
        public override string Name { get;set; }
        public string Adress { get;set; }

        public string Logo { get;set; }

        public double Longitude { get;set; }

        public double Latitude { get;set; }

        public List<Contract> ContractCollection { get; set; } =
            new List<Contract>();

        [NotMapped]
        public override string Display => 
            $"{base.Display}|Adress={Adress}|Logo={Logo}|Coordonées={Longitude},{Latitude}";

        public override void Map(Club copy)
        {
            base.Map(copy);
            Adress = copy.Adress;
            Logo = copy.Logo;
            Longitude = copy.Longitude;
            Latitude = copy.Latitude;
        }

        public override dynamic ToDynamic()
        {
            var baseDynamic = base.ToDynamic();
            return baseDynamic;
        }
    }
}