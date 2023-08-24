using Metafar_App_Challenge.Models;
using Metafar_App_Challenge.Models.DTO;
using Metafar_App_Challenge.Models.Enum;
using Metafar_Challenge.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Diagnostics;
using WebApp.Models;
using WebApp.WebTools.DataTable;

namespace Metafar_App_Challenge.Controllers
{
    public class ActionsController : Controller
    {
        private readonly ILogger<ActionsController> _logger;

        public ActionsController(ILogger<ActionsController> logger)
        {
            _logger = logger;
        }

        #region Index
        public IActionResult Index(string userId)
        {
            List<ActionDTO> actionList = new List<ActionDTO>(); // for Filter

            //string username = await query from database using userId
            ActionViewModel viewModel = new ActionViewModel()
            {
                username = "replace",
                actions = actionList
            };

            return View(viewModel);
        }
        #endregion

        #region Details
        public async Task<IActionResult> Details(string id)
        {
            ViewData["Title"] = "TestTitle"; // Later
            ViewData["Action"] = "TestAction"; // Later

            //Actions details = await actionService.GetStock(id);

            DetailsViewModel viewModel = new DetailsViewModel()
            {
                //interval = GetIntervalEnums(IntervalEnum.oneMinute.ToString())
            };


            return View("Details", viewModel);
        }

        [HttpPost]
        public async Task<JsonResult> GetFavoriteTableData(DataTableRequest request,
            [FromQuery] string userId)
        {
            List<ActionDTO> favoriteList = new List<ActionDTO>();
            //favoriteList = await logic.GetAllFavoriteActions(
            //favoriteList = await query GetFull(userId);

            //DataTable
            DataTableResponse<Actions, FavoriteRow> response = new DataTableResponse<Actions, FavoriteRow>()
            {
                data = favoriteList.Select(favorite =>
                {
                    FavoriteRow row = new FavoriteRow()
                    {
                        symbol = favorite.Symbol,
                        name = favorite.Name,
                        currency = favorite.Currency,
                        delete = favorite.Delete
                    };
                    return row;
                }),
            };

            return new JsonResult(response);
        }

        [HttpPost]
        public async Task<JsonResult> GetActionsTableData(DataTableRequest request,
            [FromQuery] string nameFilter, [FromQuery] string symbolFilter)
        {
            List<ActionDTO> actionList = new List<ActionDTO>();
            //Call twelvedata
            //actionList = await twelvedataService.GetFull(id);

            //DataTable
            DataTableResponse<Actions, ActionRow> response = new DataTableResponse<Actions, ActionRow>()
            {
                data = actionList.Select(action =>
                {
                    ActionRow row = new ActionRow()
                    {
                        symbol = action.Symbol,
                        name = action.Name,
                        currency = action.Currency,
                        favorite = action.Favorite
                    };
                    return row;
                }),
            };

            return new JsonResult(response);
        }
        #endregion

        private List<SelectListItem> GetIntervalEnums(string selected)
        {
            List<SelectListItem> intervalValues = new List<SelectListItem>()
            {
                new SelectListItem("1 minute", IntervalEnum.oneMinute.ToString()),
                new SelectListItem("5 minutes", IntervalEnum.fiveMinutes.ToString()),
                new SelectListItem("15 minutes", IntervalEnum.fifteenMinutes.ToString()),
            };
            foreach (SelectListItem intervalValue in intervalValues)
            {
                if (!string.IsNullOrEmpty(selected) && intervalValue.Value == selected)
                    intervalValue.Selected = true;
            }
            return intervalValues;
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}