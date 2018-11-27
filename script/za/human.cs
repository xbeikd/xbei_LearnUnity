using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class human : MonoBehaviour {

	// Use this for initialization
	void Start () {
        List<Personn> pe = new List<Personn>();
        chinese c = new chinese();
        American a = new American();
        Japanese j = new Japanese();
        pe.Add(c);
        pe.Add(a);
        pe.Add(j);

        foreach (Personn item in pe)
        {
            item.sayHell0();
        }
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
