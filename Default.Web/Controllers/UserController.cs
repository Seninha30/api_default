using Default.Domain.Interfaces;
using Default.Domain.Interfaces.Services.Base;
using Default.Infra.Transactions;
using Default.Web.Controllers.Base;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace Default.Web.Controllers
{
    public class UserController : BaseController
    {

        private readonly IUserService _userService;

        public UserController(IUserService userService, IUnitOfWork unitOfWork) : base(unitOfWork)
        {
            _userService = userService;
        }

        [HttpPost]
        [Route("api/v1/Adicionar")]
        public async Task<IActionResult> Adicionar([FromBody] UserRequest user)
        {
            try
            {
                var response = _userService.AddUser(user);
                return await ResponseAsync(response, _userService);
            }
            catch (Exception ex)
            {
                return await ResponseExceptionAsync(ex);
            }
        }
    }
}
