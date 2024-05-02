using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public Transform player;
    public float moveSpeed = 3.0f; 
    public float detectionRange = 5.0f;
    public string Name;

   public virtual void MakeSound()
   {
        Debug.Log("No Sound Detected");
   }
   
    // Start is called before the first frame update
    void Start()
    {
        MakeSound();

    }

    // Update is called once per frame
    void Update()
    {
        float distanceToPlayer = Vector3.Distance(transform.position, player.position);

        if (distanceToPlayer <= detectionRange)
        {
            Vector3 direction = (player.position - transform.position).normalized;

            transform.Translate(direction * moveSpeed * Time.deltaTime);
        }
    }
}
