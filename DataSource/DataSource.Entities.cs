using System;
using System.Collections.Generic;
using System.Linq;
using Bimser.CSP.DataSource.Api.Models;
using Newtonsoft.Json;

namespace ITRM.DataSources
{
   ///RequestEntities
  public class RequestTypes_DataSourceRequest : BaseDataSourceDatabaseRequest
    {
        ///Properties
        public System.String Culture { get; set; }
    }

public class RequestReasons_DataSourceRequest : BaseDataSourceDatabaseRequest
    {
        ///Properties
        public System.String Culture { get; set; }
    }

public class Priorities_DataSourceRequest : BaseDataSourceDatabaseRequest
    {
        ///Properties
        public System.String Culture { get; set; }
    }

public class RequestTypesRequest : BaseDataSourceRestWebServiceRequest
    {
        ///Properties
        
    }

public class RequestReasonRequest : BaseDataSourceRestWebServiceRequest
    {
        ///Properties
        
    }

public class PrioritiesRequest : BaseDataSourceRestWebServiceRequest
    {
        ///Properties
        
    }

public class GetUsersRequest : BaseDataSourceRestWebServiceRequest
    {
        ///Properties
        
    }

public class Requests_DataSourceRequest : BaseDataSourceDatabaseRequest
    {
        ///Properties
        public System.String Culture { get; set; }

public System.Int64 userId { get; set; }
    }

public class RequestFlow_ProcessItemsRequest : BaseDataSourceDatabaseRequest
    {
        ///Properties
        public List<object> Users { get; set; }

public List<object> Positions { get; set; }

public System.Int64 Skip { get; set; }

public System.Int64 Take { get; set; }

public System.String Culture { get; set; }

public System.Int64 ProcessType { get; set; }

public System.DateTime EndDate { get; set; }

public System.DateTime StartDate { get; set; }

public System.String FlowName { get; set; }

public System.String ProjectName { get; set; }

public System.Int64 RequestId { get; set; }
    }

public class DeleteRequestTypeRequest : BaseDataSourceDatabaseRequest
    {
        ///Properties
        public System.Int64 userId { get; set; }

public System.String documentId { get; set; }
    }

public class DeleteRequestReasonRequest : BaseDataSourceDatabaseRequest
    {
        ///Properties
        public System.Int64 userId { get; set; }

public System.String documentId { get; set; }
    }

public class DeletePriorityRequest : BaseDataSourceDatabaseRequest
    {
        ///Properties
        public System.Int64 userId { get; set; }

public System.String documentId { get; set; }
    }
}