using System;

namespace C2048
{
    class MoveNumber
    {
        public MoveNumber(){}
        Array array = new Array();

        //위
        public void GoUp()
        {
            for(int outter=0; outter<array.ground.GetLength(0); outter++) //for 4번 반복
            {
                for(int i=0; i<array.ground.GetLength(0)-1; i++)
                {
                    for(int j=0; j<array.ground.GetLength(1); j++)
                    {
                        if(array.ground[i+1,j] != 0 && array.ground[i,j] == 0) //0과 0이 아닌 수
                        {
                            array.ground[i,j] = array.ground[i+1,j];
                            array.ground[i+1,j] = 0;
                        }
                        
                        else if(array.ground[i,j] == array.ground[i+1,j]) //서로 같은 수 
                        {
                            int sum = array.ground[i,j] + array.ground[i+1,j];
                            array.ground[i,j] = sum;
                            array.ground[i+1,j] = 0;
                        }
                    }
                }
            }
        }

        //아래
        public void GoDown()
        {
            for(int outter=0; outter<array.ground.GetLength(0); outter++)
            {
                for(int i=array.ground.GetLength(0)-1; i>0; i--)
                {
                    for(int j=0; j<array.ground.GetLength(1); j++)
                    {
                        if(array.ground[i-1,j] != 0 && array.ground[i,j] == 0) //0과 0이 아닌 수
                        {
                            array.ground[i,j] = array.ground[i-1,j];
                            array.ground[i-1,j] = 0;
                        }
                        
                        else if(array.ground[i-1,j] == array.ground[i,j]) //서로 같은 수 
                        {
                            int sum = array.ground[i-1,j] + array.ground[i,j];
                            array.ground[i,j] = sum;
                            array.ground[i-1,j] = 0;
                        }
                    }
                }
            }
        }

        //왼쪽
        public void GoLeft()
        {
            for(int outter=0; outter<array.ground.GetLength(0); outter++)
            {
                for(int j=0; j<array.ground.GetLength(1)-1; j++)
                {
                    for(int i=0; i<array.ground.GetLength(0); i++)
                    {
                        if(array.ground[i,j+1] != 0 && array.ground[i,j] == 0) //0과 0이 아닌 수
                        {
                            array.ground[i,j] = array.ground[i,j+1];
                            array.ground[i,j+1] = 0;
                        }
                        
                        else if(array.ground[i,j] == array.ground[i,j+1]) //서로 같은 수 
                        {
                            int sum = array.ground[i,j] + array.ground[i,j+1];
                            array.ground[i,j] = sum;
                            array.ground[i,j+1] = 0;
                        }
                    }
                }
            }
        }

        //오른쪽
        public void GoRight()
        {
            for(int outter=0; outter<array.ground.GetLength(0); outter++)
            {
                for(int j=array.ground.GetLength(1)-1; j>0; j--)
                {
                    for(int i=0; i<array.ground.GetLength(0); i++)
                    {
                        if(array.ground[i,j-1] != 0 && array.ground[i,j] == 0) //0과 0이 아닌 수
                        {
                            array.ground[i,j] = array.ground[i,j-1];
                            array.ground[i,j-1] = 0;
                        }
                        
                        else if(array.ground[i,j-1] == array.ground[i,j]) //서로 같은 수 
                        {
                            int sum = array.ground[i,j-1] + array.ground[i,j];
                            array.ground[i,j] = sum;
                            array.ground[i,j-1] = 0;
                        }
                    }
                }
            }
        }

        public void FillRandNumber()
        {
            while(true)
            {
                Random rand = new Random();
                int xRand = rand.Next(0, array.ground.GetLength(0));
                int yRand = rand.Next(0, array.ground.GetLength(1));

                if(array.ground[xRand, yRand] == 0)
                {
                    array.ground[xRand, yRand] = 2;
                    break;
                }
                else continue;
            }
        }

        public void PrintArray()
        {
            Console.Clear();
            
            for (int i=0; i<array.ground.GetLength(0); i++)
            {
                for(int j=0; j<array.ground.GetLength(1); j++)
                {
                    Console.Write("  "+array.ground[i,j]+"    ");
                }
                Console.WriteLine("\n\n");
            }
        }
    }
}
        

    