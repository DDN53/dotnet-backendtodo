using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using webapi99.Models;

namespace webapi99.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MobileController : ControllerBase
    {
        private readonly MobileDbContext _mobileDbContext;

        public MobileController(MobileDbContext mobileDbContext) { 
        
        _mobileDbContext = mobileDbContext;
        }
        [HttpGet]
        [Route("GetMobile")]
        public async Task<IEnumerable<Mobile>> GetStudents()
        {
            return await _mobileDbContext.Mobiles.ToListAsync();

        }
        [HttpPost]
        [Route("AddMobile")]
        public async Task<Mobile> AddMobile(Mobile objMobile)
        {
            _mobileDbContext.Mobiles.Add(objMobile);
            await _mobileDbContext.SaveChangesAsync();
            return objMobile;
        }
        [HttpPatch]
        [Route("Update/{id}")]
        public async Task<Mobile> UpdateStudent(Mobile objMobile)
        {
            // _mobileDbContext.Entry(objMobile).State = EntityState.Modified;
            _mobileDbContext.Mobiles.Update(objMobile);
            await _mobileDbContext.SaveChangesAsync();
            Mobile objMobile1 = objMobile;
            return objMobile1;
        }
        [HttpDelete]
        [Route("DeleteMobile/{id}")]
        public bool DeleteMobile(int id)
        {
            bool a = false;
            var mobile = _mobileDbContext.Mobiles.Find(id);
            if (mobile != null)
            {
                a = true;
                //_mobileDbContext.Entry(mobile).State = EntityState.Modified;
                _mobileDbContext.Mobiles.Remove(mobile);
                _mobileDbContext.SaveChanges();

            }
            else
            {
                a = false;

            }
            return a;
        }
    }
}
