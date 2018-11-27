//using UnityEngine;
//using System.Collections;

//public class genericss_1 : MonoBehaviour
//{
//    // Use this for initialization
//    void Start()
//    {
        
//        ///泛型方法的调用,在调用泛型方法时指定具体的类型
//        int xx =  GetValue<int>(35);
//        float xxx = GetValue<float>(234f);
//        string y = GetValue<string>("sdasd");
       
//        print(xx);
//        print(xxx);
//        print(y);

//        //使用泛型类构造对象,在实例化构造对象时指定泛型类中T的具体类型
//        generic_class<int> g = new generic_class<int>();
//        g.UpdateItem<int>(86);
//        print(g.item);


//    }
//    ////=======================泛型=====================
//    ///////////////////泛型方法的定义:T代表任意一种输出类型,多个参数的时候写法一遍用<T,U,V...>
//    T GetValue<T>(T param)
//    {
//        return param;
//    }
//    void GetV<T,U>(T sdsd,U neko)
//    {

//    }

    
//    //================================
//    //int GetNum(int num)
//    //{
//    //    return num;
//    //}
//    //float GetFlo(float flo)
//    //{
//    //    return flo;
//    //}
//    //string GetStr(string str)
//    //{
//    //    return str;
//    //}
//    // Update is called once per frame
//    void Update()
//    {

//    }
//}
