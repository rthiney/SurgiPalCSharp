# IO.Swagger.Api.AnswerApi

All URIs are relative to *https://surgipal.com/api/api.php*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AnswerGet**](AnswerApi.md#answerget) | **GET** /answer | List
[**AnswerIdDelete**](AnswerApi.md#answeriddelete) | **DELETE** /answer/{id} | Delete
[**AnswerIdGet**](AnswerApi.md#answeridget) | **GET** /answer/{id} | Read
[**AnswerIdPatch**](AnswerApi.md#answeridpatch) | **PATCH** /answer/{id} | Increment
[**AnswerIdPut**](AnswerApi.md#answeridput) | **PUT** /answer/{id} | Update
[**AnswerPost**](AnswerApi.md#answerpost) | **POST** /answer | Create


<a name="answerget"></a>
# **AnswerGet**
> List<InlineResponse200> AnswerGet (string exclude = null, string include = null, string order = null, string page = null, bool? transform = null, string columns = null, List<string> filter = null, string satisfy = null)

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
    public class AnswerGetExample
    {
        public void main()
        {
            
            var apiInstance = new AnswerApi();
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
                List&lt;InlineResponse200&gt; result = apiInstance.AnswerGet(exclude, include, order, page, transform, columns, filter, satisfy);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AnswerApi.AnswerGet: " + e.Message );
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

[**List<InlineResponse200>**](InlineResponse200.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="answeriddelete"></a>
# **AnswerIdDelete**
> int? AnswerIdDelete (string id)

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
    public class AnswerIdDeleteExample
    {
        public void main()
        {
            
            var apiInstance = new AnswerApi();
            var id = id_example;  // string | Identifier for item.

            try
            {
                // Delete
                int? result = apiInstance.AnswerIdDelete(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AnswerApi.AnswerIdDelete: " + e.Message );
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

<a name="answeridget"></a>
# **AnswerIdGet**
> InlineResponse200 AnswerIdGet (string id)

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
    public class AnswerIdGetExample
    {
        public void main()
        {
            
            var apiInstance = new AnswerApi();
            var id = id_example;  // string | Identifier for item.

            try
            {
                // Read
                InlineResponse200 result = apiInstance.AnswerIdGet(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AnswerApi.AnswerIdGet: " + e.Message );
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

[**InlineResponse200**](InlineResponse200.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="answeridpatch"></a>
# **AnswerIdPatch**
> int? AnswerIdPatch (string id, Item2 item)

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
    public class AnswerIdPatchExample
    {
        public void main()
        {
            
            var apiInstance = new AnswerApi();
            var id = id_example;  // string | Identifier for item.
            var item = new Item2(); // Item2 | Properties of item to update.

            try
            {
                // Increment
                int? result = apiInstance.AnswerIdPatch(id, item);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AnswerApi.AnswerIdPatch: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Identifier for item. | 
 **item** | [**Item2**](Item2.md)| Properties of item to update. | 

### Return type

**int?**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="answeridput"></a>
# **AnswerIdPut**
> int? AnswerIdPut (string id, Item1 item)

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
    public class AnswerIdPutExample
    {
        public void main()
        {
            
            var apiInstance = new AnswerApi();
            var id = id_example;  // string | Identifier for item.
            var item = new Item1(); // Item1 | Properties of item to update.

            try
            {
                // Update
                int? result = apiInstance.AnswerIdPut(id, item);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AnswerApi.AnswerIdPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Identifier for item. | 
 **item** | [**Item1**](Item1.md)| Properties of item to update. | 

### Return type

**int?**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="answerpost"></a>
# **AnswerPost**
> int? AnswerPost (Item item)

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
    public class AnswerPostExample
    {
        public void main()
        {
            
            var apiInstance = new AnswerApi();
            var item = new Item(); // Item | Item to create.

            try
            {
                // Create
                int? result = apiInstance.AnswerPost(item);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AnswerApi.AnswerPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **item** | [**Item**](Item.md)| Item to create. | 

### Return type

**int?**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

