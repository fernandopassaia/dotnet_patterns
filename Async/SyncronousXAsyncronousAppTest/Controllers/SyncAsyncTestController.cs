using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace SyncronousXAsyncronousAppTest.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SyncAsyncTestController : ControllerBase
    {
        // Note by Fernando: On Startup i've reduced the ThreadPool of my App to Processor.Count (in case of this AMD, 8).
        // Here in this App, you'll see two endpoints, one that run Sync, and another Async. You'll see that it's possible to run more Async operations, once the Thread goes back to
        // ThreadPool meanwhile the operation (in this case a simple Task.Delay - but it could be a Database operation for example). You'll see that Asyncrounous i can run more tasks...
        // Note: You should run this BackEnd API and use the ConsoleApp to call and test it. You can READ explanation how async runs, when to use it or not, in the README_CSHARP.MD.

        // GET api/values
        [HttpGet]
        // Synchronous
        public IEnumerable<string> Get()
        {
            Thread.Sleep(5000);
            return new string[] { "value1", "value2" };
        }

        // Asynchronous
        // GET api/values/5
        [HttpGet("{id}")]
        public async Task<IEnumerable<string>> Get(int id)
        {
            await Task.Delay(5000);
            return new string[] { "value1", "value2" };
        }
    }
}
