using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

/// <summary>
/// Protsessoriaja planeerimise algoritmide töö visualiseerimise simulaator
/// Operatsioonisüsteemid 20/21
/// Tartu Ülikool
/// @author Anton Slavin
/// </summary>
namespace OSPlaneerija
{
    public partial class MainForm : Form
    {
        private Scheduler scheduler;
        private string algoInputString;
        private Bitmap ganttChart;

        public MainForm()
        {
            InitializeComponent();
            scheduler = new Scheduler();
            algoInputString = "";
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            taskListGrid.Columns.Add("Name", "Nimi");
            taskListGrid.Columns.Add("ArrivalTime", "Saab");
            taskListGrid.Columns.Add("BurstTime", "Kest");
            taskListGrid.Columns.Add("WaitTime", "Oote");
            taskListGrid.Columns.Add("Start", "Alg");
            taskListGrid.Columns.Add("Exit", "Lõpp");
            taskListGrid.Columns.Add("Turnaround", "Pöörd");
            taskListGrid.Columns["Turnaround"].MinimumWidth = 70;
            Clear();
        }

        private void loadAlgoInput()
        {
            // Check if custom input is selected & copy input from the textbox
            if (customAlgo.Checked && (customAlgoTextbox.Text.Length != 0))
            {
                algoInputString = customAlgoTextbox.Text;
            }
            else
            {
                // Find the selected radio button (yes there are many better ways to do this)
                algoInputString = sampleAlgo1.Checked ? sampleAlgo1.Text :
                    (sampleAlgo2.Checked ? sampleAlgo2.Text :
                    (sampleAlgo3.Checked ? sampleAlgo3.Text : ""));
            }
        }

        private void startAlgorithm(string algorithm)
        {
            Clear();
            loadAlgoInput();

            if (String.IsNullOrEmpty(algoInputString)) return; // No input was given at all, exit.

            chosenAlgoLabel.Text = algorithm;

            // Display messagebox on error (wrong string format)
            try { scheduler.LoadTasks(algoInputString); }
            catch (FormatException)
            {
                MessageBox.Show("Vale sisend!", "Viga", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Algorithm switcher based on the given parameter
            switch (algorithm)
            {
                case "FCFS":
                    scheduler.FCFS();
                    break;
                case "SRTF":
                    scheduler.SRTF();
                    break;
                case "RR3":
                    scheduler.RR(3);
                    break;
                case "2xFCFS":
                    scheduler.DoubleFCFS();
                    break;
                default:
                    return;
            }

            // Draw the Gantt chart.
            DrawGantt();

            // Now calculate and display the average waiting time
            averageTimeLabel.Text = Math.Round(scheduler.AvgWaitTime(), 1).ToString();

            // Draw content to the taskListGrid
            foreach (Task task in scheduler.TaskList)
            {
                taskListGrid.Rows.Add(task.Name, task.ArrivalTime, task.BurstTime, task.WaitTime,
                                      task.Start, task.Exit, task.Turnaround);
                taskListGrid.Sort(taskListGrid.Columns["ArrivalTime"], ListSortDirection.Ascending);
                taskListGrid.ClearSelection();
            }
        }

        private void DrawGantt()
        {
            ganttChart = new Bitmap(ganttField.Width, ganttField.Height);

            int taskHeight = ganttField.Height - 22; // adjust for bottom tick number row

            // Calculate the width of every tick based on their amound & to get the best possible fit
            int taskWidth = ganttField.Width / scheduler.TaskHistory.Count;

            using (Graphics gr = Graphics.FromImage(ganttChart))
            using (Brush blackBrush = new SolidBrush(Color.Black))
            using (Font font = new Font("Consolas", 9))
            {
                gr.Clear(Color.WhiteSmoke);

                // Iterate through the history list, which contains info on every tick
                // Here i is used for calculating the x coordinate (increasing by taskWidth every tick)
                for (int i = 0, tick = 0; tick < scheduler.TaskHistory.Count; i += taskWidth, tick++)
                {
                    // Draw and fill a rectangle for every tick
                    Rectangle rect = new Rectangle(i, 0, taskWidth, taskHeight - 1);
                    gr.FillRectangle(new SolidBrush(((Task)scheduler.TaskHistory[tick]).Color), rect);

                    using (Pen selPen = new Pen(Color.Black))
                    {
                        gr.DrawRectangle(selPen, rect);
                    }

                    // Draw the task name 
                    string taskName = ((Task)scheduler.TaskHistory[tick]).Name;

                    // Get the task name string size to center the string in each rectangle
                    SizeF stringSize = gr.MeasureString(taskName, font);
                    PointF stringLocation = new PointF(i + (taskWidth / 2) - (stringSize.Width / 2),
                                                       (taskHeight / 2) - (stringSize.Height / 2));

                    // Antialiasing for smooth text
                    gr.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;

                    // Skip drawing the task name for empty slots (P0)
                    if (!taskName.Equals("P0"))
                    {
                        gr.DrawString(taskName, font, blackBrush, stringLocation);
                    }

                    // Draw tick numbers below the rectangles
                    PointF tickStringLocation = new PointF(i - 3, 0 + (taskHeight) + 6);
                    gr.DrawString(tick.ToString(), font, blackBrush, tickStringLocation);
                }

                // Draw the last tick number
                gr.DrawString(scheduler.TaskHistory.Count.ToString(), font, blackBrush,
                    new PointF(scheduler.TaskHistory.Count * taskWidth - 13, (taskHeight) + 6));

            }

            ganttField.Image = ganttChart;
        }

        private void Clear()
        {
            scheduler.ClearTaskList();
            scheduler.ClearTaskHistory();
            ganttField.Image = null;
            chosenAlgoLabel.Text = "---";
            averageTimeLabel.Text = "0.0";
            taskListGrid.Rows.Clear();
            // Collect any garbage from drawing the bitmaps
            GC.Collect();
        }

        // Button clicks
        private void DoubleFCFSButton_Click(object sender, EventArgs e) { startAlgorithm("2xFCFS"); }
        private void FCFSButton_Click(object sender, EventArgs e) { startAlgorithm("FCFS"); }
        private void SRTFButton_Click(object sender, EventArgs e) { startAlgorithm("SRTF"); }
        private void RR4Button_Click(object sender, EventArgs e) { startAlgorithm("RR3"); }
        private void ClearButton_Click(object sender, EventArgs e) { Clear(); }

        // Switch to the "custom algorithm" option automatically when selecting its input textbox
        private void customAlgoTextbox_TextChanged(object sender, EventArgs e) { customAlgo.Checked = true; }
        private void customAlgoTextbox_Click(object sender, EventArgs e) { customAlgo.Checked = true; }
        private void customAlgoTextbox_Enter(object sender, EventArgs e) { customAlgo.Checked = true; }
    }
}
