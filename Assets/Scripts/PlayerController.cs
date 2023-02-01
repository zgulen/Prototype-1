using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float speed = 20.0f;
    private float turnSpeed = 80.0f;
    private float horizontalSpeed;
    private float verticalSpeed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("k"))
        {
            transform.rotation = Quaternion.identity;
        }
        //! player's inputs
        horizontalSpeed = Input.GetAxis("Horizontal");
        verticalSpeed = Input.GetAxis("Vertical");

        //! we move forward to car here
        transform.Translate(Vector3.forward * Time.deltaTime * verticalSpeed * speed);

        //! we turn the car here
        transform.Rotate(Vector3.up * Time.deltaTime * turnSpeed * horizontalSpeed);
    }
}
