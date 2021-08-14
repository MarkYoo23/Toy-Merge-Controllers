using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Toy.Sample.Component.Controllers
{
    [Route("sample")]

    public class SampleController : Controller
    {
        [HttpGet("sample-name-collection")]
        public IEnumerable<string> GetSampleNames()
        {
            return new string[] { "test1", "test2" };
        }
    }
}
