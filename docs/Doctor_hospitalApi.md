# IO.Swagger.Api.Doctor_hospitalApi

All URIs are relative to *https://surgipal.com/api/api.php*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DoctorHospitalGet**](Doctor_hospitalApi.md#doctorhospitalget) | **GET** /doctor_hospital | List
[**DoctorHospitalIdDelete**](Doctor_hospitalApi.md#doctorhospitaliddelete) | **DELETE** /doctor_hospital/{id} | Delete
[**DoctorHospitalIdGet**](Doctor_hospitalApi.md#doctorhospitalidget) | **GET** /doctor_hospital/{id} | Read
[**DoctorHospitalIdPatch**](Doctor_hospitalApi.md#doctorhospitalidpatch) | **PATCH** /doctor_hospital/{id} | Increment
[**DoctorHospitalIdPut**](Doctor_hospitalApi.md#doctorhospitalidput) | **PUT** /doctor_hospital/{id} | Update
[**DoctorHospitalPost**](Doctor_hospitalApi.md#doctorhospitalpost) | **POST** /doctor_hospital | Create


<a name="doctorhospitalget"></a>
# **DoctorHospitalGet**
> List<InlineResponse20012> DoctorHospitalGet (string exclude = null, string include = null, string order = null, string page = null, bool? transform = null, string columns = null, List<string> filter = null, string satisfy = null)

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
    public class DoctorHospitalGetExample
    {
        public void main()
        {
            
            var apiInstance = new Doctor_hospitalApi();
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
                List&lt;InlineResponse20012&gt; result = apiInstance.DoctorHospitalGet(exclude, include, order, page, transform, columns, filter, satisfy);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Doctor_hospitalApi.DoctorHospitalGet: " + e.Message );
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

[**List<InlineResponse20012>**](InlineResponse20012.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="doctorhospitaliddelete"></a>
# **DoctorHospitalIdDelete**
> int? DoctorHospitalIdDelete (string id)

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
    public class DoctorHospitalIdDeleteExample
    {
        public void main()
        {
            
            var apiInstance = new Doctor_hospitalApi();
            var id = id_example;  // string | Identifier for item.

            try
            {
                // Delete
                int? result = apiInstance.DoctorHospitalIdDelete(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Doctor_hospitalApi.DoctorHospitalIdDelete: " + e.Message );
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

<a name="doctorhospitalidget"></a>
# **DoctorHospitalIdGet**
> InlineResponse20012 DoctorHospitalIdGet (string id)

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
    public class DoctorHospitalIdGetExample
    {
        public void main()
        {
            
            var apiInstance = new Doctor_hospitalApi();
            var id = id_example;  // string | Identifier for item.

            try
            {
                // Read
                InlineResponse20012 result = apiInstance.DoctorHospitalIdGet(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Doctor_hospitalApi.DoctorHospitalIdGet: " + e.Message );
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

[**InlineResponse20012**](InlineResponse20012.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="doctorhospitalidpatch"></a>
# **DoctorHospitalIdPatch**
> int? DoctorHospitalIdPatch (string id, Item38 item)

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
    public class DoctorHospitalIdPatchExample
    {
        public void main()
        {
            
            var apiInstance = new Doctor_hospitalApi();
            var id = id_example;  // string | Identifier for item.
            var item = new Item38(); // Item38 | Properties of item to update.

            try
            {
                // Increment
                int? result = apiInstance.DoctorHospitalIdPatch(id, item);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Doctor_hospitalApi.DoctorHospitalIdPatch: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Identifier for item. | 
 **item** | [**Item38**](Item38.md)| Properties of item to update. | 

### Return type

**int?**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="doctorhospitalidput"></a>
# **DoctorHospitalIdPut**
> int? DoctorHospitalIdPut (string id, Item37 item)

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
    public class DoctorHospitalIdPutExample
    {
        public void main()
        {
            
            var apiInstance = new Doctor_hospitalApi();
            var id = id_example;  // string | Identifier for item.
            var item = new Item37(); // Item37 | Properties of item to update.

            try
            {
                // Update
                int? result = apiInstance.DoctorHospitalIdPut(id, item);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Doctor_hospitalApi.DoctorHospitalIdPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Identifier for item. | 
 **item** | [**Item37**](Item37.md)| Properties of item to update. | 

### Return type

**int?**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="doctorhospitalpost"></a>
# **DoctorHospitalPost**
> int? DoctorHospitalPost (Item36 item)

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
    public class DoctorHospitalPostExample
    {
        public void main()
        {
            
            var apiInstance = new Doctor_hospitalApi();
            var item = new Item36(); // Item36 | Item to create.

            try
            {
                // Create
                int? result = apiInstance.DoctorHospitalPost(item);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Doctor_hospitalApi.DoctorHospitalPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **item** | [**Item36**](Item36.md)| Item to create. | 

### Return type

**int?**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

