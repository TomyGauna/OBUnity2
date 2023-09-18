using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateObject : MonoBehaviour
{
    public GameObject lightTank;
    void Start()
    {
        
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.L)){
            lightTank.SetActive(!lightTank.activeInHierarchy);
        }
    }
}
