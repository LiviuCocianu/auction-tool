using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel.Design;

namespace Auction_Tool {
    [Designer("System.Windows.Forms.Design.ParentControlDesigner, System.Design", typeof(IDesigner))]
    public partial class AuctionTimer : UserControl {
        private string format;
        private Timer timingEngine;
        private int secondsElapsed;

        public string Format {
            get => format;
            set => format = value;
        }

        public Timer TimingEngine {
            get => timingEngine;
            set => timingEngine = value;
        }

        public int SecondsElapsed {
            get => secondsElapsed;
            set => secondsElapsed = value;
        }

        public AuctionTimer() {
            InitializeComponent();

            Format = "HH:mm:ss";
            SecondsElapsed = 0;
            TimingEngine = new Timer();
            TimingEngine.Tick += new EventHandler(timingEngine_Tick);
            TimingEngine.Interval = 1000;
        }

        public void StartTiming() {
            TimingEngine.Start();
        }

        public void ResetTimer() {
            StopTiming();
            timer_label.Text = Utils.secondsToTimestamp(Format, 0);
        }

        public void StopTiming() {
            TimingEngine.Stop();
            SecondsElapsed = 0;
        }

        private void timingEngine_Tick(object sender, EventArgs e) {
            secondsElapsed++;
            timer_label.Text = Utils.secondsToTimestamp(Format, secondsElapsed);
        }
    }
}
