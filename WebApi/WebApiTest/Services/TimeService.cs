using System;

namespace WebApiTest.Services
{
    public interface ITimeService
    {
        String Now();
    }

    public class TimeService : ITimeService
    {
        public String Now()
        {
            return DateTime.Now.ToLongTimeString();
        } 
    }
}