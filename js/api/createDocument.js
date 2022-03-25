//Create a document in a category in script.
//This requires that SafeMode is deactivated.

var TheServer = new ActiveXObject("TheAPI.TheServer");  

TheServer.SetTenant("default") // only needed if you have a tenant system - remove this if you DON'T have a tenant system
TheServer.ConnectCustom() // connect with the current user
//TheServer.ConnectUser 6, "APIUser", "********" // you need to connect with a user if the server is running with local system. (when running in workflow)

var TheDoc = new ActiveXObject("TheAPI.TheDocument")
var createdFile
TheDoc.Create(createdFile)      // NOTE: This here is a memory leak but it can't be fixed
                  // JS does not support [out/ref] parameters, so createdFile will stay empty.
                  // Maybe this API function will be changed in future releases.
                  
var IxData = TheDoc.IndexData

//TODO: set category first
//IxData.SetCategoryByNo(68, TheServer)
IxData.SetCategoryByName("Text", TheServer)
  
//TODO: set index data values
IxData.SetValueByFieldID("Text2", "test")
//IxData.SetValueByFieldID("TextField1", "some text")
//IxData.SetValueByFieldID("IntegerField", 34)      


//TODO: add a file to the document; or remove this code to save an empty document
var filePath = "C:\\temp\\somefile.txt" //TODO: you need to get a filename from somewhere
TheDoc.AddStream(filePath, "", 0)


var savedDocNo = TheDoc.ArchiveExUI (TheServer, 0, "checkin comment", false) //false means "Don't allow UI"
TheDoc.Dispose  //delete the temporary file created