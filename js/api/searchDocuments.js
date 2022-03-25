/*
This requires that SafeMode is deactivated.
This requires a connected server, see: connectServer.js
*/
var TheQuery = new ActiveXObject("TheAPI.TheQuery")
var TheCategory = new ActiveXObject("TheAPI.TheCategory")

// load the category - where you want to search the unique ID
TheCategory.LoadByName("<Category Name>", TheServer)   // set the category, where you want to search in

// prepare the query to search for the unique id
TheQuery.Category = TheCategory
TheQuery.SelectFields.AddAll()

// this is your UNIQUE ID field - and the value to search for.
TheQuery.Conditions.AddConditionByName("Invoice_No", "706075")    // use the Field ID!

var TheQueryResult = TheQuery.Execute(TheServer)
if (TheQueryResult.Count > 0) {
  var  TheQueryResultRow = TheQueryResult.Item(0) // it's a unique id - so we assume there is just one result - so just get the first one.
  searchedDocumentNo = TheQueryResultRow.DocNo // we want the DocNo of the searched document.
  //You can use TheQueryResultRow.Item(), to access any other columns, a normal search would return, like Item(0) for the first column.

        //'*******************************************************
        //'TODO: do something with the found document
        //'*********************************************************
}
else {
       // '********************************************************
        //'TODO: do something when the document was not found
        //' for example:
        //'ScriptError("No document with this unique id found.")
        //'********************************************************
}

// disconnects from the Server
TheServer.Disconnect()