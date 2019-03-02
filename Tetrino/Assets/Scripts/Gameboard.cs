using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameBoard : MonoBehaviour
{

    // ---------- NEW STUFF ----------

    // Surround all GameObjects with GameObjectGroup
    // and move it the amount of space to make the 
    // gameboard lie at the 0 0 mark

    // Stores all the cubes on the gameboard
    public static Transform[,] gameBoard = new Transform[10, 20];

    public static void PrintArray()
    {
        string arrayOutput = "";

        // Gets size of gameboard array and then subtract
        // 1 because the array starts with 0
        int iMax = gameBoard.GetLength(0) - 1;
        int jMax = gameBoard.GetLength(1) - 1;

        // Cycle through the array and print N or X 
        // depending on if you have a null or transform
        for (int j = jMax; j >= 0; j--)
        {
            for (int i = 0; i <= iMax; i++)
            {

                if (gameBoard[i, j] == null)
                {
                    arrayOutput += "N ";
                }
                else
                {
                    arrayOutput += "X ";
                }
            }

            arrayOutput += "\n \n";

        }

        // Get a reference to the Text component
        // and change its value
        var myArrayComp = GameObject.Find("MyArray").GetComponent<Text>();
        myArrayComp.text = arrayOutput;

    }
}