using Bimser.CSP.Workflow.Runtime.Base;
using Bimser.Framework.AspNetCore.Mvc.Attributes;
using Bimser.Framework.Dependency;
using Microsoft.AspNetCore.Mvc;
using WorkflowCore.Interface;

namespace ITRM.Flows
{
    [Route("apps/ITRM/latest/api/RequestFlow/[action]")]
    [Route("apps/ITRM/{v:int:min(1)}/api/RequestFlow/[action]")]
    [Route("api/RequestFlow/[action]")]
    [Produces("application/json")]
    public class RequestFlowController : BaseFlowController
    {
        private readonly string _flowFileName = "RequestFlow";

        public RequestFlowController(IIocManager iocManager, IWorkflowController workflowController, IWorkflowRegistry workflowRegistry, IDefinitionLoader definitionLoader) 
            : base(iocManager, workflowController, workflowRegistry, definitionLoader)
        {
            FlowFileName = _flowFileName;
        }

        [HttpGet]
        [ActionName("Ping")]
        [NoRequestHeaders]
        [NoResponseHeaders]
        public string Ping()
        {
            return "RequestFlow API Controller is ok";
        }
    }
}