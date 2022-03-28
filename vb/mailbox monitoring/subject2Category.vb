'Mail - Search for specific subjects or parts of a subject and set a category for them

Class SubjectToCategory
   private nCtgry
   private strSubject

   Public Property Get FindSubject
      FindSubject = strSubject
   End Property

   Public Property Let FindSubject(subj)
	  strSubject = subj
   End Property

   Public Property Get CategoryNo
      CategoryNo = nCtgry
   End Property

   Public Property Let CategoryNo(ctgry)
	  nCtgry = ctgry
   End Property
End Class

' Set here how many subjects you want to detect.
dim CountOfSubjectsToDetect
CountOfSubjectsToDetect = 3  

dim Mappings
Redim Mappings (CountOfSubjectsToDetect)

for i = 0 To CountOfSubjectsToDetect - 1
	dim mapping
	Set mapping = new SubjectToCategory
	
	select case i
		case 0
			' this is the first subject you want to detect
			mapping.FindSubject = "<Subject1>"
			mapping.CategoryNo = 14 ' the therefore category id, in which we want to save a mail, where the above "Subject" was found
		case 1
			' for example add another subject which we want to search for
			mapping.FindSubject = "<Subject2>"
			mapping.CategoryNo = 14
			'You can add additional subjects here
		case 2
			' if we find an incomplete subject, save into another category
			mapping.FindSubject = "<Subject3>"
			mapping.CategoryNo = 9
	end select
	Set Mappings(i) = mapping
Next

dim map
dim mailSubject
dim foundAMatch
dim foundSubject

foundAMatch = false
mailSubject = Subject ' save the subject of the mail

' search the subject of the mail for the Subjects which you entered above.
for j = 0 to UBound(Mappings) - 1
	Set map = Mappings(j)
	dim pos
	pos = InStr(1, mailSubject, map.FindSubject, 1) ' search for the "FindSubject"
	if pos <> 0 then
		' this mail contains the subject we are searching for.
		SetCategory(map.CategoryNo) ' set the therefore category, in which this email should be saved
		foundAMatch = true
		foundSubject = map.FindSubject
		exit for
	end if
Next

if foundAMatch = false then
	' we haven't found the subject we are searching for
	' do not save this e-mail, and just abort.
	ScriptError "No match found"
end if

' the avove code searches the subjects and if a WHOLE match was found, the category will be set accordingly
' to search for partial matches, e.g like "AS/", you need to continue here. 


