'This function sets <count> rows with the <text>
function SetRows (count, text)
   dim columnArray
   redim columnArray(count - 1)
   
   for i = 0 To count - 1
       columnArray(i) = text
   Next

   SetRows = columnArray
end function