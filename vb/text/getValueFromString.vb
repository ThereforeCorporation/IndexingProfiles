'This functions searches a keyword in an existing string, and returns everything behind that until a newline is reached.
'This function is similar to the GetValFromBody function, but you can specify a start position, from where the search starts.
'For example, you can first search for a different keyword, and then use that position as start position for GetValFromBody2. 

' start searching after a specific position
Function GetValFromBody2 (Body, Keyword, StartPos)
                Dim pos
                Dim posEnd
                Dim Value

                pos = Instr(StartPos ,Body, Keyword)
                If pos > 0 Then
                                posEnd = Instr(pos, Body, vbCrLf)
                                If posEnd > 0 Then
                                        Value = Trim(Mid(Body, pos + Len(Keyword), posEnd - (pos + Len(Keyword))))
        Else
          posEnd = Instr(pos, Body, vbLf)
          If posEnd > 0 Then
                                            Value = Trim(Mid(Body, pos + Len(Keyword), posEnd - (pos + Len(Keyword))))
          End If
                                End If
                End If
   GetValFromBody2=Value
End Function

' search for "Number:" and get everything behind it, until a newline is reached.
val = GetValFromBody2(Mail.Body, "Number:", 1)
