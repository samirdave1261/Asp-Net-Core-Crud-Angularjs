#pragma checksum "C:\Users\dev22\Desktop\Samir_Core\Samir_Core\Views\Home\Privacy.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "96474c9a834525b3e91cca109f9b3da6714bd17c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Privacy), @"mvc.1.0.view", @"/Views/Home/Privacy.cshtml")]
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
#line 1 "C:\Users\dev22\Desktop\Samir_Core\Samir_Core\Views\_ViewImports.cshtml"
using Samir_Core;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\dev22\Desktop\Samir_Core\Samir_Core\Views\_ViewImports.cshtml"
using Samir_Core.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"96474c9a834525b3e91cca109f9b3da6714bd17c", @"/Views/Home/Privacy.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"62de1989b760b80f35a01e933a076c9ba2d305d2", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Privacy : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\dev22\Desktop\Samir_Core\Samir_Core\Views\Home\Privacy.cshtml"
  
    ViewData["Title"] = "Insert/Update";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h3>");
#nullable restore
#line 4 "C:\Users\dev22\Desktop\Samir_Core\Samir_Core\Views\Home\Privacy.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h3>

<script type=""text/javascript"" src=""https://ajax.googleapis.com/ajax/libs/angularjs/1.3.9/angular.min.js""></script>
<script type=""text/javascript"" src=""http://ajax.cdnjs.com/ajax/libs/json2/20110223/json2.js""></script>


<div ng-app=""insertapp"" ng-controller=""myapp"" ng-cloak ng-init=""updaterecord();"">
    <div class=""alert alert-success"" id=""test"" style=""display:none"" role=""alert"">
        Data {{msg}} Successfully
    </div>
    <div class=""form-group"">
        <label for=""formGroupExampleInput"">First name</label>
        <input type=""text"" class=""form-control"" ng-model=""fname"" placeholder=""First name"">
    </div>
    <div class=""form-group"">
        <label for=""formGroupExampleInput2"">Last name </label>
        <input type=""text"" class=""form-control"" ng-model=""lname"" placeholder=""Last name"">
    </div>
    <div class=""form-group"">
        <label for=""formGroupExampleInput2"">Email</label>
        <input type=""text"" class=""form-control"" ng-model=""email"" id=""inputEmail3"" placeholder=");
            WriteLiteral(@"""Email"">
    </div>
    <div class=""form-group"">
        <label for=""formGroupExampleInput2"">Mobile</label>
        <input type=""number"" class=""form-control"" ng-model=""mobile"" maxlength=""10"" id=""inputEmail3"" placeholder=""Mobile"">
    </div>
    <button id=""submit"" class=""btn btn-primary"" ng-click=""submitdata('insert')"" type=""submit"">Insert</button>
    <button id=""update"" class=""btn btn-primary"" style=""display:none;"" ng-click=""submitdata('update')"" type=""button"">Update</button>
</div>


<script type=""text/javascript"">
    var app = angular.module('insertapp', []);
    app.controller('myapp', function ($scope, $http) {
        $scope.Databind = '';
        $scope.Data = '';
        $scope.fname = '';
        $scope.lname = '';
        $scope.email = '';
        $scope.mobile = '';
        $scope.updaterecord = function () {
            var Getparam = window.atob(window.location.search.substring(1)) // Id Decryption using Window.atob()
            $scope.Get_Id_Data(Getparam);
        }
");
            WriteLiteral(@"        $scope.submitdata = function (type) {
            if (type == 'insert') {
                $.ajax({
                    url: ""Home/Insert_Data"",
                    method: ""POST"",
                    dataType: 'json',
                    data: {
                        fname: $scope.fname,
                        lname: $scope.lname,
                        email: $scope.email,
                        mobile: $scope.mobile,
                    },
                    success: function (data) {
                        if (data == ""Success"") {
                            $scope.msg = ""Insert"";
                            $(""#test"").css(""display"", ""block"");
                            window.location.href = ""/"";
                        }
                    },
                });
            }
            else if (type == 'update') {
                $.ajax({
                    url: ""Home/Update"",
                    method: ""POST"",
                    dataType: 'json',
         ");
            WriteLiteral(@"           data: {
                        fname: $scope.fname,
                        lname: $scope.lname,
                        email: $scope.email,
                        mobile: $scope.mobile,
                    },
                    success: function (data) {
                        debugger
                        if (data == ""Success"") {
                            $scope.msg = ""Update"";
                            $(""#test"").css(""display"", ""block"");
                            window.location.href = ""/"";
                        }
                    },
                });
            }
        }
       
        $scope.Get_Id_Data = function (id) {
            if (id != '') {
                $('#submit').css('display', 'none');
                $('#update').css('display', 'block');
                var getdata = $http({
                    method: ""GET"",
                    url: ""Home/get_data?id="" + id,
                    dataType: 'json',
                    //data: { o");
            WriteLiteral(@"rderid: id },
                    headers: { ""Content-Type"": ""application/json"" }
                });
                getdata.success(function (data) {
                    $scope.Databind = data;
                    $scope.Data = JSON.parse($scope.Databind);
                    $scope.fname = $scope.Data[0].Fname,
                    $scope.lname = $scope.Data[0].Lname,
                    $scope.email = $scope.Data[0].Email,
                    $scope.mobile = $scope.Data[0].mobile
                });
            }
        }
    });
</script>
");
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
