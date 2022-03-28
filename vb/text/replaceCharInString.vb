'Replacing characers in string

dim ocrvalue
dim changedvalue

ocrvalue = Extract("my ocr zone")
					
'the first parameter is the string
'the second parameter is the character which should be replaced
'the third parameter is the character which will be inserted instead of
changedvalue = Replace(ocrvalue, "!", "")

'now use "changedvalue" in the assignment section of the indexing profile