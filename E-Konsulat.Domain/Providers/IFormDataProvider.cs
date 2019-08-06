using System.Threading.Tasks;
using E_Konsulat.Domain.Models.Form;

namespace E_Konsulat.Domain.Providers
{
    public interface IFormDataProvider
    {
        Task<FormData> LoadFormDataAsync(string formDataId);
    }
}
