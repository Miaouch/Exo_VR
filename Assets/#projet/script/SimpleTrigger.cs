﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class SimpleTrigger : MonoBehaviour
{

    // public Rigidbody triggerBody; 
    public UnityEvent onTriggerEnter;
    public Rigidbody triggerBody;  

    void OnTriggerEnter(Collider other){
        // //do not trigger if there's no trigger target object
        // if (triggerBody == null) return;

        // //only trigger if the triggerBody matches
        // var hitRb = other.attachedRigidbody;
        if (other.gameObject.CompareTag("Ball")){
            onTriggerEnter.Invoke();
            
        }
        
    }

}
