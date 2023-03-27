namespace RegistroEstudiantes.Shared
{

    using global::RestSharp;

    public abstract class ClienteRestSharp

    {

        public async Task<IRestResponse> Request(string url, Method Envio, object ObjetoEnviar = null, List<KeyValuePair<string, string>> headers = null)

        {

            RestClient client = new RestClient(url);

            RestRequest request = new RestRequest(Envio);

            if (ObjetoEnviar != null)

                request.AddJsonBody(ObjetoEnviar);

            request.RequestFormat = DataFormat.Json;

            if (headers != null)

                request.AddHeaders(headers);

            IRestResponse response = await client.ExecuteAsync(request);

            return response;

        }

    }

}