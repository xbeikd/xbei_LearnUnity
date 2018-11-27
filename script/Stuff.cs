using UnityEngine;
using System.Collections;

public class Stuff {
    public int  bullets;
    public int  rookets;
    public float fuel;

    public Stuff()
    {
        bullets = 1;
        rookets = 1;
        fuel = 1.0f;

    } 
    public Stuff(int bul) {
        bullets = bul;
    }
    public Stuff(int bul,int roo)
    {
        bullets = bul;
        rookets = roo;
    }
    public Stuff(int bul,int roo,float fu)
    {
        bullets = bul;
        rookets = roo;
        fu = fuel;
    }
    public static void Test()
    {
        Debug.Log("nya!nya!nya!");
    }
}
