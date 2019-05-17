using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Isen.DotNet.Library.Models
{
    public class Contract : BaseModel<Contract>
    {
        public override int Id { get;set; }

        public override string Name { get;set; }

        public DateTime? BeginningDate { get;set; }
        public DateTime? FinishingDate { get;set; }

        public string PeriodDateString
        {
            get
            {
                var beginningDateString = BeginningDate.HasValue ?
                    BeginningDate.Value.ToString("yyyy") :
                    "";
                var finishingDateString = FinishingDate.HasValue ?
                    FinishingDate.Value.ToString("yyyy")  :
                    "";
                return beginningDateString + " - " + finishingDateString;
            }
        }

        public Player Player { get;set; }

        public Club Club { get;set; }

        public int? PlayerId { get;set; }

        public int? ClubId { get;set; }



        


        [NotMapped]
       public override string Display => 
            $"{base.Display}|Debut={BeginningDate}|Fin={FinishingDate}|Player={Player.Name}|Club={Club.Name}";

        public override void Map(Contract copy)
        {
            base.Map(copy);
            BeginningDate = copy.BeginningDate;
            FinishingDate = copy.FinishingDate;
        }

        public override dynamic ToDynamic()
        {
            var baseDynamic = base.ToDynamic();
            baseDynamic.beginning = BeginningDate;
            baseDynamic.finishing = FinishingDate;
            return baseDynamic;
        }
    }
}