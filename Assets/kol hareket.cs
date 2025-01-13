using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kolhareket : MonoBehaviour
{
    public float Hiz = 2.0f;
    public float RotasyonHizi = 90.0f;
    public float SpeedFactor = 1.0f;

    private Transform tr;
    private Vector3 Pozisyon;
    // Start is called before the first frame update
    void Start()
    {
        tr = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        //hareket
        float solJojstickX = OVRInput.Get(OVRInput.Axis2D.PrimaryThumbstick).x;
        float solJojstickY = OVRInput.Get(OVRInput.Axis2D.PrimaryThumbstick).y;
        Vector3 joystickHareket = new Vector3(solJojstickX, 0f, solJojstickY);
        //dönüþ
        float sagJoystickX = OVRInput.Get(OVRInput.Axis2D.SecondaryThumbstick).x;
        tr.Rotate(Vector3.up, sagJoystickX * RotasyonHizi * Time.deltaTime);

        if (OVRInput.GetDown(OVRInput.Button.Two))
        {
            SpeedFactor = 2.5f;
        }

        else if (OVRInput.GetUp(OVRInput.Button.Two)) 
        {
            SpeedFactor = 1f;
        }
        float speed = Hiz * SpeedFactor * Time.deltaTime;
        Vector3 v = Quaternion.Euler(0, tr.eulerAngles.y, 0)*joystickHareket*speed;
        Pozisyon = Pozisyon + v;
            tr.position = Pozisyon;
    }
}
