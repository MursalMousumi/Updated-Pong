using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Paddle : MonoBehaviour
{ 
    public float speed = 8f;
   public int score = 0;
   public string left, right;
   public AudioClip waterSound;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        //float movementAxis = Input.GetAxis("Horizontal");
        
        if (Input.GetKey(left))
        {
             Transform transform = GetComponent<Transform>();
             transform.position += -Vector3.right * speed * Time.deltaTime;
        }
        else if (Input.GetKey(right))
        {
             Transform transform = GetComponent<Transform>();
             transform.position += Vector3.right * speed * Time.deltaTime;
        }
        
    }

    void OnCollisionEnter(Collision collision)
    {
        AudioSource audioSource = GetComponent<AudioSource>();
        audioSource.clip = waterSound;
        audioSource.Play();
    }
}
