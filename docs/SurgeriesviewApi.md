# IO.Swagger.Api.SurgeriesviewApi

All URIs are relative to *https://surgipal.com/api/api.php*

Method | HTTP request | Description
------------- | ------------- | -------------
[**SurgeriesviewGet**](SurgeriesviewApi.md#surgeriesviewget) | **GET** /surgeriesview | List
[**SurgeriesviewIdDelete**](SurgeriesviewApi.md#surgeriesviewiddelete) | **DELETE** /surgeriesview/{id} | Delete
[**SurgeriesviewIdGet**](SurgeriesviewApi.md#surgeriesviewidget) | **GET** /surgeriesview/{id} | Read
[**SurgeriesviewIdPatch**](SurgeriesviewApi.md#surgeriesviewidpatch) | **PATCH** /surgeriesview/{id} | Increment
[**SurgeriesviewIdPut**](SurgeriesviewApi.md#surgeriesviewidput) | **PUT** /surgeriesview/{id} | Update
[**SurgeriesviewPost**](SurgeriesviewApi.md#surgeriesviewpost) | **POST** /surgeriesview | Create


<a name="surgeriesviewget"></a>
# **SurgeriesviewGet**
> List<InlineResponse20031> SurgeriesviewGet (string exclude = null, string include = null, string order = null, string page = null, bool? transform = null, string columns = null, List<string> filter = null, string satisfy = null)

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
    public class SurgeriesviewGetExample
    {
        public void main()
        {
            
            var apiInstance = new SurgeriesviewApi();
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
                List&lt;InlineResponse20031&gt; result = apiInstance.SurgeriesviewGet(exclude, include, order, page, transform, columns, filter, satisfy);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SurgeriesviewApi.SurgeriesviewGet: " + e.Message );
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

[**List<InlineResponse20031>**](InlineResponse20031.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="surgeriesviewiddelete"></a>
# **SurgeriesviewIdDelete**
> int? SurgeriesviewIdDelete (string id)

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
    public class SurgeriesviewIdDeleteExample
    {
        public void main()
        {
            
            var apiInstance = new SurgeriesviewApi();
            var id = id_example;  // string | Identifier for item.

            try
            {
                // Delete
                int? result = apiInstance.SurgeriesviewIdDelete(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SurgeriesviewApi.SurgeriesviewIdDelete: " + e.Message );
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

<a name="surgeriesviewidget"></a>
# **SurgeriesviewIdGet**
> InlineResponse20031 SurgeriesviewIdGet (string id)

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
    public class SurgeriesviewIdGetExample
    {
        public void main()
        {
            
            var apiInstance = new SurgeriesviewApi();
            var id = id_example;  // string | Identifier for item.

            try
            {
                // Read
                InlineResponse20031 result = apiInstance.SurgeriesviewIdGet(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SurgeriesviewApi.SurgeriesviewIdGet: " + e.Message );
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

[**InlineResponse20031**](InlineResponse20031.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="surgeriesviewidpatch"></a>
# **SurgeriesviewIdPatch**
> int? SurgeriesviewIdPatch (string id, Item95 item)

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
    public class SurgeriesviewIdPatchExample
    {
        public void main()
        {
            
            var apiInstance = new SurgeriesviewApi();
            var id = id_example;  // string | Identifier for item.
            var item = new Item95(); // Item95 | Properties of item to update.

            try
            {
                // Increment
                int? result = apiInstance.SurgeriesviewIdPatch(id, item);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SurgeriesviewApi.SurgeriesviewIdPatch: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Identifier for item. | 
 **item** | [**Item95**](Item95.md)| Properties of item to update. | 

### Return type

**int?**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="surgeriesviewidput"></a>
# **SurgeriesviewIdPut**
> int? SurgeriesviewIdPut (string id, Item94 item)

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
    public class SurgeriesviewIdPutExample
    {
        public void main()
        {
            
            var apiInstance = new SurgeriesviewApi();
            var id = id_example;  // string | Identifier for item.
            var item = new Item94(); // Item94 | Properties of item to update.

            try
            {
                // Update
                int? result = apiInstance.SurgeriesviewIdPut(id, item);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SurgeriesviewApi.SurgeriesviewIdPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Identifier for item. | 
 **item** | [**Item94**](Item94.md)| Properties of item to update. | 

### Return type

**int?**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="surgeriesviewpost"></a>
# **SurgeriesviewPost**
> int? SurgeriesviewPost (Item93 item)

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
    public class SurgeriesviewPostExample
    {
        public void main()
        {
            
            var apiInstance = new SurgeriesviewApi();
            var item = new Item93(); // Item93 | Item to create.

            try
            {
                // Create
                int? result = apiInstance.SurgeriesviewPost(item);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SurgeriesviewApi.SurgeriesviewPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **item** | [**Item93**](Item93.md)| Item to create. | 

### Return type

**int?**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

