using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace MixERP.Net.WebControls.StockTransactionFactory
{
    public partial class StockTransactionForm
    {
		
		
		
        private static void CreateItemCodeField(TableRow row)
        {
            using (TableCell cell = new TableCell())
            {
                using (HtmlInputText itemCodeInputText = new HtmlInputText())
                {
                    itemCodeInputText.ID = "ItemCodeInputText";
                    itemCodeInputText.Attributes.Add("title", "ALT + C");

                    cell.Controls.Add(itemCodeInputText);
                }

                row.Cells.Add(cell);
            }
        }

        private static void CreateItemField(TableRow row)
        {
            using (TableCell cell = new TableCell())
            {
                using (HtmlSelect itemSelect = new HtmlSelect())
                {
                    itemSelect.ID = "ItemSelect";
                    itemSelect.Attributes.Add("title", "Ctrl + I");
                    cell.Controls.Add(itemSelect);
                }

                row.Cells.Add(cell);
            }
        }



        private static void CreateItemSoldPointsField(TableRow row)
        {
            using (TableCell cell = new TableCell())
            {
                using (HtmlSelect itemSoldpoints= new HtmlSelect())
                {
                    //unitSelect.ID = "UnitSelect";
                    //unitSelect.Attributes.Add("title", "Ctrl + U");
                    //cell.Controls.Add(unitSelect);


                    //using (HtmlInputText amountInputText = new HtmlInputText())
                    //{
                    //    amountInputText.ID = "AmountInputText";
                    //    amountInputText.Attributes.Add("class", "currency text-right");
                    //    amountInputText.Attributes.Add("readonly", "readonly");

                    //    cell.Controls.Add(amountInputText);
                    //}

                    itemSoldpoints.ID = "ItemSoldPointsSelect";
                    itemSoldpoints.Attributes.Add("title", "Ctrl + Q");
                    itemSoldpoints.Attributes.Add("readonly", "readonly");
                    itemSoldpoints.Attributes.Add("class", "integer text-right");

                    itemSoldpoints.Value = "1";

                    cell.Controls.Add(itemSoldpoints);
                }

                row.Cells.Add(cell);
            }
        }
    }
}