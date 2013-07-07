using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows.Markup;
using System.Xml.Serialization;
using AutoMapper;
using Microsoft.SilverlightMediaFramework.Utilities.Extensions;
using System;
using System.Windows;
using System.Windows.Media;
using Sidewired.Core.Domain;
using Sidewired.Core.Interfaces;
using Sidewired.Core.Utilities;
using Advertisement = Microsoft.SilverlightMediaFramework.Core.Media.Advertisement;
using FontStretch = Sidewired.Core.Domain.FontStretch;
using FontStyle = Sidewired.Core.Domain.FontStyle;
using FontWeight = Sidewired.Core.Domain.FontWeight;
using MarkerResource = Microsoft.SilverlightMediaFramework.Core.Media.MarkerResource;
using PlaylistItem = Microsoft.SilverlightMediaFramework.Core.Media.PlaylistItem;
using Stretch = Sidewired.Core.Domain.Stretch;
using Thickness = Sidewired.Core.Domain.Thickness;
using VerticalAlignment = Sidewired.Core.Domain.VerticalAlignment;

namespace Sidewired.Plugin
{
    public class SettingsAdapter
    {
        static SettingsAdapter()
﻿        {      
﻿            #region Enum Mappings

﻿            ﻿Mapper.CreateMap<FeatureVisibility, Microsoft.SilverlightMediaFramework.Core.FeatureVisibility>().ConstructUsing(context => (Microsoft.SilverlightMediaFramework.Core.FeatureVisibility)Convert.ToInt32(context.SourceValue));
﻿            ﻿Mapper.CreateMap<Stretch, System.Windows.Media.Stretch>().ConstructUsing(context => (System.Windows.Media.Stretch)Convert.ToInt32(context.SourceValue));
﻿            ﻿Mapper.CreateMap<VerticalAlignment, System.Windows.VerticalAlignment>().ConstructUsing(context => (System.Windows.VerticalAlignment)Convert.ToInt32(context.SourceValue));
﻿            ﻿Mapper.CreateMap<FontWeight, System.Windows.FontWeight>().ConvertUsing(weight =>
﻿                                                                                {
﻿                                                                                    switch (weight)
﻿                                                                                    {
﻿                                                                                        case FontWeight.Thin:
﻿                                                                                            return FontWeights.Thin;
﻿                                                                                        case FontWeight.ExtraLight:
﻿                                                                                            return FontWeights.ExtraLight;
﻿                                                                                        case FontWeight.Light:
﻿                                                                                            return FontWeights.Light;
﻿                                                                                        case FontWeight.SemiLight:
﻿                                                                                            return FontWeights.SemiLight;
﻿                                                                                        case FontWeight.Normal:
﻿                                                                                            return FontWeights.Normal;
﻿                                                                                        case FontWeight.Medium:
﻿                                                                                            return FontWeights.Medium;
﻿                                                                                        case FontWeight.SemiBold:
﻿                                                                                            return FontWeights.SemiBold;
﻿                                                                                        case FontWeight.Bold:
﻿                                                                                            return FontWeights.Bold;
﻿                                                                                        case FontWeight.ExtraBold:
﻿                                                                                            return FontWeights.ExtraBold;
﻿                                                                                        case FontWeight.Black:
﻿                                                                                            return FontWeights.Black;
﻿                                                                                        case FontWeight.ExtraBlack:
﻿                                                                                            return FontWeights.ExtraBlack;
﻿                                                                                        default:
﻿                                                                                            throw new ArgumentOutOfRangeException("weight");
﻿                                                                                    }
﻿                                                                                });
﻿            ﻿Mapper.CreateMap<FontStyle, System.Windows.FontStyle>().ConvertUsing(style =>
﻿                                                                            {
﻿                                                                                switch (style)
﻿                                                                                {
﻿                                                                                    case FontStyle.Normal:
﻿                                                                                        return FontStyles.Normal;
﻿                                                                                    case FontStyle.Italic:
﻿                                                                                        return FontStyles.Italic;
﻿                                                                                    default:
﻿                                                                                        throw new ArgumentOutOfRangeException("style");
﻿                                                                                }
﻿                                                                            });
﻿            ﻿Mapper.CreateMap<FontStretch, System.Windows.FontStretch>().ConvertUsing(stretch =>
﻿                                                                                {
﻿                                                                                    switch (stretch)
﻿                                                                                    {
﻿                                                                                        case FontStretch.UltraCondensed:
﻿                                                                                            return FontStretches.UltraCondensed;
﻿                                                                                        case FontStretch.ExtraCondensed:
﻿                                                                                            return FontStretches.ExtraCondensed;
﻿                                                                                        case FontStretch.Condensed:
﻿                                                                                            return FontStretches.Condensed;
﻿                                                                                        case FontStretch.SemiCondensed:
﻿                                                                                            return FontStretches.SemiCondensed;
﻿                                                                                        case FontStretch.Normal:
﻿                                                                                            return FontStretches.Normal;
﻿                                                                                        case FontStretch.SemiExpanded:
﻿                                                                                            return FontStretches.SemiExpanded;
﻿                                                                                        case FontStretch.Expanded:
﻿                                                                                            return FontStretches.Expanded;
﻿                                                                                        case FontStretch.ExtraExpanded:
﻿                                                                                            return FontStretches.ExtraExpanded;
﻿                                                                                        case FontStretch.UltraExpanded:
﻿                                                                                            return FontStretches.UltraExpanded;
﻿                                                                                        default:
﻿                                                                                            throw new ArgumentOutOfRangeException("stretch");
﻿                                                                                    }
﻿                                                                                });
﻿
﻿            ﻿Mapper.CreateMap<S3DContents, Microsoft.SilverlightMediaFramework.Plugins.Primitives.S3D.S3D_Contents>().ConstructUsing(context => (Microsoft.SilverlightMediaFramework.Plugins.Primitives.S3D.S3D_Contents)Convert.ToInt32(context.SourceValue));
﻿            ﻿Mapper.CreateMap<S3DFormats, Microsoft.SilverlightMediaFramework.Plugins.Primitives.S3D.S3D_Formats>().ConstructUsing(context => (Microsoft.SilverlightMediaFramework.Plugins.Primitives.S3D.S3D_Formats)Convert.ToInt32(context.SourceValue));
﻿            ﻿Mapper.CreateMap<S3DEyePriorities, Microsoft.SilverlightMediaFramework.Plugins.Primitives.S3D.S3D_EyePriorities>().ConstructUsing(context => (Microsoft.SilverlightMediaFramework.Plugins.Primitives.S3D.S3D_EyePriorities)Convert.ToInt32(context.SourceValue));
﻿            ﻿Mapper.CreateMap<S3DSubsamplingModes, Microsoft.SilverlightMediaFramework.Plugins.Primitives.S3D.S3D_SubsamplingModes>().ConstructUsing(context => (Microsoft.SilverlightMediaFramework.Plugins.Primitives.S3D.S3D_SubsamplingModes)Convert.ToInt32(context.SourceValue));
﻿            ﻿Mapper.CreateMap<S3DSubsamplingOrders, Microsoft.SilverlightMediaFramework.Plugins.Primitives.S3D.S3D_SubsamplingOrders>().ConstructUsing(context => (Microsoft.SilverlightMediaFramework.Plugins.Primitives.S3D.S3D_SubsamplingOrders)Convert.ToInt32(context.SourceValue));
﻿
﻿            #endregion
﻿
﻿            #region Aggregateds Types Mappings
﻿            ﻿Mapper.CreateMap<IAdvertisement, Advertisement>().ConvertUsing(advertisement =>
﻿                                                                                        {
﻿                                                                                            if (advertisement != null)
﻿                                                                                            {
﻿                                                                                                Advertisement ad = new Microsoft.SilverlightMediaFramework.Core.Media.Advertisement()
﻿                                                                                                {
﻿                                                                                                    AdSource = advertisement.AdSource,
﻿                                                                                                    DeliveryMethod = Mapper.Map<DeliveryMethods, Microsoft.SilverlightMediaFramework.Plugins.Primitives.DeliveryMethods>(advertisement.DeliveryMethod),
﻿                                                                                                    Duration = advertisement.Duration,
﻿                                                                                                    PauseTimeline = advertisement.PauseTimeline,
﻿                                                                                                    StartTime = advertisement.StartTime,
﻿                                                                                                    ClickThrough = advertisement.ClickThrough,
﻿                                                                                                    IsLinearClip = advertisement.IsLinearClip,
﻿                                                                                                };
﻿                                                                                                return ad;
﻿                                                                                            }
﻿                                                                                            return null;
﻿                                                                                        });
﻿            ﻿Mapper.CreateMap<IMarkerResource, MarkerResource>();
﻿            ﻿Mapper.CreateMap<ITimelineMediaMarker, Microsoft.SilverlightMediaFramework.Core.Media.TimelineMediaMarker>().ConvertUsing(marker =>
﻿                                                                                                {
﻿                                                                                                    if (marker != null)
﻿                                                                                                    {
﻿                                                                                                        return new Microsoft.SilverlightMediaFramework.Core.Media.TimelineMediaMarker()
﻿                                                                                                        {
﻿                                                                                                            Begin = marker.Begin,
﻿                                                                                                            End = marker.End,
﻿                                                                                                            Content = marker.Content,
﻿                                                                                                            AllowSeek = marker.AllowSeek
﻿                                                                                                        };
﻿                                                                                                    }
﻿                                                                                                    return null;
﻿                                                                                                });
            Mapper.CreateMap<IChapter, Microsoft.SilverlightMediaFramework.Core.Media.Chapter>()
                .ForMember(dest => dest.Begin, opt => opt.MapFrom(src => src.Begin))
                .ForMember(dest => dest.End, opt => opt.MapFrom(src => src.End))
                .ForMember(dest => dest.Content, opt => opt.MapFrom(src => src.Content))
                .ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.Description))
                .ForMember(dest => dest.Title, opt => opt.MapFrom(src => src.Title))
                .ForMember(dest => dest.ThumbSource, opt => opt.MapFrom(src => src.ThumbSource));

