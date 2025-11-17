using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Look : MonoBehaviour
{
    public GameObject tarjet;
    public GameObject Ojos;


    // Update is called once per frame
    void Update()
    {
        Vector3 PosRelative = tarjet.transform.position - Ojos.transform.position;
        Ojos.transform.rotation = Quaternion.LookRotation(PosRelative,Vector3.up);
    }


}
