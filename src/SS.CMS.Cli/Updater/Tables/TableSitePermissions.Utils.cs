﻿using System;
using System.Collections.Generic;
using System.Text;
using Datory;
using SS.CMS.Abstractions;
using SS.CMS.Core;

namespace SS.CMS.Cli.Updater.Tables
{
    public partial class TableSitePermissions
    {
        public static readonly List<string> OldTableNames = new List<string>
        {
            "siteserver_SystemPermissions",
            "wcm_SystemPermissions"
        };

        public ConvertInfo Converter => new ConvertInfo
        {
            NewTableName = NewTableName,
            NewColumns = NewColumns,
            ConvertKeyDict = ConvertKeyDict,
            ConvertValueDict = ConvertValueDict
        };

        private string NewTableName => _databaseManager.SitePermissionsRepository.TableName;

        private List<TableColumn> NewColumns => _databaseManager.SitePermissionsRepository.TableColumns;

        private static readonly Dictionary<string, string> ConvertKeyDict =
            new Dictionary<string, string>
            {
                {nameof(SitePermissions.SiteId), nameof(PublishmentSystemId)},
                {"ChannelIdCollection", nameof(NodeIdCollection)}
            };

        private static readonly Dictionary<string, string> ConvertValueDict = null;
    }
}
