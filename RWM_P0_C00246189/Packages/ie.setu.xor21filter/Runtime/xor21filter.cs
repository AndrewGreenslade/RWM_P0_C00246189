using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class xor21filter
{
    public static int xor(int x)
    {
        int val = x ^ 21;
        return val;
    }

    public static int[] xors(int[] xs)
    {
        int[] result = new int[xs.Length];

        for (int i = 0; i < xs.Length; i++)
        {
            result[i] = xor(xs[i]);
        }

        return result;
    }
}
