using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerApp
{
    public interface IManagerPresenter
    {
        void GetStatistics(DateTime? startDate, DateTime? endDate);

        void OnGetRecommendations();
    }
}
