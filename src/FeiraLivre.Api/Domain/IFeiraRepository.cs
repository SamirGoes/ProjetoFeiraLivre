using FeiraLivre.Api.Models;

namespace FeiraLivre.Api.Domain
{
    public interface IFeiraRepository
    {
        void LoadFeira(IEnumerable<Feira> feiras);
    }
}