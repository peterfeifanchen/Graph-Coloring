using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Graph_Coloring {
    public class GraphDisplay {
        Random random;
        UGraph graph;
        /*       
               const int MAX_VERTICES = 300;
               const float SCALE_FACTOR = 300F;
               const float RADIUS = 6F;
               const float EPSILON = 0.00001F;
               const float HUGE = 1.0E5F;
               const float CENTRAL_FORCE_CONSTANT = 0.25F;
               const float HOOKES_FORCE_CONSTANT = 0.5F;
               const float DAMPING_FORCE_CONSTANT = 0.05F;

               const float DELTA = 0.001F;
               const float COULOMB_CONSTANT = 160000F;
               */

        const int MAX_VERTICES = 300;
        const float SCALE_FACTOR = 300F;
        const float RADIUS = 6F;
        const float EPSILON = 0.00001F;
        const float HUGE = 1.0E5F;
        const float CENTRAL_FORCE_CONSTANT = 0.25F;
        const float HOOKES_FORCE_CONSTANT = 0.5F;
        const float DAMPING_FORCE_CONSTANT = 0.05F;

        const float DELTA = 0.0005F;
        const float COULOMB_CONSTANT = 160000F;

        Color[] colorVector;
        PointF[] velocityVector;


        public GraphDisplay(UGraph graph) {
            random = new Random();
            this.graph = graph;
            colorVector = CreateColorVector();
            velocityVector = new PointF[graph.NVertices];
            for (int i = 0; i < velocityVector.Length; i++)
                velocityVector[i] = new PointF(0F, 0F);

        }

        Color[] CreateColorVector() {
            Color[] colors = new Color[125];
            int[] red = new int[125];
            int[] green = new int[125];
            int[] blue = new int[125];

            int[] sortKey = Utility.InitIntArray(125, 0);

            int[] colorVal = { 0, 255, 127, 63, 191 };
            int[] sortVal = { 0, 1, 4, 13, 13 };

            int i = 0;
            for (int r = 0; r < 5; r++)
                for (int g = 0; g < 5; g++)
                    for (int b = 0; b < 5; b++) {
                        colors[i] = Color.FromArgb(colorVal[r], colorVal[g], colorVal[b]);
                        sortKey[i] = sortVal[r] + sortVal[g] + sortVal[b];

                        i++;
                    }


            Array.Sort(sortKey, colors);

            return colors;
        }

        public void CircleInit() {
            int n = graph.NVertices;

            for (int i = 0; i < n; i++) {
                double r = 2 * Math.PI * i / n;
                double x = SCALE_FACTOR * Math.Cos(r);
                double y = SCALE_FACTOR * Math.Sin(r);
                graph.Vertices[i].Loc = new PointF((float)x, (float)y);

            }
        }

        public void BipartiteInit() {
            int n2 = graph.NVertices / 2;


            for (int i = 0; i < n2; i++) {
                double x = 1 -  SCALE_FACTOR * 2 * i / (n2 - 1);
                double y = SCALE_FACTOR;
                graph.Vertices[i].Loc = new PointF((float)x, (float)-y);
                graph.Vertices[i + n2].Loc = new PointF((float)x, (float)y);
            }
        }

        public void RandomInit() {
            int n = graph.NVertices;

            for (int i = 0; i < n; i++) {
                double r1 = 2 * random.NextDouble() - 1;
                double r2 = 2 * random.NextDouble() - 1;
                double x = SCALE_FACTOR * r1;
                double y = SCALE_FACTOR * r2;
                graph.Vertices[i].Loc = new PointF((float)x, (float)y);

            }
        }

        public void DrawGraph(Graphics g, int[] coloring) {
            int n = graph.NVertices;

            if (n > MAX_VERTICES) {
                Font font = new Font("Arial", 16);
                SolidBrush brush = new SolidBrush(Color.Black);
                g.DrawString("Graph too big", font, brush, 50.0F, 50.0F);
                return;
            }


            SolidBrush blackBrush = new SolidBrush(Color.Black);
            SolidBrush redBrush = new SolidBrush(Color.Red);

            Pen pen = new Pen(Color.Black, 2F);

            for (int i = 0; i < n; i++) {
                List<UGraph.Edge> edges = graph.Vertices[i].Edges;
                foreach (UGraph.Edge e in edges) {
                    int j = e.Head;
                    if (j > i) {
                        PointF loc1 = graph.Vertices[i].Loc;
                        PointF loc2 = graph.Vertices[j].Loc;
                        g.DrawLine(pen, loc1, loc2);
                    }
                }

            }

            for (int i = 0; i < n; i++) {

                SolidBrush brush = new SolidBrush(ColorLookup(coloring[i]));
                PointF loc = graph.Vertices[i].Loc;
                float x = loc.X - RADIUS;
                float y = loc.Y - RADIUS;
                g.FillEllipse(brush, x, y, 2 * RADIUS, 2 * RADIUS);
                g.DrawEllipse(pen, x, y, 2 * RADIUS, 2 * RADIUS);

            }
        }

        public Color ColorLookup(int c) {
            int c1 = c + 1;
            int n = colorVector.Length;

            if (c1 >= n)
                c1 = c1 % (n - 1) + 1;
            return colorVector[c1];
        }

        public PointF[] ForceVector() {
            int n = graph.NVertices;
            PointF[] forces = new PointF[n];
            for (int i = 0; i < n; i++)
                forces[i] = Force(i);

            return forces;
        }

        PointF Force(int v) {
            PointF f1 = CentralForce(v);
            PointF f2 = CoulombsForce(v);
            PointF f3 = HookesForce(v);
            PointF f4 = DampingForce(v);

            return new PointF(f1.X + f2.X + f3.X + f4.X, f1.Y + f2.Y + f3.Y + f4.Y);
        }

        PointF CentralForce(int v) {
            PointF vec = graph.Vertices[v].Loc;
            PointF unit = UnitVector(vec);
            float magnitude = CENTRAL_FORCE_CONSTANT * Length(vec);

            return new PointF(-magnitude * unit.X, -magnitude * unit.Y);

        }

        PointF DampingForce(int v) {

            PointF velocity = velocityVector[v];

            PointF unit = UnitVector(velocity);
            float magnitude = DAMPING_FORCE_CONSTANT * Length(velocity);
            return new PointF(-magnitude * unit.X, -magnitude * unit.Y);
        }

        PointF HookesForce(int v) {
            PointF force = new PointF(0, 0);
            PointF p1 = graph.Vertices[v].Loc;

            List<UGraph.Edge> edges = graph.Vertices[v].Edges;
            foreach (UGraph.Edge e in edges) {
                int w = e.Head;
                PointF p2 = graph.Vertices[w].Loc;
                PointF diff = new PointF(p1.X - p2.X, p1.Y - p2.Y);
                PointF unit = UnitVector(diff);
                float magnitude = HOOKES_FORCE_CONSTANT * Length(diff);

                force.X -= magnitude * unit.X;
                force.Y -= magnitude * unit.Y;
            }


            return force;
        }

        PointF CoulombsForce(int v) {
            PointF force = new PointF(0F, 0F);
            for (int w = 0; w < graph.NVertices; w++) {
                if (v == w)
                    continue;
                PointF f1 = CoulombsForce(v, w);
                force.X += f1.X;
                force.Y += f1.Y;
            }

            return force;
        }

        PointF CoulombsForce(int v, int w) {
            PointF p1 = graph.Vertices[v].Loc;
            PointF p2 = graph.Vertices[w].Loc;
            PointF diff = new PointF(p1.X - p2.X, p1.Y - p2.Y);
            PointF unit = UnitVector(diff);
            float magnitude = Length(diff);

            float force = 0F;
            if (magnitude < EPSILON)
                force = HUGE;
            else
                force = COULOMB_CONSTANT / (magnitude * magnitude);

            return new PointF(force * unit.X, force * unit.Y);


        }




        PointF UnitVector(PointF vec) {
            float length = Length(vec);
            if (length < EPSILON)
                return new PointF(0F, 0F);

            return new PointF(vec.X / length, vec.Y / length);
        }

        float Length(PointF vec) {
            double lengthSq = vec.X * vec.X + vec.Y * vec.Y;
            return (float)Math.Sqrt(lengthSq);
        }

        public void DrawForces(Graphics g, PointF[] forces) {
            Pen pen = new Pen(Color.Red, 4F);
            pen.EndCap = System.Drawing.Drawing2D.LineCap.ArrowAnchor;

            for (int i = 0; i < graph.NVertices; i++) {
                PointF force = forces[i];
                PointF start = graph.Vertices[i].Loc;
                PointF end = new PointF(start.X + force.X / 4F, start.Y + force.Y / 4F);
                g.DrawLine(pen, start, end);

            }
        }

        public void SingleStep() {
            int n = graph.NVertices;

            PointF[] forces = ForceVector();
            for (int i = 0; i < n; i++) {
                PointF f = forces[i];
                PointF v = velocityVector[i];
                PointF v1 = new PointF(v.X + DELTA * f.X, v.Y + DELTA * f.Y);
                PointF loc = graph.Vertices[i].Loc;
                PointF loc1 = new PointF(loc.X + DELTA * v1.X, loc.Y + DELTA * v1.Y);
                velocityVector[i] = v1;
                graph.Vertices[i].Loc = loc1;

            }
        }

        public double KineticEnergy {
            get {
                double energy = 0.0;

                for (int i = 0; i < graph.NVertices; i++) {
                    PointF v = velocityVector[i];
                    energy += v.X * v.X + v.Y * v.Y;
                }
                return energy;
            }
        }

        public double PotentialEnergy {
            get {
                double energy = 0.0;

                for (int v = 0; v < graph.NVertices; v++)
                    energy += VertexPotentialEnergy(v);

                return energy;
            }
        }

        double VertexPotentialEnergy(int v) {
            double hookesPotential = HookesPotential(v);
            double coulombsPotential = 0.0;
            double centralPotential = CentralPotential(v);

            return hookesPotential + coulombsPotential + centralPotential;
        }

        double CentralPotential(int v) {
            PointF loc = graph.Vertices[v].Loc;
            double mag = Length(loc);

            return CENTRAL_FORCE_CONSTANT * mag * mag / 2.0;
        }

        double HookesPotential(int v) {
            double potential = 0.0;

            PointF p1 = graph.Vertices[v].Loc;

            List<UGraph.Edge> edges = graph.Vertices[v].Edges;
            foreach (UGraph.Edge e in edges) {
                int w = e.Head;
                PointF p2 = graph.Vertices[w].Loc;
                PointF diff = new PointF(p1.X - p2.X, p1.Y - p2.Y);
                double mag = Length(diff);

                potential += HOOKES_FORCE_CONSTANT * mag * mag / 2.0;
            }



            return potential;
        }

        double CoulombsPotential(int v) {

            double potential = 0.0;
            PointF p1 = graph.Vertices[v].Loc;

            for (int w = 0; w < graph.NVertices; w++) {
                if (v == w)
                    continue;

                PointF p2 = graph.Vertices[w].Loc;
                PointF diff = new PointF(p1.X - p2.X, p1.Y - p2.Y);
                double mag = Length(diff);

                if (mag > EPSILON) {
                    potential += -COULOMB_CONSTANT / mag;
                }
            }


            return potential;
        }
    }
}
