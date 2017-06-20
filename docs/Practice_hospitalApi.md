# IO.Swagger.Api.Practice_hospitalApi

All URIs are relative to *https://surgipal.com/api/api.php*

Method | HTTP request | Description
------------- | ------------- | -------------
[**PracticeHospitalGet**](Practice_hospitalApi.md#practicehospitalget) | **GET** /practice_hospital | List
[**PracticeHospitalIdDelete**](Practice_hospitalApi.md#practicehospitaliddelete) | **DELETE** /practice_hospital/{id} | Delete
[**PracticeHospitalIdGet**](Practice_hospitalApi.md#practicehospitalidget) | **GET** /practice_hospital/{id} | Read
[**PracticeHospitalIdPatch**](Practice_hospitalApi.md#practicehospitalidpatch) | **PATCH** /practice_hospital/{id} | Increment
[**PracticeHospitalIdPut**](Practice_hospitalApi.md#practicehospitalidput) | **PUT** /practice_hospital/{id} | Update
[**PracticeHospitalPost**](Practice_hospitalApi.md#practicehospitalpost) | **POST** /practice_hospital | Create


<a name="practicehospitalget"></a>
# **PracticeHospitalGet**
> List<InlineResponse20025> PracticeHospitalGet (string exclude = null, string include = null, string order = null, string page = null, bool? transform = null, string columns = null, List<string> filter = null, string satisfy = null)

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
    public class PracticeHospitalGetExample
    {
        public void main()
        {
            
            var apiInstance = new Practice_hospitalApi();
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
                List&lt;InlineResponse20025&gt; result = apiInstance.PracticeHospitalGet(exclude, include, order, page, transform, columns, filter, satisfy);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Practice_hospitalApi.PracticeHospitalGet: " + e.Message );
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

[**List<InlineResponse20025>**](InlineResponse20025.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="practicehospitaliddelete"></a>
# **PracticeHospitalIdDelete**
> int? PracticeHospitalIdDelete (string id)

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
    public class PracticeHospitalIdDeleteExample
    {
        public void main()
        {
            
            var apiInstance = new Practice_hospitalApi();
            var id = id_example;  // string | Identifier for item.

            try
            {
                // Delete
                int? result = apiInstance.PracticeHospitalIdDelete(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Practice_hospitalApi.PracticeHospitalIdDelete: " + e.Message );
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

<a name="practicehospitalidget"></a>
# **PracticeHospitalIdGet**
> InlineResponse20025 PracticeHospitalIdGet (string id)

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
    public class PracticeHospitalIdGetExample
    {
        public void main()
        {
            
            var apiInstance = new Practice_hospitalApi();
            var id = id_example;  // string | Identifier for item.

            try
            {
                // Read
                InlineResponse20025 result = apiInstance.PracticeHospitalIdGet(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Practice_hospitalApi.PracticeHospitalIdGet: " + e.Message );
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

[**InlineResponse20025**](InlineResponse20025.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="practicehospitalidpatch"></a>
# **PracticeHospitalIdPatch**
> int? PracticeHospitalIdPatch (string id, Item77 item)

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
    public class PracticeHospitalIdPatchExample
    {
        public void main()
        {
            
            var apiInstance = new Practice_hospitalApi();
            var id = id_example;  // string | Identifier for item.
            var item = new Item77(); // Item77 | Properties of item to update.

            try
            {
                // Increment
                int? result = apiInstance.PracticeHospitalIdPatch(id, item);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Practice_hospitalApi.PracticeHospitalIdPatch: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Identifier for item. | 
 **item** | [**Item77**](Item77.md)| Properties of item to update. | 

### Return type

**int?**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="practicehospitalidput"></a>
# **PracticeHospitalIdPut**
> int? PracticeHospitalIdPut (string id, Item76 item)

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
    public class PracticeHospitalIdPutExample
    {
        public void main()
        {
            
            var apiInstance = new Practice_hospitalApi();
            var id = id_example;  // string | Identifier for item.
            var item = new Item76(); // Item76 | Properties of item to update.

            try
            {
                // Update
                int? result = apiInstance.PracticeHospitalIdPut(id, item);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Practice_hospitalApi.PracticeHospitalIdPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Identifier for item. | 
 **item** | [**Item76**](Item76.md)| Properties of item to update. | 

### Return type

**int?**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="practicehospitalpost"></a>
# **PracticeHospitalPost**
> int? PracticeHospitalPost (Item75 item)

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
    public class PracticeHospitalPostExample
    {
        public void main()
        {
            
            var apiInstance = new Practice_hospitalApi();
            var item = new Item75(); // Item75 | Item to create.

            try
            {
                // Create
                int? result = apiInstance.PracticeHospitalPost(item);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Practice_hospitalApi.PracticeHospitalPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **item** | [**Item75**](Item75.md)| Item to create. | 

### Return type

**int?**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

