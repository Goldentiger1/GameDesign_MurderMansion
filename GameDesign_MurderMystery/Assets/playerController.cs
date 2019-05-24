using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{
    public GameObject player;
    public Animation anim;
    public GameObject cutsceneTrigger;
    void Start()
    {
        player = GameObject.Find("FPSController").gameObject;
        //anim = 
    }

    void onTriggerEnter()
    {

    }
}