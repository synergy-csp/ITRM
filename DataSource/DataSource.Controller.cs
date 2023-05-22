using Bimser.CSP.DataSource.Api.Base;
using Bimser.CSP.DataSource.Api.Models;
using Bimser.Framework.AspNetCore.Mvc.Attributes;
using Bimser.Framework.Dependency;
using Bimser.Synergy.Entities.DataSource;
using Bimser.Synergy.Entities.DataSource.Providers;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using System.Threading.Tasks;
using Bimser.Framework.Domain.Option;
using Bimser.Framework.Domain.Option.Filters;
using Bimser.Framework.Domain.Option.Pagination;
using Bimser.Framework.Domain.Option.Sorts;
using System.Collections;
using System.Collections.Generic;

namespace ITRM.DataSources 
{
    [Route("apps/ITRM/latest/api/DataSource/[action]")]
    [Route("apps/ITRM/{v:int:min(1)}/api/DataSource/[action]")]
    [Route("api/DataSource/[action]")]
    [Produces ("application/json")]
    public class DataSourceController : BaseDataSourceController 
    {

        #region [.ctor]

        public DataSourceController (IIocManager iocManager, string authorization = "", string bimserEncryptedData = "", string bimserLanguage = "") : base (iocManager, authorization, bimserEncryptedData, bimserLanguage) 
        {

        }

        #endregion

        ///Actions
        [HttpPost]
[AcceptVerbs("POST")]
[ActionName("RequestTypes_DataSource")]
[NoRequestHeaders]
[NoResponseHeaders]
public async Task<object> RequestTypes_DataSource_Action([FromBody] RequestTypes_DataSourceRequest request)
{
    return await RequestTypes_DataSource(request);
}

[HttpPost]
[AcceptVerbs("POST")]
[ActionName("RequestReasons_DataSource")]
[NoRequestHeaders]
[NoResponseHeaders]
public async Task<object> RequestReasons_DataSource_Action([FromBody] RequestReasons_DataSourceRequest request)
{
    return await RequestReasons_DataSource(request);
}

[HttpPost]
[AcceptVerbs("POST")]
[ActionName("Priorities_DataSource")]
[NoRequestHeaders]
[NoResponseHeaders]
public async Task<object> Priorities_DataSource_Action([FromBody] Priorities_DataSourceRequest request)
{
    return await Priorities_DataSource(request);
}

[HttpPost]
[AcceptVerbs("POST")]
[ActionName("RequestTypes")]
[NoRequestHeaders]
[NoResponseHeaders]
public async Task<object> RequestTypes_Action([FromBody] RequestTypesRequest request)
{
    return await RequestTypes(request);
}

[HttpPost]
[AcceptVerbs("POST")]
[ActionName("RequestReason")]
[NoRequestHeaders]
[NoResponseHeaders]
public async Task<object> RequestReason_Action([FromBody] RequestReasonRequest request)
{
    return await RequestReason(request);
}

[HttpPost]
[AcceptVerbs("POST")]
[ActionName("Priorities")]
[NoRequestHeaders]
[NoResponseHeaders]
public async Task<object> Priorities_Action([FromBody] PrioritiesRequest request)
{
    return await Priorities(request);
}

[HttpPost]
[AcceptVerbs("POST")]
[ActionName("GetUsers")]
[NoRequestHeaders]
[NoResponseHeaders]
public async Task<object> GetUsers_Action([FromBody] GetUsersRequest request)
{
    return await GetUsers(request);
}

[HttpPost]
[AcceptVerbs("POST")]
[ActionName("Requests_DataSource")]
[NoRequestHeaders]
[NoResponseHeaders]
public async Task<object> Requests_DataSource_Action([FromBody] Requests_DataSourceRequest request)
{
    return await Requests_DataSource(request);
}

[HttpPost]
[AcceptVerbs("POST")]
[ActionName("RequestFlow_ProcessItems")]
[NoRequestHeaders]
[NoResponseHeaders]
public async Task<object> RequestFlow_ProcessItems_Action([FromBody] RequestFlow_ProcessItemsRequest request)
{
    return await RequestFlow_ProcessItems(request);
}

[HttpPost]
[AcceptVerbs("POST")]
[ActionName("DeleteRequestType")]
[NoRequestHeaders]
[NoResponseHeaders]
public async Task<object> DeleteRequestType_Action([FromBody] DeleteRequestTypeRequest request)
{
    return await DeleteRequestType(request);
}

[HttpPost]
[AcceptVerbs("POST")]
[ActionName("DeleteRequestReason")]
[NoRequestHeaders]
[NoResponseHeaders]
public async Task<object> DeleteRequestReason_Action([FromBody] DeleteRequestReasonRequest request)
{
    return await DeleteRequestReason(request);
}

[HttpPost]
[AcceptVerbs("POST")]
[ActionName("DeletePriority")]
[NoRequestHeaders]
[NoResponseHeaders]
public async Task<object> DeletePriority_Action([FromBody] DeletePriorityRequest request)
{
    return await DeletePriority(request);
}

