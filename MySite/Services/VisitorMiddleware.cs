using MySite.Data;

namespace MySite.Services;

public class VisitorMiddleware
{
    private readonly RequestDelegate next;

    public VisitorMiddleware(RequestDelegate next)
    {
        this.next = next;
    }

    public async Task InvokeAsync(HttpContext context, VisitorsDbContext visitorsDatabase, IVisitorService visitorService)
    {
        visitorService.RegisterVisitor(visitorsDatabase, context);
        await next.Invoke(context);
    }
}