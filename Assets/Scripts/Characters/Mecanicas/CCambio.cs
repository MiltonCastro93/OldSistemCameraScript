using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CCambio : MonoBehaviour {
    public bool Cams = true;
    public GameObject Cam1, Cam2;


    void Update() {
        if (Cams) {
            Cam1.SetActive(true);Cam2.SetActive(false);
            Cam1.transform.rotation = Quaternion.identity;
        } else {
            Cam1.SetActive(false);Cam2.SetActive(true);
            Cam2.transform.rotation = Quaternion.identity;
        }

        if(Input.GetKeyDown(KeyCode.C)) {
            Cams = !Cams;
        }


    }


}
