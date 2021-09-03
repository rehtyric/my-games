using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wedgeOrNeedle : MonoBehaviour
{
    public float rotateSpd = 10f;
    public Rigidbody rigid;
    public bool wedge;
    public bool needle;
    public GameObject wedgeBarrel;
    public GameObject needleBarrel;
    public GameObject bullet;

    // Update is called once per frame
    void Update()
    {
        if (wedge) 
        {
            if (Input.GetKey("a"))
            {
                transform.Rotate(Vector3.up * -rotateSpd * Time.deltaTime);
            }
            if (Input.GetKey("d"))
            {
                transform.Rotate(Vector3.up * rotateSpd * Time.deltaTime);
            }
            if (Input.GetKey("w"))
            {
                rigid.velocity = transform.forward * 1;
                wedgeFire();
            }
        }
        if (needle)
        {
            if (Input.GetKey("left"))
            {
                transform.Rotate(Vector3.up * -rotateSpd * Time.deltaTime);
            }
            if (Input.GetKey("right"))
            {
                transform.Rotate(Vector3.up * rotateSpd * Time.deltaTime);
            }
            if (Input.GetKey("up"))
            {
                rigid.velocity = transform.forward * 1;
                needleFire();
            }
        }
        void wedgeFire()
        {
            Instantiate(bullet, wedgeBarrel.transform.position, wedgeBarrel.transform.rotation);

            bullet.GetComponent<Rigidbody>().AddRelativeForce(new Vector3(0, 1000, 0));
        }
        void needleFire()
        {
            Instantiate(bullet, needleBarrel.transform.position, needleBarrel.transform.rotation);

            bullet.GetComponent<Rigidbody>().AddRelativeForce(new Vector3(0, 1000, 0));
        }
    }
}
