#pragma checksum "C:\Users\fthyl\source\repos\ProjeOdev\ProjeOdev\Views\Exam\Exam.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c1a138727a5abca0de2561f358584c1485c9ce28"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Exam_Exam), @"mvc.1.0.view", @"/Views/Exam/Exam.cshtml")]
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
#line 1 "C:\Users\fthyl\source\repos\ProjeOdev\ProjeOdev\Views\_ViewImports.cshtml"
using ProjeOdev;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\fthyl\source\repos\ProjeOdev\ProjeOdev\Views\_ViewImports.cshtml"
using ProjeOdev.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\fthyl\source\repos\ProjeOdev\ProjeOdev\Views\Exam\Exam.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c1a138727a5abca0de2561f358584c1485c9ce28", @"/Views/Exam/Exam.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"210257964c41310cc652be9d4bdc17e51e617555", @"/Views/_ViewImports.cshtml")]
    public class Views_Exam_Exam : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Exam>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\fthyl\source\repos\ProjeOdev\ProjeOdev\Views\Exam\Exam.cshtml"
  
    ViewData["Title"] = "Exam";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"row justify-content-center\">\r\n");
#nullable restore
#line 10 "C:\Users\fthyl\source\repos\ProjeOdev\ProjeOdev\Views\Exam\Exam.cshtml"
       int i = 1; string name = "";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <div class=\"col-12\">\r\n");
#nullable restore
#line 13 "C:\Users\fthyl\source\repos\ProjeOdev\ProjeOdev\Views\Exam\Exam.cshtml"
         foreach (var item in Model.Article.Paragraphs)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <p>");
#nullable restore
#line 15 "C:\Users\fthyl\source\repos\ProjeOdev\ProjeOdev\Views\Exam\Exam.cshtml"
          Write(item.ParagraphText);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 16 "C:\Users\fthyl\source\repos\ProjeOdev\ProjeOdev\Views\Exam\Exam.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n\r\n");
#nullable restore
#line 19 "C:\Users\fthyl\source\repos\ProjeOdev\ProjeOdev\Views\Exam\Exam.cshtml"
     foreach (var item in Model.Questions)
    {
        name = "myList";

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"col-6\">\r\n            <div class=\"input-group\">\r\n                <div class=\"input-group-prepend\">\r\n                    <span class=\"input-group-text\">Soru ");
#nullable restore
#line 25 "C:\Users\fthyl\source\repos\ProjeOdev\ProjeOdev\Views\Exam\Exam.cshtml"
                                                   Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                </div>\r\n                <textarea readonly class=\"form-control\" id=\"soru\"");
            BeginWriteAttribute("name", " name=\"", 726, "\"", 733, 0);
            EndWriteAttribute();
            WriteLiteral(" aria-label=\"With textarea\" rows=\"3\">");
#nullable restore
#line 27 "C:\Users\fthyl\source\repos\ProjeOdev\ProjeOdev\Views\Exam\Exam.cshtml"
                                                                                                         Write(item.QuestionText);

#line default
#line hidden
#nullable disable
            WriteLiteral("</textarea>\r\n            </div>\r\n            <div class=\"input-group\">\r\n                <div class=\"list-group\" name=\"Question\" id=\"Question\" role=\"tablist\">\r\n                    <radio type=\"button\"");
            BeginWriteAttribute("name", " name=\"", 988, "\"", 1000, 1);
#nullable restore
#line 31 "C:\Users\fthyl\source\repos\ProjeOdev\ProjeOdev\Views\Exam\Exam.cshtml"
WriteAttributeValue("", 995, name, 995, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" id=\"A\" class=\"list-group-item list-group-item-action\"><span>A ) </span>");
#nullable restore
#line 31 "C:\Users\fthyl\source\repos\ProjeOdev\ProjeOdev\Views\Exam\Exam.cshtml"
                                                                                                                        Write(item.ChoiceA);

#line default
#line hidden
#nullable disable
            WriteLiteral("</radio>\r\n                    <radio type=\"button\"");
            BeginWriteAttribute("name", " name=\"", 1136, "\"", 1148, 1);
