using System.Net.Http.Headers;
using IdentityModel.Client;
using LiteracyWebApiTest.Client.Features.MyPage;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;

namespace LiteracyWebApiTest.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class TokenController : ControllerBase
    {
        [HttpGet("test")]
        [Produces("application/json")]
        public async Task<JsonResult> AccessTokenAsync()
        {
            var accessToken = await HttpContext.GetUserAccessTokenAsync();

            //var HttpClient = new HttpClient();

            //HttpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", accessToken.AccessToken);

            //try
            //{
            //    var result = await HttpClient.GetFromJsonAsync<PatientProfile>("https://api.kbiohc.io/Account/profile");
            //}
            //catch(Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}

            return new JsonResult(new { AccessToken = accessToken.AccessToken });
        }
    }
}
