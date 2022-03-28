Set TheServer = CreateObject("TheAPI.TheServer")
TheServer.ConnectCustom()

Set TheCase = CreateObject("TheAPI.TheCase")
TheCase.Load GetField("CaseNo"), TheServer
TheCase.CloseCase TheServer
