﻿using System.Collections.Generic;

namespace $safeprojectname$.Configuration
{
    public class IdpConfig
    {
        public string AppName { get; set; }
        public string SwaggerClientId { get; set; }
        public string SwaggerClientSecret { get; set; }
        public string ApiName { get; set; }
        public string ServerUrl { get; set; }
        public string AuthorizationUrl { get; set; }
        public string TokenUrl { get; set; }
        public Dictionary<string, string> Scopes { get; set; }
    }
}