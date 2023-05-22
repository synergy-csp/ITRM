using Microsoft.AspNetCore.Mvc;
using Bimser.CSP.FormControls.Api;
using Bimser.Framework.Dependency;
using Bimser.Framework.AspNetCore.Mvc.Attributes;

namespace ITRM.Forms
{
    [Route("apps/ITRM/latest/api/RequestReasons/[action]")]
    [Route("apps/ITRM/{v:int:min(1)}/api/RequestReasons/[action]")]
    [Route("api/RequestReasons/[action]")]
    [Produces("application/json")]
    public class RequestReasonsController : BaseFormController<RequestReasons>
    {
        public RequestReasonsController(IIocManager iocManager) : base(iocManager)
        {

        }

        [HttpGet]
        [ActionName("Ping")]
        [NoRequestHeaders]
        [NoResponseHeaders]
        public string Ping()
        {
            return "RequestReasons API Controller is ok";            
        }
    }
}