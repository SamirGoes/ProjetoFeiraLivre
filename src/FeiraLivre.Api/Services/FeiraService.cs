using FeiraLivre.Api.Domain;
using FeiraLivre.Api.Models;

namespace FeiraLivre.Api.Services
{
    public class FeiraService : IFeiraService
    {
        private readonly IFeiraRepository feiraRepository;

        public FeiraService(IFeiraRepository feiraRepository)
        {
            this.feiraRepository = feiraRepository;
        }

        public void LoadData(IEnumerable<Feira> feiras)
        {
            this.feiraRepository.LoadFeira(feiras);
        }
    }
}