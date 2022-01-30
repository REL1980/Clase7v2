using System.Threading.Tasks;
using Clase7v2.Models.TokenAuth;
using Clase7v2.Web.Controllers;
using Shouldly;
using Xunit;

namespace Clase7v2.Web.Tests.Controllers
{
    public class HomeController_Tests: Clase7v2WebTestBase
    {
        [Fact]
        public async Task Index_Test()
        {
            await AuthenticateAsync(null, new AuthenticateModel
            {
                UserNameOrEmailAddress = "admin",
                Password = "123qwe"
            });

            //Act
            var response = await GetResponseAsStringAsync(
                GetUrl<HomeController>(nameof(HomeController.Index))
            );

            //Assert
            response.ShouldNotBeNullOrEmpty();
        }
    }
}