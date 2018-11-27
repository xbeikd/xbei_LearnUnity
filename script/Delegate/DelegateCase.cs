using UnityEngine;
using System.Collections;

public class DelegateCase : MonoBehaviour {

    delegate void MyDelegate();
    delegate int PlusDelegate(int a ,int b );
    MyDelegate a;
    PlusDelegate plus;
    // Use this for initialization
    void Start () {
        //给委托变量赋值
        a += Test;
        a += Test2;
        a();
        plus = SumPlus;
        //调用委托

       
	}
	
    void Test()
    {
        print("Test");
    }
    void Test2()
    {
        print("Test2");
    }
    int SumPlus(int a ,int b )
    {
        return (a+b);
    }//当委托的方法有返回值,只保留最后一个方法的返回值
	// Update is called once per frame
	void Update () {
	    
	}
}
