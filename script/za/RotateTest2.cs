using UnityEngine;
using System.Collections;

public class RotateTest2 : MonoBehaviour {
    public Transform PlayerTrans;
    public Transform EnemyTrans;
    private Rigidbody r;

	// Use this for initialization
	void Start () {
        r = PlayerTrans.GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
        //Vector3 dir = EnemyTrans.position - PlayerTrans.position;
        //dir.y = 0;
        //PlayerTrans.rotation = Quaternion.LookRotation(dir);
        ////Quaternion target = Quaternion.LookRotation(dir);
        ////PlayerTrans.rotation = Quaternion.Slerp(PlayerTrans.rotation, target, Time.deltaTime);
        
        ////让玩家player对象移动到某一个目标位置,用Vector.lerp方法
        //Vector3 tagetpos = EnemyTrans.position;
        //tagetpos.y = PlayerTrans.position.y;
      // PlayerTrans.position = Vector3.Lerp(PlayerTrans.position, tagetpos, Time.deltaTime);
        //float v = Input.GetAxis("Vertical");
        //PlayerTrans.Translate(Vector3.forward * v * Time.deltaTime * 5);
        //float h = Input.GetAxis("Horizontal");
        //PlayerTrans.Rotate(Vector3.up * h * Time.deltaTime * 200);

    }



    void FixedUpdate()
    {
        //刚体的移动
        //第一种方式:设置刚体velocity
        float v = Input.GetAxis("Vertical");
    //    r.velocity = Vector3.forward * v * 10F;
        //第二种方式,给物体加力
    //    r.AddForce(Vector3.forward * v * 30F);
        //第三种方式,参数是移动的目标位置,而不是移动的距离
        r.MovePosition(PlayerTrans.position + transform.forward * v * Time.deltaTime * 5 );
        //刚体的旋转
        float h = Input.GetAxis("Horizontal");
        Quaternion deltaRotate = Quaternion.Euler(Vector3.up * h * Time.deltaTime * 200);
        r.MoveRotation(PlayerTrans.rotation * deltaRotate);

    }

    //普通物理碰撞,三个碰撞事件函数,
    void  OnCollisionEnter(Collision col)
    {
        print("进入碰撞体" + col.gameObject.name);
    }
    void OnCollisionStay(Collision col)
    {
        print("停留碰撞体"+col.gameObject.name);
    }
    void OnCollisionExit(Collision col)
    {
        print("退出碰撞体" + col.gameObject.name);
    }

    //触发器碰撞
    void OnTriggerEnter(Collider c )
    {
        print("进入触发器" + c.gameObject.name);
    }
    void OnTriggerStay(Collider c)
    {
        print("停留触发器" + c.gameObject.name);
    }
    void OnTriggerExit(Collider c)
    {
        print("离开触发器" + c.gameObject.name);
    }
}
