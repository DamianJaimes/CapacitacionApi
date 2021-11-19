using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MarcasApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MarcaController : ControllerBase
    {

        [HttpGet]
         public async Task<ActionResult> Get() 
        { 
            List<dynamic> Marcas=new List<dynamic>();
            Marcas.Add(new{id=1, marca="Bajaj", paisOrigen="India",añoFundacion=1945});
            Marcas.Add(new{id=2, marca="Daelim", paisOrigen="Corea del Sur",añoFundacion=1978});
            Marcas.Add(new{id=3, marca="Honda", paisOrigen="Japon",añoFundacion=1948});
            Marcas.Add(new{id=4, marca="Yamaha", paisOrigen="Japon",añoFundacion=1887});
            Marcas.Add(new{id=5, marca="Suzuki", paisOrigen="Japon",añoFundacion=1909});
            Marcas.Add(new{id=6, marca="Kawasaki", paisOrigen="Japon",añoFundacion=1896});
            Marcas.Add(new{id=7, marca="Harley Davidson", paisOrigen="USA",añoFundacion=1903});
            Marcas.Add(new{id=8, marca="Zanella", paisOrigen="Argentina",añoFundacion=1948});
            return Ok(Marcas);
            
        }
    }
}