using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeadTrigger : MonoBehaviour
{
    [SerializeField] Transform SpawnPoint;
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.name == "Player")
        {
            col.transform.position = SpawnPoint.position;
        }
    }
}
