# IO.Swagger.Api.Answer_suggestedApi

All URIs are relative to *https://surgipal.com/api/api.php*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AnswerSuggestedGet**](Answer_suggestedApi.md#answersuggestedget) | **GET** /answer_suggested | List
[**AnswerSuggestedIdDelete**](Answer_suggestedApi.md#answersuggestediddelete) | **DELETE** /answer_suggested/{id} | Delete
[**AnswerSuggestedIdGet**](Answer_suggestedApi.md#answersuggestedidget) | **GET** /answer_suggested/{id} | Read
[**AnswerSuggestedIdPatch**](Answer_suggestedApi.md#answersuggestedidpatch) | **PATCH** /answer_suggested/{id} | Increment
[**AnswerSuggestedIdPut**](Answer_suggestedApi.md#answersuggestedidput) | **PUT** /answer_suggested/{id} | Update
[**AnswerSuggestedPost**](Answer_suggestedApi.md#answersuggestedpost) | **POST** /answer_suggested | Create


<a name="answersuggestedget"></a>
# **AnswerSuggestedGet**
> List<InlineResponse2001> AnswerSuggestedGet (string exclude = null, string include = null, string order = null, string page = null, bool? transform = null, string columns = null, List<string> filter = null, string satisfy = null)

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
    public class AnswerSuggestedGetExample
    {
        public void main()
        {
            
            var apiInstance = new Answer_suggestedApi();
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
                List&lt;InlineResponse2001&gt; result = apiInstance.AnswerSuggestedGet(exclude, include, order, page, transform, columns, filter, satisfy);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Answer_suggestedApi.AnswerSuggestedGet: " + e.Message );
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

[**List<InlineResponse2001>**](InlineResponse2001.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="answersuggestediddelete"></a>
# **AnswerSuggestedIdDelete**
> int? AnswerSuggestedIdDelete (string id)

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
    public class AnswerSuggestedIdDeleteExample
    {
        public void main()
        {
            
            var apiInstance = new Answer_suggestedApi();
            var id = id_example;  // string | Identifier for item.

            try
            {
                // Delete
                int? result = apiInstance.AnswerSuggestedIdDelete(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Answer_suggestedApi.AnswerSuggestedIdDelete: " + e.Message );
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

<a name="answersuggestedidget"></a>
# **AnswerSuggestedIdGet**
> InlineResponse2001 AnswerSuggestedIdGet (string id)

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
    public class AnswerSuggestedIdGetExample
    {
        public void main()
        {
            
            var apiInstance = new Answer_suggestedApi();
            var id = id_example;  // string | Identifier for item.

            try
            {
                // Read
                InlineResponse2001 result = apiInstance.AnswerSuggestedIdGet(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Answer_suggestedApi.AnswerSuggestedIdGet: " + e.Message );
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

[**InlineResponse2001**](InlineResponse2001.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="answersuggestedidpatch"></a>
# **AnswerSuggestedIdPatch**
> int? AnswerSuggestedIdPatch (string id, Item5 item)

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
    public class AnswerSuggestedIdPatchExample
    {
        public void main()
        {
            
            var apiInstance = new Answer_suggestedApi();
            var id = id_example;  // string | Identifier for item.
            var item = new Item5(); // Item5 | Properties of item to update.

            try
            {
                // Increment
                int? result = apiInstance.AnswerSuggestedIdPatch(id, item);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Answer_suggestedApi.AnswerSuggestedIdPatch: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Identifier for item. | 
 **item** | [**Item5**](Item5.md)| Properties of item to update. | 

### Return type

**int?**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="answersuggestedidput"></a>
# **AnswerSuggestedIdPut**
> int? AnswerSuggestedIdPut (string id, Item4 item)

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
    public class AnswerSuggestedIdPutExample
    {
        public void main()
        {
            
            var apiInstance = new Answer_suggestedApi();
            var id = id_example;  // string | Identifier for item.
            var item = new Item4(); // Item4 | Properties of item to update.

            try
            {
                // Update
                int? result = apiInstance.AnswerSuggestedIdPut(id, item);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Answer_suggestedApi.AnswerSuggestedIdPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Identifier for item. | 
 **item** | [**Item4**](Item4.md)| Properties of item to update. | 

### Return type

**int?**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="answersuggestedpost"></a>
# **AnswerSuggestedPost**
> int? AnswerSuggestedPost (Item3 item)

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
    public class AnswerSuggestedPostExample
    {
        public void main()
        {
            
            var apiInstance = new Answer_suggestedApi();
            var item = new Item3(); // Item3 | Item to create.

            try
            {
                // Create
                int? result = apiInstance.AnswerSuggestedPost(item);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Answer_suggestedApi.AnswerSuggestedPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **item** | [**Item3**](Item3.md)| Item to create. | 

### Return type

**int?**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

