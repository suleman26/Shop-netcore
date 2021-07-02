﻿using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dutch_retreat.Services
{
    public class NullMailService : IMailService
    {
        private readonly ILogger<NullMailService> _logger;

        public NullMailService(ILogger<NullMailService> logger)
        {
            _logger = logger;
        }
        public void SendMessage(string To, string Subject, string Body)
        {
            //
        }
        
        
    }
}
