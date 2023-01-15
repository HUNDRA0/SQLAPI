using Company.API.Extensions;
using Microsoft.AspNetCore.Mvc;

namespace Company.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    
    public class PositionController : Controller
    {
        private readonly IDbService _db;
        public PositionController(IDbService db) => _db = db;
       
        [HttpGet]
        public async Task<IResult> Get() => await _db.HttpGetAsync<Position, PositionDTO>();

     
        [HttpGet("{id}")]
        public async Task<IResult> Get(int id) => await _db.HttpGetSingleAsync<Position, PositionDTO>(id);


        
        [HttpPost]
        public async Task<IResult> Post([FromBody] PositionDTO dto) => await _db.HttpPost<Position, PositionDTO>(dto);


        
        [HttpPut("{id}")]
        public async Task<IResult> Put(int id, [FromBody] PositionDTO dto) => await _db.HttpPut<Position, PositionDTO>(id, dto);


        
        [HttpDelete("{id}")]
        public async Task<IResult> Delete(int id) => await _db.HttpDeleteAsync<Position>(id);
    }
}
