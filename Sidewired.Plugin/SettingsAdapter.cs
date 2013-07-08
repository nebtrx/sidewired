using System.Collections.Generic;
using System.Xml.Serialization;
using AutoMapper;
using Microsoft.SilverlightMediaFramework.Utilities.Extensions;
using System;
using Sidewired.Core.Domain;
using Sidewired.Core.Interfaces;
using Sidewired.Core.Utilities;

namespace Sidewired.Plugin
{
    public class SettingsAdapter
    {
        static SettingsAdapter()
﻿        {      
﻿            MappingSetupServices.GetService().ForPlayerSettings();
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
