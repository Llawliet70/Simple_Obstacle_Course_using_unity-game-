using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Appear : MonoBehaviour
{
    MeshRenderer render;
    BoxCollider box;
    
    // Start is called before the first frame update
    void Start()
    {
        render = GetComponent<MeshRenderer>();
        render.enabled = false;
        for(int i=0;i<100;i++){
            if(i%3==0){
                render.enabled=true;
            }
            else{
                render.enabled = false;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
