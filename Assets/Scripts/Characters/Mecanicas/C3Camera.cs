using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class C3Camera : MonoBehaviour {
    public float SpeedX, SpeedY, AngleMax;
    public GameObject Camara;
    Quaternion RotDeseada = Quaternion.identity;
    Vector3 RotCentral = Vector3.zero;
    Vector3 angulos = Vector3.zero;

    private void Awake() {
        RotCentral = transform.rotation.eulerAngles;
    }

    void Update() {

    }


    private void LateUpdate() {
        Vector3 posRelative = transform.position - Camara.transform.position;
        Camara.transform.rotation = Quaternion.LookRotation(posRelative, Vector3.up);

        float z = transform.localEulerAngles.z;
        RotDeseada = Quaternion.Euler(Input.GetAxis("Vertical"), 0f, 0f);
        float AngleCurrent = Quaternion.Angle(Quaternion.Euler(RotCentral.x, 0f, 0f), Quaternion.Euler(transform.rotation.eulerAngles.x, 0f, 0f) * RotDeseada);
        print(AngleCurrent);

        if(AngleCurrent < AngleMax) {
            transform.rotation = Quaternion.RotateTowards(transform.rotation, transform.rotation * RotDeseada, AngleMax);
        } else {
            transform.rotation = Quaternion.Slerp(transform.rotation, transform.rotation, Input.GetAxis("Vertical"));
        }
        transform.Rotate(new Vector3(0f, -Input.GetAxis("Horizontal") * SpeedX, 0f), 0.10f, Space.Self);

        angulos = transform.localEulerAngles;
        angulos.z = z;
        transform.localEulerAngles = angulos;

    }

}
