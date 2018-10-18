﻿using CsvHelper.Configuration;

namespace AppDynamics.Dexter.ReportObjects
{
    public class InformationPointReportMap : ClassMap<InformationPoint>
    {
        public InformationPointReportMap()
        {
            int i = 0;
            Map(m => m.Controller).Index(i); i++;
            Map(m => m.ApplicationName).Index(i); i++;
            Map(m => m.IPName).Index(i); i++;
            Map(m => m.IPType).Index(i); i++;

            Map(m => m.ApplicationID).Index(i); i++;
            Map(m => m.IPID).Index(i); i++;
            Map(m => m.MetricGraphLink).Index(i); i++;
            Map(m => m.ControllerLink).Index(i); i++;
            Map(m => m.ApplicationLink).Index(i); i++;
            Map(m => m.IPLink).Index(i); i++;
        }
    }
}