using System.Collections;
using UnityEngine;

public class Chicken : MonoBehaviour
{

    public ChickenSO stats;

    private Vector3 lerpTarget;

    private int health;

    float timeElapsed;
    float lerpDuration = 100;


    float valueToLerp;

    private void Awake()
    {
        health = stats.Health;
    }

   
    public void SetDestination(Transform destination)
    {
        lerpTarget = destination.position;
    }

    private void Update()
    {
        if (timeElapsed < lerpDuration)
        {
            transform.position = Vector3.Lerp(transform.position, lerpTarget, timeElapsed/lerpDuration);

            timeElapsed += Time.deltaTime;
        }
      
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Barn"))
        {
            EventManager.RaiseAddPoints(stats.Score);
            Destroy(gameObject);
        }
    }

           
}
