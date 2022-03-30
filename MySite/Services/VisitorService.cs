using Microsoft.EntityFrameworkCore.Storage;
using MySite.Data;
using MySite.Models;

namespace MySite.Services;

public class VisitorService : IVisitorService
{
    public async void RegisterVisitor(VisitorsDbContext database, HttpContext context)
    {
        if(!context.Session.Keys.Contains("IsVisitRegistered"))
        {
            context.Session.SetInt32("IsVisitRegistered", 1);
            
            Visitor visitor = new Visitor();
            if(context.Connection.RemoteIpAddress!=null)
                visitor.Ip = context.Connection.RemoteIpAddress.ToString();
            else return;
            
            visitor.VisitTime = DateTime.Now;
            
            if(database.Visitors!=null)
                await database.Visitors.AddAsync(visitor);
            else return;

            await database.SaveChangesAsync();
        }
    }
}