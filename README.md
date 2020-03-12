# SigRChat

Followed:  
Chat app using ASP.NET core SignalR with User identity  
https://www.youtube.com/watch?v=RUZLIh4Vo20

Src code: https://github.com/dotnettrainingacademy/publico

A few differences from the video:
- VS 2019
- Project name; SigRChat
- `Id` instead of `ID` (in _Models/Message.cs_)
- `Username` instead of `UserName` (in _Models/Message.cs_ & _Views/Home/Index.cshtml_ & any other occurrences)
- `UserId` instead of `UserID` (in _Models/Message.cs_)
- `@ViewBag.CurrentUsername` instead of `@ViewBag.CurrentUserName` (in _Views/Home/Index.cshtml_)
- `Timestamp` instead of `when` (in _Models/Message.cs_ & _Views/Home/Index.cshtml_)
- Obsolete:
	```app.UseSignalR(route =>
	{
		route.MapHub<ChatHub>("/Home/Index");
	});```
	VS suggested alternative:
	`endpoints.MapHub<ChatHub>("/Home/Index");` within `app.UseEndpoints()`
- Code snippet he skipped in _Data/ApplicationDbContext.cs_: 
	`public DbSet<Message> Messages { get; set; }`
- Code snipper he skipped in _Models/Message.cs_ 
	```public Message()
	{
		Timestamp = DateTime.Now;
	}```
	

