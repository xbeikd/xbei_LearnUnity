using UnityEngine;
using System.Collections;

public class FindGo : MonoBehaviour {
    public GameObject go;
    public Transform trans;
    public Rigidbody rigi;
    public Camera c;
    // Use this for initialization
    void Start () {
        //查找游戏对象
        ///1,第一种:手动脱拽给变量赋值
        ///2,第二种:通过transform组件中的find方法查找,是在当前物体的子对象
        ///参数必须指明具体的查找路径,没有找到返回null
        Transform gg =  transform.Find("c1/c11");
       // print(go.name);
        print(gg);
        ///第三种:通过gameobject中的find方法查找,全局搜索
        ///参数不需要带路径
        GameObject go = GameObject.Find("c11");
        print(go);
        ///第四种:通过标签,通过标签tag进行查找,
        ///FindGameObjectWithTag只返回一个查找结果
        ///FindGameObjectsWithTag返回一个数组
        GameObject go2 = GameObject.FindGameObjectWithTag("Player");
        GameObject [] GoArray = GameObject.FindGameObjectsWithTag("Player");
        print(go2);
        print(GoArray[0]);
        ///销毁游戏对象




	}
	
	// Update is called once per frame
	void Update () {
        ///销毁游戏对象
        // Destroy(go,3f);
        if (Input.GetKeyDown(KeyCode.A))
        {
            Destroy(go,4f);//销毁游戏对象,支持延迟销毁(4s后销毁
            Destroy(rigi);//删除某个组件

        }

    }
}
