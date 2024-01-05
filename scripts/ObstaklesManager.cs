using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstaklesManager : MonoBehaviour
{
    
    private GameObject _cactus;
    public List<GameObject> _cactuses;
    public Transform SpawmPoint;
    public Transform Enemis;
    
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("SpawnObstaclesCactuses");
    }
    
    IEnumerator SpawnObstaclesCactuses()
    {

        while (true)
        {
            float WaitTime = Random.Range(1.5f, 5f);

            yield return new WaitForSeconds(WaitTime);


            _cactus = Instantiate(_cactuses[Random.Range(0, _cactuses.Count)], SpawmPoint.position, Quaternion.Euler(0, Random.Range(0, 360), 0));
            _cactus.transform.SetParent(Enemis);


            // _money = Instantiate(Money, SpawmPointMoney.position, Quaternion.identity);
            // _money.transform.SetParent(_money_list);

        }
    }

    
}
