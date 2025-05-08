using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Web.Resource;

namespace NetPorter.Controllers
{
    //[Authorize]
    [ApiController]
    [Route("[controller]")]
    //[RequiredScope(RequiredScopesConfigurationKey = "AzureAd:Scopes")]
    public class HomeController (ILogger<HomeController> _logger, IConfiguration _config) : ControllerBase
    {
        [HttpGet]
        [Route("DeploymentTime")]
        public string? DeploymentTime()
        {
            _logger.LogInformation("DeploymentTime called");
            return _config.GetValue<string>("DeploymentTime");
        }
    }
}
