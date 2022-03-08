using System.Threading.Tasks;

namespace DockerCompose
{
    public interface IHttpService
    {
        public Task<T> GetDataFromAPIAsync<T>(string requestUri = default);
    }
}