using FeiraLivre.Api.Models;

namespace FeiraLivre.Api.Domain
{
    public interface IFeiraService
    {
        void LoadData(IEnumerable<Feira> feiras);
    }
}