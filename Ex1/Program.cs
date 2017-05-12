using System;
using Medallion.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MazeGeneratorLib;
using MazeLib;
using SearchAlgorithmsLib;

namespace Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 5;
            CompareSolvers();
        }

        public static void CompareSolvers()
        {
            DFSMazeGenerator mazeGen = new DFSMazeGenerator();
            Maze maze = mazeGen.Generate(100,100);
            SearchableMaze sm = new SearchableMaze(maze);
            Console.WriteLine(maze);
            BFSSearcher<Position> bfs= new BFSSearcher<Position>();
            DFSSearcher<Position> dfs = new DFSSearcher<Position>();
            Solution BFSSolution = bfs.search(sm);
            Solution DFSSolution = dfs.search(sm);
            int BFSNodes = bfs.getNumberOfNodesEvaluated();
            int DFSNodes = dfs.getNumberOfNodesEvaluated();
            Console.WriteLine($"Nodes: {BFSNodes}");
            Console.WriteLine($"Nodes: {DFSNodes}");
        }
    }
}
