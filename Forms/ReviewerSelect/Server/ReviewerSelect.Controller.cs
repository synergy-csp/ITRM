using Microsoft.AspNetCore.Mvc;
using Bimser.CSP.FormControls.Api;
using Bimser.Framework.Dependency;
using Bimser.Framework.AspNetCore.Mvc.Attributes;

namespace ITRM.Forms
{
    [Route("apps/ITRM/latest/api/ReviewerSelect/[action]")]
    [Route("apps/ITRM/{v:int:min(1)}/api/ReviewerSelect/[action]")]
    [Route("api/ReviewerSelect/[action]")]
    [Produces("application/json")]
    public class ReviewerSelectController : BaseFormController<ReviewerSelect>
    {
        public ReviewerSelectController(IIocManager iocManager) : base(iocManager)
        {

        }

        [HttpGet]
        [ActionName("Ping")]
        [NoRequestHeaders]
        [NoResponseHeaders]
        public string Ping()
        {
            return "ReviewerSelect API Controller is ok";            
        }
    }
}