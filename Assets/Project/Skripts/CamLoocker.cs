using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamLoocker : MonoBehaviour
{
    void Update()
    {
        Vector3 posa = Muwer.rid.transform.position;
        Camera.main.transform.LookAt(posa + new Vector3(0,8,0));
        transform.position = Vector3.Lerp(transform.position, posa, Time.deltaTime);
    }
}
