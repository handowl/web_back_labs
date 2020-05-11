using System.Collections.Generic;
using System.Text.Encodings.Web;
using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace WLab1
{
    // You may need to install the Microsoft.AspNetCore.Razor.Runtime package into your project
    [HtmlTargetElement("field")]
    public class FieldTagHelper : TagHelper
    {
        public string Name { get; set; }
        public string Value { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "input";
            output.Attributes.SetAttribute("type", "number");
            output.Attributes.SetAttribute("name", Name);
            if (Value != "0") output.Attributes.SetAttribute("value", Value);
        }
    }

    [HtmlTargetElement("selector")]
    public class SelectorTagHelper : TagHelper
    {
        private List<string> operations;
        public string Name { get; set; }
        public string Default { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            operations = new List<string>() { "+", "-", "*", "/" };

            output.TagName = "select";
            output.Attributes.SetAttribute("name", Name);
            foreach (string item in this.operations) output.Content.AppendHtml(this.generateOptions(item).ToString());
            output.TagMode = TagMode.StartTagAndEndTag;
        }
        private IHtmlContent generateOptions(string item)
        {
            TagBuilder optionTag = new TagBuilder("option");
            optionTag.MergeAttribute("value", item);
            optionTag.InnerHtml.Append(item);
            if (Default == item) optionTag.MergeAttribute("selected", "selected");
            var writer = new System.IO.StringWriter();
            optionTag.WriteTo(writer, HtmlEncoder.Default);
            return new HtmlString(writer.ToString());
        }
    }
}
