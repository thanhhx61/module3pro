#pragma checksum "D:\study\module3\CaseStudy\Shop_san_pham\Productmanagement\Productmanagement\Views\Dashboard\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1b188efe657c17efed1cdc6d1edf2c67cf79469c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Dashboard_Index), @"mvc.1.0.view", @"/Views/Dashboard/Index.cshtml")]
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
#line 1 "D:\study\module3\CaseStudy\Shop_san_pham\Productmanagement\Productmanagement\Views\_ViewImports.cshtml"
using Productmanagement.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\study\module3\CaseStudy\Shop_san_pham\Productmanagement\Productmanagement\Views\_ViewImports.cshtml"
using Productmanagement.Models.Account;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\study\module3\CaseStudy\Shop_san_pham\Productmanagement\Productmanagement\Views\_ViewImports.cshtml"
using Productmanagement.Models.Product;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\study\module3\CaseStudy\Shop_san_pham\Productmanagement\Productmanagement\Views\_ViewImports.cshtml"
using Productmanagement.Models.Category;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\study\module3\CaseStudy\Shop_san_pham\Productmanagement\Productmanagement\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1b188efe657c17efed1cdc6d1edf2c67cf79469c", @"/Views/Dashboard/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"33b70f202a6e323ed3d14183351b34dffc19c5ac", @"/Views/_ViewImports.cshtml")]
    public class Views_Dashboard_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\study\module3\CaseStudy\Shop_san_pham\Productmanagement\Productmanagement\Views\Dashboard\Index.cshtml"
   
    ViewBag.Title = "Dashboard";

#line default
#line hidden
#nullable disable
            WriteLiteral(@" Main 
<section class=""content"">
    <div class=""container-fluid"">   
        <div class=""row"">
            <div class=""col-lg-3 col-6"">
                <div class=""small-box bg-info"">
                    <div class=""inner"">
                        <h3>150</h3>

                        <p>New Orders</p>
                    </div>
                    <div class=""icon"">
                        <i class=""ion ion-bag""></i>
                    </div>
                    <a href=""#"" class=""small-box-footer"">More info <i class=""fas fa-arrow-circle-right""></i></a>
                </div>
            </div>
            <div class=""col-lg-3 col-6"">
               <div class=""small-box bg-success"">
                    <div class=""inner"">
                        <h3>53<sup style=""font-size: 20px"">%</sup></h3>

                        <p>Bounce Rate</p>
                    </div>
                    <div class=""icon"">
                        <i class=""ion ion-stats-bars""></i>
                    <");
            WriteLiteral(@"/div>
                    <a href=""#"" class=""small-box-footer"">More info <i class=""fas fa-arrow-circle-right""></i></a>
                </div>
            </div>

            <div class=""col-lg-3 col-6"">

                <div class=""small-box bg-warning"">
                    <div class=""inner"">
                        <h3>44</h3>

                        <p>User Registrations</p>
                    </div>
                    <div class=""icon"">
                        <i class=""ion ion-person-add""></i>
                    </div>
                    <a href=""#"" class=""small-box-footer"">More info <i class=""fas fa-arrow-circle-right""></i></a>
                </div>
            </div>
            <div class=""col-lg-3 col-6"">
                <div class=""small-box bg-danger"">
                    <div class=""inner"">
                        <h3>65</h3>

                        <p>Unique Visitors</p>
                    </div>
                    <div class=""icon"">
                        <i ");
            WriteLiteral(@"class=""ion ion-pie-graph""></i>
                    </div>
                    <a href=""#"" class=""small-box-footer"">More info <i class=""fas fa-arrow-circle-right""></i></a>
                </div>
            </div>
        </div>
    </div>
</section>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591