using Furino.WebApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewEngines;
using Microsoft.AspNetCore.Mvc.ViewFeatures.Infrastructure;
using Microsoft.AspNetCore.Mvc.ViewFeatures;

namespace Furino.WebApp.Pages;

public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;
    private readonly List<Product> conext_products;
    public List<Product> Products;
    [BindProperty(SupportsGet = true)]
    public int CurrentPage { get; set; } = 1; // Giá trị mặc định là 1

    public int PageSize { get; set; } = 8; // Số sản phẩm mỗi trang
    public IndexModel(ILogger<IndexModel> logger)
    {
        _logger = logger;
        conext_products = new List<Product>();
        conext_products.Add(new Product { IsNew = true, Id = 1, Name = "Syltherine", Description = "Sytylish cafe chair", Price = 2_500_000, OldPrice = 3_500_000 });
        conext_products.Add(new Product { IsNew = true, Id = 2, Name = "Leviosa", Description = "Sytylish cafe chair", Price = 2_500_000, OldPrice = 2_500_000 });
        conext_products.Add(new Product { IsNew = true, Id = 3, Name = "Lolito", Description = "Luxury big sofa", Price = 7000_000, OldPrice = 14000000 });
        conext_products.Add(new Product { IsNew = true, Id = 4, Name = "Respira", Description = "Outdoor bar table and stool", Price = 500000, OldPrice = 500000 });
        conext_products.Add(new Product { IsNew = true, Id = 6, Name = "Grifo", Description = "Night lamp", Price = 1500000, OldPrice = 1500000 });
        conext_products.Add(new Product { IsNew = true, Id = 7, Name = "Muggo", Description = "Small mug", Price = 150000, OldPrice = 150000 });
        conext_products.Add(new Product { IsNew = true, Id = 8, Name = "Pingky", Description = "Cute bed set", Price = 7000_000, OldPrice = 14000000 });
        conext_products.Add(new Product { IsNew = true, Id = 9, Name = "Potty", Description = "Minimalist flower pot", Price = 500000, OldPrice = 500000 });
        conext_products.Add(new Product { IsNew = true, Id = 10, Name = "Syltherine", Description = "Sytylish cafe chair", Price = 2_500_000, OldPrice = 3_500_000 });
        conext_products.Add(new Product { IsNew = true, Id = 11, Name = "Leviosa", Description = "Sytylish cafe chair", Price = 2_500_000, OldPrice = 2_500_000 });
        conext_products.Add(new Product { IsNew = true, Id = 12, Name = "Lolito", Description = "Luxury big sofa", Price = 7000_000, OldPrice = 14000000 });
        conext_products.Add(new Product { IsNew = true, Id = 13, Name = "Respira", Description = "Outdoor bar table and stool", Price = 500000, OldPrice = 500000 });
        conext_products.Add(new Product { IsNew = true, Id = 14, Name = "Grifo", Description = "Night lamp", Price = 1500000, OldPrice = 1500000 });
        conext_products.Add(new Product { IsNew = true, Id = 15, Name = "Muggo", Description = "Small mug", Price = 150000, OldPrice = 150000 });
        conext_products.Add(new Product { IsNew = true, Id = 16, Name = "Pingky", Description = "Cute bed set", Price = 7000_000, OldPrice = 14000000 });
        conext_products.Add(new Product { IsNew = true, Id = 17, Name = "Potty", Description = "Minimalist flower pot", Price = 500000, OldPrice = 500000 });
        conext_products.Add(new Product { IsNew = true, Id = 18, Name = "Syltherine", Description = "Sytylish cafe chair", Price = 2_500_000, OldPrice = 3_500_000 });
        conext_products.Add(new Product { IsNew = true, Id = 19, Name = "Leviosa", Description = "Sytylish cafe chair", Price = 2_500_000, OldPrice = 2_500_000 });
        conext_products.Add(new Product { IsNew = true, Id = 20, Name = "Lolito", Description = "Luxury big sofa", Price = 7000_000, OldPrice = 14000000 });
        conext_products.Add(new Product { IsNew = true, Id = 21, Name = "Respira", Description = "Outdoor bar table and stool", Price = 500000, OldPrice = 500000 });
        conext_products.Add(new Product { IsNew = true, Id = 22, Name = "Grifo", Description = "Night lamp", Price = 1500000, OldPrice = 1500000 });
        conext_products.Add(new Product { IsNew = true, Id = 23, Name = "Muggo", Description = "Small mug", Price = 150000, OldPrice = 150000 });
        conext_products.Add(new Product { IsNew = true, Id = 24, Name = "Pingky", Description = "Cute bed set", Price = 7000_000, OldPrice = 14000000 });
        conext_products.Add(new Product { IsNew = true, Id = 25, Name = "Potty", Description = "Minimalist flower pot", Price = 500000, OldPrice = 500000 });
        conext_products.Add(new Product { IsNew = true, Id = 26, Name = "Syltherine", Description = "Sytylish cafe chair", Price = 2_500_000, OldPrice = 3_500_000 });
        conext_products.Add(new Product { IsNew = true, Id = 27, Name = "Leviosa", Description = "Sytylish cafe chair", Price = 2_500_000, OldPrice = 2_500_000 });
        conext_products.Add(new Product { IsNew = true, Id = 28, Name = "Lolito", Description = "Luxury big sofa", Price = 7000_000, OldPrice = 14000000 });
        conext_products.Add(new Product { IsNew = true, Id = 29, Name = "Respira", Description = "Outdoor bar table and stool", Price = 500000, OldPrice = 500000 });
        conext_products.Add(new Product { IsNew = true, Id = 30, Name = "Grifo", Description = "Night lamp", Price = 1500000, OldPrice = 1500000 });
        conext_products.Add(new Product { IsNew = true, Id = 31, Name = "Muggo", Description = "Small mug", Price = 150000, OldPrice = 150000 });
        conext_products.Add(new Product { IsNew = true, Id = 32, Name = "Pingky", Description = "Cute bed set", Price = 7000_000, OldPrice = 14000000 });
        conext_products.Add(new Product { IsNew = true, Id = 33, Name = "Potty", Description = "Minimalist flower pot", Price = 500000, OldPrice = 500000 });
    }

    public void OnGet()
    {
        Products = conext_products
                       .OrderBy(p => p.Id)
                       .Take(CurrentPage * PageSize) // Tăng số lượng sản phẩm mỗi lần load
                       .ToList();
    }

    public IActionResult OnGetLoadMore(int skip)
    {
        try
        {
            var products = conext_products
                .OrderBy(p => p.Id)
                .Skip(skip)
                .Take(PageSize)
                .ToList();

            if (!products.Any())
            {
                return new JsonResult(new { success = false, message = "Hết sản phẩm!" });
            }

            // Render từng sản phẩm và trả về HTML
            string html = "";
            foreach (var product in products)
            {
                html += RenderPartialViewToString("_ProductCard", product);
            }

            return Content(html, "text/html"); // Trả về HTML cho jQuery AJAX
        }
        catch (Exception ex)
        {
            return new JsonResult(new { success = false, message = "Lỗi Server", error = ex.Message });
        }
    }
    private string RenderPartialViewToString(string viewName, object model)
    {
        var httpContext = HttpContext.RequestServices.GetRequiredService<IHttpContextAccessor>().HttpContext;
        var actionContext = new ActionContext(httpContext, httpContext.GetRouteData(), new PageActionDescriptor());

        var serviceProvider = httpContext.RequestServices;
        var viewEngine = serviceProvider.GetRequiredService<ICompositeViewEngine>();
        var tempDataProvider = serviceProvider.GetRequiredService<ITempDataProvider>();
        var viewDataDictionary = new ViewDataDictionary(new EmptyModelMetadataProvider(), new ModelStateDictionary()) { Model = model };
        var tempDataDictionary = new TempDataDictionary(httpContext, tempDataProvider);

        using (var writer = new StringWriter())
        {
            var viewResult = viewEngine.FindView(actionContext, viewName, false);
            if (viewResult.View == null)
            {
                throw new ArgumentNullException($"{viewName} không tìm thấy!");
            }

            var viewContext = new ViewContext(
                actionContext,
                viewResult.View,
                viewDataDictionary,
                tempDataDictionary,
                writer,
                new HtmlHelperOptions()
            );

            viewResult.View.RenderAsync(viewContext).Wait();
            return writer.ToString();
        }
    }
}
