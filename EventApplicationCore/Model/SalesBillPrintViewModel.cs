using System.Collections.Generic;

namespace MyAccountProject.Model
{
    public class SalesBillPrintViewModel
    {
        public SalesBillViewModel SalesBillViewModel { get; set; }

        public List<SalesBillItemsViewModel> SalesItemBillViewModel { get; set; }
    }
}