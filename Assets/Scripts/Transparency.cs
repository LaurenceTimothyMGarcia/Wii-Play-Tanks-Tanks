using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Transparency : MonoBehaviour
{
    public float invisTime = 5f;
    public float revealTime = 1f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.GetComponentInChildren<MeshRenderer>().material.color = new Color(1.0f, 1.0f, 1.0f, 0.0f);
        invisTime -= Time.deltaTime;

        if(invisTime <= 0)
        {
            this.GetComponentInChildren<MeshRenderer>().material.color = new Color(1.0f, 1.0f, 1.0f, 1.0f);
            revealTime -= Time.deltaTime;
            if (revealTime <= 0)
            {
                invisTime = 5f;
            }
        }
    }
}
