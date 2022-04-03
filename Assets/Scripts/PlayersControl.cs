using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayersControl : MonoBehaviour
{
    
    public string axis;
    public float speed = 30;
    // Start is called before the first frame update
    void Start()
    {
        //Vector2 speed = new Vector2(1, 1);
        //GetComponent<Rigidbody2D>().velocity = speed;
        //Debug.Log("Hello World!");
    }

    // Update is called once per frame
    void Update()
    {
      //Debug.Log("Hello Update !!!");
    }

    private void FixedUpdate() 
    {
        float v = Input.GetAxisRaw(axis) * speed;
       //Just calling the Rigidbody2D component to change its Velocity value
        GetComponent<Rigidbody2D>().velocity = new Vector2(0, v);
    }
}
