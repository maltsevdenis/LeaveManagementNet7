using LeaveManagement.Data;
using LeaveManagement.Application.Contracts;

namespace LeaveManagement.Web.Repositories;

public class LeaveTypeRepository : GenericRepository<LeaveType>, ILeaveTypeRepository
{
    public LeaveTypeRepository(ApplicationDbContext context) : base(context)
    {
    }
}
