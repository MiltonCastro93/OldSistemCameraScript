using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour {
    public float SpeedX, SpeedY, AngleMax, AngleCurrent;
    public GameObject Character;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update() {
        AngleCurrent = Quaternion.Angle(Quaternion.Euler(0f, Character.transform.rotation.eulerAngles.x, 0f), Quaternion.Euler(0f, transform.rotation.eulerAngles.x, 0f));
        if(AngleCurrent < AngleMax) {
            //entra si esta entre los 45 Grados
        } else {
            //entra si pasa de los 45.01 Grados
        }

        transform.Rotate(new Vector3(0f, transform.rotation.eulerAngles.y * Input.GetAxis("Mouse Y"), 0f));

    }

}
