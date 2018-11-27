using UnityEngine;
using System.Collections;

public class EvenTest : MonoBehaviour {

    // Use this for initialization
    void Awake()
    {
        print("Awake");

    }

    void Start () {
        print("Start");
	}
	// Update is called once per frame
	void Update () {
        print("Update");
	}

    void Lateupdate()
    {
        print("lateupdate");
    }
    void Ondisable()
    {
        print("ondisable");
    }


    //void ondisable()
    //{
    //    print("ondisable");
    //}

}
