﻿using LeaveManagement.Web.Data;
using LeaveManagement.Web.Models;

namespace LeaveManagement.Web.Contracts;

public interface ILeaveRequestRepository : IGenericRepository<LeaveRequest>
{
    Task CreateLeaveRequest(LeaveRequestCreateVM model);
    Task<EmployeeLeaveRequestViewVM> GetMyLeaveDetails();
    Task<LeaveRequestVM?> GetLeaveRequestAsync(int? id);
    Task<List<LeaveRequest>> GetAllAsync(string employeeId);
    Task<AdminLeaveRequestViewVM> GetAdminLeaveRequestList();
    Task CancelLeaveRequest(int leaveRequestId);
    Task ChangeApprovalStatus(int leaveRequestId, bool approved);
}