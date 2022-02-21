using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class menucontrol : MonoBehaviour
{
  
    public GameObject deathpanel;
    public GameObject btnbaslat; 

    public GameObject stoppanel; 
    public GameObject stopbtn; 
    
    public Text skorpoint;
     public Text skorpoint1;
    public float speedtest = 0 ;

    public static int speed =-9; 
    public int x ; 
    public int y ;
    void Start()
    {
        deathpanel.SetActive(false);
        stoppanel.SetActive(false);
        stopbtn.SetActive(false);
        speed =-9;
    }

    // Update is called once per frame
    void Update()
    {   speedtest++;
        if(speedtest==1000){
            speedtest=0;
            if(speed >-20){
               speed--;
            }
        }
        if(gemihareket.smashkontrol){
            carpmafonksiyonu();
        }
        if(mapcontrol.baslatbiti==1 &&  gemihareket.smashkontrol==false){
            x++; 
            if(x==50){
                y++;
                x=0;
                skorpoint.text = y.ToString();
            }
        }
    }
    public void carpmafonksiyonu(){  
    deathpanel.SetActive(true);
    skorpoint1.text =y.ToString();
    stopbtn.SetActive(false);
    skorpoint.enabled=false;
    }
      public void startagain(){
          Time.timeScale =1 ;
          SceneManager.LoadScene("SampleScene");
          gemihareket.smashkontrol = false ;
          mapcontrol.baslatbiti=0;
    }
        public void taptostart(){
        mapcontrol.baslatbiti=1; 
        btnbaslat.SetActive(false);
        stopbtn.SetActive(true);
        
    }

    public void stopgame(){
        Time.timeScale = 0; 
        stoppanel.SetActive(true);
        stopbtn.SetActive(false);
    }
    public void continuegame(){
        Time.timeScale=1 ; 
        stoppanel.SetActive(false);
        stopbtn.SetActive(true);
    }
}
