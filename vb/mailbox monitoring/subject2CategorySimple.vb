dim foundAtPos

' will return 0 when the string was not found
' will return the first position of the string if it was found
foundAtPos = InStr(Subject, "what to search for in the subject")

' if  foundAtPos is not 0 then...
if foundAtPos <> 0 then
	' the string was found - choose a category
	SetCategory(14) ' Change this to your Category ID
else
	' we didn't find what we were searching for
	' Remove the line below if you want the normal category selection to pop up.
	' or leave it and set a default category when it was not found.
	SetCategory(9)
end if 