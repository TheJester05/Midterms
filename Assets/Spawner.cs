using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    
   public GameObject eggPreFab;

    // Update is called once per frame
    void Update()
    {
     if (Input.GetKeyDown(KeyCode.Space)) 
     {
        Instantiate(eggPreFab,transform.position,Quaternion.identity);
     }  
    }
}