using Bills.Models.Entities;
using System.Collections.Generic;

namespace Bills.Repository
{
    public interface IBillItemRepository : IRepository<BillItem>
    {
        List<BillItem> MoreDetails(int id);
    }
}
