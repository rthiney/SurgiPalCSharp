# IO.Swagger.Api.SystemlogApi

All URIs are relative to *https://surgipal.com/api/api.php*

Method | HTTP request | Description
------------- | ------------- | -------------
[**SystemlogGet**](SystemlogApi.md#systemlogget) | **GET** /systemlog | List
[**SystemlogIdDelete**](SystemlogApi.md#systemlogiddelete) | **DELETE** /systemlog/{id} | Delete
[**SystemlogIdGet**](SystemlogApi.md#systemlogidget) | **GET** /systemlog/{id} | Read
[**SystemlogIdPatch**](SystemlogApi.md#systemlogidpatch) | **PATCH** /systemlog/{id} | Increment
[**SystemlogIdPut**](SystemlogApi.md#systemlogidput) | **PUT** /systemlog/{id} | Update
[**SystemlogPost**](SystemlogApi.md#systemlogpost) | **POST** /systemlog | Create


<a name="systemlogget"></a>
# **SystemlogGet**
> List<InlineResponse20035> SystemlogGet (string exclude = null, string include = null, string order = null, string page = null, bool? transform = null, string columns = null, List<string> filter = null, string satisfy = null)

List

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class SystemlogGetExample
    {
        public void main()
        {
            
            var apiInstance = new SystemlogApi();
            var exclude = exclude_example;  // string | One or more related entities (comma separated). (optional) 
            var include = include_example;  // string | One or more related entities (comma separated). (optional) 
            var order = order_example;  // string | Column you want to sort on and the sort direction (comma separated). Example: id,desc (optional) 
            var page = page_example;  // string | Page number and page size (comma separated). NB: You cannot use \"page\" without \"order\"! Example: 1,10 (optional) 
            var transform = true;  // bool? | Transform the records to object format. NB: This can also be done client-side in JavaScript! (optional) 
            var columns = columns_example;  // string | The table columns you want to retrieve (comma separated). Example: posts.*,categories.name (optional) 
            var filter = new List<string>(); // List<string> | Filters to be applied. Each filter consists of a column, an operator and a value (comma separated). Example: id,eq,1 (optional) 
            var satisfy = satisfy_example;  // string | Should all filters match (default)? Or any? (optional) 

            try
            {
                // List
                List&lt;InlineResponse20035&gt; result = apiInstance.SystemlogGet(exclude, include, order, page, transform, columns, filter, satisfy);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SystemlogApi.SystemlogGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **exclude** | **string**| One or more related entities (comma separated). | [optional] 
 **include** | **string**| One or more related entities (comma separated). | [optional] 
 **order** | **string**| Column you want to sort on and the sort direction (comma separated). Example: id,desc | [optional] 
 **page** | **string**| Page number and page size (comma separated). NB: You cannot use \&quot;page\&quot; without \&quot;order\&quot;! Example: 1,10 | [optional] 
 **transform** | **bool?**| Transform the records to object format. NB: This can also be done client-side in JavaScript! | [optional] 
 **columns** | **string**| The table columns you want to retrieve (comma separated). Example: posts.*,categories.name | [optional] 
 **filter** | [**List<string>**](string.md)| Filters to be applied. Each filter consists of a column, an operator and a value (comma separated). Example: id,eq,1 | [optional] 
 **satisfy** | **string**| Should all filters match (default)? Or any? | [optional] 

### Return type

[**List<InlineResponse20035>**](InlineResponse20035.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="systemlogiddelete"></a>
# **SystemlogIdDelete**
> int? SystemlogIdDelete (string id)

Delete

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class SystemlogIdDeleteExample
    {
        public void main()
        {
            
            var apiInstance = new SystemlogApi();
            var id = id_example;  // string | Identifier for item.

            try
            {
                // Delete
                int? result = apiInstance.SystemlogIdDelete(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SystemlogApi.SystemlogIdDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Identifier for item. | 

### Return type

**int?**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="systemlogidget"></a>
# **SystemlogIdGet**
> InlineResponse20035 SystemlogIdGet (string id)

Read

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class SystemlogIdGetExample
    {
        public void main()
        {
            
            var apiInstance = new SystemlogApi();
            var id = id_example;  // string | Identifier for item.

            try
            {
                // Read
                InlineResponse20035 result = apiInstance.SystemlogIdGet(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SystemlogApi.SystemlogIdGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Identifier for item. | 

### Return type

[**InlineResponse20035**](InlineResponse20035.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="systemlogidpatch"></a>
# **SystemlogIdPatch**
> int? SystemlogIdPatch (string id, Item107 item)

Increment

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class SystemlogIdPatchExample
    {
        public void main()
        {
            
            var apiInstance = new SystemlogApi();
            var id = id_example;  // string | Identifier for item.
            var item = new Item107(); // Item107 | Properties of item to update.

            try
            {
                // Increment
                int? result = apiInstance.SystemlogIdPatch(id, item);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SystemlogApi.SystemlogIdPatch: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Identifier for item. | 
 **item** | [**Item107**](Item107.md)| Properties of item to update. | 

### Return type

**int?**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="systemlogidput"></a>
# **SystemlogIdPut**
> int? SystemlogIdPut (string id, Item106 item)

Update

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class SystemlogIdPutExample
    {
        public void main()
        {
            
            var apiInstance = new SystemlogApi();
            var id = id_example;  // string | Identifier for item.
            var item = new Item106(); // Item106 | Properties of item to update.

            try
            {
                // Update
                int? result = apiInstance.SystemlogIdPut(id, item);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SystemlogApi.SystemlogIdPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Identifier for item. | 
 **item** | [**Item106**](Item106.md)| Properties of item to update. | 

### Return type

**int?**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="systemlogpost"></a>
# **SystemlogPost**
> int? SystemlogPost (Item105 item)

Create

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class SystemlogPostExample
    {
        public void main()
        {
            
            var apiInstance = new SystemlogApi();
            var item = new Item105(); // Item105 | Item to create.

            try
            {
                // Create
                int? result = apiInstance.SystemlogPost(item);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SystemlogApi.SystemlogPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **item** | [**Item105**](Item105.md)| Item to create. | 

### Return type

**int?**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

