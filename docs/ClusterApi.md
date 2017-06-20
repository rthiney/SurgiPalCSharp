# IO.Swagger.Api.ClusterApi

All URIs are relative to *https://surgipal.com/api/api.php*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ClusterGet**](ClusterApi.md#clusterget) | **GET** /cluster | List
[**ClusterIdDelete**](ClusterApi.md#clusteriddelete) | **DELETE** /cluster/{id} | Delete
[**ClusterIdGet**](ClusterApi.md#clusteridget) | **GET** /cluster/{id} | Read
[**ClusterIdPatch**](ClusterApi.md#clusteridpatch) | **PATCH** /cluster/{id} | Increment
[**ClusterIdPut**](ClusterApi.md#clusteridput) | **PUT** /cluster/{id} | Update
[**ClusterPost**](ClusterApi.md#clusterpost) | **POST** /cluster | Create


<a name="clusterget"></a>
# **ClusterGet**
> List<InlineResponse2007> ClusterGet (string exclude = null, string include = null, string order = null, string page = null, bool? transform = null, string columns = null, List<string> filter = null, string satisfy = null)

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
    public class ClusterGetExample
    {
        public void main()
        {
            
            var apiInstance = new ClusterApi();
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
                List&lt;InlineResponse2007&gt; result = apiInstance.ClusterGet(exclude, include, order, page, transform, columns, filter, satisfy);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ClusterApi.ClusterGet: " + e.Message );
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

[**List<InlineResponse2007>**](InlineResponse2007.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="clusteriddelete"></a>
# **ClusterIdDelete**
> int? ClusterIdDelete (string id)

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
    public class ClusterIdDeleteExample
    {
        public void main()
        {
            
            var apiInstance = new ClusterApi();
            var id = id_example;  // string | Identifier for item.

            try
            {
                // Delete
                int? result = apiInstance.ClusterIdDelete(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ClusterApi.ClusterIdDelete: " + e.Message );
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

<a name="clusteridget"></a>
# **ClusterIdGet**
> InlineResponse2007 ClusterIdGet (string id)

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
    public class ClusterIdGetExample
    {
        public void main()
        {
            
            var apiInstance = new ClusterApi();
            var id = id_example;  // string | Identifier for item.

            try
            {
                // Read
                InlineResponse2007 result = apiInstance.ClusterIdGet(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ClusterApi.ClusterIdGet: " + e.Message );
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

[**InlineResponse2007**](InlineResponse2007.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="clusteridpatch"></a>
# **ClusterIdPatch**
> int? ClusterIdPatch (string id, Item23 item)

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
    public class ClusterIdPatchExample
    {
        public void main()
        {
            
            var apiInstance = new ClusterApi();
            var id = id_example;  // string | Identifier for item.
            var item = new Item23(); // Item23 | Properties of item to update.

            try
            {
                // Increment
                int? result = apiInstance.ClusterIdPatch(id, item);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ClusterApi.ClusterIdPatch: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Identifier for item. | 
 **item** | [**Item23**](Item23.md)| Properties of item to update. | 

### Return type

**int?**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="clusteridput"></a>
# **ClusterIdPut**
> int? ClusterIdPut (string id, Item22 item)

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
    public class ClusterIdPutExample
    {
        public void main()
        {
            
            var apiInstance = new ClusterApi();
            var id = id_example;  // string | Identifier for item.
            var item = new Item22(); // Item22 | Properties of item to update.

            try
            {
                // Update
                int? result = apiInstance.ClusterIdPut(id, item);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ClusterApi.ClusterIdPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Identifier for item. | 
 **item** | [**Item22**](Item22.md)| Properties of item to update. | 

### Return type

**int?**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="clusterpost"></a>
# **ClusterPost**
> int? ClusterPost (Item21 item)

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
    public class ClusterPostExample
    {
        public void main()
        {
            
            var apiInstance = new ClusterApi();
            var item = new Item21(); // Item21 | Item to create.

            try
            {
                // Create
                int? result = apiInstance.ClusterPost(item);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ClusterApi.ClusterPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **item** | [**Item21**](Item21.md)| Item to create. | 

### Return type

**int?**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

