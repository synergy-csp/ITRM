using Microsoft.AspNetCore.Mvc;
using Bimser.CSP.FormControls.Api;
using Bimser.Framework.Dependency;
using Bimser.Framework.AspNetCore.Mvc.Attributes;

namespace ITRM.Forms
{
    [Route("apps/ITRM/latest/api/PriorityEdit/[action]")]
    [Route("apps/ITRM/{v:int:min(1)}/api/PriorityEdit/[action]")]
    [Route("api/PriorityEdit/[action]")]
    [Produces("application/json")]
    public class PriorityEditController : BaseFormController<PriorityEdit>
    {
        public PriorityEditController(IIocManager iocManager) : base(iocManager)
        {

        }

        [HttpGet]
        [ActionName("Ping")]
        [NoRequestHeaders]
        [NoResponseHeaders]
        public string Ping()
        {
            return "PriorityEdit API Controller is ok";            
        }
    }
}