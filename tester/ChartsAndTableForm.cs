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

namespace tester {
    public partial class ChartsAndTableForm : Form {
        private readonly List<string> _firstIntegral;
        private readonly List<string> _secondIntegral;
        private readonly List<string> _thirdIntegral;
        private readonly List<string> _ownIntegral;

        public ChartsAndTableForm(List<string> firstIntegral, List<string> secondIntegral, List<string> thirdIntegral, List<string> ownIntegral) {
            InitializeComponent();
            _secondIntegral = secondIntegral;
            _firstIntegral = firstIntegral;
            _thirdIntegral = thirdIntegral;
            _ownIntegral = ownIntegral;
            DrawCharts();
        }

        private List<double> MakeDouble(List<string> strings) {
            List<double> doubles = new List<double>();
            foreach (string s in strings) {
                doubles.Add(double.Parse(s));
            }

            return doubles;
        }

        private List<double> MakeDoubleRel(List<string> strings, List<double> ownIntegral) {
            List<double> doubles = new List<double>();
            for (int i = 0; i < strings.Count; i++) {
                doubles.Add(Math.Abs((double.Parse(strings[i]) - ownIntegral[i]) / ownIntegral[i] * 100));
            }

            return doubles;
        }

        public Func<ChartPoint, string> PointLabel { get; set; }

        private void DrawCharts() {
            List<double> ownIntegral = MakeDouble(_ownIntegral);
            List<double> firstIntegral = MakeDoubleRel(_firstIntegral, ownIntegral);
            List<double> secondIntegral = MakeDoubleRel(_secondIntegral, ownIntegral);
            List<double> thirdIntegral = MakeDoubleRel(_thirdIntegral, ownIntegral);

            var pointsA = new ChartValues<ObservablePoint>();
            var pointsB = new ChartValues<ObservablePoint>();
            var pointsC = new ChartValues<ObservablePoint>();

            cartesianChart1.AxisX.Add(new Axis { Title = "Номер теста", FontSize = 15 });
            cartesianChart1.AxisY.Add(new Axis { Title = "Относительная погрешность, %", FontSize = 15 });
            PointLabel = chartPoint => $"{"Номер теста"}: {chartPoint.X}, {"Относительная погрешность, %"}: {chartPoint.Y}";

            for (int i = 0; i < firstIntegral.Count; i++) {

                pointsA.Add(new ObservablePoint {
                    X = i + 1,
                    Y = firstIntegral[i]
                });

                pointsB.Add(new ObservablePoint {
                    X = i + 1,
                    Y = secondIntegral[i]
                });

                pointsC.Add(new ObservablePoint {
                    X = i + 1,
                    Y = thirdIntegral[i]
                });
            }

            cartesianChart1.Series.Add(new LineSeries {
                Values = new ChartValues<ObservablePoint>(pointsA),
                Fill = System.Windows.Media.Brushes.Transparent,
                Title = "Метод парабол",
                LabelPoint = PointLabel,
            });

            cartesianChart1.Series.Add(new LineSeries {
                Values = new ChartValues<ObservablePoint>(pointsB),
                Fill = System.Windows.Media.Brushes.Transparent,
                Title = "Метод трапеции",
                LabelPoint = PointLabel,
            });

            cartesianChart1.Series.Add(new LineSeries {
                Values = new ChartValues<ObservablePoint>(pointsC),
                Fill = System.Windows.Media.Brushes.Transparent,
                Title = "Метод Монте-Карло",
                LabelPoint = PointLabel,
            });

            cartesianChart1.LegendLocation = LegendLocation.Bottom;


            DataTable dotTable = new DataTable();
            dotTable.Columns.Add("Номер теста", typeof(double));
            dotTable.Columns.Add("Метод парабол", typeof(double));
            dotTable.Columns.Add("Метод трапеций", typeof(double));
            dotTable.Columns.Add("Метод Монте-Карло", typeof(double));


            for (int i = 0; i < firstIntegral.Count; i++) {
                dotTable.Rows.Add(i + 1, firstIntegral[i], secondIntegral[i], thirdIntegral[i]);
            }


            dataGridView1.DataSource = dotTable;
            foreach (DataGridViewColumn column in dataGridView1.Columns) {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }

        }
    }
}
