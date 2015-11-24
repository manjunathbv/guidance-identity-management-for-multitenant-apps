﻿// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using MultiTenantSurveyApp.Common.Configuration;

namespace MultiTenantSurveyApp.Configuration
{
    public class ConfigurationOptions
    {
        public ConfigurationOptions()
        {
            Data = new DatabaseOptions();
            Redis = new RedisOptions();
            AppSettings = new AppSettingsOptions();
            KeyVault = new KeyVaultOptions();
            AzureAd = new AzureAdOptions();
        }

        public DatabaseOptions Data { get; set; }
        public AzureAdOptions AzureAd { get; set; }
        public AppSettingsOptions AppSettings { get; set; }
        public RedisOptions Redis { get; set; }
        public KeyVaultOptions KeyVault { get; set; }
    }
}