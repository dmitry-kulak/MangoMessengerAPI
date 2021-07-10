﻿using System;

namespace MangoAPI.Domain.Constants
{
    public static class EnvironmentConstants
    {
        public static string MangoTokenKey => Environment.GetEnvironmentVariable("MANGO_TOKEN_KEY");
        public static string MangoIssuer => Environment.GetEnvironmentVariable("MANGO_ISSUER");
        public static string MangoAudience => Environment.GetEnvironmentVariable("MANGO_AUDIENCE");
        public static string JwtLifeTime => Environment.GetEnvironmentVariable("JWT_LIFETIME");
        public static string RefreshTokenLifeTime => Environment.GetEnvironmentVariable("REFRESH_TOKEN_LIFETIME");
        public static string DbConnectionString => Environment.GetEnvironmentVariable("DATABASE_URL");
        public static string MangoApiAddress => Environment.GetEnvironmentVariable("MANGO_API_ADDRESS");
        public static string MangoClientAddress => Environment.GetEnvironmentVariable("MANGO_CLIENT_ADDRESS");
    }
}