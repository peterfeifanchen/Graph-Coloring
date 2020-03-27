using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Graph_Coloring {

    public class UGraph {
        int nVertices;
        int nEdges;
        Random random;
        Vertex[] vertices;

        public UGraph() {
            random = new Random();
        }

        public UGraph(GraphParameters gp) {
            random = new Random();

            RandomGraph(gp.N, gp.M);
        }


        public void RandomGraph(int n, int m) {

            long maxEdges = ((long)n) * (n - 1) / 2;
            if (m > maxEdges)
                throw new Exception("Too many edges");

            SetVertices(n);

            int i = 0;
            while (i < m) {
                int u = random.Next(n);
                int v = random.Next(n);
                if (u == v || IsEdge(u, v))
                    continue;
                AddEdge(u, v);
                i++;
            }
        }




        void SetVertices(int n) {
            vertices = new Vertex[n];
            nVertices = n;
            nEdges = 0;
            for (int i = 0; i < n; i++)
                vertices[i] = new Vertex(i);

        }

        void AddEdge(int u, int v) {
            vertices[u].Add(v);
            vertices[v].Add(u);

            nEdges++;
        }

        bool IsEdge(int u, int v) {
            List<Edge> edges = vertices[u].Edges;
            foreach (Edge e in edges)
                if (v == e.Head)
                    return true;
            return false;
        }

        const int MAX_GRAPH_DISPLAY_LENGTH = 500;

        public override string ToString() {
            StringBuilder sb = new StringBuilder();

            int min = Math.Min(nVertices, MAX_GRAPH_DISPLAY_LENGTH);

            for (int i = 0; i < min; i++)
                sb.Append(vertices[i].ToString() + "\r\n");

            return sb.ToString();
        }

        public Vertex[] Vertices {
            get { return vertices; }
        }

        public int NVertices {
            get { return nVertices; }
        }

        public class Edge {
            public int Head;
            public int Tail;

            public Edge(int u, int v) {
                Tail = u;
                Head = v;
            }
        }

        public class Vertex {
            public List<Edge> Edges;
            public int Name;
            public PointF Loc;

            public Vertex(int name) {
                Name = name;
                Edges = new List<Edge>();
            }

            public void Add(int v) {
                Edges.Add(new Edge(Name, v));
            }

            public override string ToString() {
                StringBuilder sb = new StringBuilder();
                sb.Append(Name + ": ");
                foreach (Edge e in Edges)
                    sb.Append(e.Head + ", ");

                return sb.ToString();
            }

            public int Degree {
                get { return Edges.Count; }
            }
        }

        public int[] DegreeCount() {
            int[] degrees = new int[nVertices];
            for (int i = 0; i < nVertices; i++)
                degrees[i] = Degree(i);

            return Utility.ArrayToCount(degrees);
        }

        int Degree(int v) {
            return vertices[v].Degree;
        }


        // HDFColor - Apply the greedy coloring algorithm in High Degree First Order
        public int[] HDFColor() {
            int[] vOrder = new int[nVertices];
            for (int i = 0; i < nVertices; i++)
                vOrder[i] = i;

            int[] degree = new int[nVertices];
            for (int i = 0; i < nVertices; i++)
                degree[i] = Degree(i);

            Array.Sort(degree, vOrder);
            Array.Reverse(vOrder);

            return GreedyColor(vOrder);
        }

        // LDFColor - Apply the greedy coloring algorithm in Low Degree First Order
        public int[] LDFColor() {
            int[] vOrder = new int[nVertices];
            for (int i = 0; i < nVertices; i++)
                vOrder[i] = i;

            int[] degree = new int[nVertices];
            for (int i = 0; i < nVertices; i++)
                degree[i] = Degree(i);

            Array.Sort(degree, vOrder);

            return GreedyColor(vOrder);
        }

        // GreedyColor - Color the vertices of graph in a specified order.  The lowest available color is used
        int[] GreedyColor(int[] vOrder) {
            int[] colors = new int[nVertices];
            for (int i = 0; i < nVertices; i++)
                colors[i] = -1;

            for (int i = 0; i < nVertices; i++) {
                int v = vOrder[i];
                colors[v] = FindLowColor(v, colors);
            }

            return colors;

        }

        //Find the lowest color available for a vertex
        int FindLowColor(int v, int[] colors) {

            int d = Degree(v) + 1;

            bool[] available = new bool[d];
            for (int i = 0; i < d; i++)
                available[i] = true;

            List<Edge> edges = vertices[v].Edges;
            foreach (Edge edge in edges) {
                int c = colors[edge.Head];
                if (c != -1 && c < d)
                    available[c] = false;
            }


            int j = 0;
            while (available[j] == false)
                j++;

            return j;
        }

        // Find the highest color available for a vertex in the range 0 . . mc
        // Return -1 if no colors are available
        int FindHighColor(int v, int mc, int[] colors) {

            int[] count = ColorCount(v, mc, colors);


            int j = mc;
            while (j >= 0 && count[j] > 0)
                j--;

            return j;
        }

        int[] ColorCount(int v, int mc, int[] colors) {
            int[] count = new int[mc + 1];
            for (int i = 0; i < mc + 1; i++)
                count[i] = 0;

            List<Edge> edges = vertices[v].Edges;
            foreach (Edge edge in edges) {
                int c = colors[edge.Head];
                if (c != -1 && c < mc + 1)
                    count[c] = count[c] + 1;
            }

            return count;

        }

        public bool ValidColoring(int[] coloring) {
            for (int i = 0; i < nVertices; i++) {
                int c = coloring[i];
                if (c < 0)
                    return false;
                List<Edge> edges = vertices[i].Edges;
                foreach (Edge edge in edges)
                    if (c == coloring[edge.Head])
                        return false;
            }
            return true;
        }

        const int MAX_RANDOM_COLORS = 125;

        public int[] RandomRecoloring(int[] coloring) {
            int k = Utility.ArrayMax(coloring);
            if (k >= MAX_RANDOM_COLORS)
                return coloring;


            int r = MAX_RANDOM_COLORS / (k + 1);

            int n = coloring.Length;
            int[] newColoring = new int[n];
            for (int i = 0; i < n; i++) {
                int v = random.Next(r);
                newColoring[i] = coloring[i] + v * (k + 1);
            }

            return newColoring;
        }


    }

    public struct GraphParameters {
        public GraphParameters(int n, int m) {
            N = n;
            M = m;
        }

        public int N { get; }
        public int M { get; }
    }
}
