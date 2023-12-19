using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;

namespace tester {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        int countTests;
        double errorRate;
        double step;
        double leftBorder;
        double rightBorder;
        int method;
        string coeffs;
        bool isPositive;
        string X;
        bool isFileClicked;
        List<double> coeffsList;
        List<string> argsForTest = new List<string>();
        List<string> resultsForTestExpected = new List<string>();
        List<string> resultsForTestFact = new List<string>();
        List<string> dataForSavingInput = new List<string>();
        List<double> calcTimes = new List<double>();

        Dictionary<string, int> myDict = new Dictionary<string, int>
        {
            { "парабол", 1 },
            { "трапеции", 2 },
            { "Монте-Карло", 3 },
        };

        public double Integral(int n) {
            double s = 0;
            double leftPower = leftBorder;
            double rightPower = rightBorder;
            for (int i = 0; i < n; i++) {
                s += coeffsList[i] * ((rightPower - leftPower) / (i + 1));
                leftPower *= leftBorder;
                rightPower *= rightBorder;
            }
            return s;
        }

        private void generateTests_button_Click(object sender, EventArgs e) {
            GenerateCoeffs();
            isFileClicked = false;
            countTests = (int)count_numericUpDown.Value;
            errorRate = (double)errorRate_numericUpDown.Value;
            step = (double)step_numericUpDown.Value;
            leftBorder = (double)left_numericUpDown.Value;
            rightBorder = (double)right_numericUpDown.Value;
            method = myDict[method_comboBox.SelectedItem.ToString()];
            coeffs = coef_textBox.Text;
            isPositive = positive_radioButton.Checked;
            

            try {
                coeffsList = ListOfCoeffs();
            } catch (Exception) {
                MessageBox.Show("Введены некорректные коэффициенты полинома!", "Ошибка!");
                return;
            }

            if (leftBorder >= rightBorder) {
                MessageBox.Show("Правая граница должна быть больше левой!", "Ошибка!");
                return;
            }

            if (argsForTest != null) {
                ClearLists();
            }
            
            if (isPositive) {
                string tests = MakePositiveTests();
                test_textBox.Text = tests;
            } else {
                string tests = MakeNegativeTests();
                test_textBox.Text = tests;
            }

            test_button.Enabled = true;
            saveTests_button.Enabled = true;
        }

        private void GenerateCoeffs(){
            Random rnd = new Random();
            var result = new List<string>();
            for (int i = 0; i < 10; i++) {
                int maxValue = (int)Math.Pow(10, i + 1);
                if (maxValue < 0)
                {
                    maxValue = int.MaxValue;
                }
                int start = rnd.Next((int)Math.Pow(10, i), maxValue);
                bool isPositive = rnd.Next(0, 2) == 0;
                if (!isPositive)
                {
                    start *= -1;
                }
                result.Add(start.ToString());
            }

            coef_textBox.Text = string.Join(" ", result);
        }

        private void ClearLists() {
            argsForTest.Clear();
            resultsForTestExpected.Clear();
            resultsForTestFact.Clear();
            dataForSavingInput.Clear();
        }

        private List<double> ListOfCoeffs() {
            return coeffs.Split(' ').Select(Double.Parse).ToList();
        }

        public double GetRandomNumber(double minimum, double maximum, int n) {
            Random random = new Random(DateTime.Now.Millisecond + n);
            return random.NextDouble() * (maximum - minimum) + minimum;
        }

        private string MakePositiveTest(int n, bool isFile=false) {
            string test = $"TEST {n} P\r\n";
            var listCoeffForN = coeffs.Split(' ');
            var coeffForN = "";
            for (int i = 0; i < n; i++)
            {
                coeffForN += listCoeffForN[i];
                if (i != n - 1)
                {
                    coeffForN += " ";
                }
            }

            if (!isFile) {
                X = $"{(decimal)leftBorder} {(decimal)rightBorder} {(decimal)step} {method} {coeffForN}";
            } 
            double result = Integral(n);
            test += $"X = {X}\r\n";
            test += $"EPS = {(decimal)errorRate}\r\n";
            test += $"YE = {(decimal)result}\r\n\r\n";

            dataForSavingInput.Add($"P~{errorRate}~{result}~{X}");
            if (!isFile) {
                argsForTest.Add(X);
            }
            resultsForTestExpected.Add(result.ToString());
            return test;           

        }

