using System;

namespace qSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int say = 20000;
            Console.WriteLine("Hello World!");
            var rand = new Random();
           
            int[] arr = new int[1000000];
            for (int i = 0; i < 1000000; i++)
            {
                arr[i] = rand.Next(0, 10000000);
            }            
            DateTime startTime = DateTime.Now;   
            
            quickSort(0, arr.Length-1,0);          

            Console.WriteLine("Time: " + DateTime.Now.Subtract(startTime).ToString());

            void quickSort(int left, int right,int num)
            {
                if (left<right)
                {
                    num++;
                  int value = operation(left, right);
                  quickSort(left,value-1,num);
                  quickSort(value + 1, right,num);
                    num--;
                }
            }

            int operation(int left, int right)
            {
                int firstLeft = left;
                int pivot = arr[left];
                while (left < right)
                {
                    if (pivot < arr[left])
                    {
                        if (arr[right] < pivot)
                        {
                            int temp = arr[left];
                            arr[left] = arr[right];
                            arr[right] = temp;
                            left++;
                            right--;
                        }
                        else
                        {
                            right--;
                        }
                    }
                    else
                    {
                        left++;
                    }
                }
                int mdl = left;

                if(arr[mdl]>pivot){
                    mdl--;
                }

                int temp2 = arr[mdl];
                arr[mdl] = arr[firstLeft];
                arr[firstLeft] = temp2;

             return mdl;
            }
        }
    }        
}

