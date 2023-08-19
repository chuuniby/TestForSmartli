using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2DInteractScript : MonoBehaviour
{
    public string spikeTag;
    public BoxCollider2D col;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag(spikeTag))
        {
            GameManagerScript.instance.hp--;
        }
    }
}
