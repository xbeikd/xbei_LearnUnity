using UnityEngine;
using System.Collections;

public class RaycastTest : MonoBehaviour {
    Vector3 target;
	// Use this for initialization
	void Start () {
        
	}
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0))
            //从主摄像机发射一条射线到屏幕上鼠标点击位置
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;//射线检测信息
            if (Physics.Raycast(ray, out hit))
            {
                //获取碰撞点的信息,hit.point
                print(hit.point);
                //设置当前物体的目标位置为碰撞点位置,且保持Y坐标不变
                target = hit.point;
                target.y = -12.38f;
               // transform.position = target;
            }
        }
        transform.position = Vector3.Lerp(transform.position, target, Time.deltaTime);
    }
}
