using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPlayer : MonoBehaviour
{
    // Start is called before the first frame update
    private GameObject roof;
    private GameObject floor;
    void Start()
    {
        roof = GameObject.FindGameObjectWithTag("roof"); 
        floor = GameObject.FindGameObjectWithTag("floor"); 
    }

    // Update is called once per frame
    void Update()
    {
        
        Debug.DrawLine(roof.transform.position, floor.transform.position);
        if (Physics.Linecast(roof.transform.position, floor.transform.position, out ))
        {
            roof.SetActive(false);
        }
        else
        {
            roof.SetActive(true);
        }
    }
}
