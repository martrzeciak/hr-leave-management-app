using MediatR;

namespace HRLeaveManagement.Application.Features.LeaveType.Queries.GetAllLeaveTypes
{
    //public class GetLeaveTypesQueryRequest : IRequest<List<LeaveTypeDto>>
    //{
    //}

    public record GetLeaveTypesQuery : IRequest<List<LeaveTypeDto>>;
}
