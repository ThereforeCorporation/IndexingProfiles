'Save just the name from an email; remove everything after the @

Dim emailAddress
Dim positionOfAtCharacter
Dim justTheName

'get the email address
emailAddress = From_SMTP

'search for the "@" character in the email address
positionOfAtCharacter = InStr(emailAddress, "@")

if positionOfAtCharacter > 0 then
	'save everything on the left side of the "@"
	justTheName = Left(emailAddress, positionOfAtCharacter - 1)
else
	'this shouldn't happen; it means that the email didn't contain an "@"
	' which is not possible
	justTheName = ""
end if