using Default.Domain.Interfaces.Services.Base;
using Default.Infra.Transactions;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Default.Web.Controllers.Base
{
    public class BaseController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private IServiceBase _serviceBase;

        public BaseController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<IActionResult> ResponseAsync(object result, IServiceBase serviceBase)
        {
            _serviceBase = serviceBase;

            if (!serviceBase.Notifications.Any())
            {
                try
                {
                    _unitOfWork.Commit();
                    return Ok(result);
                }
                catch (Exception ex)
                {
                    return BadRequest($"Houve um erro no servidor." + ex.Message);
                }
            }
            else
            {
                return BadRequest(new { erros = serviceBase.Notifications });
            }
        }

        public async Task<IActionResult> ResponseExceptionAsync(Exception ex)
        {
            return BadRequest(new { erros = ex.Message, excepion = ex.ToString() });
        }

        protected override void Dispose(bool disposing)
        {
            if (_serviceBase != null)
                _serviceBase.Dispose();

            base.Dispose(disposing);
        }

    }
}
