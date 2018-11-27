using UnityEngine;
using System.Collections;

public class GameObjectTest : MonoBehaviour
{
    public GameObject prefab;
    // Use this for initialization
    void Start()
    {
        ///创建游戏对象
        ///1,通过GameObject构造函数创建游戏对象
        GameObject go = new GameObject("喵喵喵");
        //2通过Instantiate()方法实例化创建游戏对象
        //Instantiate();
        //预制体
        Vector3 pos = new Vector3(-1.5f, 2f, 0f);
        GameObject g2 =   Instantiate(prefab, pos, Quaternion.identity) as GameObject ;
        //3
        GameObject.CreatePrimitive(PrimitiveType.Cube);
        GameObject.CreatePrimitive(PrimitiveType.Plane);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            Instantiate(prefab);

        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            for (int i = 0; i < 5; i+=1)
            {

           
                  for (int j = 0; j < 5; j+=1)
                    {
                        Vector3 pos = new Vector3(i, j, 0);
                        Instantiate(prefab, pos, Quaternion.identity);
                     }

        }
    }
}
 }