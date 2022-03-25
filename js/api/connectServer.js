/*Connect to the Therefore Server from Scripting
This requires that SafeMode is deactivated!
Remove the TheServer.SetTenant line, if you don't have a multi-tenant system.
You can use TheServer.ConnectCustom if the process, the script is running on, is running under a user account. If the process is running with LocalSystem (e.g TheServer), then use TheServer.ConnectUser instead.
*/

var TheServer = new ActiveXObject("TheAPI.TheServer");  

TheServer.SetTenant("<Tenant>") // only needed if you have a tenant system - remove this if you DON'T have a tenant system
TheServer.ConnectCustom() // connect with the current user
//TheServer.ConnectUser 6, "APIUser", "********" // you need to connect with a user if the server is running with local system. (when running in workflow)