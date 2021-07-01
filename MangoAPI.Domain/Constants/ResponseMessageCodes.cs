﻿namespace MangoAPI.Domain.Constants
{
    public static class ResponseMessageCodes
    {
        public const string Success = "SUCCESS";
        public const string InvalidOrEmptyRefreshToken = "INVALID_OR_EMPTY_REFRESH_TOKEN";
        public const string SuspiciousAction = "SUSPICIOUS_ACTION";
        public const string UserAlreadyRegistered = "USER_ALREADY_REGISTERED";
        public const string TermsNotAccepted = "TERMS_NOT_ACCEPTED";
        public const string InvalidEmail = "INVALID_EMAIL";
        public const string InvalidPassword = "INVALID_PASSWORD";
        public const string ConfirmRegisterInvalidIdentifier = "INVALID_CONFIRMATION_IDENTIFIER";
        public const string UserUnverified = "UNVERIFIED_USER";
        public const string WeakPassword = "WEAK_PASSWORD";
        public const string InvalidUserId = "INVALID_USER_ID";
        public const string UserNotFound = "USER_NOT_FOUND";
        public const string EmailAlreadyVerified = "EMAIL_ALREADY_VERIFIED";
        public const string PhoneAlreadyVerified = "PHONE_ALREADY_VERIFIED";
        public const string InvalidOrEmptyGroupTitle = "INVALID_OR_EMPTY_GROUP_TITLE";
        public const string InvalidGroupType = "INVALID_GROUP_TYPE";
    }
}