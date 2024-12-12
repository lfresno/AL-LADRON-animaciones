using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{

    public Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)){    //hide

            anim.SetTrigger("hide");


        }else if(Input.GetKeyDown(KeyCode.LeftShift)){  //steal

            anim.SetTrigger("steal");

        }
    }
}
