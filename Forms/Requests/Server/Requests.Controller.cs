using Microsoft.AspNetCore.Mvc;
using Bimser.CSP.FormControls.Api;
using Bimser.Framework.Dependency;
using Bimser.Framework.AspNetCore.Mvc.Attributes;

namespace ITRM.Forms
{
    [Route("apps/ITRM/latest/api/Requests/[action]")]
    [Route("apps/ITRM/{v:int:min(1)}/api/Requests/[action]")]
    [Route("api/Requests/[action]")]
    [Produces("application/json")]
    public class RequestsController : BaseFormController<Requests>
    {
        public RequestsController(IIocManager iocManager) : base(iocManager)
        {

        }

        [HttpGet]
        [ActionName("Ping")]
        [NoRequestHeaders]
        [NoResponseHeaders]
        public string Ping()
        {
            return "Requests API Controller is ok";            
        }
    }
}