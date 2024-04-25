using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Starter : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject gm;
    private GameObject[] gmArray;
    void Start()
    {
        gmArray = GameObject.FindGameObjectsWithTag("Enemy");
        for (int i = 0; i < gmArray.Length; i++) {
            Instantiate(gm, gmArray[i].transform.position, gmArray[i].transform.rotation);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
