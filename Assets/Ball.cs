using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using TMPro;

//[RequireComponent(typeof(Rigidbody))]
public class Ball : MonoBehaviour
{
    // Start is called before the first frame update
    private Rigidbody rb;
    public Paddle paddle1, paddle2;
    //public float speed = 2f;
    //public float acceleration = 2f;
    public TextMeshProUGUI winText;
    
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        
        rb.AddForce(new Vector3(4, 0, 4), ForceMode.Impulse);
        //rb.velocity = -transform.forward * speed;
        //accelerate to make ball move faster
    }

    //void Update()
    //{
    //    speed += Time.deltaTime * acceleration;
    //    rb.velocity = -transform.forward * speed;
    //}

    public void ReturnToCenter()
    {
        transform.position = new Vector3(0, 0, 0);

        if (paddle1.score >= 11)
        {
            //winText.enabled = true;
            winText.text = "Game Over, Left Paddle Wins";
            winText.color = Color.blue;
            paddle1.score = 0;
        }
        else if (paddle2.score >= 11)
        {
            //winText.enabled = true;
            winText.text = "Game Over, Right Paddle Wins";
            winText.color = Color.green;
            paddle2.score = 0;
        }
    }
}
