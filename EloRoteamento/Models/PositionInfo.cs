using System.Collections.Generic;

namespace EloRoteamento.Models
{
    public class PositionInfo
    {
        public string Vendedor { get; set; }
        public string DataInicial { get; set; }
        public string DataFinal { get; set; }
        public List<Position> Positions { get; set; }

        public struct Position
        {
            public double Latitude { get; set; }
            public double Longitude { get; set; }
        };

        public PositionInfo()
        {
            Positions = new List<Position>();
        }
    }
}
