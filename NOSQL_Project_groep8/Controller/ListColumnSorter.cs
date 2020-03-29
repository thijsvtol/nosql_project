using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Windows.Forms;


public class ListViewColumnSorter : IComparer
{
    private int ColumnToSort;

    private SortOrder OrderOfSort;

    private CaseInsensitiveComparer ObjectCompare;

    public ListViewColumnSorter()
    {
        // geen colomns gesorteert...
        ColumnToSort = 0;

        // sorteer order is none...
        OrderOfSort = SortOrder.None;

        // start CaseInsensitiveComparer...
        ObjectCompare = new CaseInsensitiveComparer();
    }

    // vergelijk x en y...
    public int Compare(object x, object y)
    {
        int compareResult;
        ListViewItem listviewX, listviewY;

        // vergelijk...
        listviewX = (ListViewItem)x;
        listviewY = (ListViewItem)y;
        compareResult = ObjectCompare.Compare(listviewX.SubItems[ColumnToSort].Text, listviewY.SubItems[ColumnToSort].Text);

        // kijk welk order de juiste is...
        if (OrderOfSort == SortOrder.Ascending)
        {
            // Ascending...
            return compareResult;
        }
        else if (OrderOfSort == SortOrder.Descending)
        {
            // Descending...
            return (-compareResult);
        }
        else
        {
            // 0 als ze gelijk zijn...
            return 0;
        }
    }

    // kijk welk colom gesorteerd moet worden...
    public int SortColumn
    {
        set
        {
            ColumnToSort = value;
        }
        get
        {
            return ColumnToSort;
        }
    }

    // sorteer...
    public SortOrder Order
    {
        set
        {
            OrderOfSort = value;
        }
        get
        {
            return OrderOfSort;
        }
    }

}