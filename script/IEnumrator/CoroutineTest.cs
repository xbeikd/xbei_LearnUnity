using UnityEngine;
using System.Collections;

public class CoroutineTest : MonoBehaviour
{
    public GameObject cube;
    private IEnumerator testId;

    // Use this for initialization
    void Start()
    {
        //ChangeColor();
        //协程方法的调用
        //第一种
        StartCoroutine(ChangeColor());
        //testId = TestCor(1);
        //StartCoroutine(testId);

        //第二种
        StartCoroutine("ChangeColor");
        StartCoroutine("TestCor", 3);



    }
    //协程方法的定义
    //1、返回值类型
    //2、方法体使用 yield return 返回
    IEnumerator ChangeColor()
    {
        cube.GetComponent<MeshRenderer>().material.color = Color.blue;
        yield return null;
    }

    IEnumerator TestCor(int num)
    {
        int count = 0;
        while (true)
        {
            yield return new WaitForSeconds(3f);
            //count++;
            count += num;
            print(count);
        }
    }

    IEnumerator Fade()
    {
        for (float i = 0; i <= 1; i += 0.1f)
        {
            cube.GetComponent<MeshRenderer>().material.color = new Color(i, i, i);
            //yield return null;
            yield return new WaitForSeconds(0.1f);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            //StopCoroutine(testId);
            StopCoroutine("TestCor");
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            StartCoroutine(Fade());
        }
    }

    //胜利oid ChangeColor() {
    //    cube.GetComponent<MeshRenderer>().material.color = Color.blue;
    //}
}