using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;

/**
 * Auto-generated code below aims at helping you parse
 * the standard input according to the problem statement.
 **/
class Player
{
    static void Main(string[] args)
    {
        string[] inputs;
        inputs = Console.ReadLine().Split(' ');
        int W = int.Parse(inputs[0]); // width of the building.
        int H = int.Parse(inputs[1]); // height of the building.
        int N = int.Parse(Console.ReadLine()); // maximum number of turns before game over.
        inputs = Console.ReadLine().Split(' ');
        int X0 = int.Parse(inputs[0]);
        int Y0 = int.Parse(inputs[1]);

        int x = X0; 
        int y = Y0; 
        int xMin = -1;
        int xMax = W;
        int yMax = H;
        int yMin = -1;

        // game loop
        while (true)
        {
            string bombDir = Console.ReadLine(); // the direction of the bombs from batman's current location (U, UR, R, DR, D, DL, L or UL)

              
            if(bombDir=="U"){
                yMax = y;
                   y = (y-((yMax-yMin)/2));
            }
            else if(bombDir=="D"){
                yMin = y;
                      y = (y+((yMax-yMin)/2));
                
            }
            else if(bombDir=="L"){
                xMax = x;
        
                x = (x-((xMax-xMin)/2));
            }
            else if(bombDir=="R"){
                xMin = x;
  
                x = (x+((xMax-xMin)/2));
            }
            else if(bombDir=="UR"){
                xMin = x;
                yMax = y;
       
                x = (x+((xMax-xMin)/2));
                y = (y-((yMax-yMin)/2));
            }
            else if(bombDir=="UL"){
                xMax = x;
                yMax = y;
          
                x = (x-((xMax-xMin)/2));
                y = (y-((yMax-yMin)/2));
            }
            else if(bombDir=="DR"){
                xMin = x;
                yMin = y;
           
                x = (x+((xMax-xMin)/2));
                y = (y+((yMax-yMin)/2));
            }
            else if(bombDir=="DL"){
                xMax = x;
                yMin = y;
       
                x = (x-((xMax-xMin)/2));
                y = (y+((yMax-yMin)/2));
            }
      Console.Error.WriteLine("bomb direction"+bombDir);
      Console.Error.WriteLine("Next batman direction X0:"+x+",Y0: "+y);
      Console.WriteLine(x + " " + y);
        }
    }
}