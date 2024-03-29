﻿using Serilog;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tracker
{
    public partial class Tracker : Form
    {
        private readonly Stopwatch watcher;
        private string previousText;
        private DataTable tableSource;
        private Timer timer;
        private ILogger logger;
        public Tracker()
        {
            InitializeComponent();

            watcher = new Stopwatch();
            tableSource = new DataTable();
            tableSource.Columns.Add(new DataColumn("Work Item"));
            tableSource.Columns.Add(new DataColumn("Minutes"));
            tableSource.RowChanged += TableSource_RowChanged;

            grvTimeCaptureHistory.DataSource = tableSource;

            timer = new Timer();
            timer.Tick += Timer_Tick;
            timer.Interval = 1000;
            timer.Start();

            logger = new LoggerConfiguration()
                          .MinimumLevel.Debug()
                          .WriteTo.File(path: Path.Combine(Application.StartupPath, "log.txt"), 
                                        outputTemplate: "{Message:lj}{NewLine}",
                                        rollingInterval: RollingInterval.Day)
                          .CreateLogger();
        }

        private void TableSource_RowChanged(object sender, DataRowChangeEventArgs e)
        {
            if (e.Action == DataRowAction.Add)
            {
                var rowData = e.Row;
                logger.Information($"{rowData[0]} {rowData[1]}");
            }
            else if (e.Action == DataRowAction.Change)
            {
                var rowData = e.Row;
                logger.Information($"Updated: {rowData[0]} {rowData[1]}");
            }
            else if (e.Action == DataRowAction.Delete)
            {
                var rowData = e.Row;
                logger.Information($"Deleted: {rowData[0]} {rowData[1]}");
            }
            else
            {
                var rowData = e.Row;
                logger.Information($"Unknown: {rowData[0]} {rowData[1]}");
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (watcher.IsRunning)
            {
                lblProgress.Text = $"Running since {watcher.Elapsed.TotalMinutes} minutes";
            }
            else
            {
                lblProgress.Text = "Not running";
            }
        }

        private void btnStartUpdate_Click(object sender, EventArgs e)
        {
            watcher.Stop();
            if (!string.IsNullOrEmpty(previousText)
                && !previousText.Equals(txtMessage.Text)
                && watcher.ElapsedMilliseconds > 5 * 1000)
            {
                var row = tableSource.NewRow();
                row[0] = txtMessage.Text;
                row[1] = Math.Round(watcher.Elapsed.TotalMinutes, 0);
                tableSource.Rows.Add(row);
            }
            watcher.Reset();
            previousText = txtMessage.Text;
            watcher.Start();

        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            watcher.Stop();
            if (!string.IsNullOrEmpty(txtMessage.Text)
                && watcher.ElapsedMilliseconds > 5 * 1000)
            {
                var row = tableSource.NewRow();
                row[0] = txtMessage.Text;
                row[1] = Math.Round(watcher.Elapsed.TotalMinutes, 0);
                tableSource.Rows.Add(row);

                previousText = string.Empty;
                txtMessage.Text = string.Empty;
            }
            watcher.Reset();
        }
    }
}
