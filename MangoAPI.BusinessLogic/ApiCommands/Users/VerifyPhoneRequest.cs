﻿namespace MangoAPI.BusinessLogic.ApiCommands.Users
{
    using Newtonsoft.Json;

    public record VerifyPhoneRequest
    {
        [JsonConstructor]
        public VerifyPhoneRequest(int confirmationCode)
        {
            ConfirmationCode = confirmationCode;
        }

        public int ConfirmationCode { get; }
    }

    public static class VerifyPhoneCommandMapper
    {
        public static VerifyPhoneCommand ToCommand(this VerifyPhoneRequest model, string userId)
        {
            return new ()
            {
                ConfirmationCode = model.ConfirmationCode,
                UserId = userId,
            };
        }
    }
}
