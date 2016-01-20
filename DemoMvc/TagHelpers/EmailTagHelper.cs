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
        private readonly IEmailAddressService _emailAddressService;

        
        
        public EmailTagHelper(IEmailAddressService emailAddressService, IUrlHelperFactory urlHelperFactory, IActionContextAccessor actionContextAccessor)
        {
            _urlHelper = urlHelperFactory.GetUrlHelper(actionContextAccessor.ActionContext);
            _emailAddressService = emailAddressService;
        }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "a";
            var url = _urlHelper.Action(Action, Controller);
            output.Attributes["href"] = $"emailto:{url}";
        }
    }
}
