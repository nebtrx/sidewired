using System;
using System.Collections.Generic;
using System.Web;
using System.Web.Mvc;
using Sidewired.Core.Interfaces;
using Sidewired.Core.Utilities;

namespace Sidewired.Web
{
    public static class HtmlExtensions
    {
        /// <summary>
        /// Generate the HTML code needed to deploy a silverlight media player in your view wrapped as a silverlight object.
        /// </summary>
        /// <param name="htmlHelper">The HTML helper instance that this method extends.</param>
        /// <param name="playerXapSource">Player's xap file location.</param>
        /// <param name="containerHtmlAttributes">Anonymous object with silverlight's container div attributes.</param>
        /// <param name="xamlThemeSource">External Xaml Theme Uri. </param>
        /// <param name="scriptableName">object name used for the Javascript interface to the Player. </param>
        /// <param name="onErrorCallBack">JavaScript function name for silverlight error event handling.</param>
        /// <param name="onLoadedCallback">JavaScript function name for silverlight loaded event handling. </param>
        /// <param name="sidewiredXapSource">Sidewired's plugin xap file location. </param>
        /// <param name="objectWidthPercentage">Silverlight object width percentage.</param>
        /// <param name="objectHeightPercentage">Silverlight object width percentage.</param>
        /// <param name="minimumRuntimeVersion">Silverlight object minimum runtime version </param>
        /// <param name="iFrameStyle">Silverlight object iFrame style</param>
        /// <param name="windowLess"> Enables windowless behavior.</param>
        /// <param name="enableHtmlAccess"> Enables  html access.</param>
        /// <param name="enableGpuAcceleration">Allows GPU acceleration </param>
        /// <param name="autoUpgrade"> Allows autoupgrade behavior.</param>
        /// <returns>HTML code for a silverlight media player with the requested settings.</returns>
        /// <exception cref="ArgumentNullException">Throws an ArgumentNullException exception if parameter is not <paramref name="playerXapSource"/> weren't provided.</exception>
        public static HtmlString SilverlightMediaPlayer(this HtmlHelper htmlHelper,
            string playerXapSource,
            object containerHtmlAttributes = null,
            string xamlThemeSource = null,
            string scriptableName = "SMPlayer",
            string onErrorCallBack = "onSilverlightError",
            string onLoadedCallback = "onSilverlightLoaded",
            string sidewiredXapSource = @"/ClientBin/Sidewired.xap",
            string objectWidthPercentage = "100",
            string objectHeightPercentage = "100",
            bool enableHtmlAccess = true,
            bool enableGpuAcceleration = true,
            bool autoUpgrade = true,
            bool windowLess = true,
            string minimumRuntimeVersion = "4.0.50826.0",
            string iFrameStyle = "visibility:hidden;height:0px;width:0px;border:0px")
        {
            if (playerXapSource == null)
            {
                throw new ArgumentNullException("playerXapSource");
            }

            if (sidewiredXapSource == null)
            {
                throw new ArgumentNullException("sidewiredXapSource");
            }

            return CreatePlayerMarkup(Core.Sidewired.PlayerSettings, playerXapSource, sidewiredXapSource, 
                containerHtmlAttributes, xamlThemeSource, scriptableName, onErrorCallBack, onLoadedCallback, 
                objectWidthPercentage, objectHeightPercentage, autoUpgrade, enableGpuAcceleration, windowLess, 
                enableHtmlAccess, minimumRuntimeVersion, iFrameStyle);
        }


