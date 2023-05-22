using Microsoft.AspNetCore.Mvc;
using Bimser.CSP.FormControls.Api;
using Bimser.Framework.Dependency;
using Bimser.Framework.AspNetCore.Mvc.Attributes;

namespace ITRM.Forms
{
    [Route("apps/ITRM/latest/api/Priorities/[action]")]
    [Route("apps/ITRM/{v:int:min(1)}/api/Priorities/[action]")]
    [Route("api/Priorities/[action]")]
    [Produces("application/json")]
    public class PrioritiesController : BaseFormController<Priorities>
    {
        public PrioritiesController(IIocManager iocManager) : base(iocManager)
        {

        }

        [HttpGet]
        [ActionName("Ping")]
        [NoRequestHeaders]
        [NoResponseHeaders]
        public string Ping()
        {
            return "Priorities API Controller is ok";            
        }
    }
}