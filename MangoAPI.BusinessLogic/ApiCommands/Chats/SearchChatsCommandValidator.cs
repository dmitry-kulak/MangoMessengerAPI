﻿namespace MangoAPI.BusinessLogic.ApiCommands.Chats
{
    using System;
    using FluentValidation;

    public class SearchChatsCommandValidator : AbstractValidator<SearchChatsCommand>
    {
        public SearchChatsCommandValidator()
        {
            RuleFor(x => x.DisplayName)
                .Cascade(CascadeMode.Stop)
                .NotEmpty()
                .Length(1, 300);

            RuleFor(x => x.UserId).Must(x => Guid.TryParse(x, out _))
                .WithMessage("SearchChatsQueryValidator: User Id cannot be parsed.");
        }
    }
}
