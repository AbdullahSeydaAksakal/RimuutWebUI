using RestSharp;
using Xunit;

namespace RimuutWebAPI
{
    public class ApiTest
    {
        [Fact]
        public void GetWebAPITest()
        {

            var client = new RestClient("https://rimuut.com/pricing");
            var request = new RestRequest(Method.GET);
            IRestResponse response = client.Execute(request);
            string status = response.StatusCode.ToString();
            Assert.Equal("OK", status);


        }
    }
}