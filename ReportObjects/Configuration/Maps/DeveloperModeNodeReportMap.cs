﻿using CsvHelper.Configuration;

namespace AppDynamics.Dexter.ReportObjects
{
    public class DeveloperModeNodeReportMap : ClassMap<DeveloperModeNode>
    {
        public DeveloperModeNodeReportMap()
        {
            int i = 0;
            Map(m => m.Controller).Index(i); i++;
            Map(m => m.ApplicationName).Index(i); i++;

            Map(m => m.TierName).Index(i); i++;
            Map(m => m.BTName).Index(i); i++;
            Map(m => m.NodeName).Index(i); i++;

            Map(m => m.ApplicationID).Index(i); i++;
            Map(m => m.TierID).Index(i); i++;
            Map(m => m.BTID).Index(i); i++;
            Map(m => m.NodeID).Index(i); i++;
        }
    }
}