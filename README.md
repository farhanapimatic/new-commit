# Getting started

This is an example of a simple API for a "notes" service

## How to Build

The generated code uses the Newtonsoft Json.NET NuGet Package. If the automatic NuGet package restore
is enabled, these dependencies will be installed automatically. Therefore,
you will need internet access for build.

1. Open the solution (NotesExampleAPI.sln) file.
2. Invoke the build process using `Ctrl+Shift+B` shortcut key or using the `Build` menu as shown below.

![Building SDK using Visual Studio](https://apidocs.io/illustration/cs?step=buildSDK&workspaceFolder=Notes%20Example%20API-CSharp&workspaceName=NotesExampleAPI&projectName=NotesExampleAPI.Tests)

## How to Use

The build process generates a portable class library, which can be used like a normal class library. The generated library is compatible with Windows Forms, Windows RT, Windows Phone 8,
Silverlight 5, Xamarin iOS, Xamarin Android and Mono. More information on how to use can be found at the [MSDN Portable Class Libraries documentation](http://msdn.microsoft.com/en-us/library/vstudio/gg597391%28v=vs.100%29.aspx).

The following section explains how to use the NotesExampleAPI library in a new console project.

### 1. Starting a new project

For starting a new project, right click on the current solution from the *solution explorer* and choose  ``` Add -> New Project ```.

![Add a new project in the existing solution using Visual Studio](https://apidocs.io/illustration/cs?step=addProject&workspaceFolder=Notes%20Example%20API-CSharp&workspaceName=NotesExampleAPI&projectName=NotesExampleAPI.Tests)

Next, choose "Console Application", provide a ``` TestConsoleProject ``` as the project name and click ``` OK ```.

![Create a new console project using Visual Studio](https://apidocs.io/illustration/cs?step=createProject&workspaceFolder=Notes%20Example%20API-CSharp&workspaceName=NotesExampleAPI&projectName=NotesExampleAPI.Tests)

### 2. Set as startup project

The new console project is the entry point for the eventual execution. This requires us to set the ``` TestConsoleProject ``` as the start-up project. To do this, right-click on the  ``` TestConsoleProject ``` and choose  ``` Set as StartUp Project ``` form the context menu.

![Set the new cosole project as the start up project](https://apidocs.io/illustration/cs?step=setStartup&workspaceFolder=Notes%20Example%20API-CSharp&workspaceName=NotesExampleAPI&projectName=NotesExampleAPI.Tests)

### 3. Add reference of the library project

In order to use the NotesExampleAPI library in the new project, first we must add a projet reference to the ``` TestConsoleProject ```. First, right click on the ``` References ``` node in the *solution explorer* and click ``` Add Reference... ```.

![Open references of the TestConsoleProject](https://apidocs.io/illustration/cs?step=addReference&workspaceFolder=Notes%20Example%20API-CSharp&workspaceName=NotesExampleAPI&projectName=NotesExampleAPI.Tests)

Next, a window will be displayed where we must set the ``` checkbox ``` on ``` NotesExampleAPI.Tests ``` and click ``` OK ```. By doing this, we have added a reference of the ```NotesExampleAPI.Tests``` project into the new ``` TestConsoleProject ```.

![Add a reference to the TestConsoleProject](https://apidocs.io/illustration/cs?step=createReference&workspaceFolder=Notes%20Example%20API-CSharp&workspaceName=NotesExampleAPI&projectName=NotesExampleAPI.Tests)

### 4. Write sample code

Once the ``` TestConsoleProject ``` is created, a file named ``` Program.cs ``` will be visible in the *solution explorer* with an empty ``` Main ``` method. This is the entry point for the execution of the entire solution.
Here, you can add code to initialize the client library and acquire the instance of a *Controller* class. Sample code to initialize the client library and using controller methods is given in the subsequent sections.

![Add a reference to the TestConsoleProject](https://apidocs.io/illustration/cs?step=addCode&workspaceFolder=Notes%20Example%20API-CSharp&workspaceName=NotesExampleAPI&projectName=NotesExampleAPI.Tests)

## How to Test

The generated SDK also contain one or more Tests, which are contained in the Tests project.
In order to invoke these test cases, you will need *NUnit 3.0 Test Adapter Extension for Visual Studio*.
Once the SDK is complied, the test cases should appear in the Test Explorer window.
Here, you can click *Run All* to execute these test cases.

## Initialization

### 

API client can be initialized as following.

```csharp

NotesExampleAPIClient client = new NotesExampleAPIClient();
```



# Class Reference

## <a name="list_of_controllers"></a>List of Controllers

* [NotesController](#notes_controller)

## <a name="notes_controller"></a>![Class: ](https://apidocs.io/img/class.png "NotesExampleAPI.Tests.Controllers.NotesController") NotesController

### Get singleton instance

The singleton instance of the ``` NotesController ``` class can be accessed from the API Client.

```csharp
NotesController notes = client.Notes;
```

### <a name="get_notes"></a>![Method: ](https://apidocs.io/img/method.png "NotesExampleAPI.Tests.Controllers.NotesController.GetNotes") GetNotes

> List all notes, optionally filtered by a query string


```csharp
Task<List<PCL.Models.NotesResponse>> GetNotes(string q = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| q |  ``` Optional ```  | An optional search query to filter the results |


#### Example Usage

```csharp
string q = "q";

List<PCL.Models.NotesResponse> result = await notes.GetNotes(q);

```


### <a name="delete_notes_by_id"></a>![Method: ](https://apidocs.io/img/method.png "NotesExampleAPI.Tests.Controllers.NotesController.DeleteNotesById") DeleteNotesById

> Remove the specified note


```csharp
Task DeleteNotesById(int id)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| id |  ``` Required ```  | The `id` of the specific note |


#### Example Usage

```csharp
int id = 2;

await notes.DeleteNotesById(id);

```


### <a name="get_notes_by_id"></a>![Method: ](https://apidocs.io/img/method.png "NotesExampleAPI.Tests.Controllers.NotesController.GetNotesById") GetNotesById

> Retrieve the specified note


```csharp
Task<PCL.Models.NotesResponse> GetNotesById(int id)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| id |  ``` Required ```  | The `id` of the specific note |


#### Example Usage

```csharp
int id = 2;

PCL.Models.NotesResponse result = await notes.GetNotesById(id);

```


### <a name="update_notes_by_id"></a>![Method: ](https://apidocs.io/img/method.png "NotesExampleAPI.Tests.Controllers.NotesController.UpdateNotesById") UpdateNotesById

> Update the specified note (allowing partial information)


```csharp
Task<PCL.Models.NotesResponse> UpdateNotesById(int id, object body)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| id |  ``` Required ```  | The `id` of the specific note |
| body |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
int id = 239;
var body = new object();

PCL.Models.NotesResponse result = await notes.UpdateNotesById(id, body);

```


### <a name="create_notes"></a>![Method: ](https://apidocs.io/img/method.png "NotesExampleAPI.Tests.Controllers.NotesController.CreateNotes") CreateNotes

> Create a new note in the collection


```csharp
Task<PCL.Models.NotesResponse> CreateNotes(PCL.Models.NotesRequest body, PCL.Models.XTrackingExampleEnum? xTrackingExample = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| body |  ``` Required ```  | TODO: Add a parameter description |
| xTrackingExample |  ``` Optional ```  | You can specify request headers like this |


#### Example Usage

```csharp
string bodyValue = "{ \"title\": \"Return sweater\", \"dueInDays\": -2 }";
var body = Newtonsoft.Json.JsonConvert.DeserializeObject<PCL.Models.NotesRequest>(bodyValue);
var xTrackingExample = PCL.Models.XTrackingExampleEnum?Helper.ParseString("accounting");

PCL.Models.NotesResponse result = await notes.CreateNotes(body, xTrackingExample);

```


[Back to List of Controllers](#list_of_controllers)



