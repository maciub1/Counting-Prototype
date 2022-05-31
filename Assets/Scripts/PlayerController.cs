using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float rotationSpeed = 1;
    public float blastPower = 5;

    public GameObject BallPref;
    public Transform ShootPoint;


    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles + new Vector3(0, horizontalInput * rotationSpeed, verticalInput * rotationSpeed));
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject createdBall = Instantiate(BallPref, ShootPoint.position, ShootPoint.rotation);
            createdBall.GetComponent<Rigidbody>().velocity = ShootPoint.transform.up * blastPower;
        }
        float angleY = transform.localEulerAngles.y;
        angleY = (angleY > 180) ? angleY - 360 : angleY;
        if (angleY > 60.0f)
        {
            transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles.x, 60, transform.rotation.eulerAngles.z);
        }
        else if (angleY < -60.0f)
        {
            transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles.x, -60, transform.rotation.eulerAngles.z);
        }

        float angleZ = transform.localEulerAngles.z;
        angleZ = (angleZ > 180) ? angleZ - 360 : angleZ;
        if(angleZ > 0f)
        {
            transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles.x, transform.rotation.eulerAngles.y, 0f);
        } else if(angleZ < -40)
        {
            transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles.x, transform.rotation.eulerAngles.y, -40f);
        }
    }
}
