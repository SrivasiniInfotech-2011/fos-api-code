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
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Reflection.Metadata;
using System.Security.Claims;
using System.Text;
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
                if (user == null)
                    return new BadRequestObjectResult(new Models.Responses.FOSMessageResponse
                    {
                        StatusCode = System.Net.HttpStatusCode.BadRequest,
                        Error = new FOSErrorResponse
                        {
                            Message = Constants.Messages.INVALID_USER,
                        }
                    });

                var userToken = await IdentityServer4Client.LoginAsync(_configuration[Constants.IdentityServerConfigurationKey]!, loginRequest.UserName, loginRequest.Password);
                user.SessionExpireDate = (DateTime.Now.Ticks / TimeSpan.TicksPerMillisecond) + userToken.ExpiresIn;
                return Ok(new FOSResponse
                {
                    Status = Status.Success,
                    Message = new { User = user, Token = userToken.AccessToken, RefreshToken = userToken.RefreshToken }
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

        [HttpPost]
        [Route("RefreshToken")]
        public async Task<IActionResult> RefreshToken(TokenModel tokenModel)
        {
            if (tokenModel is null)
            {
                return BadRequest("Invalid client request");
            }

            string? accessToken = tokenModel.AccessToken;
            string? refreshToken = tokenModel.RefreshToken;

            var userToken = await IdentityServer4Client.RunRefreshAsync(refreshToken!);
            var sessionExpireDate = (DateTime.Now.Ticks / TimeSpan.TicksPerMillisecond) + userToken.ExpiresIn;
            return Ok(new FOSResponse
            {
                Status = Status.Success,
                Message = new { SessionExpireDate = sessionExpireDate, AccessToken = userToken.AccessToken, RefreshToken = userToken.RefreshToken }
            });
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

        private ClaimsPrincipal? GetPrincipalFromExpiredToken(string? token)
        {
            var tokenValidationParameters = new TokenValidationParameters
            {
                ValidateAudience = false,
                ValidateIssuer = false,
                ValidateIssuerSigningKey = true,
                IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["JWT:Secret"])),
                ValidateLifetime = false
            };

            var tokenHandler = new JwtSecurityTokenHandler();
            var principal = tokenHandler.ValidateToken(token, tokenValidationParameters, out SecurityToken securityToken);
            if (securityToken is not JwtSecurityToken jwtSecurityToken || !jwtSecurityToken.Header.Alg.Equals(SecurityAlgorithms.HmacSha256, StringComparison.InvariantCultureIgnoreCase))
                throw new SecurityTokenException("Invalid token");

            return principal;

        }
    }
}