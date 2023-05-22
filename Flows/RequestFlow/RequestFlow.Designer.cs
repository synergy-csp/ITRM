using Bimser.CSP.Workflow.Api.Base;
using Bimser.CSP.Workflow.Api.Steps;
using Bimser.Synergy.Entities.Workflow.Attributes;
using Bimser.Synergy.Entities.Workflow.Interface.Runtime;

namespace ITRM.Flows
{
    [WorkflowIdentifier("d0cac8c6-2d08-49bc-a3df-e6897bae9311")]
    public partial class RequestFlow : WorkflowCode
    {   
        #region [lazy load workflow object fields]

        private FlowStart _flowStart1;
		private FlowEnd _flowEnd1;
		private FlowEnd _flowEnd2;
		private FlowPosition _managerPosition;
		private FlowPosition _requestor;
		private FlowPosition _requestorControl;
		private FlowPosition _reviewerPosition;
		private FlowAssign _assignment1;
		private FlowAssign _assignment2;
		private FlowState _flowState1;
		private FlowState _flowState2;
		private FlowState _flowState3;
		private FlowState _flowState4;
		private FlowState _flowState5;
		private FlowState _flowState6;
		private FlowMail _requestorNotification;
		private Variable _reviewerId;
		private FlowGroup _positionGroup;
		private FlowDocument _document1;
		private FlowDocument _document2;


        #endregion

        #region [lazy load workflow object properties]

        private FlowStart FlowStart1 => _flowStart1 ??= new FlowStart("FlowStart1", _workflowData, this);
		private FlowEnd FlowEnd1 => _flowEnd1 ??= new FlowEnd("FlowEnd1", _workflowData, this);
		private FlowEnd FlowEnd2 => _flowEnd2 ??= new FlowEnd("FlowEnd2", _workflowData, this);
		private FlowPosition ManagerPosition => _managerPosition ??= new FlowPosition("ManagerPosition", _workflowData, this);
		private FlowPosition Requestor => _requestor ??= new FlowPosition("Requestor", _workflowData, this);
		private FlowPosition RequestorControl => _requestorControl ??= new FlowPosition("RequestorControl", _workflowData, this);
		private FlowPosition ReviewerPosition => _reviewerPosition ??= new FlowPosition("ReviewerPosition", _workflowData, this);
		private FlowAssign Assignment1 => _assignment1 ??= new FlowAssign("Assignment1", _workflowData, this);
		private FlowAssign Assignment2 => _assignment2 ??= new FlowAssign("Assignment2", _workflowData, this);
		private FlowState FlowState1 => _flowState1 ??= new FlowState("FlowState1", _workflowData, this);
		private FlowState FlowState2 => _flowState2 ??= new FlowState("FlowState2", _workflowData, this);
		private FlowState FlowState3 => _flowState3 ??= new FlowState("FlowState3", _workflowData, this);
		private FlowState FlowState4 => _flowState4 ??= new FlowState("FlowState4", _workflowData, this);
		private FlowState FlowState5 => _flowState5 ??= new FlowState("FlowState5", _workflowData, this);
		private FlowState FlowState6 => _flowState6 ??= new FlowState("FlowState6", _workflowData, this);
		private FlowMail RequestorNotification => _requestorNotification ??= new FlowMail("RequestorNotification", _workflowData, this);
		private Variable ReviewerId => _reviewerId ??= new Variable("ReviewerId", _workflowData, this);
		private FlowGroup PositionGroup => _positionGroup ??= new FlowGroup("PositionGroup", _workflowData, this);
		private FlowDocument Document1 => _document1 ??= new FlowDocument("Document1", _workflowData, this);
		private FlowDocument Document2 => _document2 ??= new FlowDocument("Document2", _workflowData, this);


        #endregion

        #region [ctor]        

        public RequestFlow() : this(null)
        {
            
        }
        
        public RequestFlow(IRuntimeWorkflowData workflowData) : base(workflowData)
        {
            
        }

        #endregion
    }
}