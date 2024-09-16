using Microsoft.AspNetCore.Mvc;

namespace ApiSSK.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MelhorVoltaDescController : ControllerBase
    {
        [HttpGet]
        public async Task<ActionResult<List<MelhorVoltaDescModel>>> GetAllMelhoresVoltasDesc()
        {
            var mv = new List<MelhorVoltaDescModel>()
            {
                new MelhorVoltaDescModel()
                {
                    MvdId = 1,
                    MvdDesc = "Estreia",
                },
                new MelhorVoltaDescModel()
                {
                    MvdId = 2,
                    MvdDesc = "Recorde",
                },
                new MelhorVoltaDescModel()
                {
                    MvdId = 3,
                    MvdDesc = "MV Seco",
                },
                new MelhorVoltaDescModel()
                {
                    MvdId = 4,
                    MvdDesc = "MV Misto",
                },
                new MelhorVoltaDescModel()
                {
                    MvdId = 5,
                    MvdDesc = "MV Chuva",
                }
            };

            return Ok(mv);
        }
    }
}
