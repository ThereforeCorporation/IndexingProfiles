'sum up a Therefore table and prepare for assignment
Dim tableColumn = SourceIndexData.GetField("Unit Price")
Dim priceTotal

for i = 0 to UBound(tableColumn)
   priceTotal = priceTotal + tableColumn(i)
next

' use priceTotal in the assignments!