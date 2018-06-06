using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BtxBlog.Web.TagHelpers
{
    public class MarkdownTagHelper : TagHelper
    {
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            
        }

        public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
        {
            
            var innerContent = await output.GetChildContentAsync(NullHtmlEncoder.Default);

            var content = innerContent.GetContent();

            var html = Markdig.Markdown.ToHtml(content);

            output.Content.SetHtmlContent(html);
           
        }
    }
}
