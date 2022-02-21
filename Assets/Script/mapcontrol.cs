using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class mapcontrol : MonoBehaviour
{
    // Start is called before the first frame update
    public static float speed = -9; 
    public float z =1; 
    
    
    
    public static int baslatbiti = 0 ; 
    void Start()
    {
        
        Invoke("destroymap",13);
       
    }

    // Update is called once per frame
    void Update()
    {
     

        if(baslatbiti ==1){
        this.transform.Translate(0,0,z*menucontrol.speed*Time.deltaTime); 
        }
    }

    public void destroymap(){
        if(baslatbiti==1){
        Destroy(this.gameObject);
         }
    }

}
