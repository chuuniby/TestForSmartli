using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollectScript : MonoBehaviour
{
    public string collectibleTag;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(collectibleTag))
        {
            GameManagerScript.instance.collectibleCounter++;
            Destroy(other.gameObject);
        }
    }
}
