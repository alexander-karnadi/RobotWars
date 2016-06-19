using RobotWars.Model;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace RobotWars.Gui
{ 
    public partial class FormBattle : Form
    {
        private const int EXTRA_COLUMN_INDEX_FOR_ROW_HEADER = 1;
        public FormBattle()
        {
            InitializeComponent();
        }

        public void RenderBattleSituation(Size battleAreaSize, IEnumerable<IRobot> robots)
        {
            var rows = new Dictionary<int, DataRow>();
            var dataTable = new DataTable();

            dataTable.Columns.Add(new DataColumn(" "));
            for (var index = 0; index <= battleAreaSize.Width; index++)
            {
                dataTable.Columns.Add(new DataColumn($"{index}"));
            }

            for (var index = 0; index <= battleAreaSize.Height; index++)
            {
                var newRow = dataTable.NewRow();
                rows[index] = newRow;
                newRow[0] = battleAreaSize.Height - index;

                dataTable.Rows.Add(newRow);
            }

            foreach (var robot in robots)
            {
                var rowIndex = battleAreaSize.Height - robot.CurrentPosition.Location.Y;
                var columnIndex = robot.CurrentPosition.Location.X + EXTRA_COLUMN_INDEX_FOR_ROW_HEADER;

                var row = dataTable.Rows[rowIndex];
                row[columnIndex] = CreateRobotInfoForGrid(row[columnIndex].ToString(), robot);
            }

            dataGridViewBattle.DataSource = dataTable;

            PrepareColumns();
        }

        private void PrepareColumns()
        {
            foreach (DataGridViewColumn column in dataGridViewBattle.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
                column.Width = 25;
            }
        }

        private string CreateRobotInfoForGrid(string currentInfo, IRobot newRobot)
        {
            var newRobotInfo = $"{newRobot.Name}; {newRobot.CurrentPosition.Heading}";

            if (string.IsNullOrWhiteSpace(currentInfo))
                return newRobotInfo;
            else
                return string.Join(",", currentInfo, newRobotInfo);
        }
    }
}
