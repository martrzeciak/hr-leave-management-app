using HRLeaveManagement.Application.Contracts.Persistence;
using HRLeaveManagement.Domain;
using HrLeaveManagementPersistence.DataContext;
using Microsoft.EntityFrameworkCore;

namespace HRLeaveManagementPersistence.Repositories
{
    public class LeaveTypeRepository : GenericRepository<LeaveType>, ILeaveTypeRepository
    {
        public LeaveTypeRepository(HrDatabaseContext context) : base(context)
        {
        }

        public async Task<bool> IsLeaveTypeUnique(string name)
        {
            return await _context.LeaveTypes.AnyAsync(q => q.Name == name) == false;
        }
    }
}
