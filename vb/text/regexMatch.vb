'This regular expression sample script returns the first found match in a string.
Function GetRegExpMatch(patrn, strng)
	Dim regEx, Match, Matches ' Create variable.
	Set regEx = New RegExp ' Create a regular expression.
	regEx.Pattern = patrn ' Set pattern.
	regEx.IgnoreCase = True ' Set case insensitivity.
	regEx.Global = False ' Set .Global to true if you want more than one match.
	Set Matches = regEx.Execute(strng) ' Execute search.
	For Each Match in Matches ' Iterate Matches collection.
		RetStr = Match.Value	'return first found match
		GetRegExpMatch = RetStr
		exit function
	Next
	GetRegExpMatch = RetStr
End Function

'Usage
'For example this will search for a 4 digit number in an extracted OCR zone.
'It will return empty when nothing was found.
myVal = GetRegExpMatch("\d{4}", OCR.Extract("zone1"))