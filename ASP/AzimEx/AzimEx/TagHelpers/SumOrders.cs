using Microsoft.AspNetCore.Razor.TagHelpers;

namespace AzimEx.TagHelpers
{
    [HtmlTargetElement("sumorders")]
    public class SumOrders : ITagHelper
    {
        public int Order => throw new NotImplementedException();

        public void Init(TagHelperContext context)
        {
            throw new NotImplementedException();
        }
    
        public Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "sumorders";
            output.TagMode = TagMode.SelfClosing;
            output.PreContent.Append("1000");

            return Task.CompletedTask;
        }
    }
}
