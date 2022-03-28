
'Split barcode and use the splitted values

Dim barcode
dim splittedValues
' i commented the barcode out, because the sample didn't work for me
barcode = GetValue("barcode")

'i've just hardcoded the barcode for testing
'barcode = "Name,Surname,Age,City"
' some tests
'barcode = "Max,Mustermann , 33, Vienna"
'barcode = "  Max , Mustermann, 44  , Vienna   "

'splitting the barcode value, using ","
splittedValues = Split(barcode, ",")

'splittedValues is now an array with 4 elements in it.

dim name 'declare some variables, so we can use them in the assignments
dim surname
dim age
dim city

name = splittedValues(0) 'access the first array element
surname = splittedValues(1) 'access the second array element
age = splittedValues(2) ' and so on
city = splittedValues(3)

'one last thing before we use the variables.
'remove any whitespace from the left and right side of a string
'the Trim function does this for us.
name = Trim(name)
surname = Trim(surname)
age = Trim(age)
city = Trim(city)
