using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteract : MonoBehaviour
{
    Collider2D playerCollider;
    void Start()
    {
        playerCollider = GetComponent<Collider2D>();
    }

    void Update()
    {
        
    }

    void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.tag == "Interactable" && Input.GetKeyDown(KeyCode.E))
        {
            Debug.Log("Picking Up Object");
            Destroy(other.gameObject);
        }
    }
}
