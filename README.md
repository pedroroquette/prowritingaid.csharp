# ProWritingAid.SDK

[![Build status](https://ci.appveyor.com/api/projects/status/uw618e4sbv978jwg?svg=true)](https://ci.appveyor.com/project/prowriting/prowritingaid-csharp)

C# library for the ProWritingAid.API

- API version: v1
- SDK version: 1.0.0

## Frameworks supported
- .NET 4.5 or later

## Dependencies
- [RestSharp](https://www.nuget.org/packages/RestSharp) - 105.2.3 or later
- [Json.NET](https://www.nuget.org/packages/Newtonsoft.Json/) - 10.0.2 or later

The DLLs included in the package may not be the latest version. We recommned using [NuGet] (https://docs.nuget.org/consume/installing-nuget) to obtain the latest version of the packages:
```
Install-Package RestSharp
Install-Package Newtonsoft.Json
```

NOTE: RestSharp versions greater than 105.1.0 have a bug which causes file uploads to fail. See [RestSharp#742](https://github.com/restsharp/RestSharp/issues/742)

## Installation
Run the following command to generate the DLL
- [Mac/Linux] `/bin/sh build.sh`
- [Windows] `build.bat`

Then include the DLL (under the `bin` folder) in the C# project, and use the namespaces:
```csharp
using ProWritingAid.SDK.Api;
using ProWritingAid.SDK.Client;
using Model;
```

## Getting Started

```csharp
using System;
using System.Diagnostics;
using ProWritingAid.SDK.Api;
using ProWritingAid.SDK.Client;
using ProWritingAid.SDK.Model;

namespace Example
{
    public class Example
    {
        public void main()
        {
            
            var api = new TextApi();
            var request = new TextAnalysisRequest(
                "I'd like to by that toy. wood you help me? I have twp more brothers.",
                new List<string> {"grammar"},
                TextAnalysisRequest.StyleEnum.General,
                TextAnalysisRequest.LanguageEnum.En,
                LicenseCredentials); 

            try
            {
                var response = api.TextPost(request);
                Debug.WriteLine(response);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AsyncContextualThesaurusApi.AsyncContextualThesaurusPost: " + e.Message );
            }
        }
    }
}
```

<a name="documentation-for-api-endpoints"></a>
## Documentation for API Endpoints

All URIs are relative to *https://api.prowritingaid.com*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*AsyncContextualThesaurusApi* | [**AsyncContextualThesaurusPost**](docs/AsyncContextualThesaurusApi.md#asynccontextualthesauruspost) | **POST** /api/async/contextualthesaurus | 
*AsyncContextualThesaurusResultApi* | [**AsyncContextualThesaurusResultGetResult**](docs/AsyncContextualThesaurusResultApi.md#asynccontextualthesaurusresultgetresult) | **GET** /api/async/result/contextualthesaurus/{taskId} | 
*AsyncHtmlApi* | [**AsyncHtmlPost**](docs/AsyncHtmlApi.md#asynchtmlpost) | **POST** /api/async/html | 
*AsyncHtmlResultApi* | [**AsyncHtmlResultGetResult**](docs/AsyncHtmlResultApi.md#asynchtmlresultgetresult) | **GET** /api/async/result/html/{taskId} | 
*AsyncSummaryApi* | [**AsyncSummaryPost**](docs/AsyncSummaryApi.md#asyncsummarypost) | **POST** /api/async/summary | 
*AsyncSummaryResultApi* | [**AsyncSummaryResultGetResult**](docs/AsyncSummaryResultApi.md#asyncsummaryresultgetresult) | **GET** /api/async/result/summary/{taskId} | 
*AsyncTextApi* | [**AsyncTextPost**](docs/AsyncTextApi.md#asynctextpost) | **POST** /api/async/text | 
*AsyncTextResultApi* | [**AsyncTextResultGetResult**](docs/AsyncTextResultApi.md#asynctextresultgetresult) | **GET** /api/async/result/text/{taskId} | 
*AsyncWordCloudApi* | [**AsyncWordCloudPost**](docs/AsyncWordCloudApi.md#asyncwordcloudpost) | **POST** /api/async/wordcloud | 
*AsyncWordCloudResultApi* | [**AsyncWordCloudResultGetResult**](docs/AsyncWordCloudResultApi.md#asyncwordcloudresultgetresult) | **GET** /api/async/result/wordcloud/{taskId} | 
*ContextualThesaurusApi* | [**ContextualThesaurusPost**](docs/ContextualThesaurusApi.md#contextualthesauruspost) | **POST** /api/contextualthesaurus | 
*HtmlApi* | [**HtmlPost**](docs/HtmlApi.md#htmlpost) | **POST** /api/html | 
*SummaryApi* | [**SummaryPost**](docs/SummaryApi.md#summarypost) | **POST** /api/summary | 
*TextApi* | [**TextPost**](docs/TextApi.md#textpost) | **POST** /api/text | 
*WordCloudApi* | [**WordCloudPost**](docs/WordCloudApi.md#wordcloudpost) | **POST** /api/wordcloud | 


<a name="documentation-for-models"></a>
## Documentation for Models

 - [Model.AnalysisSettings](docs/AnalysisSettings.md)
 - [Model.AnalysisSummary](docs/AnalysisSummary.md)
 - [Model.AnalysisSummaryGraph](docs/AnalysisSummaryGraph.md)
 - [Model.AnalysisSummaryGraphItem](docs/AnalysisSummaryGraphItem.md)
 - [Model.AnalysisSummaryItem](docs/AnalysisSummaryItem.md)
 - [Model.AnalysisSummarySubItem](docs/AnalysisSummarySubItem.md)
 - [Model.AsyncResponseContextualThesaurusResponse](docs/AsyncResponseContextualThesaurusResponse.md)
 - [Model.AsyncResponseHtmlAnalysisResponse](docs/AsyncResponseHtmlAnalysisResponse.md)
 - [Model.AsyncResponseSummaryAnalysisResponse](docs/AsyncResponseSummaryAnalysisResponse.md)
 - [Model.AsyncResponseTextAnalysisResponse](docs/AsyncResponseTextAnalysisResponse.md)
 - [Model.AsyncResponseWordCloudResponse](docs/AsyncResponseWordCloudResponse.md)
 - [Model.ContextualThesaurusRequest](docs/ContextualThesaurusRequest.md)
 - [Model.ContextualThesaurusResponse](docs/ContextualThesaurusResponse.md)
 - [Model.DocTag](docs/DocTag.md)
 - [Model.HtmlAnalysisRequest](docs/HtmlAnalysisRequest.md)
 - [Model.HtmlAnalysisResponse](docs/HtmlAnalysisResponse.md)
 - [Model.SuggestionCategory](docs/SuggestionCategory.md)
 - [Model.SummaryAnalysisRequest](docs/SummaryAnalysisRequest.md)
 - [Model.SummaryAnalysisResponse](docs/SummaryAnalysisResponse.md)
 - [Model.TextAnalysisRequest](docs/TextAnalysisRequest.md)
 - [Model.TextAnalysisResponse](docs/TextAnalysisResponse.md)
 - [Model.WordCloudRequest](docs/WordCloudRequest.md)
 - [Model.WordCloudResponse](docs/WordCloudResponse.md)


## Documentation for Authorization

### licenseCode

- **Type**: API key
- **API key parameter name**: licenseCode
- **Location**: HTTP header

