'***************************************************
' Capture: Set Table fields/rows from OCR (simple)
'***************************************************
Dim temp

' use this variables in the table assignments
Dim TableDescription 
Dim TableItemNo

'get the OCR zone "Item No"
temp = Extract("Item No")
'split it up using spaces
TableItemNo = Split(temp, " ")

'same for Description
temp = Extract("Description")
TableDescription = Split(temp, " ")

'***************************************************
' Capture: Set Table fields/rows from OCR (advanced)
'***************************************************
'Each item has an OCR Zone defined
'Iterate over the items until an empty value is found
' -> which means we reached the end

'we named our OCR zones Item1, Item2, etc
'so we can easily utilise a loop to append the current index to the item
'like this: "Item" + index  -> Item1 -> then use this name in the extract function

Function GetOCRTable(baseName, itemCount)
	dim ResultTable
	redim ResultTable(itemCount - 1)
	For i = 1 To itemCount
		dim ocrName ' the name of the item to read ("Item1")
		dim value ' the value of the item read
		ocrName = baseName & i ' "i" will be automatically converted to string
		value = Extract(ocrName)
		if value <> Empty Then
			' when the value read is not empty, it is valid
			ResultTable(i - 1) = value ' save the value in the resulting array
		else
			Exit For  ' stop -> the value read is empty
		end if
	Next
	GetOCRTable = ResultTable 'set the result of this function
End Function

dim TableItem
dim TableDesc

TableItem = GetOCRTable("Item", 3)
TableDesc = GetOCRTable("Desc", 3)