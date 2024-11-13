using AutoMapper;
using FOS.Infrastructure.Queries;
using FOS.Infrastructure.Services.IdentityServices;
using FOS.Infrastructure.Services.Utils;
using FOS.Models.Constants;
using FOS.Models.Entities;
using FOS.Models.Requests;
using FOS.Models.Responses;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata;
using static FOS.Models.Constants.Constants;

namespace FOS.Users.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : FOSControllerBase
    {
        private readonly IConfiguration _configuration;
        /// <summary>
        /// Constructor For ApartmentsController
        /// </summary>
        /// <param name="mediator"></param>
        public UsersController(IConfiguration configuration, IMediator mediator, IMapper mapper, ILogger<UsersController> logger) : base(mediator, logger, mapper)
        {
            _configuration = configuration;
        }

        /// <summary>
        /// Get All Users.
        /// </summary>
        /// <param name="query"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("GetAllUsers")]
        public async Task<IActionResult> GetAllUsers()
        {
            //var apartments = await mediator.Send(new GetAllUsers.Query());

            //return Ok(apartments);
            return Ok();
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
        [HttpPost]
        [Route("GetUserByUserNameAndPassword")]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(typeof(byte[]), StatusCodes.Status200OK, Web.ContentType.Json)]
        [ProducesResponseType(typeof(FOSBaseResponse), StatusCodes.Status400BadRequest, Web.ContentType.Json)]
        [ProducesResponseType(typeof(FOSBaseResponse), StatusCodes.Status500InternalServerError, Web.ContentType.Json)]

        public async Task<IActionResult> GetUserById(LoginRequest loginRequest)
        {
            try
            {
                ArgumentNullException.ThrowIfNull(loginRequest.UserName, nameof(loginRequest.UserName));
                ArgumentNullException.ThrowIfNull(loginRequest.Password, nameof(loginRequest.Password));
                var query = new GetUserByUserNameAndPassword.Query(loginRequest.UserName, loginRequest.Password);
                var user = await FOSMediator.Send(query);
                if (user == null || (user != null && AppUtil.DecryptString(user.Passsword) != loginRequest.Password))
                    return new BadRequestObjectResult(new Models.Responses.FOSMessageResponse
                    {
                        StatusCode = System.Net.HttpStatusCode.BadRequest,
                        Error = new FOSErrorResponse
                        {
                            Message = Constants.Messages.INVALID_USER,
                        }
                    });

                    var userToken = await IdentityServer4Client.LoginAsync(_configuration[Constants.IdentityServerConfigurationKey]!, loginRequest.UserName, loginRequest.Password);
                    return Ok(new FOSResponse
                    {
                        Status = Status.Success,
                        Message = new { User = user, Token = userToken.AccessToken }
                    });
                }
            catch (Exception ex)
            {
                return ErrorResponse(new Models.Responses.FOSMessageResponse
                {
                    StatusCode = System.Net.HttpStatusCode.BadRequest,
                    Error = new FOSErrorResponse { Exception = ex },
                    Request = loginRequest,

                });
            }
        }


        /// <summary>
        /// Create an User.
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("CreateUser")]
        public async Task<IActionResult> CreateApartment([FromBody] User user)
        {
            //var newUser = await mediator.Send(new CreateUser.Command(user));

            //return Ok(newUser);
            return Ok();
        }

        /// <summary>
        /// Update a User.
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        [HttpPut]
        [Route("UpdateUser/{id}")]
        public async Task<IActionResult> UpdateApartment(int id, [FromBody] User user)
        {
            //user.UserId = id;
            //await mediator.Send(new UpdateUser.Command(user));

            //return Ok("Success");
            return Ok();
        }

        /// <summary>
        /// DeActivate a User.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete]
        [Route("DeactivateUser/{id}")]
        public async Task<IActionResult> DeactivateUser([FromQuery] int id)
        {
            //await mediator.Send(new DeActivateUser.Command(id));

            //return Ok("Success");
            return Ok();
        }
    }
}