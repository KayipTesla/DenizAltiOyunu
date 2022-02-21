using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
    public GameObject[] obstacle;
    private float timeBtwSpawn; 

    public float startTimeBtwSpawn; 
    public float minTime=0.65f; 
    public float decreaseTime;

    void Start()
    {
        
    }

    
    void Update()
    {
        if(mapcontrol.baslatbiti==1){
        if(gemihareket.smashkontrol==false){
        if(timeBtwSpawn<=0){
            int rand = Random.Range(0, obstacle.Length);
            Instantiate(obstacle[rand], transform.position, Quaternion.identity);
            timeBtwSpawn = startTimeBtwSpawn; 
            if(startTimeBtwSpawn>minTime){
            startTimeBtwSpawn-=decreaseTime;
            }
        }
        else{
            timeBtwSpawn -=Time.deltaTime;
        
    }
        }
    }
    }}

