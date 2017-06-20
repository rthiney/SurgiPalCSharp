# IO.Swagger.Api.Years_in_practiceApi

All URIs are relative to *https://surgipal.com/api/api.php*

Method | HTTP request | Description
------------- | ------------- | -------------
[**YearsInPracticeGet**](Years_in_practiceApi.md#yearsinpracticeget) | **GET** /years_in_practice | List
[**YearsInPracticeIdDelete**](Years_in_practiceApi.md#yearsinpracticeiddelete) | **DELETE** /years_in_practice/{id} | Delete
[**YearsInPracticeIdGet**](Years_in_practiceApi.md#yearsinpracticeidget) | **GET** /years_in_practice/{id} | Read
[**YearsInPracticeIdPatch**](Years_in_practiceApi.md#yearsinpracticeidpatch) | **PATCH** /years_in_practice/{id} | Increment
[**YearsInPracticeIdPut**](Years_in_practiceApi.md#yearsinpracticeidput) | **PUT** /years_in_practice/{id} | Update
[**YearsInPracticePost**](Years_in_practiceApi.md#yearsinpracticepost) | **POST** /years_in_practice | Create


<a name="yearsinpracticeget"></a>
# **YearsInPracticeGet**
> List<InlineResponse20039> YearsInPracticeGet (string exclude = null, string include = null, string order = null, string page = null, bool? transform = null, string columns = null, List<string> filter = null, string satisfy = null)

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
    public class YearsInPracticeGetExample
    {
        public void main()
        {
            
            var apiInstance = new Years_in_practiceApi();
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
                List&lt;InlineResponse20039&gt; result = apiInstance.YearsInPracticeGet(exclude, include, order, page, transform, columns, filter, satisfy);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Years_in_practiceApi.YearsInPracticeGet: " + e.Message );
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

[**List<InlineResponse20039>**](InlineResponse20039.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="yearsinpracticeiddelete"></a>
# **YearsInPracticeIdDelete**
> int? YearsInPracticeIdDelete (string id)

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
    public class YearsInPracticeIdDeleteExample
    {
        public void main()
        {
            
            var apiInstance = new Years_in_practiceApi();
            var id = id_example;  // string | Identifier for item.

            try
            {
                // Delete
                int? result = apiInstance.YearsInPracticeIdDelete(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Years_in_practiceApi.YearsInPracticeIdDelete: " + e.Message );
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

<a name="yearsinpracticeidget"></a>
# **YearsInPracticeIdGet**
> InlineResponse20039 YearsInPracticeIdGet (string id)

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
    public class YearsInPracticeIdGetExample
    {
        public void main()
        {
            
            var apiInstance = new Years_in_practiceApi();
            var id = id_example;  // string | Identifier for item.

            try
            {
                // Read
                InlineResponse20039 result = apiInstance.YearsInPracticeIdGet(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Years_in_practiceApi.YearsInPracticeIdGet: " + e.Message );
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

[**InlineResponse20039**](InlineResponse20039.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="yearsinpracticeidpatch"></a>
# **YearsInPracticeIdPatch**
> int? YearsInPracticeIdPatch (string id, Item119 item)

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
    public class YearsInPracticeIdPatchExample
    {
        public void main()
        {
            
            var apiInstance = new Years_in_practiceApi();
            var id = id_example;  // string | Identifier for item.
            var item = new Item119(); // Item119 | Properties of item to update.

            try
            {
                // Increment
                int? result = apiInstance.YearsInPracticeIdPatch(id, item);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Years_in_practiceApi.YearsInPracticeIdPatch: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Identifier for item. | 
 **item** | [**Item119**](Item119.md)| Properties of item to update. | 

### Return type

**int?**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="yearsinpracticeidput"></a>
# **YearsInPracticeIdPut**
> int? YearsInPracticeIdPut (string id, Item118 item)

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
    public class YearsInPracticeIdPutExample
    {
        public void main()
        {
            
            var apiInstance = new Years_in_practiceApi();
            var id = id_example;  // string | Identifier for item.
            var item = new Item118(); // Item118 | Properties of item to update.

            try
            {
                // Update
                int? result = apiInstance.YearsInPracticeIdPut(id, item);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Years_in_practiceApi.YearsInPracticeIdPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Identifier for item. | 
 **item** | [**Item118**](Item118.md)| Properties of item to update. | 

### Return type

**int?**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="yearsinpracticepost"></a>
# **YearsInPracticePost**
> int? YearsInPracticePost (Item117 item)

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
    public class YearsInPracticePostExample
    {
        public void main()
        {
            
            var apiInstance = new Years_in_practiceApi();
            var item = new Item117(); // Item117 | Item to create.

            try
            {
                // Create
                int? result = apiInstance.YearsInPracticePost(item);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Years_in_practiceApi.YearsInPracticePost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **item** | [**Item117**](Item117.md)| Item to create. | 

### Return type

**int?**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

