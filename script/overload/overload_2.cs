using UnityEngine;
using System.Collections;

public class overload_2 : MonoBehaviour {

	// Use this for initialization
	void Start () {
        overload_1 ne = new overload_1();
        int u = ne.Sakura(2, 3);
        print(u);

        overload_3 c = new overload_3();
        overload_3 c1 = new overload_3();
        overload_3 c2 = new overload_3();
        c1.num = 25;
        c2.num = 534;
        c = c1 + c2;
        print(c.num);
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
