using LeaveManagement.Common.Models;
using LeaveManagement.Data;

namespace LeaveManagement.Application.Contracts;

public interface ILeaveRequestRepository : IGenericRepository<LeaveRequest>
{
    Task<bool> CreateLeaveRequest(LeaveRequestCreateVM model);
    Task<EmployeeLeaveRequestViewVM> GetMyLeaveDetails();
    Task<LeaveRequestVM?> GetLeaveRequestAsync(int? id);
    Task<List<LeaveRequestVM>> GetAllAsync(string employeeId);
    Task<AdminLeaveRequestViewVM> GetAdminLeaveRequestList();
    Task CancelLeaveRequest(int leaveRequestId);
    Task ChangeApprovalStatus(int leaveRequestId, bool approved);
}
