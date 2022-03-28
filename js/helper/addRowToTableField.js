// get existing rows
var tableColToAddTo = SourceIndexData.GetField("fieldname")

// add row at the end
tableColToAddTo[tableColToAddTo.length] = "<New Value>"

// use tableColToAddTo in the assignments for the respective column