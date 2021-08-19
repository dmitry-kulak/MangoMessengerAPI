﻿namespace MangoAPI.BusinessLogic.ApiQueries.Chats
{
    using System.Collections.Generic;
    using System.Linq;
    using MangoAPI.BusinessLogic.Models;
    using MangoAPI.BusinessLogic.Responses;
    using MangoAPI.Domain.Constants;
    using MangoAPI.Domain.Entities;

    public record GetCurrentUserChatsResponse : ResponseBase<GetCurrentUserChatsResponse>
    {
        // ReSharper disable once UnusedAutoPropertyAccessor.Global
        // ReSharper disable once MemberCanBePrivate.Global
        public List<UserChat> Chats { get; init; }

        public static GetCurrentUserChatsResponse FromSuccess(IEnumerable<UserChatEntity> chats)
        {
            return new ()
            {
                Message = ResponseMessageCodes.Success,
                Success = true,
                Chats = chats.Select(userChatEntity => new UserChat
                {
                    ChatId = userChatEntity.ChatId,
                    Title = userChatEntity.Chat.Title,
                    Image = userChatEntity.Chat.Image,
                    LastMessage = userChatEntity.Chat.Messages.Any()
                        ? userChatEntity.Chat.Messages.OrderBy(messageEntity => messageEntity.Created).Last().Content
                        : null,
                    LastMessageAuthor = userChatEntity.Chat.Messages.Any()
                        ? userChatEntity.Chat.Messages.OrderBy(messageEntity => messageEntity.Created).Last().User
                            .DisplayName
                        : null,
                    LastMessageAt = userChatEntity.Chat.Messages.Any()
                        ? userChatEntity.Chat.Messages.OrderBy(messageEntity => messageEntity.Created).Last().Created
                            .ToShortTimeString()
                        : null,
                    MembersCount = userChatEntity.Chat.MembersCount,
                    IsMember = true,
                }).ToList(),
            };
        }
    }
}
