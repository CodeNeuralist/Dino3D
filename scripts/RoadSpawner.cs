using System.Collections.Generic;
using UnityEngine;

public class RoadSpawner : MonoBehaviour
{
    public List<GameObject> _roads;
    [SerializeField] private float roadLenght;
    private GameObject _road;
    public Transform mainRoad;

    // Start is called before the first frame update
    void Start()
    {
        _road = Instantiate(_roads[Random.Range(0, _roads.Count)], transform.position, Quaternion.identity);
        _road.transform.SetParent(mainRoad);
    }

  
    public void Spawn()
    {        
	 if(_road.transform.position.z <= 100)
	 {
	     Vector3 position = new Vector3(0, 0, _road.transform.position.z + roadLenght);
	     _road = Instantiate(_roads[Random.Range(0, _roads.Count)], position , Quaternion.identity);
	     _road.transform.SetParent(mainRoad);
	     
	 } else {
		 
	 }
	 
	
    }
}
