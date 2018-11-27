using UnityEngine;
using System.Collections;

public class Player : IKillable,IDamageable
{

    public void Kill()
    {
        Debug.Log("杀死敌人");
    }
    public void Damage()
    {
        Debug.Log("墙不给倒");
    }


}
public class Wall : IDamageable
{
    public void Damage()
    {
        Debug.Log("墙倒了");
    }
}    
