using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallBreak : MonoBehaviour
{
    public int health = 1;
    
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Bullet")
        {
            health--;
            Debug.Log("Hit");
        }
        
        if (health <= 0)
        {
            Destroy(gameObject, 0f);
        }
        
    }
}