#nullable restore
#line 32 "C:\Users\fthyl\source\repos\ProjeOdev\ProjeOdev\Views\Exam\Exam.cshtml"
WriteAttributeValue("", 1143, name, 1143, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" id=\"B\" class=\"list-group-item list-group-item-action\"><span>B ) </span>");
#nullable restore
#line 32 "C:\Users\fthyl\source\repos\ProjeOdev\ProjeOdev\Views\Exam\Exam.cshtml"
                                                                                                                        Write(item.ChoiceB);

#line default
#line hidden
#nullable disable
            WriteLiteral("</radio>\r\n                    <radio type=\"button\"");
            BeginWriteAttribute("name", " name=\"", 1284, "\"", 1296, 1);
#nullable restore
#line 33 "C:\Users\fthyl\source\repos\ProjeOdev\ProjeOdev\Views\Exam\Exam.cshtml"
WriteAttributeValue("", 1291, name, 1291, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" id=\"C\" class=\"list-group-item list-group-item-action\"><span>C ) </span>");
#nullable restore
#line 33 "C:\Users\fthyl\source\repos\ProjeOdev\ProjeOdev\Views\Exam\Exam.cshtml"
                                                                                                                        Write(item.ChoiceC);

#line default
#line hidden
#nullable disable
            WriteLiteral("</radio>\r\n                    <radio type=\"button\"");
            BeginWriteAttribute("name", " name=\"", 1432, "\"", 1444, 1);
#nullable restore
#line 34 "C:\Users\fthyl\source\repos\ProjeOdev\ProjeOdev\Views\Exam\Exam.cshtml"
WriteAttributeValue("", 1439, name, 1439, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" id=\"D\" class=\"list-group-item list-group-item-action\"><span>D ) </span>");
#nullable restore
#line 34 "C:\Users\fthyl\source\repos\ProjeOdev\ProjeOdev\Views\Exam\Exam.cshtml"
                                                                                                                        Write(item.ChoiceD);

#line default
#line hidden
#nullable disable
            WriteLiteral("</radio>\r\n                </div>\r\n            </div>\r\n\r\n            <hr />\r\n");
#nullable restore
#line 39 "C:\Users\fthyl\source\repos\ProjeOdev\ProjeOdev\Views\Exam\Exam.cshtml"
              i = i + 1;

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n");
#nullable restore
#line 41 "C:\Users\fthyl\source\repos\ProjeOdev\ProjeOdev\Views\Exam\Exam.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    <button class=\"btn btn-lg btn-info\" name=\"btnfinish\">S??nav?? Bitir</button>\r\n</div>\r\n\r\n\r\n");
            DefineSection("scripts", async() => {
                WriteLiteral(@"
    <script>
        $('radio').on('click', function (e) {
            $(this).addClass('active');
            $(this).siblings().removeClass('active');

            //do any other button related things
        });
    </script>


    <script type=""text/javascript"">

        $('button').on('click', function (e) {
                $.ajax({
                    type: ""Get"",
                    url: ""/Exam/GetResult"",
                    data: { ""id"": ");
#nullable restore
#line 63 "C:\Users\fthyl\source\repos\ProjeOdev\ProjeOdev\Views\Exam\Exam.cshtml"
                             Write(Model.ArticleID);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"},
                    dataType: 'json',
                    success: function (response) {
                        var questions = document.getElementsByName(""Question"");
                        for (i = 0; i < questions.length; i++) {
                            var nodes = questions[i].getElementsByTagName(""radio"")
                            for (j = 0; j < nodes.length; j++) {
                                if (response[i].value === nodes[j].id) {
                                    nodes[j].style.backgroundColor = ""green"";
                                }
                                else if (nodes[j].className.includes(""active"")) {
                                    nodes[j].classList.remove(""active"");
                                    nodes[j].style.backgroundColor = ""red"";
                                }
                                    
                            }
                        }
                    },
                    failure: function (response) {
   ");
                WriteLiteral(@"                     alert(response.responseText);
                    },
                    error: function (response) {
                        alert(response.responseText);
                    }
                });
            });

    </script>

");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Exam> Html { get; private set; }
    }
}
#pragma warning restore 1591
