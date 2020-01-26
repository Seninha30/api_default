using Default.Domain.Interfaces.Services.Base;
using Default.Infra.Transactions;
using Log4Net_Logging;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using System.Reflection;
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
            LogFourNet.SetUp(Assembly.GetEntryAssembly(), "Log4net.Config");
        }

        public async Task<IActionResult> ResponseAsync(object result, IServiceBase serviceBase)
        {
            _serviceBase = serviceBase;

            if (!serviceBase.Notifications.Any())
            {
                try
                {
                    LogFourNet.Info(this, "Adicionando usuários");
                    _unitOfWork.Commit();
                    return Ok(result);
                }
                catch (Exception ex)
                {
                    LogFourNet.Error(ex, ex.Message);
                    return BadRequest($"Houve um erro no servidor." + ex.Message);
                }
            }
            else
            {
                foreach (var item in serviceBase.Notifications)
                    LogFourNet.Error(this, item.Message);


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