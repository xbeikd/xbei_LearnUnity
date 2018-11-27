using UnityEngine;
using System.Collections;

public class TestDemoOne : MonoBehaviour
{
    /// <summary>
    /// Start, 协程的执行流程
    /// Start函数运行，输出“1”，然后开始协程Do；
    /// Do输出“2”，然后开始协程newDo；
    /// newDo输出“3”，产生中断指令后暂停，立即返回Do；
    /// Do产生中断指令后暂停，Do暂停并立即返回Start函数；
    /// Start执行StartCoroutine的下一条语句：输出“4”；
    /// 2秒后，newDo的中断指令完成并继续执行，输出“5”，协程newDo结束；
    /// Do的中断指令因为协程newDo的结束而完成并继续执行，输出“6”，协程Do结束。
    /// </summary>
    void Start()
    {
        Debug.Log("1");
        StartCoroutine(Do());
        Debug.Log("4");
    }
    IEnumerator Do()
    {
        Debug.Log("2");
        yield return StartCoroutine(newDo());//WaitForSeconds(5);
        Debug.Log("6");
    }
    IEnumerator newDo()
    {
        Debug.Log("3");
        yield return new WaitForSeconds(2);
        Debug.Log("5");
    }
}