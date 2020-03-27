using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Graph_Coloring {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
            Initialize();
        }

        int graphCounter;
        List<GraphEntry> graphEntries;
        GraphEntry currentGraphEntry;




        private void Initialize() {
            graphCounter = 0;

            graphEntries = new List<GraphEntry>();
            currentGraphEntry = new GraphEntry();
        }

        private void OnExitClick(object sender, EventArgs e) {
            Application.Exit();
        }

        private void OnNewGraphClick(object sender, EventArgs e) {
            int n = (int)vertexUpDown.Value;
            int m = (int)edgeUpDown.Value;


            string str = "Graph: " + n + " " + m + " " + graphCounter;
            graphCounter++;

            GraphParameters gp = new GraphParameters(n, m);
            UGraph uGraph = new UGraph(gp);
            GraphDisplay graphDisplay = new GraphDisplay(uGraph);
            graphDisplay.CircleInit();
            int[] coloring = Utility.InitIntArray(n, 0);

            GraphEntry ge = new GraphEntry(gp, new UGraph(gp), graphDisplay, coloring);

            graphListBox.Items.Add(str);
            graphEntries.Add(ge);



            graphListBox.SetSelected(graphListBox.Items.Count - 1, true);



        }

        private void OnRemoveClick(object sender, EventArgs e) {
            int index = graphListBox.SelectedIndex;
            if (index == -1)
                return;
            graphListBox.Items.RemoveAt(index);
            graphEntries.RemoveAt(index);
            UpdateDisplay();

        }

        private void OnRemoveAllClick(object sender, EventArgs e) {
            graphListBox.Items.Clear();
            graphEntries.Clear();
            textBox2.Text = "";
            currentGraphEntry = new GraphEntry();
            UpdateDisplay();
        }

        private void OnSelectedGraphChanged(object sender, EventArgs e) {
            int index = graphListBox.SelectedIndex;
            if (index == -1) {
                textBox2.Text = "";
                currentGraphEntry = new GraphEntry();
            } else {
                currentGraphEntry = graphEntries[index];
                textBox2.Text = currentGraphEntry.UGraph.ToString();
            }
            UpdateDisplay();
        }

        private void OnDrawingPanelPaint(object sender, PaintEventArgs e) {
            GraphDisplay graphDisplay = currentGraphEntry.GraphDisplay;

            if (graphDisplay != null) {
                Graphics g = e.Graphics;
                int h = drawingPanel.Height;
                int w = drawingPanel.Width;
                float scaleX = drawingPanel.Width / 6.0F;
                float scaleY = drawingPanel.Height / 6.0F;

                Matrix matrix = new Matrix();
                matrix.Scale(1F, -1F);
                matrix.Translate(w / 2.0F, h / 2.0F, MatrixOrder.Append);
                g.Transform = matrix;

                graphDisplay.DrawGraph(g, currentGraphEntry.Coloring);
 
            }
        }

        private void UpdateDisplay() {
            int n = currentGraphEntry.Param.N;
            int m = currentGraphEntry.Param.M;

            statusVertexLabel.Text = "N " + n;
            statusEdgeLabel.Text = "M " + m;

            drawingPanel.Invalidate();

        }

        private void OnRunButtonClick(object sender, EventArgs e) {
            GraphDisplay graphDisplay = currentGraphEntry.GraphDisplay;

            int steps = (int) stepsUpDown.Value;
            int reps = (int) repsUpDown.Value;
            if (graphDisplay != null) {

                for (int r = 0; r < reps; r++) {
                    for (int i = 0; i < steps; i++) {
                        graphDisplay.SingleStep();

                    }
                    drawingPanel.Refresh();
                    System.Threading.Thread.Sleep(25);

                    statusCountLabel.Text = "Count " + r.ToString();

                    double kineticEnergy = graphDisplay.KineticEnergy / 10000.0;
                    statusKineticEnergyLabel.Text = "Kinetice Energy " + kineticEnergy.ToString("F4");
                   
                    double potentialEnergy = graphDisplay.PotentialEnergy / 10000.0;
                    statusPotentialEnergyLabel.Text = "Potential Energy " + potentialEnergy.ToString("F4");

                    statusStrip1.Refresh();
                }
            }
        }

        private void OnHDFClick(object sender, EventArgs e) {
            UGraph uGraph = currentGraphEntry.UGraph;

            if (uGraph != null)
                ApplyColoring(uGraph.HDFColor);
        }

        private void OnLDFClick(object sender, EventArgs e) {
            UGraph uGraph = currentGraphEntry.UGraph;

            if (uGraph != null)
                ApplyColoring(uGraph.LDFColor);
        }

        public delegate int[] ColoringFunction();
        public delegate int[] RecoloringFunction(int[] coloring);


        private void ApplyColoring(ColoringFunction coloringFunction) {
            UGraph uGraph = currentGraphEntry.UGraph;
            int[] coloring = coloringFunction();

            if (uGraph.ValidColoring(coloring)) {
                currentGraphEntry.Coloring = coloring;
                int[] colorCount = Utility.ArrayToCount(coloring);
                textBox1.Text = Utility.ArrayToString(colorCount, true);
                UpdateDisplay();
            } else
                textBox1.Text = "Bogus Coloring";

        }

        private void ApplyRecoloring(RecoloringFunction recoloringFunction) {
            UGraph uGraph = currentGraphEntry.UGraph;
            int[] coloring = currentGraphEntry.Coloring;

            if (coloring == null) {
                textBox1.Text = "Cannot recolor uncolored graph";
                return;
            }

            coloring = recoloringFunction(coloring);

            if (uGraph.ValidColoring(coloring)) {
                currentGraphEntry.Coloring = coloring;
                int[] colorCount = Utility.ArrayToCount(coloring);
                textBox1.Text = Utility.ArrayToString(colorCount, true);
                UpdateDisplay();
            } else
                textBox1.Text = "Bogus Coloring";

        }

        private void OnRandomRecolorClick(object sender, EventArgs e) {
            UGraph uGraph = currentGraphEntry.UGraph;

            if (uGraph != null)
                ApplyRecoloring(uGraph.RandomRecoloring);
        }
    }

    public struct GraphEntry {
        public GraphEntry(GraphParameters p, UGraph uGraph, GraphDisplay graphDisplay, int[] coloring) {
            Param = p;
            UGraph = uGraph;
            GraphDisplay = graphDisplay;
            Coloring = coloring;
        }

        public GraphParameters Param { get; }

        public UGraph UGraph { get; }

        public GraphDisplay GraphDisplay { get; }

        public int[] Coloring { get; set; }

    }
}
