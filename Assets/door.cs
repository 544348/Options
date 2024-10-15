using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class door : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject go;


    //private Animator anim;

    private Animation animtion;

    void Start()
    {
       // anim = go.GetComponent<Animator>();
        animtion = go.GetComponent<Animation>();
    }

    private void OnTriggerEnter(Collider other)
    {

        Debug.Log("open door");
        animtion.Play("Scene", PlayMode.StopAll);

        //anim.speed = 0f;
        //anim.Play("Scene", 0, 20);
    }
    private void OnTriggerStay(Collider other)
    {

    }
    private void OnTriggerExit(Collider other)
    {

    }
}
  
