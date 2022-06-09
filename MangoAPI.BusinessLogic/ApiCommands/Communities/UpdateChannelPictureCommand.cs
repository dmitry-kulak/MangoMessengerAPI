﻿using MangoAPI.BusinessLogic.Responses;
using MediatR;
using System;
using Microsoft.AspNetCore.Http;

namespace MangoAPI.BusinessLogic.ApiCommands.Communities;

public record UpdateChanelPictureCommand(Guid UserId, Guid ChatId, IFormFile NewGroupPicture, string ContentType) 
    : IRequest<Result<UpdateChannelPictureResponse>>;