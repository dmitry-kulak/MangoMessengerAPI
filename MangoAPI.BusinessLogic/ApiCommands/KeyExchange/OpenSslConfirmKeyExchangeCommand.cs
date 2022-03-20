﻿using System;
using MangoAPI.BusinessLogic.Responses;
using MediatR;
using Microsoft.AspNetCore.Http;

namespace MangoAPI.BusinessLogic.ApiCommands.KeyExchange;

public record OpenSslConfirmKeyExchangeCommand : IRequest<Result<ResponseBase>>
{
    public Guid RequestId { get; init; }
    public Guid UserId { get; init; }
    public bool Confirmed { get; init; }
    public IFormFile ReceiverPublicKey { get; init; }
}