        private string MakePositiveTests() {
            string tests = "";
            for (int i = 1; i < countTests + 1; i++) {
                tests += MakePositiveTest(i, isFileClicked);
            }
            return tests;
        }

        static string GenerateRandomString(int n, int length = 1) {
            const string chars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ"; // Символы латинского алфавита
            var random = new Random(DateTime.Now.Millisecond + n);
            var result = new StringBuilder();

            for (int i = 0; i < length; i++) {
                result.Append(chars[random.Next(chars.Length)]);
            }

            return result.ToString();
        }

        private string MakeNegativeTest(int n, bool isFile=false) {
            string test = $"TEST {n} N\r\n";
            var listCoeffForN = coeffs.Split(' ');
            var coeffForN = "";
            for (int i = 0; i < n; i++)
            {
                coeffForN += listCoeffForN[i];
                if (i != n - 1)
                {
                    coeffForN += " ";
                }
            }


            if (!isFile) {
                var step = GenerateRandomString(n);
                X = $"{(decimal)leftBorder} {(decimal)rightBorder} {step} {method} {coeffForN}";
            }
            string result = "Шаг интегрирования должен быть в пределах [0.000001;0.5]";
            test += $"X = {X}\r\n";
            test += $"EPS = {(decimal)errorRate}\r\n";
            test += $"YE = {result}\r\n\r\n";

            if (!isFile) {
                argsForTest.Add(X);
            }
            resultsForTestExpected.Add(result);
            dataForSavingInput.Add($"N~{errorRate}~{result}~{X}");
            return test;

        }

        private string MakeNegativeTests() {
            string tests = "";
            for (int i = 1; i < countTests + 1; i++) {
                tests += MakeNegativeTest(i, isFileClicked);
            }
            return tests;
        }

        private string TestProgram(string args) {
            DateTime startTime = DateTime.Now;
            var process = new Process();

            process.StartInfo.FileName = @"Integral3x.exe";

            process.StartInfo.Arguments = args.Replace('.', ',');

            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.RedirectStandardInput = true;
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.CreateNoWindow = true;
            try
            {
                process.Start();
            } catch (Exception)
            {
                MessageBox.Show("Не найден файл программы!");
            }

            string YF = string.Empty;
            YF = process.StandardOutput.ReadLine();//результат полученный из тестируемой праграммы
            process.StandardInput.Write(Keys.Enter);
            process.WaitForExit();
            resultsForTestFact.Add(YF);
            DateTime endTime = DateTime.Now;
            TimeSpan elapsed = endTime - startTime;
            calcTimes.Add(elapsed.TotalMilliseconds);
            return YF;
        }

        private void test_button_Click(object sender, EventArgs e) {
            calcTimes.Clear();
            string resultOfExe = "";
            string successResult = "";
            string failedResult = "";
            for (int i = 0; i < argsForTest.Count; i++) {
                string test = argsForTest[i];
                resultOfExe = TestProgram(test);
                if (isPositive) {
                    var t = resultsForTestExpected[i];
                    //t = t.Replace(',', '.');
                    resultOfExe = resultOfExe.Replace('.', ',');
                    double dif = Math.Abs(double.Parse(resultOfExe.Substring(4)) - double.Parse(t));
                    if (dif <= errorRate) {
                        successResult += PrintResultOfTest(i + 1, 'P', "<=", true);
                        successResult += "\r\n";
                    } else {
                        failedResult += PrintResultOfTest(i + 1, 'P', ">", false);
                        failedResult += "\r\n";

                    }

                } else {
                    bool isSuccess = resultOfExe == resultsForTestExpected[i];
                    if (isSuccess) {
                        successResult += PrintResultOfTest(i + 1, 'N', "", isSuccess);
                        successResult += "\r\n";
                    } else {
                        failedResult += PrintResultOfTest(i + 1, 'N', "", !isSuccess);
                        failedResult += "\r\n";
                    }
                }
            }

            passed_textBox.Text = successResult;
            failed_textBox.Text = failedResult;

            save_result_button.Enabled = true;
            button_plotTimes.Enabled = true;
        }

