using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBehaviour : MonoBehaviour
{
    public Rigidbody2D rigidbody;
    private const float default_move_speed = 2.5f;
    public float move_speed = default_move_speed;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
        rigidbody.gravityScale = 0;
    }

    // Update is called once per frame
    void Update()
    {
        float hor_input = Input.GetAxis("Horizontal");
        float ver_input = Input.GetAxis("Vertical");
        // Move Rigid Body according to Horizontal and Vertical inputs
        rigidbody.velocity = new Vector2(move_speed*hor_input, move_speed*ver_input);
        // Increase move_speed constant press
        if(!(hor_input == 0 && ver_input == 0))
        {
            move_speed += 0.2f;
        }
        // reset move speed if user release input
        else
        {
            move_speed = default_move_speed;
        }
    }
}
