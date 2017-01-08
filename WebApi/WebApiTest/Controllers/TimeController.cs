﻿using System.Web.Http;
using WebApiTest.Services;

namespace WebApiTest.Controllers
{
    public class TimeController : ApiController
    {
        private readonly ITimeService _timeService;

        public TimeController(ITimeService timeService)
        {
            _timeService = timeService;
        }

        // GET: api/Time
        public string Get()
        {
            return _timeService.Now();
        }
    }
}
