using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lessons2206.Engine
{
    class CAction
    {
        private const int GridAutoResizeBoundary = 100;
        private const int MaxColumnWidth = 300;

        public static void AutoSizeColumns(DataGridView dataGridView)
        {
            if (dataGridView.RowCount <= GridAutoResizeBoundary)
                dataGridView.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            else
                dataGridView.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.DisplayedCells);
            foreach (DataGridViewColumn column in dataGridView.Columns)
            {
                if (column.Width > MaxColumnWidth)
                    column.Width = MaxColumnWidth;
            }
        }
    }
}
