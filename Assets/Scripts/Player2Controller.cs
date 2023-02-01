using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2Controller : MonoBehaviour
{
    private float speed = 20.0f;
    private float turnSpeed = 80.0f;
    private float horizontalSpeed = 1;
    private float verticalSpeed = 1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //! player's inputs
        horizontalSpeed = Input.GetAxis("Horizontal2");
        verticalSpeed = Input.GetAxis("Vertical2");

        //! we turn the car here
        transform.Rotate(Vector3.up * Time.deltaTime * turnSpeed * horizontalSpeed);

        //! we move forward to car here
        transform.Translate(Vector3.forward * Time.deltaTime * verticalSpeed * speed);
        
        if (Input.GetKeyDown("r"))
        {
            transform.rotation = Quaternion.identity;
        }
    }
}
