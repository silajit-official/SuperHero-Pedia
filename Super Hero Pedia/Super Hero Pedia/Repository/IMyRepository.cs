using Super_Hero_Pedia.Models;

namespace Super_Hero_Pedia.Repository
{
    public interface IMyRepository
    {
        List<Heros> GetHeros();
    }
}