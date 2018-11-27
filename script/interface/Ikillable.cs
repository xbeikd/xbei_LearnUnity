using UnityEngine;
using System.Collections;
////定义接口：关键字interface
////不能使用实例化构造对象
/////声明方法,不用具体实现
/////需要实现接口里面的所有方法
public interface IKillable
{
    void Kill();
}
public interface IDamageable
{
    void Damage();
}




