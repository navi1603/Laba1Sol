﻿using Microsoft.AspNetCore.Razor.TagHelpers;
using Microsoft.AspNetCore.Routing;

namespace Laba1.TagHelpers
{
    [HtmlTargetElement(tag: "img", Attributes = "img-action, img-controller")]
    public class ImageTagHelper: TagHelper
    {
        public string ImgAction { get; set; }
        public string ImgController { get; set; }
        LinkGenerator _linkGenerator;
        public ImageTagHelper(LinkGenerator linkGenerator)
        {
            _linkGenerator = linkGenerator;
        }
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            var uri = _linkGenerator.GetPathByAction(ImgAction, ImgController);
            output.Attributes.Add("src", uri);
        }
    }
}