        private string PrintResultOfTest(int n, char type, string comparator, bool isSuccess) {
            string result = $"TEST {n} {type}\r\n";
            double YE;
            double YF;
            double dif = 0;
            if (type == 'P') {
                YE = double.Parse(resultsForTestExpected[n - 1]);
                var t = resultsForTestFact[n - 1].Replace('.', ',');
                YF = double.Parse(t.Substring(4));
                dif = Math.Abs(YE - YF);
            }
            result += $"{argsForTest[n - 1]}\r\n";
            result += $"EPS = {(decimal)errorRate}\r\n";
            result += $"YE = {resultsForTestExpected[n - 1]}\r\n";
            result += $"YF = {resultsForTestFact[n - 1]}\r\n";
            if (type == 'P') {
                result += $"|YE-YF| = {(decimal)dif} {comparator} {(decimal)errorRate}\r\n";
            }
            if (isSuccess) {
                result += "Тест пройден";
            } else {
                result += "Тест не пройден";
            }
            result += "\r\n\r\n";

            return result;
        }

        private void saveTests_button_Click(object sender, EventArgs e) {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog.FilterIndex = 2;
            saveFileDialog.RestoreDirectory = true;

            if (saveFileDialog.ShowDialog() == DialogResult.OK) {
       
                using (var sr = new StreamWriter(saveFileDialog.FileName)) {
                    sr.WriteLine(dataForSavingInput.Count);
                    sr.WriteLine(coeffs);
                    foreach (var data in dataForSavingInput) {
                        sr.WriteLine(data);
                    }
                }
                MessageBox.Show("File was successfully saved!", "Saving!");
            } else {
                MessageBox.Show("File was not saved!", "Warning!");
            }
        }

        private void read_button_Click(object sender, EventArgs e) {
            isFileClicked = true;
            List<string> data = new List<string>();
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog.FilterIndex = 2;
            openFileDialog.RestoreDirectory = true;

            if (openFileDialog.ShowDialog() != DialogResult.OK) {
                MessageBox.Show("File was not read!", "Warning!");
                return;
            }

            using (StreamReader streamReader = new StreamReader(openFileDialog.FileName)) {
                try {
                    data = ReadDataFromFile(streamReader);
                } catch (Exception) {
                    MessageBox.Show("Некорректные данные в файле!", "Ошибка!");
                    return;
                }
            }
            argsForTest.Clear();
            MakeTestsFromSavingInput(data);
            test_button.Enabled = true;
            saveTests_button.Enabled = true;
        }

        private void MakeTestsFromSavingInput(List<string> data) {
            string test = "";
            int i = 1;
            coeffs = data[0];
            coef_textBox.Text = data[0];
            foreach (string d in data.Skip(1)) {
                string[] splitData =  d.Split('~');
                test += $"TEST {i} {splitData[0]}\r\n";
                test += $"X = {splitData[3]}\r\n";
                argsForTest.Add(splitData[3]);
                test += $"EPS = {splitData[1]}\r\n";
                test += $"YE = {splitData[2]}\r\n\r\n";
                i++;

                errorRate = double.Parse(splitData[1]);
                leftBorder = double.Parse(splitData[3].Split()[0]);
                rightBorder = double.Parse(splitData[3].Split()[1]);
                coeffsList = ListOfCoeffs();

                if (splitData[0] == "P") {
                    isPositive = true;
                    string tests = MakePositiveTests();
                } else {
                    isPositive = false;
                    string tests = MakeNegativeTests();
                }
            }
            test_textBox.Text = test;
        }

        private List<string> ReadDataFromFile(StreamReader streamReader) {
            List<string> data = new List<string>();
            countTests = int.Parse(streamReader.ReadLine());
            
            for (int i = 0; i < countTests + 1; i++) {
                
                data.Add(streamReader.ReadLine());
          
            }

            return data;
        }

        private void save_result_button_Click(object sender, EventArgs e) {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog.FilterIndex = 2;
            saveFileDialog.RestoreDirectory = true;

            if (saveFileDialog.ShowDialog() == DialogResult.OK) {

                using (var sr = new StreamWriter(saveFileDialog.FileName)) {
                    sr.WriteLine(passed_textBox.Text);
                    sr.WriteLine(failed_textBox.Text);
                    
                }
                MessageBox.Show("Файл был успешно сохранен!", "Сохранение!");
            } else {
                MessageBox.Show("Файб не был сохранен!", "Предупреждение!");
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void step_numericUpDown_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button_plotTimes_Click(object sender, EventArgs e)
        {
            ChartsForm chartForm = new ChartsForm(calcTimes);
            chartForm.Show();
        }
    }
}
