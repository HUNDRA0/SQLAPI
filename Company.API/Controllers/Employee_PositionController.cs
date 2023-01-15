using Company.API.Extensions;
using Microsoft.AspNetCore.Mvc;

namespace Company.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Employee_PositionController : Controller
    {
        private readonly IDbService _db;
        public Employee_PositionController(IDbService db) => _db = db;



        //[HttpPost]
        //public async Task<IResult> Post([FromBody] EmployeePositionDTO dto) => await _db.HttpPost<EmployeePositionDTO, EmployeePosition>(dto);


        [HttpPost]
        public async Task<IResult> Post([FromBody] EmployeePositionDTO employeePosition) =>
            await _db.HttpAddAsync<EmployeePosition, EmployeePositionDTO>(employeePosition);


        [HttpDelete("{id}")]
        public async Task<IResult> Delete(EmployeePositionDTO dto) =>
              await _db.HttpDeleteAsyncMany<EmployeePosition, EmployeePositionDTO>(dto);
    }
}

//    using Company.API.Extensions;
//using Microsoft.AspNetCore.Mvc;

//[Route("api/[controller]")]
//[ApiController]
//public class EmployeePositionController : Controller
//{
//    private readonly IDbService _db;
//    public EmployeePositionController(IDbService db) => _db = db;


//    [HttpPost]
//    public async Task<IResult> Post([FromBody] EmployeePosition companyemployee) =>
//        await _db.HttpAddAsync<EmployeePosition, EmployeePositionDTO>(companyemployee);

//    [HttpDelete("{id}")]
//    public async Task<IResult> Delete(EmployeePositionDTO dto) =>
//        await _db.HttpDeleteAsync<EmployeePosition, EmployeePositionDTO>(dto);

//}
//}