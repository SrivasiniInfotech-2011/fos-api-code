using FOS.Infrastructure.Queries;
using FOS.Models.Responses;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using static FOS.Models.Constants.Constants;

namespace FOS.Users.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class HomeController : FOSControllerBase
    {
        /// <summary>
        /// Constructor For <see cref="HomeController"/>
        /// </summary>
        /// <param name="mediator"></param>
        public HomeController(IMediator mediator, ILogger<UsersController> logger) : base(mediator, logger)
        {

        }
        /// <summary>
        /// Gets the user's details.
        /// </summary>
        /// <param name="loginRequest">The query containing the search filters to be applied to the user's requests.</param>
        /// <returns>A <see cref="Task{IActionResult}"/> representing the result of the asynchronous operation.</returns>
        /// <response code="200">Returns the user's requests as a byte array.</response>
        /// <response code="400">If the query is invalid or the message handler response status is not OK.</response>
        /// <response code="401">Returns if the user is unauthorized.</response>
        /// <response code="500">If an internal server error occurs.</response>
        [HttpGet("GetUserMenus/{userId}",Name ="UserMenus")]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(typeof(byte[]), StatusCodes.Status200OK, Web.ContentType.Json)]
        [ProducesResponseType(typeof(FOSBaseResponse), StatusCodes.Status400BadRequest, Web.ContentType.Json)]
        [ProducesResponseType(typeof(FOSBaseResponse), StatusCodes.Status500InternalServerError, Web.ContentType.Json)]

        public async Task<IActionResult> GetUserMenus(int? userId)
        {
            try
            {
                ArgumentNullException.ThrowIfNull(userId, nameof(userId));
                var query = new GetUserMenusByUserId.Query(userId.Value);
                var userMenus = await FOSMediator.Send(query);
                return Ok(new FOSResponse
                {
                    Status = Status.Success,
                    Message = new { UserMenus = userMenus }
                });
            }
            catch (Exception ex)
            {
                return ErrorResponse(new Models.Responses.FOSMessageResponse
                {
                    StatusCode = System.Net.HttpStatusCode.BadRequest,
                    Error = new FOSErrorResponse { Exception = ex },
                    Request = userId
                });
            }
        }
    }
}
