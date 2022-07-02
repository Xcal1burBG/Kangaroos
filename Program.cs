using System;

class Result
{

    /*
     * Complete the 'kangaroo' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts following parameters:
     *  1. INTEGER x1
     *  2. INTEGER v1
     *  3. INTEGER x2
     *  4. INTEGER v2
     */

    public static string kangaroo(int x1, int v1, int x2, int v2)
    {
        int kangaroo1Position = x1;
        int metersPerJump1stKangaroo = v1;
        int kangaroo2Position = x2;
        int metersPerJump2ndKangaroo = v2;

        //I use the next variable to end the loop of jumps if the distance between the kangaroos is increasing as
        //it will mean that thay will never meet at same position.

        int distanceBetweenKangaroos = Math.Abs(kangaroo1Position - kangaroo2Position);
        int newDistance = 0;

        //if the kangaroo at furtherer position make longer jumps they will never meet at same position
        if ((x1 > x2 && v1 > v2) || (x1 < x2 && v1 < v2))
        {
            return "NO";
        }

        while (true)
        {
            if (kangaroo1Position == kangaroo2Position)
            {
                return "YES";
            }
            else
            {
                kangaroo1Position += v1;
                kangaroo2Position += v2;
                newDistance = Math.Abs(kangaroo1Position - kangaroo2Position);
                if(newDistance >= distanceBetweenKangaroos)
                {
                    return "NO";
                }
                    
            }

        }

    }

}

class Solution
{
    public static void Main(string[] args)
    {

        string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

        int x1 = Convert.ToInt32(firstMultipleInput[0]);

        int v1 = Convert.ToInt32(firstMultipleInput[1]);

        int x2 = Convert.ToInt32(firstMultipleInput[2]);

        int v2 = Convert.ToInt32(firstMultipleInput[3]);

        string result = Result.kangaroo(x1, v1, x2, v2);

        Console.WriteLine(result);

    }
}
