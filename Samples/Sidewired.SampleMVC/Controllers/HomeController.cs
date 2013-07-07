using System;
using System.Web.Mvc;
using Sidewired.Core.Domain;
using Sidewired.Core.Fluent;

namespace Sidewired.SampleMVC.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Smooth()
        {
            //Core.Sidewired.WirePlayerSettings(settings => settings
            //    .WithAutoPlay()
            //    .WithPlaylistItem(item => item
            //        .WithTitle("BigBuck")
            //        .WithDeliveryMethod(DeliveryMethods.AdaptiveStreaming)
            //        .WithMediaSource(new Uri("http://localhost/Html5PlayerSamples/media/smooth/max.ism/manifest"))));

            var host = HttpContext.Request.Url.Host;
            var port = HttpContext.Request.Url.Port;
            var baseUrl = "http://" + host + ":" + port;

            Core.Sidewired.WirePlayerSettings(playerSettings => playerSettings
                .WithAutoPlay()
                .WithCaptionsVisibility(FeatureVisibility.Visible)

                .WithPlaylistItem(item => item.WithTimelineMarker(marker => marker.WithBegin(new TimeSpan(0, 0, 11))
                                                                                  .WithEnd(new TimeSpan(0, 0, 11))
                                                                                  .WithContent("Is he singing?")
                                                                                  .WithAllowSeek())
                                              .WithChapters(chapter => chapter.WithBegin(new TimeSpan(0,1,0))
                                                                              .WithEnd(new TimeSpan(0,1,45))
                                                                              .WithTitle("WOW!!!")
                                                                              .WithDescription("LOL"))
                                              .WithTimelineMarker(marker => marker.WithBegin(new TimeSpan(0, 0, 19))
                                                                                  .WithEnd(new TimeSpan(0, 0, 19))
                                                                                  .WithContent("Almost finish")
                                                                                  .WithAllowSeek())
                                              .WithInterstitialAdvertisement(advertisement => advertisement.WithDeliveryMethod(DeliveryMethods.ProgressiveDownload)
                                                                                                             .WithAdSource(new Uri(baseUrl + Url.Content("~/Content/media/ad.wmv")))
                                                                                                             .WithDuration(new TimeSpan(0, 0, 20))
                                                                                                             .WithStartTime(new TimeSpan(0, 0, 5)))
                                              .WithMarkerResource(resource => resource.WithSource(new Uri(baseUrl + Url.Content("~/Content/media/captions1.xml")))
                                                                                        .WithFormat("TTAF1-DFXP"))
                                              .WithMediaSource(new Uri("http://localhost/Videos/playlist.ism/manifest"))
                                              .WithDeliveryMethod(DeliveryMethods.AdaptiveStreaming)
                                              .WithThumbSource(new Uri(baseUrl + Url.Content("~/Content/media/magnifier.png"))))

                .WithPlaylistItem(item => item.WithTimelineMarker(marker => marker.WithBegin(new TimeSpan(0, 0, 14))
                                                                                  .WithEnd(new TimeSpan(0, 0, 14))
                                                                                  .WithContent("Watch the guy on the right")
                                                                                  .WithAllowSeek())
                                              .WithMarkerResource(resource => resource.WithSource(new Uri(baseUrl + Url.Content("~/Content/media/captions2.xml")))
                                                                                        .WithFormat("TTAF1-DFXP"))
                                              .WithMediaSource(new Uri(baseUrl + Url.Content("~/Content/media/video.wmv")))
                                              .WithDeliveryMethod(DeliveryMethods.ProgressiveDownload)
                                              .WithThumbSource(new Uri(baseUrl + Url.Content("~/Content/media/nuke.jpg")))
                                              .WithStartPosition(new TimeSpan(0,0,10))));


            return View();

            return View();
        }

        public ActionResult Progressive()
        {
            Core.Sidewired.WirePlayerSettings(settings => settings
                .WithAutoPlay()
                .WithPlaylistItem(item => item
                    .WithTitle("BigBuck")
                    .WithDeliveryMethod(DeliveryMethods.ProgressiveDownload)
                    .WithMediaSource(new Uri("http://localhost/Html5PlayerSamples/media/bigbuck.mp4"))));

            return View();
        }
    }
}
