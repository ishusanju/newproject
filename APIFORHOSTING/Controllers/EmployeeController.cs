using APIFORHOSTING.Model;
using APIFORHOSTING.Services;
using Microsoft.AspNetCore.Mvc;

namespace APIFORHOSTING
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        public readonly EmployeeServices _employeeservices;
        public EmployeeController(EmployeeServices employeeservices)
        {
            _employeeservices = employeeservices;
        }
        [HttpGet]
        public Employee Get(int id)
        {
            return _employeeservices.Get(id);
        }
        [HttpPost]

        public void AddEmp(int ID, string Name, string Address)
        {
            _employeeservices.AddEmp(ID, Name, Address);
        }
        [HttpPost]
        [Route("Update")]
        public void Update(int ID,string Name)
        {
            _employeeservices.Update(ID,Name);
        }
        [HttpDelete]
        public void DeleteEmp(int ID)
        {
            _employeeservices.Delete(ID);
        }

    }
}
