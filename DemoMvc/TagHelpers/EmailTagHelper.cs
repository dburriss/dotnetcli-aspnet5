using DemoMvc.Abstractions;
using Microsoft.AspNet.Razor.TagHelpers;

namespace DemoMvc.TagHelpers
{
    [HtmlTargetElement("email")]
    [OutputElementHint("email")]
    public class EmailTagHelper : TagHelper
    {
        private readonly IEmailAddressService _emailAddressService;

        public string Department { get; set; }

        public EmailTagHelper(IEmailAddressService emailAddressService)
        {
            _emailAddressService = emailAddressService;
        }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "a";
            var url = _emailAddressService.GetEmail(Department);
            output.Attributes["href"] = $"emailto:{url}";
        }
    }
}
