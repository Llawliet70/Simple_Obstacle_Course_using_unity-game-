using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] int movespeed = 50;
    // Start is called before the first frame update
    void Start()
    {
        PIns();
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
    }

    void PIns()
    {
        Debug.Log("welcome to the game");
        Debug.Log("hello");
        Debug.Log("you can move your player");
    }
    
    void MovePlayer()
    {
        float xValue = Input.GetAxis("Horizontal")*Time.deltaTime*movespeed;
        float zValue = Input.GetAxis("Vertical")*Time.deltaTime*movespeed;

        transform.Translate(xValue,0f,zValue);
    }
}
