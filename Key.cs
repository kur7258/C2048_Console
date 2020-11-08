using System;
using System.Collections.Generic;
using System.Text;

namespace C2048
{
    class Key
    {
        public Key(){}

        public void KeyDown()
        {
            Array array = new Array();
            MoveNumber mv = new MoveNumber();
            ConsoleKeyInfo keys;


            mv.FillRandNumber();
            mv.PrintArray();

            while(true)
            {
                keys = Console.ReadKey(true);
                
                switch(keys.Key)
                {
                    case ConsoleKey.UpArrow : 
                        mv.GoUp();
                        mv.FillRandNumber();
                        break;
                    case ConsoleKey.DownArrow : 
                        mv.GoDown();
                        mv.FillRandNumber();
                        break;
                    case ConsoleKey.LeftArrow : 
                        mv.GoLeft();
                        mv.FillRandNumber();
                        break;
                    case ConsoleKey.RightArrow : 
                        mv.GoRight();
                        mv.FillRandNumber();
                        break;
                }
                mv.PrintArray();
            }
        }
    }
}