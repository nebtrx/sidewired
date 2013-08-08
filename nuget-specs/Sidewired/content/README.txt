Please see https://bitbucket.org/nebtrx/sidewired/overview for more information about Sidewired.
 
Getting started with Sidewired
------------------------------

Once installed Sidewired can be used in two modes: Explicit & Implicit. 

The explicit mode forces you to create the player configuration object and passes it to Sidewired Html Helpers

	// Controller Code Fragment
	
	...
	
	IPlayerSettings playerSettings = Core.Sidewired.CreatePlayerSettingsWith(playerSettings => playerSettings
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
												
	...
	
	return View(playerSettings);	
	
	...


	
	// View Code

	@model Sidewired.Core.Interfaces.IPlayerSettings 	
	
	...
	
	@Html.SilverlightMediaPlayer(@Url.Content("~/ClientBin/ProgressiveDownloadPlayer.xap"), Model, new { style = "height:350px; width:450px;" })
	
	...


The implicit mode allows you to define a unique configuration for your player anywhere in your code without worrying about any other code using or messing with it, since it is thread locally stored and only lasts for the contextual thread's life time. 
This mode comes quite handy when you want to get rid of passing the player configuration object to the view or, even worse, having to create it right there.


	// Controller(or anywhere) Code Fragment
	
	...
	
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
	
	...

	
	// View Code
	
	...
	
	@Html.SilverlightMediaPlayer(@Url.Content("~/ClientBin/ProgressiveDownloadPlayer.xap"), new { style = "height:350px; width:450px;" })
	
	...
	