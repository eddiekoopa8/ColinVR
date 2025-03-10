using System.Collections;
using System.Collections.Generic;

public class HoopStatus
{
    private static int __hoopGot = 0;
    private const  int HoopMax = 3;
    public static void Reset()
    {
        __hoopGot = 0;
    }
    public static bool Done()
    {
        return __hoopGot >= HoopMax;
    }
    public static void Ball()
    {
        __hoopGot++;
    }
}
