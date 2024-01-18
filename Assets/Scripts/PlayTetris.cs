using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class PlayTetris : MonoBehaviour
{
    public GameObject Box;
    
    private void ExecuteTrigger(string trigger)
    {
        if (Box != null)
        {
            var animator = Box.GetComponent<Animator>();
            if(animator != null)
            {
                animator.SetTrigger(trigger);
            }
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        ExecuteTrigger("PlayTetris");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
