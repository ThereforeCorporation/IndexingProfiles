'*******************************************************************
'Setting the category from Barcode
'*******************************************************************

Dim myBarcode
'Get the barcode value
myBarcode = Barcode.GetValue(„barcodename“)

'Extract only the first two characters
Dim firstChars
firstChars = Mid(myBarcode, 1, 2)

'We have the first 2 characters, but now we need to convert them from characters to integer
Dim categoryId
categoryId = CInt(firstChars)

'Set the category of the index data
SetCategory(categoryId)


'*******************************************************************
'Setting the category from Barcode (Upgrade with Translation Table)
'*******************************************************************

Dim myBarcode
'Get the barcode value
myBarcode = Barcode.GetValue(„barcodename“)

'Extract only the first two characters
Dim firstChars
firstChars = Mid(myBarcode, 1, 2)

Dim categoryId
'We need to "translate" the first 2 characters of the barcode to a category id
'In this case i will just use some If - else statements
If firstChars = "EN" Then
	categoryId = 1
ElseIf firstChars = "AT" Then
	categoryId = 2
ElseIf firstChars = "DE" Then
	categoryId = 3
Else
	' nothing matched from above, just assign 4
	categoryId = 4 
	' if you don't want this fallback you can either:
	' 1. say that this profile is not applicable
	NotApplicable()
	' 2. throw a script error, if this shouldn't happen and you want to be informed
	ScriptError("Invalid characters from the barcode. No category matched.")
End If 
' i could go on and on...

'finally set the category
SetCategory(categoryId)