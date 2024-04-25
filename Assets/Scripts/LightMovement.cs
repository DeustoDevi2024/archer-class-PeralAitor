using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightMovement : MonoBehaviour
{

    public GameObject gm;
    // Start is called before the first frame update
    void Start()
    {
        this.transform.SetParent(gm.GetComponent<Transform>());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
