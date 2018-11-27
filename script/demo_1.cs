using UnityEngine;
using System.Collections;
using System.Collections.Generic;




//结构体的定义
struct Position
{
    public float x;
    public float y;
    public float z;
}

enum direction     //定义一个枚举类型:
{
    East,
    West,
    South,
    north
}

struct path
{
    public float distance;
    public direction dir;
    
}
        //类的定义:访问控制符 class的类名();
public class demo_1 : MonoBehaviour{   //继承自MonoBehaviour

    // Use this for initialization
    /// <summary>
    /// 
    /// </summary>
    //public List<int> intList = new List<int>();
    //public List<GameObject> goList = new List<GameObject>();
    //public GameObject[] goArray;
    //public Transform[] Ts;
    void Start ()
	{

        /////=======================================================================================================
        ///=======================构造方法什么的==============================================================================
        ///============================================================================================
        //创建一个enemy类类型的变量(称为对象)
        //Enemy enemy = new Enemy();
        ////访问对象里的某个字段:对象名+字段名
        //print(enemy.name);
        ////修改对象里某个字段的值
        //enemy.name = "nya";
        //enemy.age = 42;
        //print(enemy.name);
        //print(enemy.age);
        ////调用对象里的方法:对象名.方法名();
        //enemy.Move();
        //enemy.Attack();

        //Enemy enemy2 = new Enemy("bbb",21);
        //print(enemy2.name);
        //print(enemy2.age);
        //enemy2.Move();
        //enemy2.Attack();

        //Enemy enemy3 = new Enemy();
        //print(enemy3.name);
        //print(enemy3.age);

        //Enemy enemy4 = new Enemy("ccc");
        //print(enemy4.name);
        ////获取静态变量EnemyCount的值:
        //print(Enemy.EnemyCount);
        //print(Enemy.Add(3,4));

        //Stuff mmm = new Stuff(23);
        //print(mmm.bullets);
        //Stuff.Test();

        //int 的默认值是"0"
        //string 的默认值是"null"



        //创建一个敌人
        //方法的调用
        //		Vector3 pos = new Vector3(2,4,5);
        //		CreateEmpty (pos);
        //		CreateEmpty (new Vector3(2,5,6));
        //	}
        //

        //返回类型  方法名(参数){
        //方法体
        //	void CreateEmpty (Vector3 pos)
        //	{

        //		print ("喵喵喵");
        //		print ("喵喵喵喵"+pos);
        //		print ("喵喵喵喵喵");
        //		print ("喵喵喵喵喵喵");

        //	}
        ///////////此处对应privateDemo.cs的22行以前的
        /////实例化生成一个对象
        privateDemo pri = new privateDemo();
        //通过对象的访问属性:对象名.属性名
        print(pri.Expi);
        pri.Expi = 2000;//调用set访问器
        print(pri.Expi);
        pri.level = 4000; 

        //-------------------------------------------------------------------------------------------------------------------------------------
        //-----------------------------------------------------Transform,获取游戏对象什么的-------------------------------------------------------------------
        //-------------------------------------------------------------------------------------------------------------------------------------

        //		Transform t = GetComponentInChildren<Transform>();      //返回单个
        //		t.gameObject                         //获取"t"所在的游戏对象
        //		t.gameObject.name                     //获取"t"所在的游戏对象名字
        //		Transform[] transArray = GetComponentsInChildren<Transform> ();   //定义一个数组返回所有子对象
        //
        //		foreach (Transform s in transArray) {
        //			if (s != transform) {
        //
        //				print (s.gameObject.name);
        ////                    		
        //				GameObject.Destroy(s.gameObject);--------------------销毁游戏对象的方法
        //			
        //			}
        //		}
        //		Transform t = GetComponent<Transform>();
        //		print (t);
        //------
        //	Collider[] transArray =GetComponentsInChildren<Collider> ();   //定义一个数组返回所有子对象
        //		foreach (Collider s in transArray) {
        //			print (s);
        //			print(GetComponent<BoxCollider>());
        //			zujian zj = GetComponents<zujian> ();
        //-------
        //                    		
        //				GameObject.Destroy(s.gameObject);--------------------销毁游戏对象的方法




        //-------------------------------------------------------------------------------------------------------------------------------------	
        //----------------------------------------------------------数组-------------------------------------------
        //----------------------------------------------------------------------------------------------------------------------------
        //----------------数组的初始化-------------------
        //数组的声明方式   类型+[]+数组的名称;
        //	int [] a1 ;//数组初始化

        //数组初始化
        //1,第一种初始化方式
        //数组的访问方式  a1 [0]    print(	"a1"+(a1 [0]));
        //int[] a1 = {34,52,64,74,224};
        /*	for (int i = 0;i < a1.Length;i++) {
            print (a1 [i]);
        }
        print(	"a1"+(a1 [0]));

        //第二种初始化方式    会赋默认值
        int [] a2 = new int[7];
        print(	"a2"+(a2 [0]));

        //第三章初始化方式
        int [] a3 = new int[6]{23,52,46,52,65,75};//如果大括号的长度和中括号数字不一致,会报错
        */
        /*
                foreach(int s in a1){
                    print(s);
                }
                 数组的缺点:1,插入数据很麻烦
                            2,长度变化什么的麻烦死了
            */

        /*  ==============================标签
        GameObject[] array = GameObject.FindGameObjectsWithTag("Player");
         */


        //===================================================================================================================================================================================
        //==============================================================================字符串的处理========================================================================================
        //====================================================================================================================================================================================
        /* 
        string str = "www.njcit.cn";          //char类型
            print(str.Length);
            print(str[5]); ///打印索引元素

        //字符串相关方法
        //1,ToLower()方法:打印出来全小写
        //2,ToUpper()方法:打印出来全大写
        //3,Trim()方法:去掉字符串前面和后面的所有空白字符
        //4,split()方法:把字符串通过指定的分隔符分成若干个数组
        string str = "www.NJCIT.cn";

        string res1 = str.ToLower();
        string res2 = str.ToUpper();
        string res3 = str.Trim();


        print(res1);
        print(res2);
        print(res3);

        string[] strs =  str.Split('.');
        foreach (string item in strs)
        {
           print(item);
        }

        //=========================================================================================================================================================================
        //================================================================================List 列表================================================================================
        // =========================================================================================================================================================================


        //创建一个空的列表
        List<int> scoreList = new List<int>();
        List<string> nameList = new List<string>();
        //创建一个非空的列表
        List<int> scoreList2 = new List<int>() { 1, 2, 3 };


        //获取列表的长度,通过count属性获取
        print(scoreList.Count);
        //往列表添加元素,通过add()方法
        scoreList.Add(34);
        scoreList.Add(453);
        scoreList.Add(323);
        // print(scoreList.Count);
        print(scoreList[0]);
        //列表的遍历
        //foreach (var item in scoreList)
        //{
        //    print("m"+item);
        //}
         //列表的insert()方法,插入方法
        scoreList.Insert(3,78);//表示在scorelist列表索引位置为1的位置插入元素"78"
        //remove()方法,移除方法
        scoreList.Remove(34);//移除元素本身
        scoreList.RemoveAt(0);//移除指定位置上的元素
        //indexOf()方法,获取元素的索引值,从前往后
        //LastIndexOf(),获取索引值,从后往前
        int mmm = scoreList.IndexOf(323);
        print(mmm);
        //Sort();方法,列表元素从小到大排序
        scoreList.Sort();
        //for (int i = 0; i < scoreList.Count; i++)
        //{
        //    print("mmm" + scoreList[i]);
        //}
        //clear();方法,清除掉列表
        scoreList.Clear();//




        //foreach (Transform i in Ts)
        //{
        //    print(i);
        //}





        //==================================================================================================================================== 
        //================================================================字典================================================================
        //====================================================================================================================================



        //        //创建一个空的字典：字典的每一个元素是一个键值对，<key，value>,一个字典里面key是唯一的
        //        Dictionary<string, int> nameToHp = new Dictionary<string, int>();//------------------字典,
        //        //往字典中体检元素
        //        nameToHp.Add("蒸鸡", 114);
        //        nameToHp.Add("小爱", 514);
        //        nameToHp.Add("多米", 911);
        //        nameToHp.Add("么西", 250);
        //        //根据字典的key获取value
        //        //print( nameToHp["蒸鸡"]);
        //        //获取字典的长度
        //        print(nameToHp.Count);
        //        //字典的遍历
        //        //1,只遍历字典的key,通过.key获取字典的所有键
        //        //2,只遍历字典的value,通过.value获取字典的所有键

        //        foreach (int value in nameToHp.Values)//-----------------------仅仅遍历key
        //        {
        //            Debug.Log("value " + value);


        //        }

        //        foreach (KeyValuePair<string,int> kv in nameToHp)//-------------key和value都遍历
        //        {
        //            Debug.Log(kv);
        //            Debug.Log("键" + kv.Key + "值" + kv.Value);
        //        }

        //        //--------------------------判断字典中可以存不存在呀
        //        bool b = nameToHp.ContainsKey("蒸鸡");
        //        if (b){  print("存在呀");
        //        }
        //        else{    print("想多了");
        //        }
        //    //------------
        //        bool b2 = nameToHp.ContainsKey("么西");
        //        print(b2);                       //打印true或者false
        ////----------------------------------------------------------------
        */   ////////////// //////////////////////////////////////////////////////////////////////////以上为笔记//////////////////////////////////////////////////////////////////////////// 
             //======================================================================================================================================================================================
             //----------------------------------------------------------------------------结构体,,封装???----------------------------------
             ////////////////////结构体的定义写在start方法上面了
             //float enemy1x;
             //float enemy1y;
             //float enemy1z;
             ////声明结构体类型的变量
             //Position enemy1pos;
             ////访问结构体的字段
             //enemy1pos.x = 34f;
             //enemy1pos.y = 56f;
             //enemy1pos.z = 25f;
             //print(enemy1pos.x);

        //声明path类型的变量
        //path enemy1ph;
        //enemy1ph.distance = 23;
        //enemy1ph.dir = direction.East;



































    }
  // Update is called once per frame
  void Update () {

  }
}
