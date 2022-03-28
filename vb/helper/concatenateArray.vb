function concatenateArray(arr1, arr2)
	if not IsArray(arr1) then
		concatenateArray = arr2
		Exit function
	end if

	dim result
	result = arr1
	redim preserve result(Ubound(arr1) + Ubound(arr2) + 1)
	dim index
	index = Ubound(arr1) + 1
	for i = 0 to Ubound(arr2)
		result(index) = arr2(i)
		index = index + 1
	next 
	concatenateArray = result
end function

'Alternative function
function concatArray(arr1, arr2)
	str = join(arr1, "~") + "~" + join(arr2, "~")
	result = split(str, "~")
	concatArray = result
end function

Dim array1=SourceIndexData.GetField("<Field1>")
Dim array2=SourceIndexData.GetField("<Field2>")
Dim newArr = concatenateArray(array1, array2)