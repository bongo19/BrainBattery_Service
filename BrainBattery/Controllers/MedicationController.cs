using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace BrainBattery.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MedicationController : ControllerBase
    {
        private readonly ILogger<MedicationController> _logger;

        public MedicationController(ILogger<MedicationController> logger)
        {
            _logger = logger;
        }

        public List<Medication>GetMedicationList()

    }
}
