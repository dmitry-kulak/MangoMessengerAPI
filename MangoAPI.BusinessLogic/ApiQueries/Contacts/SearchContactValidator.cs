﻿using FluentValidation;

namespace MangoAPI.BusinessLogic.ApiQueries.Contacts
{
    public class SearchContactValidator : AbstractValidator<SearchContactQuery>
    {
        public SearchContactValidator()
        {
            RuleFor(x => x.Data)
        }
    }
}