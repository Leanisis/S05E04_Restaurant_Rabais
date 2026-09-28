using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant.Rabais
{
    public class RabaisFidelite : IStrategieRabais
    {
        private const decimal _facteurFidelite = 0.90m;

        public decimal CalculerRabais(decimal sousTotal)
        {
            return ReglesRabais.LimiterTotalAZero(sousTotal * _facteurFidelite);
        }
    }
}