        ///Handles
        internal async Task<DataSourceResponse<object>> RequestTypes_DataSource(RequestTypes_DataSourceRequest request)
{
    string queryContent = "{\n  \"name\": \"RequestTypes_DataSource\",\n  \"connectionId\": \"3ee648e2-6d8b-49ad-babf-a6d85f12bb92\",\n  \"connectionName\": {\n    \"tr-TR\": \"SystemDefultConnection\"\n  },\n  \"connectionType\": 1,\n  \"description\": {},\n  \"id\": null,\n  \"properties\": {\n    \"cacheTTL\": 60000,\n    \"cacheType\": \"Memory\",\n    \"enableCache\": true,\n    \"timeout\": 60,\n    \"commandText\": \"SELECT DOCUMENTID,\\nCOALESCE(NULLIF(E_ITRM_RequestTypeEditML_SystemCulture.REQUESTTYPE, ''), NULLIF(E_ITRM_RequestTypeEditML_UserCulture.REQUESTTYPE, ''), NULLIF(E_ITRM_RequestTypeEditML_defaultCulture.REQUESTTYPE, '')) AS REQUESTTYPE,\\nCOALESCE(NULLIF(E_ITRM_RequestTypeEditML_SystemCulture.DESCRIPTION, ''), NULLIF(E_ITRM_RequestTypeEditML_UserCulture.DESCRIPTION, ''), NULLIF(E_ITRM_RequestTypeEditML_defaultCulture.DESCRIPTION, '')) AS DESCRIPTION\\n FROM E_ITRM_RequestTypeEdit\\n\\nOUTER APPLY (SELECT REQUESTTYPE,DESCRIPTION FROM E_ITRM_RequestTypeEditML WHERE E_ITRM_RequestTypeEdit.ID = E_ITRM_RequestTypeEditML.PARENTID AND E_ITRM_RequestTypeEditML.CULTURE = 'system') E_ITRM_RequestTypeEditML_SystemCulture \\nOUTER APPLY (SELECT REQUESTTYPE,DESCRIPTION FROM E_ITRM_RequestTypeEditML WHERE E_ITRM_RequestTypeEdit.ID = E_ITRM_RequestTypeEditML.PARENTID AND E_ITRM_RequestTypeEditML.CULTURE = {{Culture}}) E_ITRM_RequestTypeEditML_UserCulture\\nOUTER APPLY (SELECT REQUESTTYPE,DESCRIPTION FROM E_ITRM_RequestTypeEditML WHERE E_ITRM_RequestTypeEdit.ID = E_ITRM_RequestTypeEditML.PARENTID AND E_ITRM_RequestTypeEditML.CULTURE = (SELECT TOP 1 CULTURE from LANGUAGES WHERE ISDEFAULT = 1)) E_ITRM_RequestTypeEditML_defaultCulture\\n\\nWHERE\\nE_ITRM_RequestTypeEdit.DELETEDAT IS NULL\\nORDER BY DOCUMENTID DESC\\n\",\n    \"parameters\": [\n      {\n        \"caption\": \"Culture\",\n        \"isActive\": true,\n        \"isRequired\": true,\n        \"key\": \"Culture\",\n        \"value\": \"%User.Language%\",\n        \"valueType\": 1,\n        \"length\": 10,\n        \"subType\": null\n      }\n    ],\n    \"commandType\": 1,\n    \"executionType\": 3\n  },\n  \"structure\": {\n    \"columns\": [],\n    \"returnType\": null\n  }\n}";

    JObject queryObj = JObject.Parse(queryContent);

    string connectionId = queryObj.Value<string>("connectionId");

    DataSourceConnectionObject connectionObj = await DataSourceApi.GetConnectionObject(GetContextData(), HttpClientOptions, connectionId);
    CurrentUserInfo currentUserInfo = await DataSourceApi.GetCurrentUserInfo(GetContextData(), HttpClientOptions);

    IProvider provider = DataSourceApi.CreateProvider(connectionObj.Type, connectionObj.Properties, currentUserInfo);

    string requestContent = queryObj["properties"].ToString();

    var executeRequest = provider.MergeParameters(request,  requestContent);

    return await provider.ExecuteAsync(executeRequest);
}

internal async Task<DataSourceResponse<object>> RequestReasons_DataSource(RequestReasons_DataSourceRequest request)
{
    string queryContent = "{\n  \"name\": \"RequestReasons_DataSource\",\n  \"connectionId\": \"3ee648e2-6d8b-49ad-babf-a6d85f12bb92\",\n  \"connectionName\": {\n    \"tr-TR\": \"SystemDefultConnection\"\n  },\n  \"connectionType\": 1,\n  \"description\": {},\n  \"id\": null,\n  \"properties\": {\n    \"cacheTTL\": 60000,\n    \"cacheType\": \"Memory\",\n    \"enableCache\": true,\n    \"timeout\": 60,\n    \"commandText\": \"SELECT DOCUMENTID,\\nCOALESCE(NULLIF(E_ITRM_RequestReasonEditML_SystemCulture.REQUESTREASON, ''), NULLIF(E_ITRM_RequestReasonEditML_UserCulture.REQUESTREASON, ''), NULLIF(E_ITRM_RequestReasonEditML_defaultCulture.REQUESTREASON, '')) AS REQUESTREASON,\\nCOALESCE(NULLIF(E_ITRM_RequestReasonEditML_SystemCulture.DESCRIPTION, ''), NULLIF(E_ITRM_RequestReasonEditML_UserCulture.DESCRIPTION, ''), NULLIF(E_ITRM_RequestReasonEditML_defaultCulture.DESCRIPTION, '')) AS DESCRIPTION,\\nE_ITRM_RequestReasonEditSL.REQUESTTYPE,\\nReasonEditSL.VALUE as REQUESTTYPEID\\n FROM E_ITRM_RequestReasonEdit\\n\\nOUTER APPLY (SELECT REQUESTREASON,DESCRIPTION FROM E_ITRM_RequestReasonEditML WHERE E_ITRM_RequestReasonEdit.ID = E_ITRM_RequestReasonEditML.PARENTID AND E_ITRM_RequestReasonEditML.CULTURE = 'system') E_ITRM_RequestReasonEditML_SystemCulture \\nOUTER APPLY (SELECT REQUESTREASON,DESCRIPTION FROM E_ITRM_RequestReasonEditML WHERE E_ITRM_RequestReasonEdit.ID = E_ITRM_RequestReasonEditML.PARENTID AND E_ITRM_RequestReasonEditML.CULTURE = {{Culture}}) E_ITRM_RequestReasonEditML_UserCulture\\nOUTER APPLY (SELECT REQUESTREASON,DESCRIPTION FROM E_ITRM_RequestReasonEditML WHERE E_ITRM_RequestReasonEdit.ID = E_ITRM_RequestReasonEditML.PARENTID AND E_ITRM_RequestReasonEditML.CULTURE = (SELECT TOP 1 CULTURE from LANGUAGES WHERE ISDEFAULT = 1)) E_ITRM_RequestReasonEditML_defaultCulture\\n\\nLEFT JOIN E_ITRM_RequestReasonEditSL ReasonEditSL on ReasonEditSL.PARENTID=E_ITRM_RequestReasonEdit.ID\\n LEFT JOIN\\n (SELECT * FROM (\\n\\t\\tSELECT formSL.CONTROLID, \\n                   (\\n                       SELECT \\n                         STRING_AGG(formSLMLMultiple.TEXT, ',') AS TEXT                    \\n                       FROM E_ITRM_RequestReasonEditSL formSLMultiple\\n                           JOIN E_ITRM_RequestReasonEditSLML formSLMLMultiple WITH (NOLOCK)\\n                               ON formSLMultiple.ID = formSLMLMultiple.PARENTID\\n                       WHERE formSLMultiple.PARENTID = formSL.PARENTID\\n                             AND formSLMultiple.CONTROLID = formSL.CONTROLID\\n                             AND formSLMLMultiple.CULTURE = CASE WHEN\\n                                             EXISTS (SELECT TOP 1 1 FROM E_ITRM_RequestReasonEditSLML checkML WITH (NOLOCK) WHERE\\n                                                        formSLML.PARENTID = checkML.PARENTID AND\\n                                                        checkML.CULTURE = {{Culture}} AND\\n                                                        checkML.TEXT  IS NOT NULL\\n                                                    )\\n                                             THEN {{Culture}}\\n                                             WHEN\\n                                             (SELECT COUNT (1) FROM E_ITRM_RequestReasonEditSLML WHERE \\n                                                 E_ITRM_RequestReasonEditSLML.PARENTID = formSLMultiple.ID) = 1\\n                                             THEN \\n                                                 formSLMLMultiple.CULTURE\\n                                             ELSE\\n                                                 'system'\\n                                             END\\n                        \\n                   ) AS TEXT, \\n                formSL.PARENTID\\n\\t\\t\\t        FROM E_ITRM_RequestReasonEditSL formSL\\n\\t\\t\\t        JOIN E_ITRM_RequestReasonEditSLML formSLML \\n\\t\\t\\t        \\t WITH (NOLOCK) ON formSL.ID = formSLML.PARENTID\\n\\t\\t        ) as formSLML\\t\\nPIVOT(MAX(TEXT) FOR CONTROLID IN (REQUESTTYPE)) AS formSelect)  E_ITRM_RequestReasonEditSL\\n          ON E_ITRM_RequestReasonEditSL.PARENTID = E_ITRM_RequestReasonEdit.ID\\n         \\nWHERE\\nE_ITRM_RequestReasonEdit.DELETEDAT IS NULL\\nORDER BY DOCUMENTID DESC\\n\",\n    \"parameters\": [\n      {\n        \"caption\": \"Culture\",\n        \"isActive\": true,\n        \"isRequired\": true,\n        \"key\": \"Culture\",\n        \"value\": \"%User.Language%\",\n        \"valueType\": 1,\n        \"length\": 10,\n        \"subType\": null\n      }\n    ],\n    \"commandType\": 1,\n    \"executionType\": 3\n  },\n  \"structure\": {\n    \"columns\": [\n      {\n        \"name\": \"DOCUMENTID\",\n        \"type\": 3,\n        \"caption\": \"DOCUMENTID\",\n        \"columns\": []\n      },\n      {\n        \"name\": \"REQUESTREASON\",\n        \"type\": 1,\n        \"caption\": \"REQUESTREASON\",\n        \"columns\": []\n      },\n      {\n        \"name\": \"DESCRIPTION\",\n        \"type\": 1,\n        \"caption\": \"DESCRIPTION\",\n        \"columns\": []\n      },\n      {\n        \"name\": \"REQUESTTYPE\",\n        \"type\": 1,\n        \"caption\": \"REQUESTTYPE\",\n        \"columns\": []\n      },\n      {\n        \"name\": \"REQUESTTYPEID\",\n        \"type\": 9,\n        \"caption\": \"REQUESTTYPEID\",\n        \"columns\": []\n      }\n    ],\n    \"returnType\": 10\n  }\n}";

    JObject queryObj = JObject.Parse(queryContent);

    string connectionId = queryObj.Value<string>("connectionId");

    DataSourceConnectionObject connectionObj = await DataSourceApi.GetConnectionObject(GetContextData(), HttpClientOptions, connectionId);
    CurrentUserInfo currentUserInfo = await DataSourceApi.GetCurrentUserInfo(GetContextData(), HttpClientOptions);

    IProvider provider = DataSourceApi.CreateProvider(connectionObj.Type, connectionObj.Properties, currentUserInfo);

    string requestContent = queryObj["properties"].ToString();

    var executeRequest = provider.MergeParameters(request,  requestContent);

    return await provider.ExecuteAsync(executeRequest);
}

internal async Task<DataSourceResponse<object>> Priorities_DataSource(Priorities_DataSourceRequest request)
{
    string queryContent = "{\n  \"name\": \"Priorities_DataSource\",\n  \"connectionId\": \"3ee648e2-6d8b-49ad-babf-a6d85f12bb92\",\n  \"connectionName\": {\n    \"tr-TR\": \"SystemDefultConnection\"\n  },\n  \"connectionType\": 1,\n  \"description\": {},\n  \"id\": null,\n  \"properties\": {\n    \"cacheTTL\": 60000,\n    \"cacheType\": \"Memory\",\n    \"enableCache\": true,\n    \"timeout\": 60,\n    \"commandText\": \"SELECT DOCUMENTID,\\nCOALESCE(NULLIF(E_ITRM_PriorityEditML_SystemCulture.PRIORITY, ''), NULLIF(E_ITRM_PriorityEditML_UserCulture.PRIORITY, ''), NULLIF(E_ITRM_PriorityEditML_defaultCulture.PRIORITY, '')) AS PRIORITY,\\nCOALESCE(NULLIF(E_ITRM_PriorityEditML_SystemCulture.DESCRIPTION, ''), NULLIF(E_ITRM_PriorityEditML_UserCulture.DESCRIPTION, ''), NULLIF(E_ITRM_PriorityEditML_defaultCulture.DESCRIPTION, '')) AS DESCRIPTION\\n FROM E_ITRM_PriorityEdit\\n\\nOUTER APPLY (SELECT PRIORITY,DESCRIPTION FROM E_ITRM_PriorityEditML WHERE E_ITRM_PriorityEdit.ID = E_ITRM_PriorityEditML.PARENTID AND E_ITRM_PriorityEditML.CULTURE = 'system') E_ITRM_PriorityEditML_SystemCulture \\nOUTER APPLY (SELECT PRIORITY,DESCRIPTION FROM E_ITRM_PriorityEditML WHERE E_ITRM_PriorityEdit.ID = E_ITRM_PriorityEditML.PARENTID AND E_ITRM_PriorityEditML.CULTURE = {{Culture}}) E_ITRM_PriorityEditML_UserCulture\\nOUTER APPLY (SELECT PRIORITY,DESCRIPTION FROM E_ITRM_PriorityEditML WHERE E_ITRM_PriorityEdit.ID = E_ITRM_PriorityEditML.PARENTID AND E_ITRM_PriorityEditML.CULTURE = (SELECT TOP 1 CULTURE from LANGUAGES WHERE ISDEFAULT = 1)) E_ITRM_PriorityEditML_defaultCulture\\n\\nWHERE\\nE_ITRM_PriorityEdit.DELETEDAT IS NULL\\nORDER BY DOCUMENTID DESC\\n\",\n    \"parameters\": [\n      {\n        \"caption\": \"Culture\",\n        \"isActive\": true,\n        \"isRequired\": true,\n        \"key\": \"Culture\",\n        \"value\": \"%User.Language%\",\n        \"valueType\": 1,\n        \"length\": 10,\n        \"subType\": null\n      }\n    ],\n    \"commandType\": 1,\n    \"executionType\": 3\n  },\n  \"structure\": {\n    \"columns\": [],\n    \"returnType\": null\n  }\n}";

    JObject queryObj = JObject.Parse(queryContent);

    string connectionId = queryObj.Value<string>("connectionId");

    DataSourceConnectionObject connectionObj = await DataSourceApi.GetConnectionObject(GetContextData(), HttpClientOptions, connectionId);
    CurrentUserInfo currentUserInfo = await DataSourceApi.GetCurrentUserInfo(GetContextData(), HttpClientOptions);

    IProvider provider = DataSourceApi.CreateProvider(connectionObj.Type, connectionObj.Properties, currentUserInfo);

    string requestContent = queryObj["properties"].ToString();

    var executeRequest = provider.MergeParameters(request,  requestContent);

    return await provider.ExecuteAsync(executeRequest);
}

internal async Task<DataSourceResponse<object>> RequestTypes(RequestTypesRequest request)
{
    string queryContent = "{\n  \"name\": \"RequestTypes\",\n  \"connectionId\": \"766d3c90-bc8a-4b27-a42c-6cc31e9514b8\",\n  \"connectionName\": {\n    \"tr-TR\": \"DeployAgent\"\n  },\n  \"connectionType\": 5,\n  \"description\": {},\n  \"id\": null,\n  \"properties\": {\n    \"cacheTTL\": 60000,\n    \"cacheType\": \"Memory\",\n    \"enableCache\": true,\n    \"timeout\": 60,\n    \"bodyContent\": \"{\\\"loadOptions\\\":{\\\"filters\\\":[],\\\"sorts\\\":[]},\\\"forceRefresh\\\":true}\",\n    \"contentType\": 3,\n    \"endpoint\": \"/apps/ITRM/latest/api/DataSource/RequestTypes_DataSource\",\n    \"requestType\": 1,\n    \"selectedPath\": \"result.result\",\n    \"parameters\": [\n      {\n        \"caption\": \"\",\n        \"isActive\": true,\n        \"isRequired\": true,\n        \"key\": \"Authorization\",\n        \"value\": \"%User.Token%\",\n        \"valueType\": 1,\n        \"type\": 1\n      },\n      {\n        \"caption\": \"\",\n        \"isActive\": true,\n        \"isRequired\": true,\n        \"key\": \"Bimser-Encrypted-Data\",\n        \"value\": \"%User.EncryptedData%\",\n        \"valueType\": 1,\n        \"type\": 1\n      },\n      {\n        \"caption\": \"\",\n        \"isActive\": true,\n        \"isRequired\": true,\n        \"key\": \"Bimser-Language\",\n        \"value\": \"%User.Language%\",\n        \"valueType\": 1,\n        \"type\": 1\n      }\n    ]\n  },\n  \"structure\": {\n    \"metaData\": [\n      {\n        \"childs\": [\n          {\n            \"childs\": [\n              {\n                \"childs\": [\n                  {\n                    \"childs\": [],\n                    \"displayName\": \"returnType\",\n                    \"name\": \"returnType\",\n                    \"valueType\": 3\n                  },\n                  {\n                    \"childs\": [\n                      {\n                        \"childs\": [],\n                        \"displayName\": \"name\",\n                        \"name\": \"name\",\n                        \"valueType\": 1\n                      },\n                      {\n                        \"childs\": [],\n                        \"displayName\": \"caption\",\n                        \"name\": \"caption\",\n                        \"valueType\": 1\n                      },\n                      {\n                        \"childs\": [],\n                        \"displayName\": \"type\",\n                        \"name\": \"type\",\n                        \"valueType\": 3\n                      }\n                    ],\n                    \"displayName\": \"columns\",\n                    \"name\": \"columns\",\n                    \"valueType\": 10\n                  }\n                ],\n                \"displayName\": \"structure\",\n                \"name\": \"structure\",\n                \"valueType\": 9\n              },\n              {\n                \"childs\": [],\n                \"displayName\": \"size\",\n                \"name\": \"size\",\n                \"valueType\": 5\n              },\n              {\n                \"childs\": [],\n                \"displayName\": \"count\",\n                \"name\": \"count\",\n                \"valueType\": 3\n              },\n              {\n                \"childs\": [],\n                \"displayName\": \"isFromCache\",\n                \"name\": \"isFromCache\",\n                \"valueType\": 2\n              },\n              {\n                \"childs\": [],\n                \"displayName\": \"cachingDate\",\n                \"name\": \"cachingDate\",\n                \"valueType\": 5\n              },\n              {\n                \"childs\": [],\n                \"displayName\": \"isEndOfSource\",\n                \"name\": \"isEndOfSource\",\n                \"valueType\": 2\n              },\n              {\n                \"childs\": [\n                  {\n                    \"childs\": [\n                      {\n                        \"childs\": [],\n                        \"displayName\": \"selectors\",\n                        \"name\": \"selectors\",\n                        \"valueType\": 5\n                      },\n                      {\n                        \"childs\": [],\n                        \"displayName\": \"distinct\",\n                        \"name\": \"distinct\",\n                        \"valueType\": 2\n                      },\n                      {\n                        \"childs\": [],\n                        \"displayName\": \"filters\",\n                        \"name\": \"filters\",\n                        \"valueType\": 10\n                      },\n                      {\n                        \"childs\": [],\n                        \"displayName\": \"sorts\",\n                        \"name\": \"sorts\",\n                        \"valueType\": 10\n                      },\n                      {\n                        \"childs\": [\n                          {\n                            \"childs\": [],\n                            \"displayName\": \"skip\",\n                            \"name\": \"skip\",\n                            \"valueType\": 3\n                          },\n                          {\n                            \"childs\": [],\n                            \"displayName\": \"take\",\n                            \"name\": \"take\",\n                            \"valueType\": 3\n                          }\n                        ],\n                        \"displayName\": \"pagination\",\n                        \"name\": \"pagination\",\n                        \"valueType\": 9\n                      }\n                    ],\n                    \"displayName\": \"loadOptions\",\n                    \"name\": \"loadOptions\",\n                    \"valueType\": 9\n                  },\n                  {\n                    \"childs\": [],\n                    \"displayName\": \"Culture\",\n                    \"name\": \"Culture\",\n                    \"valueType\": 1\n                  }\n                ],\n                \"displayName\": \"parameters\",\n                \"name\": \"parameters\",\n                \"valueType\": 9\n              },\n              {\n                \"childs\": [],\n                \"displayName\": \"success\",\n                \"name\": \"success\",\n                \"valueType\": 2\n              },\n              {\n                \"childs\": [],\n                \"displayName\": \"message\",\n                \"name\": \"message\",\n                \"valueType\": 1\n              },\n              {\n                \"childs\": [],\n                \"displayName\": \"internalMessage\",\n                \"name\": \"internalMessage\",\n                \"valueType\": 1\n              },\n              {\n                \"childs\": [\n                  {\n                    \"childs\": [],\n                    \"displayName\": \"DOCUMENTID\",\n                    \"name\": \"DOCUMENTID\",\n                    \"valueType\": 3\n                  },\n                  {\n                    \"childs\": [],\n                    \"displayName\": \"REQUESTTYPE\",\n                    \"name\": \"REQUESTTYPE\",\n                    \"valueType\": 1\n                  },\n                  {\n                    \"childs\": [],\n                    \"displayName\": \"DESCRIPTION\",\n                    \"name\": \"DESCRIPTION\",\n                    \"valueType\": 1\n                  }\n                ],\n                \"displayName\": \"result\",\n                \"name\": \"result\",\n                \"valueType\": 10\n              }\n            ],\n            \"displayName\": \"result\",\n            \"name\": \"result\",\n            \"valueType\": 9\n          },\n          {\n            \"childs\": [],\n            \"displayName\": \"success\",\n            \"name\": \"success\",\n            \"valueType\": 2\n          }\n        ],\n        \"displayName\": \"\",\n        \"name\": \"\",\n        \"valueType\": 9\n      }\n    ]\n  }\n}";

    JObject queryObj = JObject.Parse(queryContent);

    string connectionId = queryObj.Value<string>("connectionId");

    DataSourceConnectionObject connectionObj = await DataSourceApi.GetConnectionObject(GetContextData(), HttpClientOptions, connectionId);
    CurrentUserInfo currentUserInfo = await DataSourceApi.GetCurrentUserInfo(GetContextData(), HttpClientOptions);

    IProvider provider = DataSourceApi.CreateProvider(connectionObj.Type, connectionObj.Properties, currentUserInfo);

    string requestContent = queryObj["properties"].ToString();

    var executeRequest = provider.MergeParameters(request,  requestContent);

    return await provider.ExecuteAsync(executeRequest);
}

internal async Task<DataSourceResponse<object>> RequestReason(RequestReasonRequest request)
{
    string queryContent = "{\n  \"name\": \"RequestReason\",\n  \"connectionId\": \"766d3c90-bc8a-4b27-a42c-6cc31e9514b8\",\n  \"connectionName\": {\n    \"tr-TR\": \"DeployAgent\"\n  },\n  \"connectionType\": 5,\n  \"description\": {},\n  \"id\": null,\n  \"properties\": {\n    \"cacheTTL\": 60000,\n    \"cacheType\": \"Memory\",\n    \"enableCache\": true,\n    \"timeout\": 60,\n    \"bodyContent\": \"{\\\"loadOptions\\\":{\\\"filters\\\":[{\\\"Operator\\\":1,\\\"Filters\\\":[{\\\"Column\\\":\\\"REQUESTTYPEID\\\",\\\"Not\\\":false,\\\"Type\\\":1,\\\"Value\\\":\\\"@requestTypeId\\\",\\\"ItemType\\\":4}]}],\\\"sorts\\\":[]}}\",\n    \"contentType\": 3,\n    \"endpoint\": \"/apps/ITRM/latest/api/DataSource/RequestReasons_DataSource\",\n    \"requestType\": 1,\n    \"selectedPath\": \"result.result\",\n    \"parameters\": [\n      {\n        \"caption\": \"\",\n        \"isActive\": true,\n        \"isRequired\": true,\n        \"key\": \"requestTypeId\",\n        \"value\": \"196850\",\n        \"valueType\": 1,\n        \"type\": 3\n      },\n      {\n        \"caption\": \"\",\n        \"isActive\": true,\n        \"isRequired\": true,\n        \"key\": \"Authorization\",\n        \"value\": \"%User.Token%\",\n        \"valueType\": 1,\n        \"type\": 1\n      },\n      {\n        \"caption\": \"\",\n        \"isActive\": true,\n        \"isRequired\": true,\n        \"key\": \"Bimser-Encrypted-Data\",\n        \"value\": \"%User.EncryptedData%\",\n        \"valueType\": 1,\n        \"type\": 1\n      },\n      {\n        \"caption\": \"\",\n        \"isActive\": true,\n        \"isRequired\": true,\n        \"key\": \"Bimser-Language\",\n        \"value\": \"%User.Language%\",\n        \"valueType\": 1,\n        \"type\": 1\n      }\n    ]\n  },\n  \"structure\": {\n    \"metaData\": [\n      {\n        \"childs\": [\n          {\n            \"childs\": [\n              {\n                \"childs\": [\n                  {\n                    \"childs\": [],\n                    \"displayName\": \"returnType\",\n                    \"name\": \"returnType\",\n                    \"valueType\": 3\n                  },\n                  {\n                    \"childs\": [\n                      {\n                        \"childs\": [],\n                        \"displayName\": \"name\",\n                        \"name\": \"name\",\n                        \"valueType\": 1\n                      },\n                      {\n                        \"childs\": [],\n                        \"displayName\": \"caption\",\n                        \"name\": \"caption\",\n                        \"valueType\": 1\n                      },\n                      {\n                        \"childs\": [],\n                        \"displayName\": \"type\",\n                        \"name\": \"type\",\n                        \"valueType\": 3\n                      }\n                    ],\n                    \"displayName\": \"columns\",\n                    \"name\": \"columns\",\n                    \"valueType\": 10\n                  }\n                ],\n                \"displayName\": \"structure\",\n                \"name\": \"structure\",\n                \"valueType\": 9\n              },\n              {\n                \"childs\": [],\n                \"displayName\": \"size\",\n                \"name\": \"size\",\n                \"valueType\": 5\n              },\n              {\n                \"childs\": [],\n                \"displayName\": \"count\",\n                \"name\": \"count\",\n                \"valueType\": 3\n              },\n              {\n                \"childs\": [],\n                \"displayName\": \"isFromCache\",\n                \"name\": \"isFromCache\",\n                \"valueType\": 2\n              },\n              {\n                \"childs\": [],\n                \"displayName\": \"cachingDate\",\n                \"name\": \"cachingDate\",\n                \"valueType\": 5\n              },\n              {\n                \"childs\": [],\n                \"displayName\": \"isEndOfSource\",\n                \"name\": \"isEndOfSource\",\n                \"valueType\": 2\n              },\n              {\n                \"childs\": [\n                  {\n                    \"childs\": [\n                      {\n                        \"childs\": [],\n                        \"displayName\": \"selectors\",\n                        \"name\": \"selectors\",\n                        \"valueType\": 5\n                      },\n                      {\n                        \"childs\": [],\n                        \"displayName\": \"distinct\",\n                        \"name\": \"distinct\",\n                        \"valueType\": 2\n                      },\n                      {\n                        \"childs\": [\n                          {\n                            \"childs\": [\n                              {\n                                \"childs\": [],\n                                \"displayName\": \"column\",\n                                \"name\": \"column\",\n                                \"valueType\": 1\n                              },\n                              {\n                                \"childs\": [],\n                                \"displayName\": \"not\",\n                                \"name\": \"not\",\n                                \"valueType\": 2\n                              },\n                              {\n                                \"childs\": [],\n                                \"displayName\": \"type\",\n                                \"name\": \"type\",\n                                \"valueType\": 3\n                              },\n                              {\n                                \"childs\": [],\n                                \"displayName\": \"value\",\n                                \"name\": \"value\",\n                                \"valueType\": 3\n                              },\n                              {\n                                \"childs\": [],\n                                \"displayName\": \"itemType\",\n                                \"name\": \"itemType\",\n                                \"valueType\": 3\n                              }\n                            ],\n                            \"displayName\": \"filters\",\n                            \"name\": \"filters\",\n                            \"valueType\": 10\n                          },\n                          {\n                            \"childs\": [],\n                            \"displayName\": \"operator\",\n                            \"name\": \"operator\",\n                            \"valueType\": 3\n                          }\n                        ],\n                        \"displayName\": \"filters\",\n                        \"name\": \"filters\",\n                        \"valueType\": 10\n                      },\n                      {\n                        \"childs\": [],\n                        \"displayName\": \"sorts\",\n                        \"name\": \"sorts\",\n                        \"valueType\": 10\n                      },\n                      {\n                        \"childs\": [\n                          {\n                            \"childs\": [],\n                            \"displayName\": \"skip\",\n                            \"name\": \"skip\",\n                            \"valueType\": 3\n                          },\n                          {\n                            \"childs\": [],\n                            \"displayName\": \"take\",\n                            \"name\": \"take\",\n                            \"valueType\": 3\n                          }\n                        ],\n                        \"displayName\": \"pagination\",\n                        \"name\": \"pagination\",\n                        \"valueType\": 9\n                      }\n                    ],\n                    \"displayName\": \"loadOptions\",\n                    \"name\": \"loadOptions\",\n                    \"valueType\": 9\n                  },\n                  {\n                    \"childs\": [],\n                    \"displayName\": \"Culture\",\n                    \"name\": \"Culture\",\n                    \"valueType\": 1\n                  }\n                ],\n                \"displayName\": \"parameters\",\n                \"name\": \"parameters\",\n                \"valueType\": 9\n              },\n              {\n                \"childs\": [],\n                \"displayName\": \"success\",\n                \"name\": \"success\",\n                \"valueType\": 2\n              },\n              {\n                \"childs\": [],\n                \"displayName\": \"message\",\n                \"name\": \"message\",\n                \"valueType\": 1\n              },\n              {\n                \"childs\": [],\n                \"displayName\": \"internalMessage\",\n                \"name\": \"internalMessage\",\n                \"valueType\": 1\n              },\n              {\n                \"childs\": [\n                  {\n                    \"childs\": [],\n                    \"displayName\": \"DOCUMENTID\",\n                    \"name\": \"DOCUMENTID\",\n                    \"valueType\": 3\n                  },\n                  {\n                    \"childs\": [],\n                    \"displayName\": \"REQUESTREASON\",\n                    \"name\": \"REQUESTREASON\",\n                    \"valueType\": 1\n                  },\n                  {\n                    \"childs\": [],\n                    \"displayName\": \"DESCRIPTION\",\n                    \"name\": \"DESCRIPTION\",\n                    \"valueType\": 1\n                  },\n                  {\n                    \"childs\": [],\n                    \"displayName\": \"REQUESTTYPE\",\n                    \"name\": \"REQUESTTYPE\",\n                    \"valueType\": 1\n                  },\n                  {\n                    \"childs\": [],\n                    \"displayName\": \"REQUESTTYPEID\",\n                    \"name\": \"REQUESTTYPEID\",\n                    \"valueType\": 3\n                  }\n                ],\n                \"displayName\": \"result\",\n                \"name\": \"result\",\n                \"valueType\": 10\n              }\n            ],\n            \"displayName\": \"result\",\n            \"name\": \"result\",\n            \"valueType\": 9\n          },\n          {\n            \"childs\": [],\n            \"displayName\": \"success\",\n            \"name\": \"success\",\n            \"valueType\": 2\n          }\n        ],\n        \"displayName\": \"\",\n        \"name\": \"\",\n        \"valueType\": 9\n      }\n    ]\n  }\n}";

    JObject queryObj = JObject.Parse(queryContent);

    string connectionId = queryObj.Value<string>("connectionId");

    DataSourceConnectionObject connectionObj = await DataSourceApi.GetConnectionObject(GetContextData(), HttpClientOptions, connectionId);
    CurrentUserInfo currentUserInfo = await DataSourceApi.GetCurrentUserInfo(GetContextData(), HttpClientOptions);

    IProvider provider = DataSourceApi.CreateProvider(connectionObj.Type, connectionObj.Properties, currentUserInfo);

    string requestContent = queryObj["properties"].ToString();

    var executeRequest = provider.MergeParameters(request,  requestContent);

    return await provider.ExecuteAsync(executeRequest);
}

internal async Task<DataSourceResponse<object>> Priorities(PrioritiesRequest request)
{
    string queryContent = "{\n  \"name\": \"Priorities\",\n  \"connectionId\": \"766d3c90-bc8a-4b27-a42c-6cc31e9514b8\",\n  \"connectionName\": {\n    \"tr-TR\": \"DeployAgent\"\n  },\n  \"connectionType\": 5,\n  \"description\": {},\n  \"id\": null,\n  \"properties\": {\n    \"cacheTTL\": 60000,\n    \"cacheType\": \"Memory\",\n    \"enableCache\": true,\n    \"timeout\": 60,\n    \"bodyContent\": \"{\\\"loadOptions\\\":{\\\"filters\\\":[],\\\"sorts\\\":[]},\\\"forceRefresh\\\":true}\",\n    \"contentType\": 3,\n    \"endpoint\": \"/apps/ITRM/latest/api/DataSource/Priorities_DataSource\",\n    \"requestType\": 1,\n    \"selectedPath\": \"result.result\",\n    \"parameters\": [\n      {\n        \"caption\": \"\",\n        \"isActive\": true,\n        \"isRequired\": true,\n        \"key\": \"Authorization\",\n        \"value\": \"%User.Token%\",\n        \"valueType\": 1,\n        \"type\": 1\n      },\n      {\n        \"caption\": \"\",\n        \"isActive\": true,\n        \"isRequired\": true,\n        \"key\": \"Bimser-Encrypted-Data\",\n        \"value\": \"%User.EncryptedData%\",\n        \"valueType\": 1,\n        \"type\": 1\n      },\n      {\n        \"caption\": \"\",\n        \"isActive\": true,\n        \"isRequired\": true,\n        \"key\": \"Bimser-Language\",\n        \"value\": \"%User.Language%\",\n        \"valueType\": 1,\n        \"type\": 1\n      }\n    ]\n  },\n  \"structure\": {\n    \"metaData\": [\n      {\n        \"childs\": [\n          {\n            \"childs\": [\n              {\n                \"childs\": [\n                  {\n                    \"childs\": [],\n                    \"displayName\": \"returnType\",\n                    \"name\": \"returnType\",\n                    \"valueType\": 3\n                  },\n                  {\n                    \"childs\": [\n                      {\n                        \"childs\": [],\n                        \"displayName\": \"name\",\n                        \"name\": \"name\",\n                        \"valueType\": 1\n                      },\n                      {\n                        \"childs\": [],\n                        \"displayName\": \"caption\",\n                        \"name\": \"caption\",\n                        \"valueType\": 1\n                      },\n                      {\n                        \"childs\": [],\n                        \"displayName\": \"type\",\n                        \"name\": \"type\",\n                        \"valueType\": 3\n                      }\n                    ],\n                    \"displayName\": \"columns\",\n                    \"name\": \"columns\",\n                    \"valueType\": 10\n                  }\n                ],\n                \"displayName\": \"structure\",\n                \"name\": \"structure\",\n                \"valueType\": 9\n              },\n              {\n                \"childs\": [],\n                \"displayName\": \"size\",\n                \"name\": \"size\",\n                \"valueType\": 5\n              },\n              {\n                \"childs\": [],\n                \"displayName\": \"count\",\n                \"name\": \"count\",\n                \"valueType\": 3\n              },\n              {\n                \"childs\": [],\n                \"displayName\": \"isFromCache\",\n                \"name\": \"isFromCache\",\n                \"valueType\": 2\n              },\n              {\n                \"childs\": [],\n                \"displayName\": \"cachingDate\",\n                \"name\": \"cachingDate\",\n                \"valueType\": 5\n              },\n              {\n                \"childs\": [],\n                \"displayName\": \"isEndOfSource\",\n                \"name\": \"isEndOfSource\",\n                \"valueType\": 2\n              },\n              {\n                \"childs\": [\n                  {\n                    \"childs\": [\n                      {\n                        \"childs\": [],\n                        \"displayName\": \"selectors\",\n                        \"name\": \"selectors\",\n                        \"valueType\": 5\n                      },\n                      {\n                        \"childs\": [],\n                        \"displayName\": \"distinct\",\n                        \"name\": \"distinct\",\n                        \"valueType\": 2\n                      },\n                      {\n                        \"childs\": [],\n                        \"displayName\": \"filters\",\n                        \"name\": \"filters\",\n                        \"valueType\": 10\n                      },\n                      {\n                        \"childs\": [],\n                        \"displayName\": \"sorts\",\n                        \"name\": \"sorts\",\n                        \"valueType\": 10\n                      },\n                      {\n                        \"childs\": [\n                          {\n                            \"childs\": [],\n                            \"displayName\": \"skip\",\n                            \"name\": \"skip\",\n                            \"valueType\": 3\n                          },\n                          {\n                            \"childs\": [],\n                            \"displayName\": \"take\",\n                            \"name\": \"take\",\n                            \"valueType\": 3\n                          }\n                        ],\n                        \"displayName\": \"pagination\",\n                        \"name\": \"pagination\",\n                        \"valueType\": 9\n                      }\n                    ],\n                    \"displayName\": \"loadOptions\",\n                    \"name\": \"loadOptions\",\n                    \"valueType\": 9\n                  },\n                  {\n                    \"childs\": [],\n                    \"displayName\": \"Culture\",\n                    \"name\": \"Culture\",\n                    \"valueType\": 1\n                  }\n                ],\n                \"displayName\": \"parameters\",\n                \"name\": \"parameters\",\n                \"valueType\": 9\n              },\n              {\n                \"childs\": [],\n                \"displayName\": \"success\",\n                \"name\": \"success\",\n                \"valueType\": 2\n              },\n              {\n                \"childs\": [],\n                \"displayName\": \"message\",\n                \"name\": \"message\",\n                \"valueType\": 1\n              },\n              {\n                \"childs\": [],\n                \"displayName\": \"internalMessage\",\n                \"name\": \"internalMessage\",\n                \"valueType\": 1\n              },\n              {\n                \"childs\": [\n                  {\n                    \"childs\": [],\n                    \"displayName\": \"DOCUMENTID\",\n                    \"name\": \"DOCUMENTID\",\n                    \"valueType\": 3\n                  },\n                  {\n                    \"childs\": [],\n                    \"displayName\": \"PRIORITY\",\n                    \"name\": \"PRIORITY\",\n                    \"valueType\": 1\n                  },\n                  {\n                    \"childs\": [],\n                    \"displayName\": \"DESCRIPTION\",\n                    \"name\": \"DESCRIPTION\",\n                    \"valueType\": 1\n                  }\n                ],\n                \"displayName\": \"result\",\n                \"name\": \"result\",\n                \"valueType\": 10\n              }\n            ],\n            \"displayName\": \"result\",\n            \"name\": \"result\",\n            \"valueType\": 9\n          },\n          {\n            \"childs\": [],\n            \"displayName\": \"success\",\n            \"name\": \"success\",\n            \"valueType\": 2\n          }\n        ],\n        \"displayName\": \"\",\n        \"name\": \"\",\n        \"valueType\": 9\n      }\n    ]\n  }\n}";

    JObject queryObj = JObject.Parse(queryContent);

    string connectionId = queryObj.Value<string>("connectionId");

    DataSourceConnectionObject connectionObj = await DataSourceApi.GetConnectionObject(GetContextData(), HttpClientOptions, connectionId);
    CurrentUserInfo currentUserInfo = await DataSourceApi.GetCurrentUserInfo(GetContextData(), HttpClientOptions);

    IProvider provider = DataSourceApi.CreateProvider(connectionObj.Type, connectionObj.Properties, currentUserInfo);

    string requestContent = queryObj["properties"].ToString();

    var executeRequest = provider.MergeParameters(request,  requestContent);

    return await provider.ExecuteAsync(executeRequest);
}

internal async Task<DataSourceResponse<object>> GetUsers(GetUsersRequest request)
{
    string queryContent = "{\n  \"name\": \"GetUsers\",\n  \"connectionId\": \"78100f8c-e4b6-45e9-8597-26808ca11381\",\n  \"connectionName\": {\n    \"tr-TR\": \"REST_HR\"\n  },\n  \"connectionType\": 5,\n  \"description\": {},\n  \"id\": null,\n  \"properties\": {\n    \"cacheTTL\": 60000,\n    \"cacheType\": \"Memory\",\n    \"enableCache\": true,\n    \"timeout\": 60,\n    \"bodyContent\": \"{\\\"loadOptions\\\":{\\\"sorts\\\":[],\\\"filters\\\":[{\\\"Operator\\\":1,\\\"Filters\\\":[{\\\"Column\\\":\\\"department\\\",\\\"Not\\\":false,\\\"Type\\\":1,\\\"Value\\\":\\\"@department\\\",\\\"ItemType\\\":4}]}]},\\\"companyId\\\":null,\\\"noneSetCompany\\\":false}\",\n    \"contentType\": 3,\n    \"endpoint\": \"/Users/GetAllWithLoadOptions\",\n    \"requestType\": 1,\n    \"selectedPath\": \"result.data\",\n    \"parameters\": [\n      {\n        \"caption\": \"\",\n        \"isActive\": true,\n        \"isRequired\": true,\n        \"key\": \"department\",\n        \"value\": \"1\",\n        \"valueType\": 1,\n        \"type\": 3\n      },\n      {\n        \"caption\": \"\",\n        \"isActive\": true,\n        \"isRequired\": true,\n        \"key\": \"Authorization\",\n        \"value\": \"%User.Token%\",\n        \"valueType\": 1,\n        \"type\": 1\n      },\n      {\n        \"caption\": \"\",\n        \"isActive\": true,\n        \"isRequired\": true,\n        \"key\": \"Bimser-Encrypted-Data\",\n        \"value\": \"%User.EncryptedData%\",\n        \"valueType\": 1,\n        \"type\": 1\n      },\n      {\n        \"caption\": \"\",\n        \"isActive\": true,\n        \"isRequired\": true,\n        \"key\": \"Bimser-Language\",\n        \"value\": \"%User.Language%\",\n        \"valueType\": 1,\n        \"type\": 1\n      }\n    ]\n  },\n  \"structure\": {\n    \"metaData\": [\n      {\n        \"childs\": [\n          {\n            \"childs\": [\n              {\n                \"childs\": [\n                  {\n                    \"childs\": [],\n                    \"displayName\": \"id\",\n                    \"name\": \"id\",\n                    \"valueType\": 3\n                  },\n                  {\n                    \"childs\": [],\n                    \"displayName\": \"firstname\",\n                    \"name\": \"firstname\",\n                    \"valueType\": 1\n                  },\n                  {\n                    \"childs\": [],\n                    \"displayName\": \"lastname\",\n                    \"name\": \"lastname\",\n                    \"valueType\": 1\n                  },\n                  {\n                    \"childs\": [],\n                    \"displayName\": \"username\",\n                    \"name\": \"username\",\n                    \"valueType\": 1\n                  },\n                  {\n                    \"childs\": [],\n                    \"displayName\": \"eMail\",\n                    \"name\": \"eMail\",\n                    \"valueType\": 1\n                  },\n                  {\n                    \"childs\": [],\n                    \"displayName\": \"department\",\n                    \"name\": \"department\",\n                    \"valueType\": 3\n                  },\n                  {\n                    \"childs\": [],\n                    \"displayName\": \"departmentName\",\n                    \"name\": \"departmentName\",\n                    \"valueType\": 1\n                  },\n                  {\n                    \"childs\": [],\n                    \"displayName\": \"profession\",\n                    \"name\": \"profession\",\n                    \"valueType\": 3\n                  },\n                  {\n                    \"childs\": [],\n                    \"displayName\": \"professionName\",\n                    \"name\": \"professionName\",\n                    \"valueType\": 1\n                  },\n                  {\n                    \"childs\": [],\n                    \"displayName\": \"status\",\n                    \"name\": \"status\",\n                    \"valueType\": 3\n                  }\n                ],\n                \"displayName\": \"data\",\n                \"name\": \"data\",\n                \"valueType\": 10\n              },\n              {\n                \"childs\": [],\n                \"displayName\": \"totalCount\",\n                \"name\": \"totalCount\",\n                \"valueType\": 3\n              }\n            ],\n            \"displayName\": \"result\",\n            \"name\": \"result\",\n            \"valueType\": 9\n          },\n          {\n            \"childs\": [],\n            \"displayName\": \"success\",\n            \"name\": \"success\",\n            \"valueType\": 2\n          }\n        ],\n        \"displayName\": \"\",\n        \"name\": \"\",\n        \"valueType\": 9\n      }\n    ]\n  }\n}";

    JObject queryObj = JObject.Parse(queryContent);

    string connectionId = queryObj.Value<string>("connectionId");

    DataSourceConnectionObject connectionObj = await DataSourceApi.GetConnectionObject(GetContextData(), HttpClientOptions, connectionId);
    CurrentUserInfo currentUserInfo = await DataSourceApi.GetCurrentUserInfo(GetContextData(), HttpClientOptions);

    IProvider provider = DataSourceApi.CreateProvider(connectionObj.Type, connectionObj.Properties, currentUserInfo);

    string requestContent = queryObj["properties"].ToString();

    var executeRequest = provider.MergeParameters(request,  requestContent);

    return await provider.ExecuteAsync(executeRequest);
}

internal async Task<DataSourceResponse<object>> Requests_DataSource(Requests_DataSourceRequest request)
{
    string queryContent = "{\n  \"name\": \"Requests_DataSource\",\n  \"connectionId\": \"3ee648e2-6d8b-49ad-babf-a6d85f12bb92\",\n  \"connectionName\": {\n    \"tr-TR\": \"SystemDefultConnection\"\n  },\n  \"connectionType\": 1,\n  \"description\": {},\n  \"id\": null,\n  \"properties\": {\n    \"cacheTTL\": 60000,\n    \"cacheType\": \"Memory\",\n    \"enableCache\": true,\n    \"timeout\": 60,\n    \"commandText\": \"SELECT process.ID AS 'ProcessID',\\n(users.FIRSTNAME + ' ' + users.LASTNAME) AS 'RequestingUser',\\ndocuments.CREATEDAT AS 'CreatedDate',\\nprocessRequest.ID AS RequestId,\\nPROJECTFLOWSTATUSESML.CAPTION AS Status,\\ndocuments.ID AS DOCUMENTID,\\nE_ITRM_RequestEditSL.OPENTYPE,\\nE_ITRM_RequestEditSL.REQUESTORDEPARTMENT,\\nE_ITRM_RequestEditSL.PRIORITY,\\nE_ITRM_RequestEditSL.REQUESTTYPE,\\nE_ITRM_RequestEdit.UNIQUEID,\\nCASE WHEN E_ITRM_RequestEditSL.REQUESTORLOOK IS NULL THEN E_ITRM_RequestEdit.REQUESTOR ELSE E_ITRM_RequestEditSL.REQUESTORLOOK END REQUESTOR,\\nE_ITRM_RequestEditSL.REQUESTREASON,\\nCOALESCE(NULLIF(E_ITRM_RequestEditML_SystemCulture.IMAGES, ''), NULLIF(E_ITRM_RequestEditML_UserCulture.IMAGES, ''), NULLIF(E_ITRM_RequestEditML_defaultCulture.IMAGES, '')) AS IMAGES,\\nCOALESCE(NULLIF(E_ITRM_RequestEditML_SystemCulture.DESCRIPTION, ''), NULLIF(E_ITRM_RequestEditML_UserCulture.DESCRIPTION, ''), NULLIF(E_ITRM_RequestEditML_defaultCulture.DESCRIPTION, '')) AS DESCRIPTION,\\nE_ITRM_RequestEdit.REQUESTDATE,\\nCOALESCE(NULLIF(E_ITRM_RequestEditML_SystemCulture.DEVELOPERDESCRIPTION, ''), NULLIF(E_ITRM_RequestEditML_UserCulture.DEVELOPERDESCRIPTION, ''), NULLIF(E_ITRM_RequestEditML_defaultCulture.DEVELOPERDESCRIPTION, '')) AS DEVELOPERDESCRIPTION,\\nCOALESCE(NULLIF(E_ITRM_RequestEditML_SystemCulture.REVIEWREASON, ''), NULLIF(E_ITRM_RequestEditML_UserCulture.REVIEWREASON, ''), NULLIF(E_ITRM_RequestEditML_defaultCulture.REVIEWREASON, '')) AS REVIEWREASON\\n FROM E_ITRM_RequestEdit\\n\\nOUTER APPLY (SELECT IMAGES,DESCRIPTION,DEVELOPERDESCRIPTION,REVIEWREASON FROM E_ITRM_RequestEditML WHERE E_ITRM_RequestEdit.ID = E_ITRM_RequestEditML.PARENTID AND E_ITRM_RequestEditML.CULTURE = 'system') E_ITRM_RequestEditML_SystemCulture \\nOUTER APPLY (SELECT IMAGES,DESCRIPTION,DEVELOPERDESCRIPTION,REVIEWREASON FROM E_ITRM_RequestEditML WHERE E_ITRM_RequestEdit.ID = E_ITRM_RequestEditML.PARENTID AND E_ITRM_RequestEditML.CULTURE = {{Culture}}) E_ITRM_RequestEditML_UserCulture\\nOUTER APPLY (SELECT IMAGES,DESCRIPTION,DEVELOPERDESCRIPTION,REVIEWREASON FROM E_ITRM_RequestEditML WHERE E_ITRM_RequestEdit.ID = E_ITRM_RequestEditML.PARENTID AND E_ITRM_RequestEditML.CULTURE = (SELECT TOP 1 CULTURE from LANGUAGES WHERE ISDEFAULT = 1)) E_ITRM_RequestEditML_defaultCulture\\n\\n\\n LEFT JOIN\\n (SELECT * FROM (\\n\\t\\tSELECT formSL.CONTROLID, \\n                   (\\n                       SELECT \\n                         STRING_AGG(formSLMLMultiple.TEXT, ',') AS TEXT                    \\n                       FROM E_ITRM_RequestEditSL formSLMultiple\\n                           JOIN E_ITRM_RequestEditSLML formSLMLMultiple WITH (NOLOCK)\\n                               ON formSLMultiple.ID = formSLMLMultiple.PARENTID\\n                       WHERE formSLMultiple.PARENTID = formSL.PARENTID\\n                             AND formSLMultiple.CONTROLID = formSL.CONTROLID\\n                             AND formSLMLMultiple.CULTURE = CASE WHEN\\n                                             EXISTS (SELECT TOP 1 1 FROM E_ITRM_RequestEditSLML checkML WITH (NOLOCK) WHERE\\n                                                        formSLML.PARENTID = checkML.PARENTID AND\\n                                                        checkML.CULTURE = {{Culture}} AND\\n                                                        checkML.TEXT  IS NOT NULL\\n                                                    )\\n                                             THEN {{Culture}}\\n                                             WHEN\\n                                             (SELECT COUNT (1) FROM E_ITRM_RequestEditSLML WHERE \\n                                                 E_ITRM_RequestEditSLML.PARENTID = formSLMultiple.ID) = 1\\n                                             THEN \\n                                                 formSLMLMultiple.CULTURE\\n                                             ELSE\\n                                                 'system'\\n                                             END\\n                        \\n                   ) AS TEXT, \\n                formSL.PARENTID\\n\\t\\t\\t        FROM E_ITRM_RequestEditSL formSL\\n\\t\\t\\t        JOIN E_ITRM_RequestEditSLML formSLML \\n\\t\\t\\t        \\t WITH (NOLOCK) ON formSL.ID = formSLML.PARENTID\\n\\t\\t        ) as formSLML\\t\\nPIVOT(MAX(TEXT) FOR CONTROLID IN (OPENTYPE,REQUESTORDEPARTMENT,PRIORITY,REQUESTTYPE,REQUESTORLOOK,REQUESTREASON)) AS formSelect)  E_ITRM_RequestEditSL\\n          ON E_ITRM_RequestEditSL.PARENTID = E_ITRM_RequestEdit.ID\\n         \\nJOIN DOCUMENTS documents WITH (NOLOCK) ON documents.ID = E_ITRM_RequestEdit.DOCUMENTID\\nLEFT JOIN PROJECTS projects WITH (NOLOCK) ON projects.NAME = 'ITRM'\\nLEFT JOIN PROCESSES process WITH (NOLOCK) ON process.PROJECTID = projects.ID\\nJOIN PROCESSREQUESTDOCUMENTS processRD WITH(NOLOCK) ON processRD.DOCUMENTID = documents.ID\\nJOIN PROCESSREQUESTS processRequest  ON processRD.PROCESSREQUESTID = processRequest.ID\\nLEFT JOIN PROJECTFLOWSTATUSES WITH (NOLOCK) ON PROJECTFLOWSTATUSES.ID = process.FLOWSTATUSID\\nLEFT JOIN PROJECTFLOWSTATUSESML WITH (NOLOCK) ON PROJECTFLOWSTATUSESML.FLOWSTATUSID = PROJECTFLOWSTATUSES.ID AND PROJECTFLOWSTATUSESML.CULTURE = {{Culture}}\\nINNER JOIN OSUSERS users WITH (NOLOCK) ON users.ID = documents.CREATEDBY\\nWHERE\\ndocuments.DELETEDAT IS NULL AND documents.CREATEDBY = {{userId}} AND\\nprocessRequest.ID = (\\n                                            SELECT MAX(PR.ID) REQUESTID\\n                                            FROM PROCESSREQUESTS PR WITH (NOLOCK)\\n                                            WHERE PR.PROCESSID = processRequest.PROCESSID\\n                                                AND PR.PROCESSID = process.ID\\n  \\t\\t                                    \\tAND PR.REQUESTTYPE IN (2,3)\\n                    )\\nORDER BY processRequest.ID DESC\\n\",\n    \"parameters\": [\n      {\n        \"caption\": \"Culture\",\n        \"isActive\": true,\n        \"isRequired\": true,\n        \"key\": \"Culture\",\n        \"value\": \"%User.Language%\",\n        \"valueType\": 1,\n        \"length\": 10,\n        \"subType\": null\n      },\n      {\n        \"caption\": \"\",\n        \"isActive\": true,\n        \"isRequired\": true,\n        \"key\": \"userId\",\n        \"value\": \"%User.Id%\",\n        \"valueType\": 3,\n        \"length\": 255,\n        \"subType\": null\n      }\n    ],\n    \"commandType\": 1,\n    \"executionType\": 3\n  },\n  \"structure\": {\n    \"columns\": [],\n    \"returnType\": null\n  }\n}";

    JObject queryObj = JObject.Parse(queryContent);

    string connectionId = queryObj.Value<string>("connectionId");

    DataSourceConnectionObject connectionObj = await DataSourceApi.GetConnectionObject(GetContextData(), HttpClientOptions, connectionId);
    CurrentUserInfo currentUserInfo = await DataSourceApi.GetCurrentUserInfo(GetContextData(), HttpClientOptions);

    IProvider provider = DataSourceApi.CreateProvider(connectionObj.Type, connectionObj.Properties, currentUserInfo);

    string requestContent = queryObj["properties"].ToString();

    var executeRequest = provider.MergeParameters(request,  requestContent);

    return await provider.ExecuteAsync(executeRequest);
}

internal async Task<DataSourceResponse<object>> RequestFlow_ProcessItems(RequestFlow_ProcessItemsRequest request)
{
    string queryContent = "{\"name\":\"RequestFlow_ProcessItems\",\"connectionId\":\"4a85d4a4-77b7-472b-bad8-8963308c2273\",\"connectionType\":1,\"description\":{},\"id\":null,\"properties\":{ \"commandText\":\"SELECT MAX(PROCESSES.ID) AS ProcessID,\\nMAX(CONCAT(OSUSERS.FIRSTNAME, ' ', OSUSERS.LASTNAME)) AS 'User',\\nMAX(PROCESSREQUESTS.REQUESTDATE) AS CreateDate,\\nMAX(PROCESSREQUESTS.ID) AS RequestId,\\nMAX(PROJECTFLOWSTATUSESML.CAPTION) AS Caption,\\nMAX(PROJECTS.MOBILEFORMVIEW) AS MobileFormView,\\nMAX(PROJECTCOREPUBLISHMENTS.PACKAGEVERSION) AS PackageVersion,\\nMAX(PROCESSES.CREATEDATE) AS ProcessStartDate\\n FROM PROCESSREQUESTS\\nLEFT  JOIN PROCESSREQUESTDOCUMENTS WITH(NOLOCK) ON PROCESSREQUESTDOCUMENTS.PROCESSREQUESTID = PROCESSREQUESTS.ID\\nLEFT  JOIN DOCUMENTS WITH(NOLOCK) ON DOCUMENTS.ID = PROCESSREQUESTDOCUMENTS.DOCUMENTID\\nINNER JOIN PROCESSES WITH(NOLOCK) ON PROCESSES.ID = PROCESSREQUESTS.PROCESSID\\nINNER JOIN PROJECTS WITH(NOLOCK) ON PROJECTS.ID = PROCESSES.PROJECTID AND PROJECTS.NAME = {{ProjectName}}\\nLEFT  JOIN PROJECTFLOWSTATUSES WITH(NOLOCK) ON PROJECTFLOWSTATUSES.ID = PROCESSES.FLOWSTATUSID\\nLEFT  JOIN PROJECTFLOWSTATUSESML WITH(NOLOCK) ON PROJECTFLOWSTATUSESML.FLOWSTATUSID = PROJECTFLOWSTATUSES.ID AND PROJECTFLOWSTATUSESML.CULTURE = {{Culture}}\\nINNER JOIN OSUSERS WITH(NOLOCK) ON OSUSERS.ID = PROCESSES.USERID\\nINNER JOIN PROJECTFLOWS WITH(NOLOCK) ON PROJECTFLOWS.ID = PROCESSES.FLOWID AND PROJECTFLOWS.NAME = {{FlowName}}\\nINNER JOIN PROJECTCOREDEPLOYMENTS WITH(NOLOCK) ON PROJECTCOREDEPLOYMENTS.ID = PROCESSES.DEPLOYMENTID\\nINNER JOIN PROJECTCOREPUBLISHMENTS WITH(NOLOCK) ON PROJECTCOREPUBLISHMENTS.ID = PROJECTCOREDEPLOYMENTS.PUBLISHMENTID\\nWHERE\\n(\\n({{ProcessType}} = 0 AND ((PROCESSREQUESTS.STATUS=1 AND PROCESSREQUESTS.RESPONSEDATE IS NULL AND ((PROCESSREQUESTS.OWNEDREQUESTID IS NULL) OR (PROCESSREQUESTS.OWNEDREQUESTID=PROCESSREQUESTS.ID))) OR (PROCESSREQUESTS.STATUS = 1 AND (PROCESSREQUESTS.RESPONSEDATE IS NULL))) AND PROCESSES.FINISHDATE IS NULL AND PROCESSES.DELETEDATE IS NULL)\\nOR\\n({{ProcessType}} = 1 AND (PROCESSREQUESTS.REQUESTTYPE=6 AND PROCESSREQUESTS.DELETEDFROMLIST=0 AND PROCESSREQUESTS.REQUESTDATE BETWEEN {{StartDate}} AND {{EndDate}}) AND PROCESSES.DELETEDATE IS NULL)\\nOR\\n({{ProcessType}} = 2 AND (PROCESSREQUESTS.REQUESTTYPE = 1 AND PROCESSREQUESTS.DELETEDFROMLIST = 0 AND PROCESSREQUESTS.REQUESTDATE BETWEEN {{StartDate}} AND {{EndDate}}) AND PROCESSES.DELETEDATE IS NULL)\\nOR\\n({{ProcessType}} = 3 AND (PROCESSREQUESTS.STATUS=1 AND PROCESSES.FINISHDATE IS NULL AND PROCESSREQUESTS.REQUESTTYPE=3) AND PROCESSES.DELETEDATE IS NULL)\\nOR\\n({{ProcessType}} = 4 AND (PROCESSREQUESTS.DELETEDFROMLIST=0 AND PROCESSREQUESTS.STATUS=4 AND PROCESSREQUESTS.REQUESTDATE BETWEEN {{StartDate}} AND {{EndDate}}))\\nOR\\n({{ProcessType}} = 5 AND (PROCESSREQUESTS.DELETEDFROMLIST=0 AND PROCESSREQUESTS.STATUS=4 AND PROCESSREQUESTS.REQUESTDATE BETWEEN {{StartDate}} AND {{EndDate}} AND PROCESSREQUESTS.REQUESTTYPE IN (2, 3) AND PROCESSREQUESTS.RESPONSEDATE IS NOT NULL) AND PROCESSES.DELETEDATE IS NULL)\\nOR\\n({{ProcessType}} = 6 AND (PROCESSREQUESTS.DELETEDFROMLIST=0 AND PROCESSREQUESTS.STATUS=4 AND PROCESSREQUESTS.REQUESTDATE BETWEEN {{StartDate}} AND {{EndDate}} AND PROCESSREQUESTS.REQUESTTYPE=6 ))\\nOR\\n({{ProcessType}} = 7 AND(PROCESSREQUESTS.DELETEDFROMLIST=0 AND PROCESSREQUESTS.STATUS=4 AND PROCESSREQUESTS.REQUESTDATE BETWEEN {{StartDate}} AND {{EndDate}} AND PROCESSREQUESTS.REQUESTTYPE=1))\\nOR\\n({{ProcessType}} = 8 AND (PROCESSREQUESTS.DELETEDFROMLIST=0 AND PROCESSREQUESTS.STATUS=4 AND PROCESSREQUESTS.REQUESTDATE BETWEEN {{StartDate}} AND {{EndDate}} AND PROCESSREQUESTS.REQUESTTYPE=2 AND PROCESSREQUESTS.RESPONSEDATE IS NOT NULL))\\nOR\\n({{ProcessType}} = 10 AND (PROCESSREQUESTS.REQUESTTYPE = 1 AND PROCESSREQUESTS.DELETEDFROMLIST = 0 AND PROCESSREQUESTS.REQUESTDATE BETWEEN {{StartDate}} AND {{EndDate}}) AND PROCESSES.DELETEDATE IS NULL AND PROCESSES.FINISHDATE IS NULL)\\nOR\\n({{ProcessType}} = 11 AND (PROCESSREQUESTS.REQUESTTYPE = 1 AND PROCESSREQUESTS.DELETEDFROMLIST = 0 AND PROCESSREQUESTS.REQUESTDATE BETWEEN {{StartDate}} AND {{EndDate}}) AND PROCESSES.DELETEDATE IS NULL AND PROCESSES.FINISHDATE IS NOT NULL)\\nOR\\n(({{ProcessType}} < 0 OR {{ProcessType}} IS NULL) AND {{RequestId}} > 0)\\n)\\nAND\\nPROCESSREQUESTS.ID = CASE WHEN {{RequestId}} IS NULL OR {{RequestId}} <= 0 THEN PROCESSREQUESTS.ID ELSE {{RequestId}} END AND\\nPROJECTS.STATUS = 1 AND\\nPROJECTCOREDEPLOYMENTS.DELETEDAT IS NULL AND\\n(({{RequestId}} IS NOT NULL AND {{RequestId}} > 0) OR (PROCESSREQUESTS.USERID IN ({{Users}}) OR PROCESSREQUESTS.POSITIONID IN ({{Positions}})))\\nGROUP BY PROCESSREQUESTS.ID\\nORDER BY PROCESSREQUESTS.ID DESC\\nOFFSET {{Skip}} ROWS FETCH NEXT {{Take}} ROWS ONLY\\n\",\"parameters\":[{\"caption\":\"\",\"isActive\":true,\"isRequired\":true,\"key\":\"Users\",\"value\":[0],\"valueType\":10,\"length\":10000,\"subType\":3},{\"caption\":\"\",\"isActive\":true,\"isRequired\":true,\"key\":\"Positions\",\"value\":[0],\"valueType\":10,\"length\":1000, \"subType\":3},{\"caption\":\"\",\"isActive\":true,\"isRequired\":true,\"key\":\"Skip\",\"value\":0,\"valueType\":3,\"length\":1000},{\"caption\":\"\",\"isActive\":true,\"isRequired\":true,\"key\":\"Take\",\"value\":0,\"valueType\":3,\"length\":1000},{\"caption\":\"Culture\",\"isActive\":true,\"isRequired\":true,\"key\":\"Culture\",\"value\":\"%User.Language%\",\"valueType\":1,\"length\":10},{\"caption\":\"ProcessType\",\"isActive\":true,\"isRequired\":true,\"key\":\"ProcessType\",\"value\":0,\"valueType\":3,\"length\":100},{\"caption\":\"EndDate\",\"isActive\":true,\"isRequired\":true,\"key\":\"EndDate\",\"value\":\"2021-09-25T21:48:29+03:00\",\"valueType\":6,\"length\":100},{\"caption\":\"StartDate\",\"isActive\":true,\"isRequired\":true,\"key\":\"StartDate\",\"value\":\"2021-09-25T21:48:29+03:00\",\"valueType\":6,\"length\":100}, {\"caption\":\"FlowName\",\"isActive\":true,\"isRequired\":true,\"key\":\"FlowName\",\"value\":\"FlowName\",\"valueType\":1,\"length\":200}, {\"caption\":\"ProjectName\",\"isActive\":true,\"isRequired\":true,\"key\":\"ProjectName\",\"value\":\"ProjectName\",\"valueType\":1,\"length\":500}, {\"caption\":\"RequestId\",\"isActive\":true,\"isRequired\":true,\"key\":\"RequestId\",\"value\":0,\"valueType\":3,\"length\":1000}],\"commandType\":1,\"executionType\":3},\"structure\":{ \"columns\":[{\"name\":\"ProcessId\",\"caption\":\"ProcessId\",\"type\":3,\"displayFormat\":null},{\"name\":\"User\",\"caption\":\"User\",\"type\":1,\"displayFormat\":null},{\"name\":\"CreatedDate\",\"caption\":\"CreatedDate\",\"type\":6,\"displayFormat\":null},{\"name\":\"RequestId\",\"caption\":\"RequestId\",\"type\":3,\"displayFormat\":null},{\"name\":\"Caption\",\"caption\":\"Caption\",\"type\":1,\"displayFormat\":null},{\"name\":\"MobileFormView\",\"caption\":\"MobileFormView\",\"type\":2,\"displayFormat\":null},{\"name\":\"PackageVersion\",\"caption\":\"PackageVersion\",\"type\":3,\"displayFormat\":null},{\"name\":\"ProcessStartDate\",\"caption\":\"ProcessStartDate\",\"type\":12,\"displayFormat\":null}],\"returnType\":null}}";

    JObject queryObj = JObject.Parse(queryContent);

    string connectionId = queryObj.Value<string>("connectionId");

    DataSourceConnectionObject connectionObj = await DataSourceApi.GetConnectionObject(GetContextData(), HttpClientOptions, connectionId);
    CurrentUserInfo currentUserInfo = await DataSourceApi.GetCurrentUserInfo(GetContextData(), HttpClientOptions);

    IProvider provider = DataSourceApi.CreateProvider(connectionObj.Type, connectionObj.Properties, currentUserInfo);

    string requestContent = queryObj["properties"].ToString();

    var executeRequest = provider.MergeParameters(request,  requestContent);

    return await provider.ExecuteAsync(executeRequest);
}

internal async Task<DataSourceResponse<object>> DeleteRequestType(DeleteRequestTypeRequest request)
{
    string queryContent = "{\n  \"name\": \"DeleteRequestType\",\n  \"connectionId\": \"3ee648e2-6d8b-49ad-babf-a6d85f12bb92\",\n  \"connectionName\": {\n    \"tr-TR\": \"SystemDefultConnection\"\n  },\n  \"connectionType\": 1,\n  \"description\": {},\n  \"id\": null,\n  \"properties\": {\n    \"cacheTTL\": 60000,\n    \"cacheType\": \"Memory\",\n    \"enableCache\": true,\n    \"timeout\": 60,\n    \"commandText\": \"UPDATE E_ITRM_RequestTypeEdit SET DELETEDAT=GETDATE(), DELETEDBY={{userId}} WHERE DOCUMENTID={{documentId}}\",\n    \"parameters\": [\n      {\n        \"caption\": \"\",\n        \"isActive\": true,\n        \"isRequired\": true,\n        \"key\": \"userId\",\n        \"value\": \"%User.Id%\",\n        \"valueType\": 3,\n        \"length\": 255,\n        \"subType\": null\n      },\n      {\n        \"caption\": \"\",\n        \"isActive\": true,\n        \"isRequired\": true,\n        \"key\": \"documentId\",\n        \"value\": \"0\",\n        \"valueType\": 1,\n        \"length\": 255,\n        \"subType\": null\n      }\n    ],\n    \"commandType\": 1,\n    \"executionType\": 2\n  },\n  \"structure\": {\n    \"columns\": [],\n    \"returnType\": null\n  }\n}";

    JObject queryObj = JObject.Parse(queryContent);

    string connectionId = queryObj.Value<string>("connectionId");

    DataSourceConnectionObject connectionObj = await DataSourceApi.GetConnectionObject(GetContextData(), HttpClientOptions, connectionId);
    CurrentUserInfo currentUserInfo = await DataSourceApi.GetCurrentUserInfo(GetContextData(), HttpClientOptions);

    IProvider provider = DataSourceApi.CreateProvider(connectionObj.Type, connectionObj.Properties, currentUserInfo);

    string requestContent = queryObj["properties"].ToString();

    var executeRequest = provider.MergeParameters(request,  requestContent);

    return await provider.ExecuteAsync(executeRequest);
}

internal async Task<DataSourceResponse<object>> DeleteRequestReason(DeleteRequestReasonRequest request)
{
    string queryContent = "{\n  \"name\": \"DeleteRequestReason\",\n  \"connectionId\": \"3ee648e2-6d8b-49ad-babf-a6d85f12bb92\",\n  \"connectionName\": {\n    \"tr-TR\": \"SystemDefultConnection\"\n  },\n  \"connectionType\": 1,\n  \"description\": {},\n  \"id\": null,\n  \"properties\": {\n    \"cacheTTL\": 60000,\n    \"cacheType\": \"Memory\",\n    \"enableCache\": true,\n    \"timeout\": 60,\n    \"commandText\": \"UPDATE E_ITRM_RequestReasonEdit SET DELETEDAT=GETDATE(), DELETEDBY={{userId}} WHERE DOCUMENTID={{documentId}}\",\n    \"parameters\": [\n      {\n        \"caption\": \"\",\n        \"isActive\": true,\n        \"isRequired\": true,\n        \"key\": \"userId\",\n        \"value\": \"%User.Id%\",\n        \"valueType\": 3,\n        \"length\": 255,\n        \"subType\": null\n      },\n      {\n        \"caption\": \"\",\n        \"isActive\": true,\n        \"isRequired\": true,\n        \"key\": \"documentId\",\n        \"value\": \"0\",\n        \"valueType\": 1,\n        \"length\": 255,\n        \"subType\": null\n      }\n    ],\n    \"commandType\": 1,\n    \"executionType\": 2\n  },\n  \"structure\": {\n    \"columns\": [],\n    \"returnType\": null\n  }\n}";

    JObject queryObj = JObject.Parse(queryContent);

    string connectionId = queryObj.Value<string>("connectionId");

    DataSourceConnectionObject connectionObj = await DataSourceApi.GetConnectionObject(GetContextData(), HttpClientOptions, connectionId);
    CurrentUserInfo currentUserInfo = await DataSourceApi.GetCurrentUserInfo(GetContextData(), HttpClientOptions);

    IProvider provider = DataSourceApi.CreateProvider(connectionObj.Type, connectionObj.Properties, currentUserInfo);

    string requestContent = queryObj["properties"].ToString();

    var executeRequest = provider.MergeParameters(request,  requestContent);

    return await provider.ExecuteAsync(executeRequest);
}

internal async Task<DataSourceResponse<object>> DeletePriority(DeletePriorityRequest request)
{
    string queryContent = "{\n  \"name\": \"DeletePriority\",\n  \"connectionId\": \"3ee648e2-6d8b-49ad-babf-a6d85f12bb92\",\n  \"connectionName\": {\n    \"tr-TR\": \"SystemDefultConnection\"\n  },\n  \"connectionType\": 1,\n  \"description\": {},\n  \"id\": null,\n  \"properties\": {\n    \"cacheTTL\": 60000,\n    \"cacheType\": \"Memory\",\n    \"enableCache\": true,\n    \"timeout\": 60,\n    \"commandText\": \"UPDATE E_ITRM_PriorityEdit SET DELETEDAT=GETDATE(), DELETEDBY={{userId}} WHERE DOCUMENTID={{documentId}}\",\n    \"parameters\": [\n      {\n        \"caption\": \"\",\n        \"isActive\": true,\n        \"isRequired\": true,\n        \"key\": \"userId\",\n        \"value\": \"%User.Id%\",\n        \"valueType\": 3,\n        \"length\": 255,\n        \"subType\": null\n      },\n      {\n        \"caption\": \"\",\n        \"isActive\": true,\n        \"isRequired\": true,\n        \"key\": \"documentId\",\n        \"value\": \"0\",\n        \"valueType\": 1,\n        \"length\": 255,\n        \"subType\": null\n      }\n    ],\n    \"commandType\": 1,\n    \"executionType\": 2\n  },\n  \"structure\": {\n    \"columns\": [],\n    \"returnType\": null\n  }\n}";

    JObject queryObj = JObject.Parse(queryContent);

    string connectionId = queryObj.Value<string>("connectionId");

    DataSourceConnectionObject connectionObj = await DataSourceApi.GetConnectionObject(GetContextData(), HttpClientOptions, connectionId);
    CurrentUserInfo currentUserInfo = await DataSourceApi.GetCurrentUserInfo(GetContextData(), HttpClientOptions);

    IProvider provider = DataSourceApi.CreateProvider(connectionObj.Type, connectionObj.Properties, currentUserInfo);

    string requestContent = queryObj["properties"].ToString();

    var executeRequest = provider.MergeParameters(request,  requestContent);

    return await provider.ExecuteAsync(executeRequest);
}

