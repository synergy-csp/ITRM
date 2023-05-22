using Microsoft.AspNetCore.Mvc;
using Bimser.CSP.FormControls.Api;
using Bimser.Framework.Dependency;
using Bimser.Framework.AspNetCore.Mvc.Attributes;

namespace ITRM.Forms
{
    [Route("apps/ITRM/latest/api/RequestTypeEdit/[action]")]
    [Route("apps/ITRM/{v:int:min(1)}/api/RequestTypeEdit/[action]")]
    [Route("api/RequestTypeEdit/[action]")]
    [Produces("application/json")]
    public class RequestTypeEditController : BaseFormController<RequestTypeEdit>
    {
        public RequestTypeEditController(IIocManager iocManager) : base(iocManager)
        {

        }

        [HttpGet]
        [ActionName("Ping")]
        [NoRequestHeaders]
        [NoResponseHeaders]
        public string Ping()
        {
            return "RequestTypeEdit API Controller is ok";            
        }
    }
}