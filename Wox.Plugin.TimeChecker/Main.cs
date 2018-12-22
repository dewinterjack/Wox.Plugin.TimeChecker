using System;
using System.Collections.Generic;

namespace Wox.Plugin.TimeChecker
{
    class Main : IPlugin
    {
        public void Init(PluginInitContext context) { }
        public List<Result> Query(Query query)
        {
            return new List<Result>
            {
                new Result
                {
                    Title = $"The time is:{DateTime.Now.ToString("t")}",
                    IcoPath = "timeIcon.png",
                    Action = _ =>
                    {
                        return true;
                    }
                },

                new Result
                {
                    Title = $"The date: {DateTime.Today.ToString("d")}",
                    IcoPath = "calendarIcon.png",
                    Action = _ =>
                    {
                        return true;
                    }
                }
            };
        }
    }
}
