using MySite.Data;

namespace MySite.Services;

public interface IVisitorService
{
    void RegisterVisitor(VisitorsDbContext database, HttpContext context);
}