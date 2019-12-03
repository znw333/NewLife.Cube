﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace ASP
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Web;
    using System.Web.Helpers;
    using System.Web.Mvc;
    using System.Web.Mvc.Ajax;
    using System.Web.Mvc.Html;
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    
    #line 1 "..\..\Views\Shared\_ListTree_Data.cshtml"
    using NewLife;
    
    #line default
    #line hidden
    using NewLife.Cube;
    using NewLife.Reflection;
    
    #line 2 "..\..\Views\Shared\_ListTree_Data.cshtml"
    using NewLife.Web;
    
    #line default
    #line hidden
    
    #line 3 "..\..\Views\Shared\_ListTree_Data.cshtml"
    using XCode;
    
    #line default
    #line hidden
    
    #line 4 "..\..\Views\Shared\_ListTree_Data.cshtml"
    using XCode.Configuration;
    
    #line default
    #line hidden
    using XCode.Membership;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Shared/_ListTree_Data.cshtml")]
    public partial class _Views_Shared__ListTree_Data_cshtml : System.Web.Mvc.WebViewPage<dynamic>
    {
        public _Views_Shared__ListTree_Data_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 5 "..\..\Views\Shared\_ListTree_Data.cshtml"
  
    var fact = ViewBag.Factory as IEntityOperate;
    var page = ViewBag.Page as Pager;
    var fields = ViewBag.Fields as IList<FieldItem>;
    var fk = fact.Unique;
    var set = ViewBag.PageSetting as PageSetting;

            
            #line default
            #line hidden
WriteLiteral("\r\n<table");

WriteLiteral(" class=\"table table-bordered table-hover table-striped table-condensed table-data" +
"-list\"");

WriteLiteral(">\r\n    <thead>\r\n        <tr>\r\n");

            
            #line 15 "..\..\Views\Shared\_ListTree_Data.cshtml"
            
            
            #line default
            #line hidden
            
            #line 15 "..\..\Views\Shared\_ListTree_Data.cshtml"
             if (set.EnableSelect)
            {

            
            #line default
            #line hidden
WriteLiteral("                <th");

WriteLiteral(" class=\"text-center\"");

WriteLiteral(" style=\"width:10px;\"");

WriteLiteral("><input");

WriteLiteral(" type=\"checkbox\"");

WriteLiteral(" id=\"chkAll\"");

WriteLiteral(" title=\"全选\"");

WriteLiteral(" /></th>\r\n");

            
            #line 18 "..\..\Views\Shared\_ListTree_Data.cshtml"
            }

            
            #line default
            #line hidden
WriteLiteral("            ");

            
            #line 19 "..\..\Views\Shared\_ListTree_Data.cshtml"
             foreach (var item in fields)
            {
                var sortUrl = item.OriField != null ? page.GetSortUrl(item.OriField.Name) : page.GetSortUrl(item.Name);

            
            #line default
            #line hidden
WriteLiteral("                <th");

WriteLiteral(" class=\"text-center\"");

WriteAttribute("title", Tuple.Create(" title=\"", 833), Tuple.Create("\"", 858)
            
            #line 22 "..\..\Views\Shared\_ListTree_Data.cshtml"
, Tuple.Create(Tuple.Create("", 841), Tuple.Create<System.Object, System.Int32>(item.Description
            
            #line default
            #line hidden
, 841), false)
);

WriteLiteral("><a");

WriteAttribute("href", Tuple.Create(" href=\"", 862), Tuple.Create("\"", 887)
            
            #line 22 "..\..\Views\Shared\_ListTree_Data.cshtml"
, Tuple.Create(Tuple.Create("", 869), Tuple.Create<System.Object, System.Int32>(Html.Raw(sortUrl)
            
            #line default
            #line hidden
, 869), false)
);

WriteLiteral(">");

            
            #line 22 "..\..\Views\Shared\_ListTree_Data.cshtml"
                                                                                          Write(item.DisplayName);

            
            #line default
            #line hidden
WriteLiteral("</a></th>\r\n");

            
            #line 23 "..\..\Views\Shared\_ListTree_Data.cshtml"
            }

            
            #line default
            #line hidden
WriteLiteral("            <th");

WriteLiteral(" class=\"text-center\"");

WriteLiteral(">升</th>\r\n            <th");

WriteLiteral(" class=\"text-center\"");

WriteLiteral(">降</th>\r\n");

            
            #line 26 "..\..\Views\Shared\_ListTree_Data.cshtml"
            
            
            #line default
            #line hidden
            
            #line 26 "..\..\Views\Shared\_ListTree_Data.cshtml"
             if (this.Has(PermissionFlags.Detail, PermissionFlags.Update, PermissionFlags.Delete))
            {

            
            #line default
            #line hidden
WriteLiteral("                <th");

WriteLiteral(" class=\"text-center\"");

WriteLiteral(">操作</th>\r\n");

            
            #line 29 "..\..\Views\Shared\_ListTree_Data.cshtml"
            }

            
            #line default
            #line hidden
WriteLiteral("        </tr>\r\n    </thead>\r\n    <tbody>\r\n");

            
            #line 33 "..\..\Views\Shared\_ListTree_Data.cshtml"
        
            
            #line default
            #line hidden
            
            #line 33 "..\..\Views\Shared\_ListTree_Data.cshtml"
         foreach (IEntityTree entity in Model)
        {
            var FirstFlag = 0;
            var p = entity.Parent as IEntityTree;
            if (p == null)
            {
                p = fact.EntityType.GetValue("Root") as IEntityTree;
            }
            var id = entity["ID"];

            
            #line default
            #line hidden
WriteLiteral("            <tr>\r\n");

            
            #line 43 "..\..\Views\Shared\_ListTree_Data.cshtml"
                
            
            #line default
            #line hidden
            
            #line 43 "..\..\Views\Shared\_ListTree_Data.cshtml"
                 if (set.EnableSelect)
                {

            
            #line default
            #line hidden
WriteLiteral("                    <td");

WriteLiteral(" class=\"text-center\"");

WriteLiteral("><input");

WriteLiteral(" type=\"checkbox\"");

WriteLiteral(" name=\"keys\"");

WriteAttribute("value", Tuple.Create(" value=\"", 1702), Tuple.Create("\"", 1726)
            
            #line 45 "..\..\Views\Shared\_ListTree_Data.cshtml"
      , Tuple.Create(Tuple.Create("", 1710), Tuple.Create<System.Object, System.Int32>(entity[fk.Name]
            
            #line default
            #line hidden
, 1710), false)
);

WriteLiteral(" /></td>\r\n");

            
            #line 46 "..\..\Views\Shared\_ListTree_Data.cshtml"
                }

            
            #line default
            #line hidden
WriteLiteral("                ");

            
            #line 47 "..\..\Views\Shared\_ListTree_Data.cshtml"
                 foreach (var item in fields)
                {
                    if (FirstFlag == 0)
                    {
                        
            
            #line default
            #line hidden
            
            #line 51 "..\..\Views\Shared\_ListTree_Data.cshtml"
                   Write(Html.Partial("_List_Data_Item_First", new Pair(entity, item)));

            
            #line default
            #line hidden
            
            #line 51 "..\..\Views\Shared\_ListTree_Data.cshtml"
                                                                                      
                    }
                    else
                    {
                        
            
            #line default
            #line hidden
            
            #line 55 "..\..\Views\Shared\_ListTree_Data.cshtml"
                   Write(Html.Partial("_List_Data_Item", new Pair(entity, item)));

            
            #line default
            #line hidden
            
            #line 55 "..\..\Views\Shared\_ListTree_Data.cshtml"
                                                                                
                    }

                    FirstFlag++;
                }

            
            #line default
            #line hidden
WriteLiteral("                <td");

WriteLiteral(" class=\"text-center\"");

WriteLiteral(">\r\n");

            
            #line 61 "..\..\Views\Shared\_ListTree_Data.cshtml"
                    
            
            #line default
            #line hidden
            
            #line 61 "..\..\Views\Shared\_ListTree_Data.cshtml"
                     if (p != null && p.Childs != null && p.Childs.Count > 0 && entity != p.Childs[0])
                    {

            
            #line default
            #line hidden
WriteLiteral("                        <a");

WriteAttribute("href", Tuple.Create(" href=\"", 2401), Tuple.Create("\"", 2437)
            
            #line 63 "..\..\Views\Shared\_ListTree_Data.cshtml"
, Tuple.Create(Tuple.Create("", 2408), Tuple.Create<System.Object, System.Int32>(Url.Action("Up", new { id })
            
            #line default
            #line hidden
, 2408), false)
);

WriteLiteral("><span");

WriteLiteral(" class=\"glyphicon glyphicon-arrow-up\"");

WriteLiteral(" style=\"color: green;\"");

WriteLiteral("></span></a>\r\n");

            
            #line 64 "..\..\Views\Shared\_ListTree_Data.cshtml"
                    }

            
            #line default
            #line hidden
WriteLiteral("                </td>\r\n                <td");

WriteLiteral(" class=\"text-center\"");

WriteLiteral(">\r\n");

            
            #line 67 "..\..\Views\Shared\_ListTree_Data.cshtml"
                    
            
            #line default
            #line hidden
            
            #line 67 "..\..\Views\Shared\_ListTree_Data.cshtml"
                     if (p != null && p.Childs != null && p.Childs.Count > 0 && entity != p.Childs[p.Childs.Count - 1])
                    {

            
            #line default
            #line hidden
WriteLiteral("                        <a");

WriteAttribute("href", Tuple.Create(" href=\"", 2775), Tuple.Create("\"", 2813)
            
            #line 69 "..\..\Views\Shared\_ListTree_Data.cshtml"
, Tuple.Create(Tuple.Create("", 2782), Tuple.Create<System.Object, System.Int32>(Url.Action("Down", new { id })
            
            #line default
            #line hidden
, 2782), false)
);

WriteLiteral("><span");

WriteLiteral(" class=\"glyphicon glyphicon-arrow-down\"");

WriteLiteral(" style=\"color: red;\"");

WriteLiteral("></span></a>\r\n");

            
            #line 70 "..\..\Views\Shared\_ListTree_Data.cshtml"
                    }

            
            #line default
            #line hidden
WriteLiteral("                </td>\r\n");

            
            #line 72 "..\..\Views\Shared\_ListTree_Data.cshtml"
                
            
            #line default
            #line hidden
            
            #line 72 "..\..\Views\Shared\_ListTree_Data.cshtml"
                 if (this.Has(PermissionFlags.Detail, PermissionFlags.Update, PermissionFlags.Delete))
                {

            
            #line default
            #line hidden
WriteLiteral("                    <td");

WriteLiteral(" class=\"text-center\"");

WriteLiteral(">\r\n");

WriteLiteral("                        ");

            
            #line 75 "..\..\Views\Shared\_ListTree_Data.cshtml"
                   Write(Html.Partial("_List_Data_Action", (Object)entity));

            
            #line default
            #line hidden
WriteLiteral("\r\n                    </td>\r\n");

            
            #line 77 "..\..\Views\Shared\_ListTree_Data.cshtml"
                }

            
            #line default
            #line hidden
WriteLiteral("            </tr>\r\n");

            
            #line 79 "..\..\Views\Shared\_ListTree_Data.cshtml"
        }

            
            #line default
            #line hidden
WriteLiteral("    </tbody>\r\n</table>");

        }
    }
}
#pragma warning restore 1591
