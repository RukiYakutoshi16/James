using UnityEngine;
using System.Collections;

public class movement : MonoBehaviour {

    float x = 0;
    float y = 0;
    const float acceleration = -1;
    float velocity = 0;
    float accUp = 1;
    float deltaY2=0;


    // Use this for initialization
    void Start () {
       // transform.position = new Vector3(2, 2, 0);
	}
	
	// Update is called once per frame
	void Update () {
        /*  if(Input.GetButtonDown("Horizontal"))
         {
             transform.position = new Vector3(2, 2, 0);
         }
         */

        int changeDirection = (int)Input.GetAxisRaw("Horizontal");

        // print(changeDirection);

        float deltaX = transform.position.x + changeDirection;
        transform.position = new Vector3(deltaX, transform.position.y, 0);

        if (Input.GetKeyDown(KeyCode.Space))
        {

            velocity = 6;
        }


        if (transform.position.y < velocity)
        {
            //accUp += 1;
            float deltaY1 = accUp + transform.position.y;
            transform.position = new Vector3(deltaX, deltaY1, 0);
        }
        else {


            velocity += acceleration;
            deltaY2 = velocity + transform.position.y;
            transform.position = new Vector3(transform.position.x, deltaY2, 0);


        }

       /* velocity += acceleration;
         deltaY2 += velocity + transform.position.y;
        transform.position = new Vector3(transform.position.x, deltaY2, 0);
        */
        if (transform.position.y <= 0)
        {
            transform.position = new Vector3(transform.position.x, 0, 0);
            velocity = 0;
            deltaY2 = 0;
        }
    }
}
