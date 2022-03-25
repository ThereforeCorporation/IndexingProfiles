/*
This requires that SafeMode is deactivated.
This requires a connected server, see: connectServer.js
You need to know the Document number (DocNo) for the document.
To find the Document number, based on index data, you can use the Scripting - searchDocuments.js.
*/

// ******************************************************************************
//                          Update Document Index Data
// ******************************************************************************
// get the index data of the document and update them
var TheDocumentIndexData =  new ActiveXObject("TheAPI.TheIndexData")
TheDocumentIndexData.LoadEx(DocumentNumber, CategoryNo, TheServer) //<-TODO: DocNo
// ***********Change the required index data below******************************
//TheDocumentIndexData.SetValueByFieldID("The field ID of the index data you want to update" , "the new value")
TheDocumentIndexData.SetValueByFieldID("myTextField", "new data")
TheDocumentIndexData.SetValueByFieldID("myNumberField", 1234)

// for Tables
var TheTable = TheDocumentIndexData.GetTableValueByIndexDataFieldName("TableName")
TheTable.SetValueByFieldName("table column field", 0, "new value - line 1")
TheTable.SetValueByFieldName("table column field", 1, "new value - line 2")
TheTable.SetValueByFieldName("table column field", 2, "new value - line 3")
TheDocumentIndexData.SetTableValueByIndexDataFieldName("TableName", TheTable)

// if you have a source table, to copy over, for example this: (for Workflow only!)
var sourceCol = SourceIndexData.GetField("sourceCol")
var TheTable = TheDocumentIndexData.GetTableValueByIndexDataFieldName("TableName")
for (var i =0; i < sourceCol.length; i++)
{
     TheTable.SetValueByFieldName("destination_tablecol", i, sourceCol[i])
}
TheDocumentIndexData.SetTableValueByIndexDataFieldName("TableName", TheTable)
TheDocumentIndexData.SaveChangesEx(TheServer, "Changed by Content Connector")  //This is the checkin-comment

// ******************************************************************************
//                          Update Case Header
// ******************************************************************************
var TheCase = new ActiveXObject("TheAPI.TheCase")
TheCase.Load(FoundCaseNo, TheServer) //TODO: <- FoundCaseNo!
// get the index data of the case and update them
var TheCaseIndexData = TheCase.IndexData   
// **********Change the required index data below***********************
// TheCaseIndexData.SetValueByFieldID("The field ID of the case index data you want to update" , "the new value")
TheCaseIndexData.SetValueByFieldID("CaseHeaderTextField", "new case header data")
TheCaseIndexData.SetValueByFieldID("CaseHeaderNumber", 1234)

// for Tables
var TheTable = TheCaseIndexData.GetTableValueByIndexDataFieldName("TableName")
TheTable.SetValueByFieldName("table column field", 0, "new value - line 1")
TheTable.SetValueByFieldName("table column field", 1, "new value - line 2")
TheTable.SetValueByFieldName("table column field", 2, "new value - line 3")
TheCaseIndexData.SetTableValueByIndexDataFieldName("TableName", TheTable)
// **********************************************************************

TheCaseIndexData.SaveChangesEx(TheServer, "Changed by Content Connector")  //This is the checkin-comment
