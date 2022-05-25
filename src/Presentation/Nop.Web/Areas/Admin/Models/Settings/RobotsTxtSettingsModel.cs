using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;
using Nop.Web.Framework.Models;
using Nop.Web.Framework.Mvc.ModelBinding;

namespace Nop.Web.Areas.Admin.Models.Settings
{
    /// <summary>
    /// Represents the robots.txt settings model
    /// </summary>
    public partial record RobotsTxtSettingsModel : BaseNopModel
    {
        [NopResourceDisplayName("Admin.Configuration.Settings.GeneralCommon.RobotsDisallowPaths")]
        public string DisallowPaths { get; set; }

        [NopResourceDisplayName("Admin.Configuration.Settings.GeneralCommon.RobotsLocalizableDisallowPaths")]
        public string LocalizableDisallowPaths { get; set; }

        [NopResourceDisplayName("Admin.Configuration.Settings.GeneralCommon.RobotsDisallowLanguages")]
        public List<int> DisallowLanguages { get; set; } = new();
        public List<SelectListItem> AvailableLanguages { get; set; } = new();

        [NopResourceDisplayName("Admin.Configuration.Settings.GeneralCommon.RobotsAdditionsRules")]
        public string AdditionsRules { get; set; }
        
        [NopResourceDisplayName("Admin.Configuration.Settings.GeneralCommon.RobotsAllowSitemapXml")]
        public bool AllowSitemapXml { get; set; }

        public string CustomFileExists { get; set; }
        
        public string AdditionsInstruction { get; set; }
    }
}
