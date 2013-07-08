Please see https://bitbucket.org/nebtrx/framerizr/overview for more information about Framerizr.
 
Getting started with Framerizr.MVC
----------------------------------

Using Framerizr.MVC is easy once installed. You just have to specify the container where you want to iframe an ASP.NET MVC Web Application empowered with Framerizr, e.g.:

	<div data-iframe-src="http://example. domain.com/" ></div>

Or alternatively you may specified a custom Framerizr URI, e.g.:

	<div data-iframe-src="http://example.domain.com/" data-framerizr-uri="http://other.route.com/OtherApp/Framerizr"></div>

Note:

It's strongly recomended to check the jQuery reference in Views/Framerizr/Index.cshtml. It’s default set to jQuery v1.6.2 but surely you’ll have another one installed, it’s just Murphy’s Law. 
	
	<script src="@Url.Content("~/Scripts/jquery-1.6.2.min.js")">  </script>
