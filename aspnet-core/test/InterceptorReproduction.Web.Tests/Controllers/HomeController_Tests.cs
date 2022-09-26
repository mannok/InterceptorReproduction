using System.Threading.Tasks;
using InterceptorReproduction.Models.TokenAuth;
using InterceptorReproduction.Web.Controllers;
using Shouldly;
using Xunit;

namespace InterceptorReproduction.Web.Tests.Controllers
{
    public class HomeController_Tests: InterceptorReproductionWebTestBase
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