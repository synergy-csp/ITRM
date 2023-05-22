using Microsoft.AspNetCore.Mvc;
using Bimser.CSP.FormControls.Api;
using Bimser.Framework.Dependency;
using Bimser.Framework.AspNetCore.Mvc.Attributes;

namespace ITRM.Forms
{
    [Route("apps/ITRM/latest/api/RequestEdit/[action]")]
    [Route("apps/ITRM/{v:int:min(1)}/api/RequestEdit/[action]")]
    [Route("api/RequestEdit/[action]")]
    [Produces("application/json")]
    public class RequestEditController : BaseFormController<RequestEdit>
    {
        public RequestEditController(IIocManager iocManager) : base(iocManager)
        {

        }

        [HttpGet]
        [ActionName("Ping")]
        [NoRequestHeaders]
        [NoResponseHeaders]
        public string Ping()
        {
            return "RequestEdit API Controller is ok";            
        }
    }
}