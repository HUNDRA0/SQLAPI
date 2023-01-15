using Company.API.Extensions;
using Microsoft.AspNetCore.Mvc;

namespace Company.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : Controller
    {
        private readonly IDbService _db;
        public EmployeeController(IDbService db) => _db = db;
       
        [HttpGet]
        public async Task<IResult> Get() => await _db.HttpGetAsync<Employee, EmployeeDTO>();

        
        [HttpGet("{id}")]
        public async Task<IResult> Get(int id) => await _db.HttpGetSingleAsync<Employee, EmployeeController>(id);


        [HttpPost]
        public async Task<IResult> Post([FromBody] EmployeeDTO dto) => await _db.HttpPost<Employee, EmployeeDTO>(dto);


        
        [HttpPut("{id}")]
        public async Task<IResult> Put(int id, [FromBody] EmployeeDTO dto) => await _db.HttpPut<Employee, EmployeeDTO>(id, dto);


        
        [HttpDelete("{id}")]
        public async Task<IResult> Delete(int id) => await _db.HttpDeleteAsync<Employee>(id);


    }
}
