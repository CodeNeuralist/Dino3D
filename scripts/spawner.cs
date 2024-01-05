using UnityEngine;

public class spawner : MonoBehaviour
{
    [SerializeField] private RoadSpawner _roadSpawner;

    private void OnTriggerEnter(Collider other)
    {
 
        _roadSpawner.Spawn();
    }

}