        ///Iterators
        [NonAction] public IEnumerable RequestTypes_DataSourceIterator(RequestTypes_DataSourceRequest request)
{
            int pagingSkip = 0;
            int pagingTake = 100;
            int pageIndex = 0;
            var filters = new List<IFilter>();
            var sorts = new List<ISort>();

            bool endOfSource = false;
            while (!endOfSource)
            {
                if (request.LoadOptions != null)
                {
                    filters = request.LoadOptions.Filters;
                    sorts = request.LoadOptions.Sorts;
                    if (pageIndex > 0 && request.LoadOptions.Pagination != null)
                    {
                        pagingSkip = request.LoadOptions.Pagination.Skip + request.LoadOptions.Pagination.Take;
                        pagingTake = request.LoadOptions.Pagination.Take;
                    }
                }

                request.LoadOptions = new DataSourceLoadOptions(filters, sorts, new Pagination(pagingSkip, pagingTake));

                var response = RequestTypes_DataSource(request).Result;
                endOfSource = response.IsEndOfSource;
                if (response.Success && response.Result != null)
                {
                    JArray data = (JArray)response.Result;

                    foreach (var item in data)
                    {
                        var dataItem = item.ToObject<Dictionary<string, object>>();
                        yield return dataItem;
                    }
                }
                else
                {
                    endOfSource = true;
                }

                pageIndex++;
            }
}

[NonAction] public IEnumerable RequestReasons_DataSourceIterator(RequestReasons_DataSourceRequest request)
{
            int pagingSkip = 0;
            int pagingTake = 100;
            int pageIndex = 0;
            var filters = new List<IFilter>();
            var sorts = new List<ISort>();

            bool endOfSource = false;
            while (!endOfSource)
            {
                if (request.LoadOptions != null)
                {
                    filters = request.LoadOptions.Filters;
                    sorts = request.LoadOptions.Sorts;
                    if (pageIndex > 0 && request.LoadOptions.Pagination != null)
                    {
                        pagingSkip = request.LoadOptions.Pagination.Skip + request.LoadOptions.Pagination.Take;
                        pagingTake = request.LoadOptions.Pagination.Take;
                    }
                }

                request.LoadOptions = new DataSourceLoadOptions(filters, sorts, new Pagination(pagingSkip, pagingTake));

                var response = RequestReasons_DataSource(request).Result;
                endOfSource = response.IsEndOfSource;
                if (response.Success && response.Result != null)
                {
                    JArray data = (JArray)response.Result;

                    foreach (var item in data)
                    {
                        var dataItem = item.ToObject<Dictionary<string, object>>();
                        yield return dataItem;
                    }
                }
                else
                {
                    endOfSource = true;
                }

                pageIndex++;
            }
}

[NonAction] public IEnumerable Priorities_DataSourceIterator(Priorities_DataSourceRequest request)
{
            int pagingSkip = 0;
            int pagingTake = 100;
            int pageIndex = 0;
            var filters = new List<IFilter>();
            var sorts = new List<ISort>();

            bool endOfSource = false;
            while (!endOfSource)
            {
                if (request.LoadOptions != null)
                {
                    filters = request.LoadOptions.Filters;
                    sorts = request.LoadOptions.Sorts;
                    if (pageIndex > 0 && request.LoadOptions.Pagination != null)
                    {
                        pagingSkip = request.LoadOptions.Pagination.Skip + request.LoadOptions.Pagination.Take;
                        pagingTake = request.LoadOptions.Pagination.Take;
                    }
                }

                request.LoadOptions = new DataSourceLoadOptions(filters, sorts, new Pagination(pagingSkip, pagingTake));

                var response = Priorities_DataSource(request).Result;
                endOfSource = response.IsEndOfSource;
                if (response.Success && response.Result != null)
                {
                    JArray data = (JArray)response.Result;

                    foreach (var item in data)
                    {
                        var dataItem = item.ToObject<Dictionary<string, object>>();
                        yield return dataItem;
                    }
                }
                else
                {
                    endOfSource = true;
                }

                pageIndex++;
            }
}

[NonAction] public IEnumerable RequestTypesIterator(RequestTypesRequest request)
{
            int pagingSkip = 0;
            int pagingTake = 100;
            int pageIndex = 0;
            var filters = new List<IFilter>();
            var sorts = new List<ISort>();

            bool endOfSource = false;
            while (!endOfSource)
            {
                if (request.LoadOptions != null)
                {
                    filters = request.LoadOptions.Filters;
                    sorts = request.LoadOptions.Sorts;
                    if (pageIndex > 0 && request.LoadOptions.Pagination != null)
                    {
                        pagingSkip = request.LoadOptions.Pagination.Skip + request.LoadOptions.Pagination.Take;
                        pagingTake = request.LoadOptions.Pagination.Take;
                    }
                }

                request.LoadOptions = new DataSourceLoadOptions(filters, sorts, new Pagination(pagingSkip, pagingTake));

                var response = RequestTypes(request).Result;
                endOfSource = response.IsEndOfSource;
                if (response.Success && response.Result != null)
                {
                    JArray data = (JArray)response.Result;

                    foreach (var item in data)
                    {
                        var dataItem = item.ToObject<Dictionary<string, object>>();
                        yield return dataItem;
                    }
                }
                else
                {
                    endOfSource = true;
                }

                pageIndex++;
            }
}

[NonAction] public IEnumerable RequestReasonIterator(RequestReasonRequest request)
{
            int pagingSkip = 0;
            int pagingTake = 100;
            int pageIndex = 0;
            var filters = new List<IFilter>();
            var sorts = new List<ISort>();

            bool endOfSource = false;
            while (!endOfSource)
            {
                if (request.LoadOptions != null)
                {
                    filters = request.LoadOptions.Filters;
                    sorts = request.LoadOptions.Sorts;
                    if (pageIndex > 0 && request.LoadOptions.Pagination != null)
                    {
                        pagingSkip = request.LoadOptions.Pagination.Skip + request.LoadOptions.Pagination.Take;
                        pagingTake = request.LoadOptions.Pagination.Take;
                    }
                }

                request.LoadOptions = new DataSourceLoadOptions(filters, sorts, new Pagination(pagingSkip, pagingTake));

                var response = RequestReason(request).Result;
                endOfSource = response.IsEndOfSource;
                if (response.Success && response.Result != null)
                {
                    JArray data = (JArray)response.Result;

                    foreach (var item in data)
                    {
                        var dataItem = item.ToObject<Dictionary<string, object>>();
                        yield return dataItem;
                    }
                }
                else
                {
                    endOfSource = true;
                }

                pageIndex++;
            }
}

[NonAction] public IEnumerable PrioritiesIterator(PrioritiesRequest request)
{
            int pagingSkip = 0;
            int pagingTake = 100;
            int pageIndex = 0;
            var filters = new List<IFilter>();
            var sorts = new List<ISort>();

            bool endOfSource = false;
            while (!endOfSource)
            {
                if (request.LoadOptions != null)
                {
                    filters = request.LoadOptions.Filters;
                    sorts = request.LoadOptions.Sorts;
                    if (pageIndex > 0 && request.LoadOptions.Pagination != null)
                    {
                        pagingSkip = request.LoadOptions.Pagination.Skip + request.LoadOptions.Pagination.Take;
                        pagingTake = request.LoadOptions.Pagination.Take;
                    }
                }

                request.LoadOptions = new DataSourceLoadOptions(filters, sorts, new Pagination(pagingSkip, pagingTake));

                var response = Priorities(request).Result;
                endOfSource = response.IsEndOfSource;
                if (response.Success && response.Result != null)
                {
                    JArray data = (JArray)response.Result;

                    foreach (var item in data)
                    {
                        var dataItem = item.ToObject<Dictionary<string, object>>();
                        yield return dataItem;
                    }
                }
                else
                {
                    endOfSource = true;
                }

                pageIndex++;
            }
}

[NonAction] public IEnumerable GetUsersIterator(GetUsersRequest request)
{
            int pagingSkip = 0;
            int pagingTake = 100;
            int pageIndex = 0;
            var filters = new List<IFilter>();
            var sorts = new List<ISort>();

            bool endOfSource = false;
            while (!endOfSource)
            {
                if (request.LoadOptions != null)
                {
                    filters = request.LoadOptions.Filters;
                    sorts = request.LoadOptions.Sorts;
                    if (pageIndex > 0 && request.LoadOptions.Pagination != null)
                    {
                        pagingSkip = request.LoadOptions.Pagination.Skip + request.LoadOptions.Pagination.Take;
                        pagingTake = request.LoadOptions.Pagination.Take;
                    }
                }

                request.LoadOptions = new DataSourceLoadOptions(filters, sorts, new Pagination(pagingSkip, pagingTake));

                var response = GetUsers(request).Result;
                endOfSource = response.IsEndOfSource;
                if (response.Success && response.Result != null)
                {
                    JArray data = (JArray)response.Result;

                    foreach (var item in data)
                    {
                        var dataItem = item.ToObject<Dictionary<string, object>>();
                        yield return dataItem;
                    }
                }
                else
                {
                    endOfSource = true;
                }

                pageIndex++;
            }
}

[NonAction] public IEnumerable Requests_DataSourceIterator(Requests_DataSourceRequest request)
{
            int pagingSkip = 0;
            int pagingTake = 100;
            int pageIndex = 0;
            var filters = new List<IFilter>();
            var sorts = new List<ISort>();

            bool endOfSource = false;
            while (!endOfSource)
            {
                if (request.LoadOptions != null)
                {
                    filters = request.LoadOptions.Filters;
                    sorts = request.LoadOptions.Sorts;
                    if (pageIndex > 0 && request.LoadOptions.Pagination != null)
                    {
                        pagingSkip = request.LoadOptions.Pagination.Skip + request.LoadOptions.Pagination.Take;
                        pagingTake = request.LoadOptions.Pagination.Take;
                    }
                }

                request.LoadOptions = new DataSourceLoadOptions(filters, sorts, new Pagination(pagingSkip, pagingTake));

                var response = Requests_DataSource(request).Result;
                endOfSource = response.IsEndOfSource;
                if (response.Success && response.Result != null)
                {
                    JArray data = (JArray)response.Result;

                    foreach (var item in data)
                    {
                        var dataItem = item.ToObject<Dictionary<string, object>>();
                        yield return dataItem;
                    }
                }
                else
                {
                    endOfSource = true;
                }

                pageIndex++;
            }
}

[NonAction] public IEnumerable RequestFlow_ProcessItemsIterator(RequestFlow_ProcessItemsRequest request)
{
            int pagingSkip = 0;
            int pagingTake = 100;
            int pageIndex = 0;
            var filters = new List<IFilter>();
            var sorts = new List<ISort>();

            bool endOfSource = false;
            while (!endOfSource)
            {
                if (request.LoadOptions != null)
                {
                    filters = request.LoadOptions.Filters;
                    sorts = request.LoadOptions.Sorts;
                    if (pageIndex > 0 && request.LoadOptions.Pagination != null)
                    {
                        pagingSkip = request.LoadOptions.Pagination.Skip + request.LoadOptions.Pagination.Take;
                        pagingTake = request.LoadOptions.Pagination.Take;
                    }
                }

                request.LoadOptions = new DataSourceLoadOptions(filters, sorts, new Pagination(pagingSkip, pagingTake));

                var response = RequestFlow_ProcessItems(request).Result;
                endOfSource = response.IsEndOfSource;
                if (response.Success && response.Result != null)
                {
                    JArray data = (JArray)response.Result;

                    foreach (var item in data)
                    {
                        var dataItem = item.ToObject<Dictionary<string, object>>();
                        yield return dataItem;
                    }
                }
                else
                {
                    endOfSource = true;
                }

                pageIndex++;
            }
}

[NonAction] public IEnumerable DeleteRequestTypeIterator(DeleteRequestTypeRequest request)
{
            int pagingSkip = 0;
            int pagingTake = 100;
            int pageIndex = 0;
            var filters = new List<IFilter>();
            var sorts = new List<ISort>();

            bool endOfSource = false;
            while (!endOfSource)
            {
                if (request.LoadOptions != null)
                {
                    filters = request.LoadOptions.Filters;
                    sorts = request.LoadOptions.Sorts;
                    if (pageIndex > 0 && request.LoadOptions.Pagination != null)
                    {
                        pagingSkip = request.LoadOptions.Pagination.Skip + request.LoadOptions.Pagination.Take;
                        pagingTake = request.LoadOptions.Pagination.Take;
                    }
                }

                request.LoadOptions = new DataSourceLoadOptions(filters, sorts, new Pagination(pagingSkip, pagingTake));

                var response = DeleteRequestType(request).Result;
                endOfSource = response.IsEndOfSource;
                if (response.Success && response.Result != null)
                {
                    JArray data = (JArray)response.Result;

                    foreach (var item in data)
                    {
                        var dataItem = item.ToObject<Dictionary<string, object>>();
                        yield return dataItem;
                    }
                }
                else
                {
                    endOfSource = true;
                }

                pageIndex++;
            }
}

[NonAction] public IEnumerable DeleteRequestReasonIterator(DeleteRequestReasonRequest request)
{
            int pagingSkip = 0;
            int pagingTake = 100;
            int pageIndex = 0;
            var filters = new List<IFilter>();
            var sorts = new List<ISort>();

            bool endOfSource = false;
            while (!endOfSource)
            {
                if (request.LoadOptions != null)
                {
                    filters = request.LoadOptions.Filters;
                    sorts = request.LoadOptions.Sorts;
                    if (pageIndex > 0 && request.LoadOptions.Pagination != null)
                    {
                        pagingSkip = request.LoadOptions.Pagination.Skip + request.LoadOptions.Pagination.Take;
                        pagingTake = request.LoadOptions.Pagination.Take;
                    }
                }

                request.LoadOptions = new DataSourceLoadOptions(filters, sorts, new Pagination(pagingSkip, pagingTake));

                var response = DeleteRequestReason(request).Result;
                endOfSource = response.IsEndOfSource;
                if (response.Success && response.Result != null)
                {
                    JArray data = (JArray)response.Result;

                    foreach (var item in data)
                    {
                        var dataItem = item.ToObject<Dictionary<string, object>>();
                        yield return dataItem;
                    }
                }
                else
                {
                    endOfSource = true;
                }

                pageIndex++;
            }
}

[NonAction] public IEnumerable DeletePriorityIterator(DeletePriorityRequest request)
{
            int pagingSkip = 0;
            int pagingTake = 100;
            int pageIndex = 0;
            var filters = new List<IFilter>();
            var sorts = new List<ISort>();

            bool endOfSource = false;
            while (!endOfSource)
            {
                if (request.LoadOptions != null)
                {
                    filters = request.LoadOptions.Filters;
                    sorts = request.LoadOptions.Sorts;
                    if (pageIndex > 0 && request.LoadOptions.Pagination != null)
                    {
                        pagingSkip = request.LoadOptions.Pagination.Skip + request.LoadOptions.Pagination.Take;
                        pagingTake = request.LoadOptions.Pagination.Take;
                    }
                }

                request.LoadOptions = new DataSourceLoadOptions(filters, sorts, new Pagination(pagingSkip, pagingTake));

                var response = DeletePriority(request).Result;
                endOfSource = response.IsEndOfSource;
                if (response.Success && response.Result != null)
                {
                    JArray data = (JArray)response.Result;

                    foreach (var item in data)
                    {
                        var dataItem = item.ToObject<Dictionary<string, object>>();
                        yield return dataItem;
                    }
                }
                else
                {
                    endOfSource = true;
                }

                pageIndex++;
            }
}

    }
}