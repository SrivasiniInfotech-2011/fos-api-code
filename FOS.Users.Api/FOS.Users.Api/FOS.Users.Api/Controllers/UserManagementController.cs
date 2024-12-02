using AutoMapper;
using FOS.Infrastructure.Commands;
using FOS.Infrastructure.Queries;
using FOS.Models.Requests;
using FOS.Models.Responses;
using MediatR;

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using static FOS.Models.Constants.Constants;

namespace FOS.Users.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserManagementController : FOSControllerBase
    {


        private readonly IConfiguration _configuration;
        public UserManagementController(IConfiguration configuration, IMediator mediator, IMapper mapper, ILogger<UserManagementController> logger) : base(mediator, logger, mapper)
        {
            _configuration = configuration;
        }

        /// <summary>
        /// Get the UserLevel Lookup.
        /// </summary>
        /// <returns>A <see cref="Task{IActionResult}"/> representing the result of the asynchronous operation.</returns>
        [HttpPost]
        [Route("GetUserlevelLookup")]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(typeof(byte[]), StatusCodes.Status200OK, Web.ContentType.Json)]
        [ProducesResponseType(typeof(FOSBaseResponse), StatusCodes.Status400BadRequest, Web.ContentType.Json)]
        [ProducesResponseType(typeof(FOSBaseResponse), StatusCodes.Status500InternalServerError, Web.ContentType.Json)]

        public async Task<IActionResult> GetUserLevelLookup(UsermanagementLookupRequest usermanagementlookup)
        {
            try
            {
                var query = new UserLevelLookup.Query(usermanagementlookup.UserId,usermanagementlookup.CompanyId);
                var lookup = await FOSMediator.Send(query);

                return Ok(new FOSResponse
                {
                    Status = Status.Success,
                    Message = lookup
                });
            }
            catch (Exception ex)
            {
                return ErrorResponse(new Models.Responses.FOSMessageResponse
                {
                    StatusCode = System.Net.HttpStatusCode.BadRequest,
                    Error = new FOSErrorResponse { Exception = ex }

                });
            }
        }


        /// <summary>
        /// Get the UserDesignationLevel Lookup.
        /// </summary>
        [HttpPost]
        [Route("GetUserdesignationlevel")]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(typeof(byte[]), StatusCodes.Status200OK, Web.ContentType.Json)]
        [ProducesResponseType(typeof(FOSBaseResponse), StatusCodes.Status400BadRequest, Web.ContentType.Json)]
        [ProducesResponseType(typeof(FOSBaseResponse), StatusCodes.Status500InternalServerError, Web.ContentType.Json)]

        public async Task<IActionResult> GetUserdesignationlevelLookup()
        {
            try
            {
                var query = new GetUserdesignationlevelLookups.Query();
                var lookup = await FOSMediator.Send(query);

                return Ok(new FOSResponse
                {
                    Status = Status.Success,
                    Message = lookup
                });
            }
            catch (Exception ex)
            {
                return ErrorResponse(new Models.Responses.FOSMessageResponse
                {
                    StatusCode = System.Net.HttpStatusCode.BadRequest,
                    Error = new FOSErrorResponse { Exception = ex }

                });
            }
        }





        /// <summary>
        /// Creates a User Details ,Insert.
        /// </summary>
        /// <param name="prospectRequest">Prospect Request.</param>
        /// <returns>A <see cref="Task{IActionResult}"/> representing the result of the asynchronous operation.</returns>
        /// <response code="200">Returns the user's requests as a byte array.</response>
        /// <response code="400">If the query is invalid or the message handler response status is not OK.</response>
        /// <response code="401">Returns if the user is unauthorized.</response>
        /// <response code="500">If an internal server error occurs.</response>
        [HttpPost]
        [Route("UserInsert")]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(typeof(byte[]), StatusCodes.Status200OK, Web.ContentType.Json)]
        [ProducesResponseType(typeof(FOSBaseResponse), StatusCodes.Status400BadRequest, Web.ContentType.Json)]
        [ProducesResponseType(typeof(FOSBaseResponse), StatusCodes.Status500InternalServerError, Web.ContentType.Json)]

        public async Task<IActionResult> UserDetailsInsert(CreateProspectRequestModel prospectRequest)
        {
            try
            {
                var command = new CreateProspectCommand.Command(prospectRequest);
                var response = await FOSMediator.Send(command);
                return GenerateResponse(response);
            }
            catch (Exception ex)
            {
                return ErrorResponse(new Models.Responses.FOSMessageResponse
                {
                    StatusCode = System.Net.HttpStatusCode.BadRequest,
                    Error = new FOSErrorResponse { Exception = ex }
                });
            }
        }

    }
}
