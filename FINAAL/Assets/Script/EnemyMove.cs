using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{

    public int EnemySpeed;
    public int XMoveDirect;
    

    // Update is called once per frame
    void Update()
    {
        RaycastHit2D hit = Physics2D.Raycast(transform.position, new Vector2(XMoveDirect, 0));
        gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(XMoveDirect, 0) * EnemySpeed;
        if (hit.distance < 1.7f)
        {
            Flip();
            if (hit.collider.tag == "Player")
            {
                Destroy(hit.collider.gameObject);
            }
        }
        
    }

    void Flip()
    {
        if(XMoveDirect > 0)
        {
            XMoveDirect = -1;
        }
        else
        {
            XMoveDirect = 1;
        }
    }
}
