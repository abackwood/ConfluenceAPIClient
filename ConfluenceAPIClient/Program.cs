using System.Net.Http;
using Newtonsoft.Json;

public class Program {
    public const string APIEndpoint = "https://ns-confl.dev.infosupport.net/rest/api/";

    public static void Main(string[] args) {
        string pageTitle = "ConfluenceAPIClient Test Pagina";
        string pageContent = "<p>Dit is een test pagina aangemaakt door de ConfluenceAPIClient</p>";

        HttpClient client = new HttpClient();
    }
}