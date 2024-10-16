using Blazored.LocalStorage;
using HRLeaveManagement.BlazorUI.Contracts;
using HRLeaveManagement.BlazorUI.Services.Base;

namespace HRLeaveManagement.BlazorUI.Services
{
    public class LeaveAllocationService : BaseHttpService, ILeaveAllocationService
    {
        public LeaveAllocationService(IClient client, ILocalStorageService localStorage) : 
            base(client, localStorage)
        {

        }

        public async Task<Response<Guid>> CreateLeaveAllocation(int leaveTypeId)
        {
            try
            {
                var response = new Response<Guid>();
                CreateLeaveAllocationCommand createLeaveAllocationCommand = new() { LeaveTypeId = leaveTypeId };
                await _client.LeaveAllocationsPOSTAsync(createLeaveAllocationCommand);

                return response;
            }
            catch (ApiException ex)
            {
                return ConvertApiException<Guid>(ex);
            }
        }
    }
}
