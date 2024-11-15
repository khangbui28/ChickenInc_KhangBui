using UnityEngine;

public class ChickenSpawner : MonoBehaviour
{
    [SerializeField] Chicken chickenPrefabs;



    [SerializeField] Transform spawnPoint;
    [SerializeField] Transform endPoint;

    private float _currentTime;

    private void Awake()
    {
        
    }

    void Update()
    {
       
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SpawnChicken();
        }
    }

    public void SpawnChicken()
    {
        
        Chicken chicken = Instantiate(chickenPrefabs, spawnPoint.position, Quaternion.identity);

    
        if (chicken != null)
        {
            chicken.SetDestination(endPoint);
        }
    }
    
}
