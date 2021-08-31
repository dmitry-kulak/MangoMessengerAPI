﻿using System.Threading;
using System.Threading.Tasks;
using MangoAPI.BusinessLogic.ApiCommands.UserChats;
using Microsoft.AspNetCore.Mvc;

namespace MangoAPI.Presentation.Interfaces
{
    public interface IUserChatsController
    {
        Task<IActionResult> JoinChatAsync(string chatId, CancellationToken cancellationToken);
        Task<IActionResult> LeaveGroup(string chatId, CancellationToken cancellationToken);
        Task<IActionResult> ArchiveChat(ArchiveChatRequest request, CancellationToken cancellationToken);
    }
}
