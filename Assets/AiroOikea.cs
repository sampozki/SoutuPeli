using System.Collections;
using System.Collections.Generic;
using TreeEditor;
using UnityEngine;

public class AiroOikea : MonoBehaviour
{

    public Vector3 rotateVertical;
    public Vector3 rotateHorizontal;
    public float speed;

    public float smooth = 5.0f;
    public float tiltAngle = 60.0f;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        /*if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Rotate(rotateVertical * Time.deltaTime * speed);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Rotate(rotateVertical * Time.deltaTime * speed * -1);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(rotateHorizontal * Time.deltaTime * speed);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(rotateHorizontal * Time.deltaTime * speed * -1);
        }

        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");

        transform.Rotate(new Vector3(0, x, 0));
        transform.Rotate(new Vector3(0, 0, y));*/

        float tiltAroundZ = Input.GetAxis("Horizontal Right Stick") * tiltAngle;
        float tiltAroundY = Input.GetAxis("Vertical Right Stick") * tiltAngle;

        Quaternion target = Quaternion.Euler(0, -tiltAroundY, -tiltAroundZ);

        transform.localRotation = Quaternion.Slerp(transform.localRotation, target, Time.deltaTime * smooth);





    }
}
