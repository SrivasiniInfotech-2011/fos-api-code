using AutoMapper;
using FOS.Models.Exceptions;
using FOS.Models.Responses;
using System.Net;

namespace FOS.Models.Profiles;

/// <summary>Mapping profile for <see cref="FOSBaseResponse"/></summary>
public sealed class FOSBaseResponseMappingProfile : Profile
{
    /// <summary>
    /// Initializes a new instance of the <see cref="FOSBaseResponseMappingProfile"/> class.
    /// </summary>
    public FOSBaseResponseMappingProfile()
    {
        CreateMap<Exception, FOSBaseResponse>()
            .ForMember(d => d.StatusCode, m => m.MapFrom(_ => HttpStatusCode.InternalServerError))
            .ForMember(d => d.Error, m => m.MapFrom(s => s));

        CreateMap<FOSException, FOSBaseResponse>()
            .ForMember(d => d.StatusCode, m => m.MapFrom(s => s.StatusCode))
            .ForMember(d => d.Error, m => m.MapFrom(s => s));

        CreateMap<FOSMessageHandlerException, FOSBaseResponse>()
            .ForMember(d => d.StatusCode, m => m.MapFrom(s => s.StatusCode))
            .ForMember(d => d.Error, m => m.MapFrom(s => s.Response.Error))
            .ForPath(d => d.Error.InnerError, m => m.MapFrom(s => s.Response.Error.Exception));

        CreateMap<FOSDataException, FOSBaseResponse>()
            .ForMember(d => d.StatusCode, m => m.MapFrom(s => s.StatusCode))
            // #Localize
            .ForPath(d => d.Error.Message, m => m.MapFrom(_ => "Data API service error"))
            .ForPath(d => d.Error.InnerError, m => m.MapFrom(s => s));
    }

    /// <summary>Mapping profile for <see cref="FOSErrorResponse"/></summary>
    public sealed class FOSErrorResponseMappingProfile : Profile
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FOSErrorResponseMappingProfile"/> class.
        /// </summary>
        public FOSErrorResponseMappingProfile()
        {
            CreateMap<FOSException, FOSErrorResponse>()
                .ForMember(d => d.Message, m => m.MapFrom(s => s.Message))
                .ForMember(d => d.Exception, m => m.MapFrom(s => s))
                .ForMember(d => d.InnerError, m => m.MapFrom(s => s.InnerException));

            CreateMap<Exception, FOSErrorResponse>()
                .ForMember(d => d.Message, m => m.MapFrom(s => s.Message))
                .ForMember(d => d.Exception, m => m.MapFrom(s => s))
                .ForMember(d => d.InnerError, m => m.MapFrom(s => s.InnerException));

            CreateMap<FOSDataException, FOSErrorResponse>()
                // #Localize
                .ForPath(d => d.Message, m => m.MapFrom(_ => "REST service error"))
                .ForPath(d => d.InnerError, m => m.MapFrom(s => s));
        }
    }
}