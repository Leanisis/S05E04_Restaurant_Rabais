using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant.Rabais
{
    public class RabaisFixe : IStrategieRabais
    {
        private const decimal _montantRabais = 5m;

        public decimal CalculerRabais(decimal sousTotal)
        {
            return ReglesRabais.LimiterTotalAZero(sousTotal - _montantRabais);
        }

    }
}