        /// <summary>
        /// Generate the HTML code needed to deploy a silverlight media player in your view wrapped as a silverlight object.
        /// </summary>
        /// <param name="htmlHelper">The HTML helper instance that this method extends.</param>
        /// <param name="playerXapSource">Player's xap file location.</param>
        /// <param name="playerSettings﻿">Player's settings.</param>
        /// <param name="containerHtmlAttributes">Anonymous object with silverlight's container div attributes.</param>
        /// <param name="xamlThemeSource">External Xaml Theme Uri. </param>
        /// /// <param name="scriptableName">object name used for the Javascript interface to the Player. </param>
        /// <param name="onErrorCallBack">JavaScript function name for silverlight error event handling.</param>
        /// <param name="onLoadedCallback">JavaScript function name for silverlight loaded event handling. </param>
        /// <param name="sidewiredXapSource">Sidewired's plugin xap file location. </param>
        /// <param name="objectWidthPercentage">Silverlight object width percentage.</param>
        /// <param name="objectHeightPercentage">Silverlight object width percentage.</param>
        /// <param name="windowLess"> Enables windowless behavior.</param>
        /// <param name="enableHtmlAccess"> Enables  html access.</param>
        /// <param name="enableGpuAcceleration">Allows GPU acceleration </param>
        /// <param name="autoUpgrade"> Allows autoupgrade behavior.</param>
        /// <param name="minimumRuntimeVersion">Silverlight object minimum runtime version </param>
        /// <param name="iFrameStyle">Silverlight object iFrame style</param>
        /// <returns>HTML code for a silverlight media player with the requested settings.</returns>
        /// <exception cref="ArgumentNullException">Throws an ArgumentNullException exception if parameters <paramref name="playerSettings﻿"/> or <paramref name="playerXapSource"/> weren't provided.</exception>
        public static HtmlString SilverlightMediaPlayer(this HtmlHelper htmlHelper,
            string playerXapSource,
            IPlayerSettings playerSettings﻿,
            object containerHtmlAttributes = null,            
            string xamlThemeSource = null,
            string scriptableName = "SMPlayer",
            string onErrorCallBack = "onSilverlightError",
            string onLoadedCallback = "onSilverlightLoaded",
            string sidewiredXapSource = @"/ClientBin/Sidewired.xap",
            string objectWidthPercentage = "100",
            string objectHeightPercentage = "100",
            bool enableHtmlAccess = true,
            bool enableGpuAcceleration = true,
            bool autoUpgrade = true,
            bool windowLess = true,
            string minimumRuntimeVersion = "4.0.50826.0",
            string iFrameStyle = "visibility:hidden;height:0px;width:0px;border:0px")
        {
            if (playerSettings﻿ == null)
            {
                throw new ArgumentNullException("playerSettings\xFEFF");
            }

            if (playerXapSource == null)
            {
                throw new ArgumentNullException("playerXapSource");
            }

            if (sidewiredXapSource == null)
            {
                throw new ArgumentNullException("sidewiredXapSource");
            }

            return CreatePlayerMarkup(playerSettings﻿, playerXapSource, sidewiredXapSource, containerHtmlAttributes, 
                xamlThemeSource, scriptableName, onErrorCallBack, onLoadedCallback, objectWidthPercentage, objectHeightPercentage, 
                autoUpgrade, enableGpuAcceleration, windowLess, enableHtmlAccess,minimumRuntimeVersion, iFrameStyle);
        }

        private static HtmlString CreatePlayerMarkup(IPlayerSettings playerSettings﻿, string playerXapSource,
                                                     string sidewiredXapSource, object containerHtmlAttributes, string xamlThemeSource,
                                                     string scriptableName,  string onErrorCallback, string onLoadedCallback,
                                                     string objectWidthPercentage, string objectHeightPercentage,
                                                     bool autoUpgrade, bool enableGpuAcceleration, bool windowless, bool enableHtmlAccess,
                                                     string minimumRuntimeVersion, string iFrameStyle)
        {
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
                                           {"width", string.Format("{0}%", objectWidthPercentage)},
                                           {"height", string.Format("{0}%", objectHeightPercentage)},
                                       };
            objectBuilder.MergeAttributes(objectAttributes);

            objectBuilder.InnerHtml = new MvcHtmlString(
                CraftParamTagBuilder("source", playerXapSource).ToString(TagRenderMode.SelfClosing) +
                CraftParamTagBuilder("minRuntimeVersion", minimumRuntimeVersion).ToString(TagRenderMode.SelfClosing) +
                CraftParamTagBuilder("onError", onErrorCallback).ToString(TagRenderMode.SelfClosing) +
                CraftParamTagBuilder("onLoad", onLoadedCallback).ToString(TagRenderMode.SelfClosing) +
                CraftParamTagBuilder("background", "white").ToString(TagRenderMode.SelfClosing) +
                CraftParamTagBuilder("autoUpgrade", autoUpgrade.ToString()).ToString(TagRenderMode.SelfClosing) +
                CraftParamTagBuilder("EnableGPUAcceleration", enableGpuAcceleration.ToString()).ToString(TagRenderMode.SelfClosing) +
                CraftParamTagBuilder("Windowless", windowless.ToString()).ToString(TagRenderMode.SelfClosing) +
                CraftParamTagBuilder("EnableHtmlAccess", enableHtmlAccess.ToString()).ToString(TagRenderMode.SelfClosing) +
                (String.IsNullOrWhiteSpace(xamlThemeSource) ?
                CraftParamTagBuilder("InitParams", string.Format("pluginUrl = {0}, scriptableName = {1}, InitialSettings ={2}\n ", sidewiredXapSource, scriptableName , playerSettings﻿.AsXmlSerializedString())) :
                CraftParamTagBuilder("InitParams", string.Format("pluginUrl = {0}, scriptableName = {1}, xamlThemeSource = {2}, InitialSettings ={3}\n ", sidewiredXapSource, scriptableName, xamlThemeSource, playerSettings﻿.AsXmlSerializedString()))
                ).ToString(
                    TagRenderMode.SelfClosing) +
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
            divBuilder.MergeAttributes(HtmlHelper.AnonymousObjectToHtmlAttributes(containerHtmlAttributes));
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
