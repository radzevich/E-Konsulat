using System.Collections.Generic;
using System.Threading.Tasks;
using E_Konsulat.Domain.Models.Form;
using E_Konsulat.Domain.Providers;

namespace E_Konsulat.Infrastructure.Providers
{
    public class TestDataProvider : IFormDataProvider
    {
        public async Task<FormData> LoadFormDataAsync(string formDataId)
        {
            return await Task.FromResult(new FormData
            {
                Fields = new Dictionary<string, string>
                {
                    {"Nazwisko", "Nazwisko"},
                    {"NazwiskoRodowe", "NazwiskoRodowe"},
                    {"Imiona", "Imiona"},
                    {"DataUrodzin", "DataUrodzin"},
                    {"MiejsceUrodzenia", "MiejsceUrodzenia"}
                }
            });
        }
    }
}