            Mapper.CreateMap<IPlaylistItem, PlaylistItem>();
﻿            ﻿Mapper.CreateMap<Thickness, System.Windows.Thickness>();
﻿            ﻿Mapper.CreateMap<ColorString, Brush>().ConvertUsing(colorString => new SolidColorBrush(colorString));
﻿            ﻿Mapper.CreateMap<String, FontFamily>().ConvertUsing(fontFamily => new FontFamily(fontFamily));
﻿            ﻿Mapper.CreateMap<S3DProperties, Microsoft.SilverlightMediaFramework.Plugins.Primitives.S3D.S3DProperties>();
            Mapper.CreateMap<IPlayerSettings, Microsoft.SilverlightMediaFramework.Core.SMFPlayer>();
            #endregion
        }

        private static bool TryGetPlayerSettings(IDictionary<string, string> initParams, out IPlayerSettings playerSettings)
        {
            if (initParams.ContainsKeyIgnoreCase("InitialSettings"))
            {
                string xmlSettings = initParams.GetEntryIgnoreCase("InitialSettings");
                if (!String.IsNullOrWhiteSpace(xmlSettings))
                {
                    var serializer = new XmlSerializer(typeof(PlayerSettings));
                    playerSettings = (IPlayerSettings)serializer.Deserialize(xmlSettings.AsStream());
                    return true;
                }

            }
            playerSettings = null;
            return false;
        }

        

        public static void ApplyInitialSettingsToPlayer(IDictionary<String, string> initParams, Microsoft.SilverlightMediaFramework.Core.SMFPlayer player)
        {
            initParams.IfNotNull(dictionary =>
                                     {
                                         IPlayerSettings playerSettings;
                                         if (TryGetPlayerSettings(initParams, out playerSettings))
                                         {
                                             Mapper.Map(playerSettings, player);
                                         }
                                     });

        }
    }
}
