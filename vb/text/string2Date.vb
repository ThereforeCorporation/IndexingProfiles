' searching a date in a string and converting it

dim x
x = "<OCR Zone Name>"
'You need to replace x with the actual OCR value
'for example
'x = Extract("OCR zone name")

For i = 1 To Len(x)
  char = Mid(x, i, 1)
  if IsNumeric(char) then
	extractedDate = Mid(x, i, 10)
	exit for
  end if
Next

theDate = ToDate(extractedDate, "YYYY-MM-DD")
