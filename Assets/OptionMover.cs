using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OptionMover : MonoBehaviour
{
    GameObject options;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        options = GameObject.Find("ButtonGroup");

        if(options != null)
        {
            options.transform.localPosition = new Vector3(288, options.transform.localPosition.y, options.transform.localPosition.z);
        }
    }
}
