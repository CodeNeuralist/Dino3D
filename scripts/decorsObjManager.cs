using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class decorsObjManager : MonoBehaviour
{
    public Transform EnemisDecores;

    public Transform tumbleweeds;


    public List<Transform> spawnpoints;
	public List<Transform> spawnpointsChereps;
    public List<Transform> spawnpointsTumbleweeds;
    public List<GameObject> decorsOdjects;
	public List<GameObject> ScorpionsAndChereps;

    private GameObject _cactus;
    private GameObject _money;

    public GameObject _tumbleweed;

    private GameObject _tumbleweedPriv;

    private GameObject _enemyy;
	
	private GameObject _cherepPriv;
	
	public Transform roadsAndObjects;
	

    void Start()
    {
		StartCoroutine("SpawnDecorsObjects");
		StartCoroutine("SpawnCherepAndScorpionsObjects");
    }

    IEnumerator SpawnDecorsObjects()
    {
        while (true)
        {
            for (int count = 0; count < Random.Range(1, 4); count++)
            {
                var indexPoint = Random.Range(0, spawnpointsTumbleweeds.Count);
                var indexObject = Random.Range(0, decorsOdjects.Count);

                _tumbleweedPriv = Instantiate(_tumbleweed, spawnpointsTumbleweeds[indexPoint].transform.position,
                    Quaternion.identity);
                _tumbleweedPriv.transform.SetParent(tumbleweeds);

                _cactus = Instantiate(decorsOdjects[indexObject], spawnpoints[indexPoint].transform.position,
                    Quaternion.Euler(0, Random.Range(0, 360), 0));
                _cactus.transform.SetParent(roadsAndObjects);
				

                yield return new WaitForSeconds(0.3f);
            }

            float WaitTime = Random.Range(2f, 4f);
            yield return new WaitForSeconds(WaitTime);
        }
    }
	
	IEnumerator SpawnCherepAndScorpionsObjects()
    {
        while (true)
        {
            for (int count = 0; count < Random.Range(1, 4); count++)
            {
                var indexPoint = Random.Range(0, spawnpoints.Count);
				var indexObject = Random.Range(0, ScorpionsAndChereps.Count);
				
				// scorpio
				if (indexObject == 0){
					_cherepPriv = Instantiate(ScorpionsAndChereps[indexObject], spawnpointsChereps[indexPoint].transform.position, Quaternion.Euler(0, Random.Range(0, 360), 0));
					_cherepPriv.transform.SetParent(roadsAndObjects);
				} else if (indexObject == 1) {
					
					// else
					_cherepPriv = Instantiate(ScorpionsAndChereps[indexObject], spawnpointsChereps[indexPoint].transform.position, Quaternion.Euler(Random.Range(0, 360), Random.Range(0, 360), Random.Range(0, 360)));
					_cherepPriv.transform.SetParent(roadsAndObjects);

				}
                
				
       			
			

                yield return new WaitForSeconds(3f);
            }

            float WaitTime = Random.Range(2f, 4f);
            yield return new WaitForSeconds(WaitTime);
        }
    }
	
	
	
	
}