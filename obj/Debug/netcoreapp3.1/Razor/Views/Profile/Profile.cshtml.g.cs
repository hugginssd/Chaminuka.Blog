#pragma checksum "C:\Users\Administrator\source\repos\WebApplication3\Views\Profile\Profile.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b78e023c0ee4cd7e609fbb9fbd38b3f2d6fe5aa2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Profile_Profile), @"mvc.1.0.view", @"/Views/Profile/Profile.cshtml")]
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
#line 2 "C:\Users\Administrator\source\repos\WebApplication3\Views\Profile\Profile.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b78e023c0ee4cd7e609fbb9fbd38b3f2d6fe5aa2", @"/Views/Profile/Profile.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"95760f8a83ab7795cd7ef6e81f11c70072b293e4", @"/Views/_ViewImports.cshtml")]
    public class Views_Profile_Profile : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IndexViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 6 "C:\Users\Administrator\source\repos\WebApplication3\Views\Profile\Profile.cshtml"
  
    ViewData["Title"] = "Profile";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"


<div class=""container"">
    <div class=""row"">
        <div class=""col"">

            <div class=""text-left mt-lg-5 mb-lg-5"">
                <h1 class=""display-3"" style=""font-size: 30px; margin-top:20px;"">Profile</h1>
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
            WriteLiteral(@"      </div>

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
                    <a class=""nav-link"" id=""friends-tab"" data-toggle=""tab"" href=""#friends"" role");
            WriteLiteral(@"=""tab"" aria-controls=""friends"" aria-selected=""false"">
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
                    ...
                </div>
                <div class=""tab-pane fade"" id=""profile"" role=""tabpanel"" aria-labelledby=""profile-tab"">
                    <d");
            WriteLiteral(@"iv class=""row"">
                        <div class=""mt-5"" style=""width: 18rem"">
                            <img src=""https://images.youracclaim.com/size/680x680/images/11636db1-f9fa-4669-b13c-9a15f0d81ab0/EXAM-Associate-MB-500.png""
                                 style=""width: 50px; height: 50px;""
                                 class=""card-img-top""
                                 alt=""..."" />
                        </div>
                        <div class=""mt-5"" style=""width: 18rem"">
                            <img src=""https://images.youracclaim.com/size/680x680/images/11636db1-f9fa-4669-b13c-9a15f0d81ab0/EXAM-Associate-MB-500.png""
                                 style=""width: 50px; height: 50px;""
                                 class=""card-img-top""
                                 alt=""..."" />
                        </div>
                    </div>
                </div>
                <div class=""tab-pane fade"" id=""contact"" role=""tabpanel"" aria-labelledby=""contact-tab"">
       ");
            WriteLiteral(@"             ...
                </div>
                <div class=""tab-pane fade"" id=""friends"" role=""tabpanel"" aria-labelledby=""friends-tab"">
                    ...
                </div>
                <div class=""tab-pane fade"" id=""likes"" role=""tabpanel"" aria-labelledby=""likes-tab"">
                    ...
                </div>
                <div class=""tab-pane fade"" id=""posts"" role=""tabpanel"" aria-labelledby=""posts-tab"">
                    ...
                </div>
            </div>
        </div>
        <div class=""col-md-auto"">
            <div class=""mt-5"" style=""width: 18rem; padding-top: 30px;"">
                <img src=""https://lledogrupo.com/wp-content/uploads/2018/04/user-img-1.png""
                     style=""width:85px; height:85px; margin-top:45px; margin-left:40px;""
                     class=""card-img-top"" alt=""..."">
                <div class=""card-body"">
                    <h5 class=""display-3 ml-3"" style=""font-size: 20px;"">Profile photo</h5>
                <");
            WriteLiteral("/div>\r\n            </div>\r\n            <div class=\"ml-4\">\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
