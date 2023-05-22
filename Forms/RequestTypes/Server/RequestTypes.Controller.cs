using Microsoft.AspNetCore.Mvc;
using Bimser.CSP.FormControls.Api;
using Bimser.Framework.Dependency;
using Bimser.Framework.AspNetCore.Mvc.Attributes;

namespace ITRM.Forms
{
    [Route("apps/ITRM/latest/api/RequestTypes/[action]")]
    [Route("apps/ITRM/{v:int:min(1)}/api/RequestTypes/[action]")]
    [Route("api/RequestTypes/[action]")]
    [Produces("application/json")]
    public class RequestTypesController : BaseFormController<RequestTypes>
    {
        public RequestTypesController(IIocManager iocManager) : base(iocManager)
        {

        }

        [HttpGet]
        [ActionName("Ping")]
        [NoRequestHeaders]
        [NoResponseHeaders]
        public string Ping()
        {
            return "RequestTypes API Controller is ok";            
        }
    }
}