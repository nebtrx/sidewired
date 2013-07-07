using System;
using System.Collections.Generic;
using System.Web;
using System.Web.Mvc;
using Panda4Web.Core.Extensions;
using Panda4Web.Core.Interfaces;

namespace System.Web.Mvc
{
    /// <summary>
    /// Panda4Web helpers holder class.
    /// </summary>
    public static class Panda4WebPlayer
    {
        /// <summary>
        /// Generate the HTML code needed to deploy a silverlight media player in your view wrapped as a silverlight object.
        /// </summary>
        /// <param name="silverlightXapSource">Player's xap file location.</param>
        /// <param name="playerSettings">Player's settings.</param>
        /// <param name="divContainerHtmlAttributes">Anonymous object with silverlight's container div attributes.</param>
        /// <param name="onErrorJavaScriptHandlerFuntionName">JavaScript function name for error event handling.</param>
        /// <param name="onLoadJavaScriptHandlerFunctionName">JavaScript function name for load event handling.</param>
        /// <param name="objectWidthPercentage">Silverlight object width percentage.</param>
        /// <param name="objectHeightPercentage">Silverlight object width percentage.</param>
        /// <param name="minimumRuntimeVersion">Silverlight object minimum runtime version </param>
        /// <param name="iFrameStyle">Silverlight object iFrame style</param>
        /// <returns>HTML code for a silverlight media player with the requested settings.</returns>
        /// <exception cref="ArgumentNullException">Throws an ArgumentNullException exception if parameters <paramref name="playerSettings"/> or <paramref name="silverlightXapSource"/> weren't provided.</exception>
        public static HtmlString ControlHost(
            string silverlightXapSource, // URI Location of the Silverlight XAP file
            IPlayerSettings playerSettings,
            object divContainerHtmlAttributes = null,
            string onErrorJavaScriptHandlerFuntionName = "onSilverlightError",
            string onLoadJavaScriptHandlerFunctionName = "onSilverlightLoad",
            string objectWidthPercentage = "100",
            string objectHeightPercentage = "100",
            string minimumRuntimeVersion = "4.0.50826.0",
            string iFrameStyle = "visibility:hidden;height:0px;width:0px;border:0px")
        {
            if (playerSettings == null)
            {
                throw new ArgumentNullException("playerSettings");
            }

            if (silverlightXapSource == null)
            {
                throw new ArgumentNullException("silverlightXapSource");
            }

            //string silverlightObject = string.Format(
                                       
            //                                    "<object data=\"data:application/x-silverlight-2,\" type=\"application/x-silverlight-2\" width=\"{0}\" height=\"{1}\"> \n" +
            //                                      "<param name=\"source\" value=\"{2}\"/> \n" +
            //                                      "<param name=\"minRuntimeVersion\" value=\"{3}\" /> \n" +
            //                                      "<param name=\"onError\" value=\"{4}\" /> \n" +
            //                                      "<param name=\"onLoad\" value=\"{5}\" /> \n" +
            //                                      "<param name=\"background\" value=\"white\" /> \n" +
            //                                      "<param name=\"autoUpgrade\" value=\"true\" /> \n" +
            //                                      "<param name=\"InitParams\" value=\"PlayerSettings ={6}\" /> \n" +
            //                                      "<a href=\"http://go.microsoft.com/fwlink/?LinkID=149156&v=3.0.40818.0\" style=\"text-decoration:none\"> \n" +
            //                                          "<img src=\"http://go.microsoft.com/fwlink/?LinkId=161376\" alt=\"Get Microsoft Silverlight\" style=\"border-style:none\"/> \n" +
            //                                      "</a> \n" +
            //                                    "</object><iframe id=\"_sl_historyFrame\" style=\"{7}\"></iframe> \n",
            //                          objectWidth,
            //                          objectHeight,
            //                          silverlightXapSource,
            //                          minimumRuntimeVersion,
            //                          onErrorJavaScriptHandlerFuntionName,
            //                          onLoadJavaScriptHandlerFunctionName,
            //                          playerSettings.AsXmlSerializedString(),
            //                          iFrameStyle
            //                          );


            var imgBuilder = new TagBuilder("img");
            var imgAttributes = new Dictionary<string, string>()
                                       {
                                           {"src", "http://go.microsoft.com/fwlink/?LinkId=161376"},
                                           {"alt", "Get Microsoft Silverlight"},
                                           {"style", "border-style:none"},
                                       };
            imgBuilder.MergeAttributes(imgAttributes);

            var linkBuilder = new TagBuilder("a");
            var linkAttributes = new Dictionary<string, string>()
                                       {
                                           {"href", "http://go.microsoft.com/fwlink/?LinkID=149156&v=3.0.40818.0"},
                                           {"style", "text-decoration:none"},
                                       };
            linkBuilder.MergeAttributes(linkAttributes);
            linkBuilder.InnerHtml = imgBuilder.ToString(TagRenderMode.Normal);
            

            var objectBuilder = new TagBuilder("object");
            var objectAttributes = new Dictionary<string, string>()
                                       {
                                           {"data", "data:application/x-silverlight-2,"},
                                           {"type", "application/x-silverlight-2"},
                                           {"width", string.Format("{0}%",objectWidthPercentage)},
                                           {"height", string.Format("{0}%",objectHeightPercentage)},
                                       };
            objectBuilder.MergeAttributes(objectAttributes);
            
            objectBuilder.InnerHtml = new MvcHtmlString(
                CraftParamTagBuilder("source", silverlightXapSource).ToString(TagRenderMode.SelfClosing) +
                CraftParamTagBuilder("minRuntimeVersion", minimumRuntimeVersion).ToString(TagRenderMode.SelfClosing) +
                CraftParamTagBuilder("onError", onErrorJavaScriptHandlerFuntionName).ToString(TagRenderMode.SelfClosing) +
                CraftParamTagBuilder("onLoad", onLoadJavaScriptHandlerFunctionName).ToString(TagRenderMode.SelfClosing) +
                CraftParamTagBuilder("background", "white").ToString(TagRenderMode.SelfClosing) +
                CraftParamTagBuilder("autoUpgrade", "true").ToString(TagRenderMode.SelfClosing) +
                CraftParamTagBuilder("InitParams", "PlayerSettings = \n" + playerSettings.AsXmlSerializedString()).ToString(TagRenderMode.SelfClosing) +
                linkBuilder.ToString(TagRenderMode.Normal)
            ).ToHtmlString();

            var iframeBuilder = new TagBuilder("iframe");
            var iframeAttributes = new Dictionary<string, string>()
                                       {
                                           {"id", "_sl_historyFrame"},
                                           {"style", iFrameStyle},
                                       };
            iframeBuilder.MergeAttributes(iframeAttributes);

            var divBuilder = new TagBuilder("div");
            divBuilder.MergeAttributes(HtmlHelper.AnonymousObjectToHtmlAttributes(divContainerHtmlAttributes));
            //divBuilder.InnerHtml = new MvcHtmlString(silverlightObject).ToHtmlString();
            divBuilder.InnerHtml = new MvcHtmlString(
                objectBuilder.ToString(TagRenderMode.Normal) +
                iframeBuilder.ToString(TagRenderMode.Normal)
            ).ToHtmlString();

            return new MvcHtmlString(divBuilder.ToString(TagRenderMode.Normal));
        }

        private static TagBuilder CraftParamTagBuilder(string paramName, string paramValue)
        {
            var paramBuilder = new TagBuilder("param");
            var paramAttributes = new Dictionary<string, string>()
                                       {
                                           {"name", paramName},
                                           {"value", paramValue},
                                       };
            paramBuilder.MergeAttributes(paramAttributes);
            return paramBuilder;
        }
    }
}
