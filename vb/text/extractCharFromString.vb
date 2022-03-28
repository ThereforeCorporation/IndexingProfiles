'Extracting characters from string

Dim myBarcode
'Get the barcode value
myBarcode = Barcode.GetValue(„barcodename“)

'Extract only the first two characters
Dim firstChars
firstChars = Mid(myBarcode, 1, 2)

'Extract characters 5 to 7
Dim char5To7
char5To7 = Mid(myBarcode, 5, 2)

'use firstChars and char5To7 in the assignment of the indexing profile