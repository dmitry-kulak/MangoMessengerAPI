﻿using System.Threading;
using System.Threading.Tasks;
using MangoAPI.BusinessLogic.ApiCommands.Users;
using MangoAPI.BusinessLogic.Responses;
using MangoAPI.Domain.Constants;
using MangoAPI.Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Http.Internal;
using Microsoft.EntityFrameworkCore;
using Xunit;

namespace MangoAPI.Tests.ApiCommandsTests.UpdatePictureCommandHandlerTests
{
    public class UpdateProfilePictureTestSuccess 
        : ITestable<UpdateProfilePictureCommand, UpdateProfilePictureResponse>
    {
        private readonly MangoDbFixture _mangoDbFixture = new();
        private readonly Assert<UpdateProfilePictureResponse> _assert = new();

        [Fact]
        public async Task UpdateProfilePictureTest_Success()
        {
            Seed();
            var command = new UpdateProfilePictureCommand
            {
                PictureFile = new FormFile(null, 0, 120, null, null),
                UserId = SeedDataConstants.RazumovskyId
            };
            var handler = CreateHandler();

            var result = await handler.Handle(command, CancellationToken.None);
            
            _assert.Pass(result);
        }
        
        public bool Seed()
        {
            _mangoDbFixture.Context.Users.Add(_user);

            _mangoDbFixture.Context.SaveChanges();

            _mangoDbFixture.Context.Entry(_user).State = EntityState.Detached;

            return true;
        }

        public IRequestHandler<UpdateProfilePictureCommand, Result<UpdateProfilePictureResponse>> CreateHandler()
        {
            var blobServiceMock = MockedObjects.GetBlobServiceMock();
            var responseFactory = new ResponseFactory<UpdateProfilePictureResponse>();
            var handler =
                new UpdateProfilePictureCommandHandler(_mangoDbFixture.Context, responseFactory, blobServiceMock);

            return handler;
        }

        private readonly UserEntity _user = new()
        {
            DisplayName = "razumovsky r",
            Bio = "11011 y.o Dotnet Developer from $\"{cityName}\"",
            Id = SeedDataConstants.RazumovskyId,
            UserName = "razumovsky_r",
            Email = "kolosovp95@gmail.com",
            NormalizedEmail = "KOLOSOVP94@GMAIL.COM",
            EmailConfirmed = true,
            PhoneNumberConfirmed = true,
            Image = "razumovsky_picture.jpg"
        };
    }
}