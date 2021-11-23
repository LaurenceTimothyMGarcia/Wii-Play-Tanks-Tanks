using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoInvisible : MonoBehaviour
{
    public MeshRenderer meshy;
    public float visibleTime = 1f;
    public float invisibleTime = 5f;

    float timerVisible;
    float timerInvisible;
    bool visible = true;

    // Start is called before the first frame update
    void Start()
    {
        timerVisible = visibleTime;
        timerInvisible = invisibleTime;
    }

    // Update is called once per frame
    void Update()
    {
        if (visible)
        {
            timerVisible -= Time.deltaTime;
            if (timerVisible <= 0)
            {
                meshy.enabled = false;
                timerVisible = visibleTime;
                visible = false;
            }
        }
        else
        {
            timerInvisible -= Time.deltaTime;
            if (timerInvisible <= 0)
            {
                meshy.enabled = true;
                timerInvisible = invisibleTime;
                visible = true;
            }
        }
        
    }
}
