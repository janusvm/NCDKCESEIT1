using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EITParcelDelivery.Library
{
    public class ShortestPath
    {
        List<int> spList = new List<int>();
        public int[,] graph;
        private int size = 8;

        public void shortestPath(int s)
        {
            size = s;
        }

        public void setGraph(int[,] g)
        {
            graph = g;
        }

        public void setSize(int s)
        {
            if (s >= 0) 
                graph = new int[s, s];
        }

        public void addUniEdge(int v, int u, int w)
        {
            if (v < size && u < size && w >= 0)
            {
                graph[u, v] = w;
                graph[v, u] = w;
            }
        }



        //// Method name: calculatePath 
        //// Input:       Source, Destination, Edges, ParcelTypes, WeightPrice, OptimizeFor
        //// Output:      PathComponent, Price, ETA


        public int getPrice()
        {
            int sum = 0;
            foreach (int v in spList)
            {
                //sum += Edges.getSegments(v) * WeightPrice.findPrice(Parcels.weight) * ParselType.fee(Parcels.type) / 100;
            }

            return sum;
        }

        public int getDuration()
        {
            int dur = 0;
            foreach (int v in spList)
            {
                //dur += Edges.getSegments(v) * timeUnit;
            }

            return dur;
        }


        // A utility function to convert the list to a string
        // the constructed distance array
        public string toString()
        {
            string resp = "Vertex \t\t Distance " + "from Source: ";
            for (int i = 0; i < spList.Count; i++)
                resp += "  " + spList[i] + " : ";

            return resp;
        }

        // Util fn
        int minDistance(int[] dist,
            bool[] sptSet)
        {
            // Initialize min value
            int min = int.MaxValue, min_index = -1;

            for (int v = 0; v < size; v++)
                if (sptSet[v] == false && dist[v] <= min)
                {
                    min = dist[v];
                    min_index = v;
                }

            return min_index;
        }


        // Funtion that implements Dijkstra's
        // single source shortest path algorithm
        // for a graph represented using adjacency
        // matrix representation
        public List<int> dijkstra(int src, int dest)
        {
            int[] dist = new int[size]; // The output array. dist[i]
                                     // will hold the shortest
                                     // distance from src to i

            // The dijkstra algorithm doesnt supply the path. So a parent is 
            int[] parent = new int[size];

            // sptSet[i] will true if vertex
            // i is included in shortest path
            // tree or shortest distance from
            // src to i is finalized
            bool[] sptSet = new bool[size];

            // Initialize all distances as
            // INFINITE and stpSet[] as false
            for (int i = 0; i < size; i++)
            {
                dist[i] = int.MaxValue;
                sptSet[i] = false;
                parent[i] = int.MaxValue;
            }

            // Distance of source vertex
            // from itself is always 0
            dist[src] = 0;

            // Find shortest path for all vertices
            for (int count = 0; count <size- 1; count++)
            {
                // Pick the minimum distance vertex
                // from the set of vertices not yet
                // processed. u is always equal to
                // src in first iteration.
                int u = minDistance(dist, sptSet);

                // Mark the picked vertex as processed
                sptSet[u] = true;

                // Update dist value of the adjacent
                // vertices of the picked vertex.
                for (int v = 0; v < size; v++)

                    // Update dist[v] only if is not in
                    // sptSet, there is an edge from u
                    // to v, and total weight of path
                    // from src to v through u is smaller
                    // than current value of dist[v]
                    if (!sptSet[v] && graph[u, v] != 0 && dist[u] != int.MaxValue && dist[u] + graph[u, v] < dist[v])
                    {
                        dist[v] = dist[u] + graph[u, v];
                        parent[v] = u;
                    }
            }

            int vertex = dest;
            spList.Add(dest);
            while (parent[vertex] != int.MaxValue)
            {
                vertex = parent[vertex];
                spList.Insert(0, vertex);
            }
            return spList;
        }
    }
}