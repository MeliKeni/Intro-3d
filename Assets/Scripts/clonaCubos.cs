using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clonaCubos : MonoBehaviour
{
    public GameObject cuboPrefab;
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void ClonarCubo()
    {
        Instantiate(cuboPrefab);

    }
}
