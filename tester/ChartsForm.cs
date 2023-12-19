using LiveCharts.Defaults;
using LiveCharts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LiveCharts.Wpf;
using LiveCharts.WinForms;
using LiveCharts.Definitions.Charts;

namespace tester
{
    public partial class ChartsForm : Form
    {

        private readonly List<double> _calcTimes;

        public ChartsForm(List<double> calcTimes)
        {
            InitializeComponent();
            _calcTimes = calcTimes;
            DrawCharts();
        }

        public Func<ChartPoint, string> PointLabel { get; set; }

        private void DrawCharts()
        {

            var pointsA = new ChartValues<ObservablePoint>();

            TimeChart.AxisX.Add(new Axis { Title = "Номер теста", FontSize = 15 });
            TimeChart.AxisY.Add(new Axis { Title = "Время работы, мс", FontSize = 15 });
            PointLabel = chartPoint => $"{"Номер теста"}: {chartPoint.X}, {"Время работы, мс"}: {chartPoint.Y}";

            for (int i = 0; i < _calcTimes.Count; i++)
            {

                pointsA.Add(new ObservablePoint
                {
                    X = i + 1,
                    Y = _calcTimes[i]
                });
            }

            TimeChart.Series.Add(new LineSeries
            {
                Values = new ChartValues<ObservablePoint>(pointsA),
                Fill = System.Windows.Media.Brushes.Transparent,
                Title = "Время работы программы",
                LabelPoint = PointLabel,
            });

            DataTable dotTable = new DataTable();
            dotTable.Columns.Add("Номер теста", typeof(double));
            dotTable.Columns.Add("Время работы", typeof(double));

            for (int i = 0; i < _calcTimes.Count; i++)
            {
                dotTable.Rows.Add(i + 1, Math.Round(_calcTimes[i], 2));
            }

            dataGridView_Time.DataSource = dotTable;
            foreach (DataGridViewColumn column in dataGridView_Time.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }
    }
}
