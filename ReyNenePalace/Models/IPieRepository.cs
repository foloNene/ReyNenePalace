using System.Collections.Generic;

namespace ReyNenePalace.Models
{
    public interface IPieRepository
    {
        IEnumerable<Pie> AllPies { get; }
        IEnumerable<Pie> PiesOfTheWeek { get; }
        Pie GetPieById (int pieId);
    }
}
