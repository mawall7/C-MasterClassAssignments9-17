using System.Threading.Tasks;

namespace UltimateCSharpMasterClass
{
    public interface IApiReader
    {
        Task<string> ReadAsync(string baseAdress, string requestUri);
    }
}