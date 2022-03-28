set TheServer = CreateObject("TheAPI.TheServer")
TheServer.SetTenant("default") ' only needed if you have a tenant system - remove this if you DONT have a tenant system
'TheServer.ConnectCustom() 'connect with the current user (the server user)
TheServer.ConnectUser 6, "ados\test", "XXX" ' you need to connect with a user if the server is running with local system.

set TheWFInstance = CreateObject("TheAPI.TheWFInstance")
TheWFInstance.Load TheServer, InstanceNo

TheWFInstance.ClaimInstance TheServer

' TODO: ADDITIONAL INFO COMES FROM THIS INDEX FIELD!
TheWFInstance.SetText SourceIndexData.GetField("Text1") 

TheWFInstance.SaveInstance TheServer
TheWFInstance.UnclaimInstance TheServer