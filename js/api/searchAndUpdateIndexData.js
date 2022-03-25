/*To update index data in a category, you can use the Update index workflow task.
Sometimes though, it is required, that you need to update a different category, than the workflow runs on.
This is currently only possible when SafeMode is deactivated.*/

var TheServer = new ActiveXObject("TheAPI.TheServer");  
TheServer.ConnectCustom() // connect with the current user

var TheQuery = new ActiveXObject("TheAPI.TheQuery")
var TheCategory = new ActiveXObject("TheAPI.TheCategory")

// load the category - where you want to search the unique ID
TheCategory.LoadByName("STC Input", TheServer)   // set the category, where you want to search in

// prepare the query to search for the unique id
TheQuery.Category = TheCategory
TheQuery.SelectFields.AddAll()

// this is your UNIQUE ID field - and the value to search for. we are using the InvNo field from this category, to search in the other category.
TheQuery.Conditions.AddConditionByName("Invoice_No", SourceIndexData.GetField("InvNo"))    // use the Field ID!

var TheQueryResult = TheQuery.Execute(TheServer)
if (TheQueryResult.Count > 0) {
  var  TheQueryResultRow = TheQueryResult.Item(0) // it's a unique id - so we assume there is just one result - so just get the first one.
  searchedDocumentNo = TheQueryResultRow.DocNo // we want the DocNo of the searched document.
  //You can use TheQueryResultRow.Item(), to access any other columns, a normal search would return, like Item(0) for the first column.


// get the index data of the document and update them
var TheDocumentIndexData =  new ActiveXObject("TheAPI.TheIndexData")
TheDocumentIndexData.LoadEx(searchedDocumentNo , 68, TheServer) //<-TODO: CategoryNo
// ***********Change the required index data below******************************
//TheDocumentIndexData.SetValueByFieldID("The field ID of the index data you want to update" , "the new value")
TheDocumentIndexData.SetValueByFieldID("myTextField", "new data")
TheDocumentIndexData.SetValueByFieldID("myNumberField", 1234)
// ******************************************************************************

TheDocumentIndexData.SaveChangesEx(TheServer, "Changed by Content Connector")  //This is the checkin-comment

}
else {
        ScriptError("No document with this unique id found.")
}

// disconnects from the Server
TheServer.Disconnect()