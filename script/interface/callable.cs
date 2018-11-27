using UnityEngine;
using System.Collections;

public class callable : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        Player player1 = new Player();
        player1.Kill();
        Wall player2 = new Wall();
        player2.Damage();
        

    }

    // Update is called once per frame
    void Update()
    {

    }
}