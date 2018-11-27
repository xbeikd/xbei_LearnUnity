using UnityEngine;
using System.Collections;

public class C_04 : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Invoke("Xbei", 3);
	}
	void Xbei()
    {
        Debug.Log("xbeikd");
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            Invoke("Xbei",1);
        }
    }
}
