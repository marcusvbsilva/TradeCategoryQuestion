using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TradeCategoryQuestion.Enum;
using TradeCategoryQuestion.Interfaces;

namespace TradeCategoryQuestion.Classes
{
    internal class Trade : ITrade
    {
        public double Value { get; set; }

        public string ClientSector { get; set; }

        public DateTime NextPaymentDate { get; set; }

        public TradeEnum.Category Category { get; set; }

        public Trade(double value, string clientSector, DateTime nextPaymentDate, DateTime? referenceDate)
        {
            Value = value;
            ClientSector = clientSector;
            NextPaymentDate = nextPaymentDate;
            Category = SetCategory(referenceDate);
        }
        
        private TradeEnum.Category SetCategory(DateTime? referenceDate)
        {
            if (this.NextPaymentDate.AddDays(30) < referenceDate)
                return TradeEnum.Category.EXPIRED;
            else if ((this.Value > 1000000) && (this.ClientSector == "Private"))
                return TradeEnum.Category.HIGHRISK;
            else if ((this.Value > 1000000) && (this.ClientSector == "Public"))
                return TradeEnum.Category.MEDIUMRISK;

            return TradeEnum.Category.EXPIRED;
        }
    }
}
