'fieldName - this should be the fieldName of a table index data column.
'Use the same as e.g in SourceIndexData.GetField("TableText") -> "TableText"
'text - this is the entry you want to add to the table -> e.g "test"
'Sample call in the assignments(!): AddTableEntry("TableText", "added entry")
function AddTableEntry(fieldName, text)
	' get existing index data
  	tableColumn = SourceIndexData.GetField(fieldName)
  	if not IsArray(tableColumn) then
  		redim tableColumn(-1) 'if it's empty, make it an empty array, so code below works
  	end if
  	' add an additional row
	redim preserve tableColumn(Ubound(tableColumn) + 1) ' make the new array one entry bigger
	' set the content of the row
	tableColumn(Ubound(tableColumn)) = text
	AddTableEntry = tableColumn
end function