using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using thINC.BukStore.MultiTenancy.HostDashboard.Dto;

namespace thINC.BukStore.MultiTenancy.HostDashboard
{
    public interface IIncomeStatisticsService
    {
        Task<List<IncomeStastistic>> GetIncomeStatisticsData(DateTime startDate, DateTime endDate,
            ChartDateInterval dateInterval);
    }
}