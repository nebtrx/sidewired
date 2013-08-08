Sidewired
=========

What is it?
-----------

A **MEF Plugin** with a **fluent configuration API** which allow you to drop the whole media content experience of **Silverlight Media Platform Player Framework (SMPPF)** into an **ASP.NET MVC Application** without having to create your own **Customized Silverlight Player**.
In other words you may use any third party **Silverlight Player** like Silverlight Smooth Streaming Player or Silverlight Preogressive Download Player, both shipped by Microsoft, or even a lightweight custom player  and use **Sidewired** to *sidewire* the playlist, chapters, timeline markers, ads, captions and other stuff to enhance the end user experience.

How it works?
-------------

**Sidewired** deploys a **MEF Plugin** packed in a XAP file and a couple of Html Helpers, as well as the core library right into your **ASP.NET MVC Application**. 
Using **Sidewired fluent configuration API** you are able to create a **player configuration object**, wich will be use as DTO to pass the configuration to a **Silverlight Player**.
The starting spark lies inside the Html Helpers which, besides of allowing you to control **Sidewired**'s behavior, use the Silverlight object's markup to inject the **MEF Plugin** packed in the XAP file and the **player configuration object** serialized in XML format.

```html
	<div id="player2" style="height:350px; width:450px;">
		<object data="data:application/x-silverlight-2," height="100%" type="application/x-silverlight-2" width="100%">
			<param name="source" value="/ClientBin/TestCustomPlayer.xap"><param name="minRuntimeVersion" value="4.0.50826.0">
			<param name="onError" value="onError2">
			<param name="onLoad" value="onLoaded2">
			<param name="background" value="white">
			<param name="autoUpgrade" value="true">
			<param name="InitParams" value="pluginUrl = /ClientBin/Sidewired.xap, scriptableName = Player2, xamlThemeSource = /ClientBin/Simple.xaml, InitialSettings =
				<PlayerSettings>
				  <AutoPlay>true</AutoPlay>
				  <EnableCachedComposition>false</EnableCachedComposition>
				  <CaptionsVisibility>Visible</CaptionsVisibility>
				  <StartMuted>false</StartMuted>
				  <IsControlStripVisible>true</IsControlStripVisible>
				  <ContinuousPlay>false</ContinuousPlay>
				  <PlaylistVisibility>Hidden</PlaylistVisibility>
				  <PlaylistItem>
					<DeliveryMethod>ProgressiveDownload</DeliveryMethod>
					<JumpToLive>false</JumpToLive>
					<VideoStretchMode>Uniform</VideoStretchMode>
					<LiveDvrRequired>false</LiveDvrRequired>
					<MediaSource>http://localhost:57377/Content/media/video.wmv</MediaSource>
					<ThumbSource>http://localhost:57377/Content/media/nuke.jpg</ThumbSource>
					<MarkerResource>
					  <Format>TTAF1-DFXP</Format>
					  <Source>http://localhost:57377/Content/media/captions2.xml</Source>
					</MarkerResource>
					<TimelineMediaMarker>
					  <Id>4d1429d7e713473a893e004a222a4c32</Id>
					  <Content>Watch the guy on the right</Content>
					  <AllowSeek>true</AllowSeek>
					  <Begin>PT14S</Begin>
					  <End>PT14S</End>
					</TimelineMediaMarker>
					<StartPosition>PT10S</StartPosition>
				  </PlaylistItem>		
				</PlayerSettings>
				 ">
			<a href="http://go.microsoft.com/fwlink/?LinkID=149156&amp;v=3.0.40818.0" style="text-decoration:none">
				<img alt="Get Microsoft Silverlight" src="http://go.microsoft.com/fwlink/?LinkId=161376" style="border-style:none">
			</a>
		</object>
		<iframe id="_sl_historyFrame" style="visibility:hidden;height:0px;width:0px;border:0px"> </iframe>
	</div>

```

Once the plugin wakes up it reads the XML markup and parses it to an object graph coherent with the **player configuration object** which finally is transformed and injected in the **SMFPlayer** object. 

Installation
------------

Use the *Package Manager Console* for installing full Sidewired package:

```
	PM> Install-Package Sidewired
```

Or alternatively installing the core and web packages as it suits:

```
	PM> Install-Package Sidewired.Core
```

```
	PM> Install-Package Sidewired.Web
```

Getting Started
---------------

Once installed Sidewired can be used in two modes: **Explicit** & **Implicit**. 

The explicit mode forces you to create the **player configuration object** and passes it to **Sidewired** Html Helpers

```

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

```


```cshtml
	
	@* View Code *@

	@model Sidewired.Core.Interfaces.IPlayerSettings 	
	
	...
	
	@Html.SilverlightMediaPlayer(@Url.Content("~/ClientBin/ProgressiveDownloadPlayer.xap"), Model, new { style = "height:350px; width:450px;" })
	
	...
```

The implicit mode allows you to define a unique configuration for your player anywhere in your code without worrying about any other code using or messing with it since it is *thread locally storaged* and only lasts for the contextual thread's life time. 
This mode comes quite handy when you want to get rid of passing the **player configuration object** to the view or, even worse, having to create it right there.

```

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

```

```cshtml
	
	@* View Code *@
	
	...
	
	@Html.SilverlightMediaPlayer(@Url.Content("~/ClientBin/ProgressiveDownloadPlayer.xap"), new { style = "height:350px; width:450px;" })
	
	...
	
```

Additional Features
-------------------

Additionally, **Sidewired** allows you to set up a custom **XAML** based theme for the *sidewired* **Silverlight Player**. 
To achieve this, you have to specify the XAML file URI in the HTML Helper, just like this:

```cshtml
	
	...
	
	@Html.SilverlightMediaPlayer(@Url.Content("~/ClientBin/TestCustomPlayer.xap"), new { id= "player2", style = "height:350px; width:450px;" }, @Url.Content("~/ClientBin/Simple.xaml"),"Player2", "onError2", "onLoaded2")
	
	...
	
```

### Note
* This feature relies on the match of both resource key name (the one specified in the **XAML** theme file and the one specified in the player **XAML** UI Design Specification) during the process of binding the player style with the **SMFPlayer** object. It is a smoke gun potentially pointing to your feet which I strongly recommend using only when you control both sides (player code and **XAML** theme markup).

