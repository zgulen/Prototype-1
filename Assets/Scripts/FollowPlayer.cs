using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset = new Vector3(0, 5, -19);
    private Vector3 fpsCam = new Vector3(0, 2, -0.37f);
    private bool toogle = true;
    float eulerAngY;
    float eulerAngX;
    float eulerAngZ;
    // private float turnSpeed = 80.0f;
    // private float horizontalSpeed;
    // private float verticalSpeed;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void LateUpdate()
    {
        eulerAngY = transform.localEulerAngles.y;
        // eulerAngX = transform.localEulerAngles.x;
        // eulerAngZ = transform.localEulerAngles.z;

        //? 3rd person camera view
        if (toogle)
        {
            transform.position = player.transform.position + offset;
            transform.rotation = Quaternion.identity;

            //! necessary to change view
            if (Input.GetKeyDown("m"))
            {
                toogle = false;
                //* positioning the right position after the view changed
                transform.rotation = Quaternion.Euler(0, -eulerAngY, 0);
            }
        }

        //? fps camera view
        else
        {
            transform.position = player.transform.position + fpsCam;

            //! necessary to change view
            if (Input.GetKeyDown("m"))
            {
                toogle = true;
            }

            //? Re-Set the came position
            else if(Input.GetKeyDown("k")){
                transform.rotation = Quaternion.identity;
            }
        }
    }
}
