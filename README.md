# Graph-Coloring
Revised Graph Coloring project

This project was initially created for experimenting with graph coloring on random graphs.  For the class, this was used
to generate random graphs to show how random graphs evolve.

Generating a random graph is easy - edges are added at random.  Achieving a good layout is hard.   For dense graphs, the problem
is hopeless.   A common approach for sparse graphs is to set this up as a physics problem.  The vertices have a repulsive force,  edges have an
attractive force,  and an additional attractive force is added to vertices to keep everything bound.  THe simulations starts with a big bang, and then with
enough patience,  will settle to the graph layout.  (Note that this code was just hacked together,  and a physicist would be appalled at the code details.  Also,
it is not efficient).

To run it,  set N and M.  (Recommend N=50, M = 25)
Graph/New will generate a random graph
Graph/New Bipartite Graph generates a bipartite graph,  which arise in the Cuckoo hashing

To get a random coloring of the nodes, 
Color/Two Color followed by Color/Random Recolor 

Set Reps and Steps.  Steps are the number of time increments between screen refresh,  and reps is the number of repetitions
You can use Reps = 100, and steps = 100.  The run button starts the simulation.  You will need to hit run several times to get convergance.
This example will take about 200,000 
