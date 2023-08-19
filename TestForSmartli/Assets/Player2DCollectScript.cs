using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2DCollectScript : MonoBehaviour
{
    public string collectibleTag;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag(collectibleTag))
        {
            GameManagerScript.instance.collectibleCounter++;
            Destroy(collision.gameObject);
        }
    }
}
