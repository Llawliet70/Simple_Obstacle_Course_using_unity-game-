using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    [SerializeField] float timer = 5;
    MeshRenderer render;
    Rigidbody rigidbod;
    
    // Start is called before the first frame update
    void Start()
    {
        render = GetComponent<MeshRenderer>();
        render.enabled = false;
        rigidbod = GetComponent<Rigidbody>();
        rigidbod.useGravity = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time > timer){
            render.enabled = true;
            rigidbod.useGravity = true;
        }
    }
}
