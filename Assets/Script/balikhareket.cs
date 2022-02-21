using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class balikhareket : MonoBehaviour
{
    public float speed; 
    public float z =1; 

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Translate(0,0,z*speed*Time.deltaTime); 
    }
}
