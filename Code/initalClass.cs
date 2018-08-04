using System;
using System.Collections;
using System.Collections.Generic;
public class initialClass
{
    private static board theboard;

    private static bool error = false;
    private static bool xTurn = true;

    static int Main(string[] args)
    {
        theboard = new board();
        theboard.createBoard();

        do
        {
            for (int y = 0; y < 3; y++)
            {
                Console.Write("|");
                for (int x = 0; x < 3; x++)
                {
                    if (theboard.myboard[x, y] == board.field.none) Console.Write("_|");
                    else if (theboard.myboard[x, y] == board.field.x) Console.Write("x|");
                    else if (theboard.myboard[x, y] == board.field.o) Console.Write("o|");
                }
                Console.WriteLine();
            }
            string turn = "o";
            if (xTurn) turn = "x";
            Console.WriteLine("It is " + turn + "'s Turn!");
            string input;
            
            Console.WriteLine("Pls input value");
            input = Console.ReadLine();

            if (!input.Contains(",")) continue;
          
            

            string[] substrings = input.Split(',');
            List<int> i_substrings = new List<int>();
            foreach(string s in substrings)
            {
                int parsedinput;
                if (int.TryParse(s, out parsedinput))
                {
                    i_substrings.Add(parsedinput);
                }
                else
                {
                    Console.Write("not a valid number");
                    error = true;
                }
            }
            if(xTurn) theboard.myboard[i_substrings[1], i_substrings[0]] = board.field.x;
            else theboard.myboard[i_substrings[1], i_substrings[0]] = board.field.o;
            xTurn = !xTurn;
        }
        while (!error);
        

        return 0;
    }


}

public class board
{
    public enum field { none, x, o};
    public field[,] myboard;

   public int createBoard()
    {
        myboard = new field[3,3];

        return 0;
    }
}