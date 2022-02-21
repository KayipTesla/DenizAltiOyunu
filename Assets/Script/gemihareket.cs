using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gemihareket : MonoBehaviour
{
  
  public int gold;
  public ParticleSystem baliksmashpart;
  public int can; 
  
  public Text scorpoint;
  public int oyungold;
  
    public float speed;
    
    public Rigidbody rb;
  public static bool smashkontrol;

    public Vector3 parmakilkpozisyon;

    public Vector3 parmakpozisyon;

    public Vector3 parmakposisyondelta; 

    public float startTime;
   public Vector2 startPos;

   public float diffTime;
   public Vector2 endPos;
   public float distance; 

    private Vector3 particlesystem;
      void Start()
    {
        oyungold = 0 ; 
        can = 3 ;
        particlesystem = new Vector3 (transform.position.x,transform.position.y,transform.position.z+0.50f);
        smashkontrol=false;
    }

    // Update is called once per frame
    void Update()
    
    {
     
        if(mapcontrol.baslatbiti==1){
        if(Input.touchCount > 0){
            Touch parmak = Input.GetTouch(0);
            Debug.Log(parmak.deltaPosition);
          
            if(parmak.deltaPosition.y>5 && gameObject.transform.position.y<4.58){
                gameObject.transform.Translate(Vector3.up*speed*Time.timeScale);
            }
             if(parmak.deltaPosition.y<-5 && gameObject.transform.position.y>-2.71){
                gameObject.transform.Translate(Vector3.down*speed*Time.timeScale);
            }
           if(parmak.deltaPosition.x<5 && gameObject.transform.position.x>2.59){
                gameObject.transform.Translate(Vector3.left*speed*Time.timeScale);
            }
            if(parmak.deltaPosition.x>-5 && gameObject.transform.position.x<6.9){
                gameObject.transform.Translate(Vector3.right*speed*Time.timeScale);
            }
            if(parmak.phase == TouchPhase.Ended)
            parmak.deltaPosition= new Vector2(0,0) ; 
        }
          
        }

        if(mapcontrol.baslatbiti == 1 && smashkontrol==false){
       if(Input.GetKey(KeyCode.S) && gameObject.transform.position.y>-2.71)
		{	gameObject.transform.Translate(Vector3.down*speed);
		}
		if(Input.GetKey(KeyCode.W) && gameObject.transform.position.y<4.58)
		{	gameObject.transform.Translate(Vector3.up*speed);
		}
        if(Input.GetKey(KeyCode.A) && gameObject.transform.position.x> 2.59)
		{	gameObject.transform.Translate(Vector3.left*speed);
		}
		if(Input.GetKey(KeyCode.D) && gameObject.transform.position.x<6.9)
		{	gameObject.transform.Translate(Vector3.right*speed);
		}
        baliksmashpart.transform.position = transform.position + new Vector3 (0,0,1) ; 

        }
    }
    private void OnCollisionEnter(Collision carpilannesne){
        if(carpilannesne.gameObject.tag=="mayin"){
            Destroy(carpilannesne.gameObject);
            gameObject.transform.Rotate(0,0,0);
            smashkontrol = true ;
            Time.timeScale= 0 ; 
            
        }
         if(carpilannesne.gameObject.tag=="baliktag"){
             oyungold++;
             scorpoint.text=oyungold.ToString();
            Destroy(carpilannesne.gameObject);
            gameObject.transform.Rotate(0,0,0);
            baliksmashpart.Play();
            Invoke("stopfishparticle",2);

        }
        
        }
    void stopfishparticle(){
        baliksmashpart.Stop();
    }
   
  
}
