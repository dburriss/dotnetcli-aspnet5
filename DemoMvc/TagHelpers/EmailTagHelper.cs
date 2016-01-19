using Microsoft.AspNet.Razor.TagHelpers;
using Microsoft.AspNet.Mvc;
using Microsoft.AspNet.Mvc.Routing;
using Microsoft.AspNet.Mvc.Infrastructure;

namespace DemoMvc.TagHelpers
{
    [HtmlTargetElement("email")]
    [OutputElementHint("email")]
    public class EmailTagHelper : TagHelper
    {
        private readonly IUrlHelper _urlHelper;

        public string Action { get; set; }
        public string Controller { get; set; }
        //public string Area { get; set; }


        public EmailTagHelper(IUrlHelperFactory urlHelperFactory, IActionContextAccessor actionContextAccessor)
        {
            _urlHelper = urlHelperFactory.GetUrlHelper(actionContextAccessor.ActionContext);
        }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "a";
            var url = _urlHelper.Action(Action, Controller);
            output.Attributes["href"] = $"emailto:{url}";
        }
    }
}
