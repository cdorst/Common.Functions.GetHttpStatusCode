using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace Common.Functions.GetHttpStatusCode
{
    public static class HttpStatusCodeGetter
    {
        public static async Task<HttpStatusCode> GetStatusCode(string uri)
        {
            using (var client = new HttpClient()) return (await client.GetAsync(uri)).StatusCode;
        }
    }
}
