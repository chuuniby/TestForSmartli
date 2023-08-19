using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStatScript : MonoBehaviour
{
    public string spikeTag;
    public CapsuleCollider col;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(spikeTag))
        {
            StartCoroutine(IFrame());
            GameManagerScript.instance.hp--;
        }
    }

    IEnumerator IFrame()
    {
        col.enabled = false;
        yield return new WaitForSeconds(0.5f);
        col.enabled = true;
    }
}
