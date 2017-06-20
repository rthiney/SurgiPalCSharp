# IO.Swagger.Api.ArticleApi

All URIs are relative to *https://surgipal.com/api/api.php*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ArticleGet**](ArticleApi.md#articleget) | **GET** /article | List
[**ArticleIdDelete**](ArticleApi.md#articleiddelete) | **DELETE** /article/{id} | Delete
[**ArticleIdGet**](ArticleApi.md#articleidget) | **GET** /article/{id} | Read
[**ArticleIdPatch**](ArticleApi.md#articleidpatch) | **PATCH** /article/{id} | Increment
[**ArticleIdPut**](ArticleApi.md#articleidput) | **PUT** /article/{id} | Update
[**ArticlePost**](ArticleApi.md#articlepost) | **POST** /article | Create


<a name="articleget"></a>
# **ArticleGet**
> List<InlineResponse2003> ArticleGet (string exclude = null, string include = null, string order = null, string page = null, bool? transform = null, string columns = null, List<string> filter = null, string satisfy = null)

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
    public class ArticleGetExample
    {
        public void main()
        {
            
            var apiInstance = new ArticleApi();
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
                List&lt;InlineResponse2003&gt; result = apiInstance.ArticleGet(exclude, include, order, page, transform, columns, filter, satisfy);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ArticleApi.ArticleGet: " + e.Message );
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

[**List<InlineResponse2003>**](InlineResponse2003.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="articleiddelete"></a>
# **ArticleIdDelete**
> int? ArticleIdDelete (string id)

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
    public class ArticleIdDeleteExample
    {
        public void main()
        {
            
            var apiInstance = new ArticleApi();
            var id = id_example;  // string | Identifier for item.

            try
            {
                // Delete
                int? result = apiInstance.ArticleIdDelete(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ArticleApi.ArticleIdDelete: " + e.Message );
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

<a name="articleidget"></a>
# **ArticleIdGet**
> InlineResponse2003 ArticleIdGet (string id)

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
    public class ArticleIdGetExample
    {
        public void main()
        {
            
            var apiInstance = new ArticleApi();
            var id = id_example;  // string | Identifier for item.

            try
            {
                // Read
                InlineResponse2003 result = apiInstance.ArticleIdGet(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ArticleApi.ArticleIdGet: " + e.Message );
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

[**InlineResponse2003**](InlineResponse2003.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="articleidpatch"></a>
# **ArticleIdPatch**
> int? ArticleIdPatch (string id, Item11 item)

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
    public class ArticleIdPatchExample
    {
        public void main()
        {
            
            var apiInstance = new ArticleApi();
            var id = id_example;  // string | Identifier for item.
            var item = new Item11(); // Item11 | Properties of item to update.

            try
            {
                // Increment
                int? result = apiInstance.ArticleIdPatch(id, item);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ArticleApi.ArticleIdPatch: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Identifier for item. | 
 **item** | [**Item11**](Item11.md)| Properties of item to update. | 

### Return type

**int?**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="articleidput"></a>
# **ArticleIdPut**
> int? ArticleIdPut (string id, Item10 item)

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
    public class ArticleIdPutExample
    {
        public void main()
        {
            
            var apiInstance = new ArticleApi();
            var id = id_example;  // string | Identifier for item.
            var item = new Item10(); // Item10 | Properties of item to update.

            try
            {
                // Update
                int? result = apiInstance.ArticleIdPut(id, item);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ArticleApi.ArticleIdPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Identifier for item. | 
 **item** | [**Item10**](Item10.md)| Properties of item to update. | 

### Return type

**int?**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="articlepost"></a>
# **ArticlePost**
> int? ArticlePost (Item9 item)

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
    public class ArticlePostExample
    {
        public void main()
        {
            
            var apiInstance = new ArticleApi();
            var item = new Item9(); // Item9 | Item to create.

            try
            {
                // Create
                int? result = apiInstance.ArticlePost(item);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ArticleApi.ArticlePost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **item** | [**Item9**](Item9.md)| Item to create. | 

### Return type

**int?**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

