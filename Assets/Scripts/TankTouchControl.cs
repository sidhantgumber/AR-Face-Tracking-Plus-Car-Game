using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankTouchControl : MonoBehaviour
{
    public Joystick joystick;
    public float movementSpeed = 10;
    float horizontalMovement = 0f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            Vector3 touchPosition =  Camera.main.ScreenToWorldPoint(touch.position);
        }

       if(joystick.Horizontal >=0.2)
        {
            horizontalMovement = movementSpeed;
        }

     //  else if(joystickMovement.ho)
    }
}
