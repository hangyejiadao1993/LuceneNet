using System;
using System.Net;
using Microsoft.Extensions.Configuration;

namespace NCL.Helper
{
    public class ConfigHelper
    {
        private ConfigHelper()
        {
        }

        private IConfigurationRoot _configuration;

        private static ConfigHelper _configHelper = new ConfigHelper();

        public static ConfigHelper GetInstance(string fileName)
        {
            var directory = AppContext.BaseDirectory;
            directory = directory.Replace("\\", "/");

            var filePath = $"{directory}/{fileName}";
            var builder = new ConfigurationBuilder()
                .AddJsonFile(filePath, false, true);
            _configHelper._configuration = builder.Build();
            return _configHelper;
        }


        public string GetValue(string key)
        {
            return _configHelper._configuration.GetSection(key).Value;
        }
    }
}