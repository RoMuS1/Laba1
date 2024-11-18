using System;

public static class Kata
{
  public static int Enough(int cap, int on, int wait)
  {
        int totalPeople = on + wait;

        if (totalPeople <= cap)
        {
            return 0;
        }
        else
        {
            return totalPeople - cap;
        }
  }
}