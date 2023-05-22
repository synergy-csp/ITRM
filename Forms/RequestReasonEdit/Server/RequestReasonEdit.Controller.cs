using Microsoft.AspNetCore.Mvc;
using Bimser.CSP.FormControls.Api;
using Bimser.Framework.Dependency;
using Bimser.Framework.AspNetCore.Mvc.Attributes;

namespace ITRM.Forms
{
    [Route("apps/ITRM/latest/api/RequestReasonEdit/[action]")]
    [Route("apps/ITRM/{v:int:min(1)}/api/RequestReasonEdit/[action]")]
    [Route("api/RequestReasonEdit/[action]")]
    [Produces("application/json")]
    public class RequestReasonEditController : BaseFormController<RequestReasonEdit>
    {
        public RequestReasonEditController(IIocManager iocManager) : base(iocManager)
        {

        }

        [HttpGet]
        [ActionName("Ping")]
        [NoRequestHeaders]
        [NoResponseHeaders]
        public string Ping()
        {
            return "RequestReasonEdit API Controller is ok";            
        }
    }
}