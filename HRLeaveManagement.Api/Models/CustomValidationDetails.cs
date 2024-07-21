using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace HRLeaveManagement.Api.Models
{
    public class CustomProblemDetails : ProblemDetails
    {
        public IDictionary<string, string[]> Errors { get; set; } = new Dictionary<string, string[]>();
    }
}
