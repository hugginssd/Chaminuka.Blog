#pragma checksum "C:\Users\Administrator\source\repos\WebApplication3\Views\Profile\MyProfile.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d978ff8c84125cd8d78183cfd4729557b9cbc824"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Profile_MyProfile), @"mvc.1.0.view", @"/Views/Profile/MyProfile.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\Administrator\source\repos\WebApplication3\Views\_ViewImports.cshtml"
using WebApplication3;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Administrator\source\repos\WebApplication3\Views\_ViewImports.cshtml"
using WebApplication3.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Administrator\source\repos\WebApplication3\Views\_ViewImports.cshtml"
using WebApplication3.Models.Comments;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Administrator\source\repos\WebApplication3\Views\_ViewImports.cshtml"
using WebApplication3.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Administrator\source\repos\WebApplication3\Views\Profile\MyProfile.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d978ff8c84125cd8d78183cfd4729557b9cbc824", @"/Views/Profile/MyProfile.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"95760f8a83ab7795cd7ef6e81f11c70072b293e4", @"/Views/_ViewImports.cshtml")]
    public class Views_Profile_MyProfile : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProfileViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("a"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString(@"display: inline-block;
                                                       border-radius: 24px;
                                                       background-color: #fff !important;
                                                       border: solid 1px #e6e6e6;
                                                       padding: 4px 6px;
                                                       margin-right: 4px;
                                                       font-size: 15px;
                                                       text-decoration: underline;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-dark"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Profile", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Update", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 6 "C:\Users\Administrator\source\repos\WebApplication3\Views\Profile\MyProfile.cshtml"
  
    ViewData["Title"] = "My profile";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"


<div class=""container"">
    <div class=""row"">
        <div class=""col"">

            <div class=""text-left mt-lg-5 mb-lg-5"">
                <h1 class=""display-3"" style=""font-size: 30px; margin-top:20px;"">My profile</h1>
                <p class=""display-4"" style=""font-size: 25px;"">Bio</p>
                <p>
                    Professional Software Engineer and developer who focused on the Microsoft stack of technologies with significant experience ranging from Microsoft Dynamics AX 2009,
                    Microsoft Dynamics AX 2012 Dynamics 365 Finance and Operations , Supply Chain Management, Azure Cloud, and Azure DevOps.
                </p>

                <p>
                    For more than 5 years, I have installed, configured, developed, and managed business-critical systems for plenty of companies. During this time,
                    I am working across many industries, including manufacturing, distribution, finance, and professional services.
                </p>

   ");
            WriteLiteral(@"         </div>

            <ul class=""nav nav-tabs"" id=""myTab"" role=""tablist"">
                <li class=""nav-item"">
                    <a class=""nav-link active"" id=""home-tab"" data-toggle=""tab"" href=""#home"" role=""tab"" aria-controls=""home"" aria-selected=""true"">
                        Activity
                    </a>
                </li>
                <li class=""nav-item"">
                    <a class=""nav-link"" id=""profile-tab"" data-toggle=""tab"" href=""#profile"" role=""tab"" aria-controls=""profile"" aria-selected=""false"">
                        Badges
                    </a>
                </li>
                <li class=""nav-item"">
                    <a class=""nav-link"" id=""contact-tab"" data-toggle=""tab"" href=""#contact"" role=""tab"" aria-controls=""contact"" aria-selected=""false"">
                        Groups
                    </a>
                </li>
                <li class=""nav-item"">
                    <a class=""nav-link"" id=""friends-tab"" data-toggle=""tab"" href=""#friends"" r");
            WriteLiteral(@"ole=""tab"" aria-controls=""friends"" aria-selected=""false"">
                        Friends
                    </a>
                </li>
                <li class=""nav-item"">
                    <a class=""nav-link"" id=""likes-tab"" data-toggle=""tab"" href=""#likes"" role=""tab"" aria-controls=""likes"" aria-selected=""false"">
                        Likes
                    </a>
                </li>
                <li class=""nav-item"">
                    <a class=""nav-link"" id=""posts-tab"" data-toggle=""tab"" href=""#posts"" role=""tab"" aria-controls=""posts"" aria-selected=""false"">
                        Posts
                    </a>
                </li>
            </ul>
            <div class=""tab-content"" id=""myTabContent"">
                <div class=""tab-pane fade show active"" id=""home"" role=""tabpanel"" aria-labelledby=""home-tab"">
                    <ul class=""mt-3"">
");
#nullable restore
#line 74 "C:\Users\Administrator\source\repos\WebApplication3\Views\Profile\MyProfile.cshtml"
                         foreach (var post in Model.Posts.Where(un => un.UserId == UserManager.Users.FirstOrDefault().Id))
                        {


#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"blog-listing pb-0\">\r\n\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d978ff8c84125cd8d78183cfd4729557b9cbc82410696", async() => {
                WriteLiteral("\r\n                                    <h3 class=\"post-title display-3\" style=\"font-size: 24px; color: #16568A;\">\r\n                                        ");
#nullable restore
#line 81 "C:\Users\Administrator\source\repos\WebApplication3\Views\Profile\MyProfile.cshtml"
                                   Write(post.Title);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                    </h3>\r\n                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 79 "C:\Users\Administrator\source\repos\WebApplication3\Views\Profile\MyProfile.cshtml"
                                                                                       WriteLiteral(post.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n                                <p class=\"post-subtitle\">\r\n                                    ");
#nullable restore
#line 86 "C:\Users\Administrator\source\repos\WebApplication3\Views\Profile\MyProfile.cshtml"
                               Write(post.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                </p>

                                <p class=""post-meta"">
                                    <footer class=""blockquote-footer"">
                                        <cite title=""Posted by"" style=""margin-left:15px;"">
                                            Posted on ");
#nullable restore
#line 92 "C:\Users\Administrator\source\repos\WebApplication3\Views\Profile\MyProfile.cshtml"
                                                 Write(post.Created);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </cite>\r\n\r\n");
#nullable restore
#line 95 "C:\Users\Administrator\source\repos\WebApplication3\Views\Profile\MyProfile.cshtml"
                                             if (!String.IsNullOrEmpty(post.Tags))
                                            {
                                                string[] tags = @post.Tags.Split(',');
                                                foreach (var tag in tags)
                                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d978ff8c84125cd8d78183cfd4729557b9cbc82415273", async() => {
#nullable restore
#line 109 "C:\Users\Administrator\source\repos\WebApplication3\Views\Profile\MyProfile.cshtml"
                                                                                                   Write(tag);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-tag", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 109 "C:\Users\Administrator\source\repos\WebApplication3\Views\Profile\MyProfile.cshtml"
                                                                                WriteLiteral(post.Tags);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["tag"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-tag", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["tag"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 110 "C:\Users\Administrator\source\repos\WebApplication3\Views\Profile\MyProfile.cshtml"
                                                }
                                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            </footer>\r\n                                </p>\r\n                            </div>\r\n                            <hr>\r\n");
#nullable restore
#line 116 "C:\Users\Administrator\source\repos\WebApplication3\Views\Profile\MyProfile.cshtml"

                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    </ul>
                </div>
                <div class=""tab-pane fade"" id=""profile"" role=""tabpanel"" aria-labelledby=""profile-tab"">
                    <div class=""row mt-3"">
                        <div style=""width: 18rem"">
                            <img src=""https://images.youracclaim.com/size/680x680/images/11636db1-f9fa-4669-b13c-9a15f0d81ab0/EXAM-Associate-MB-500.png""
                                 class=""card-img-top""
                                 alt=""..."" />
                        </div>
                        <div style=""width: 18rem"">
                            <img src=""https://images.youracclaim.com/size/680x680/images/11636db1-f9fa-4669-b13c-9a15f0d81ab0/EXAM-Associate-MB-500.png""
                                 class=""card-img-top""
                                 alt=""..."" />
                        </div>
                    </div>
                </div>
                <div class=""tab-pane fade"" id=""contact"" role=""tabpanel"" aria-labelledby=""cont");
            WriteLiteral(@"act-tab"">
                    <div class=""mt-3"">
                        No friends yet
                    </div>
                </div>
                <div class=""tab-pane fade"" id=""friends"" role=""tabpanel"" aria-labelledby=""friends-tab"">
                    <div class=""mt-3"">
                        No groups yet
                    </div>
                </div>
                <div class=""tab-pane fade"" id=""likes"" role=""tabpanel"" aria-labelledby=""likes-tab"">
                    <div class=""mt-3"">
                        No likes yet
                    </div>
                </div>
                <div class=""tab-pane fade"" id=""posts"" role=""tabpanel"" aria-labelledby=""posts-tab"">
                    <div class=""mt-3"">
                        No posts
                    </div>
                </div>
            </div>
        </div>
        <div class=""col-md-auto"">
            <div class=""mt-5"" style=""width: 18rem; padding-top: 30px;"">
                <img src=""https://lledogrupo.c");
            WriteLiteral(@"om/wp-content/uploads/2018/04/user-img-1.png""
                     style=""width:85px; height:85px; margin-top:45px; margin-left:40px;""
                     class=""card-img-top rounded-circle"" alt=""..."">
                <div class=""card-body"">
                    <h5 class=""display-3 ml-3"" style=""font-size: 20px;"">Profile photo</h5>
                </div>
            </div>
            <div class=""ml-4"">
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d978ff8c84125cd8d78183cfd4729557b9cbc82421202", async() => {
                WriteLiteral("\r\n                    Edit my profile\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-username", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 166 "C:\Users\Administrator\source\repos\WebApplication3\Views\Profile\MyProfile.cshtml"
                                                                                                     WriteLiteral(User.Identity.Name);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["username"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-username", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["username"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public UserManager<ApplicationUsers> UserManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SignInManager<ApplicationUsers> SignInManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProfileViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
