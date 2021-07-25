﻿using System.Threading;
using System.Threading.Tasks;
using MangoAPI.DTO.Commands.Chats;
using Microsoft.AspNetCore.Mvc;

namespace MangoAPI.WebApp.Interfaces
{
    public interface IChatsController
    {
        Task<IActionResult> GetChats(CancellationToken cancellationToken);
        Task<IActionResult> CreateChat(CreateGroupCommand command, CancellationToken cancellationToken);
        Task<IActionResult> CreateDirectChat(CreateDirectChatCommand command, CancellationToken cancellationToken);
        Task<IActionResult> JoinChat(JoinChatCommand command, CancellationToken cancellationToken);
    }
}