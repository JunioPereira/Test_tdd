using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Test_tdd.Challenge;

namespace Test_tdd.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ChallengeController : ControllerBase
    {
        private readonly ILogger<ChallengeController> _logger;
        private readonly IChallengeService _iChallengeService;

        public ChallengeController(ILogger<ChallengeController> logger, IChallengeService iChallengeService)
        {
            _logger = logger;
            _iChallengeService = iChallengeService;
        }

        [HttpGet]
        public string Get()
        {
            return "ok";
        }

        [HttpGet, Route("1")]
        public int Outlier()
        {
            List<int> _lst = new List<int>();
            _lst.Add(2);
            _lst.Add(3);
            _lst.Add(4);
            _lst.Add(6);
            _lst.Add(8);

            return _iChallengeService.Outlier(_lst);
        }

        [HttpGet, Route("2")]
        public int[] GetIntegerList()
        {
            List<object> _lst = new List<object>();
            _lst.Add(2);
            _lst.Add("Junio");
            _lst.Add(4);
            _lst.Add("Cesar");
            _lst.Add(6);
            _lst.Add("Pereira");
            _lst.Add(8);

            return _iChallengeService.GetIntegerList(_lst);
        }

        [HttpGet, Route("3")]
        public string FormatWords()
        {
            return _iChallengeService.FormatWords(new string[] { "junio", "cesar", "pereira" });
        }
    }
}
