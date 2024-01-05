using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{

    public Transform SpawmPoint;
    public Transform SpawmPointMoney;
	public List<Transform> SpawmPointPtero;

    public static int score = 0;
    public TextMeshProUGUI scoreText;
    
    public Transform EnemisLetaushes;
    
    
    public List<GameObject> _fishes;
    public List<GameObject> _nenuphars;

    private GameObject _cactus;
    private GameObject _money;
    public GameObject _enemy;
    
	
	private GameObject _tumbleweedPriv;
    
    private GameObject _enemyy;
    

    private void Start()
    {
        StartCoroutine("SpawnDecorsObjects");
        InvokeRepeating("ScoreUp", 1f, 2f);
        StartCoroutine("SpawnFishesAndPtero");
    }
    
    IEnumerator SpawnFishesAndPtero()
    {

        while (true)
        {
            float WaitTime = Random.Range(10f,20f);

            yield return new WaitForSeconds(WaitTime);

			var a = SpawmPointPtero[Random.Range(0, SpawmPointPtero.Count)].position;
            _enemyy = Instantiate(_enemy, a, Quaternion.Euler(0, 180, 0));
			print(a);
            _enemyy.transform.SetParent(EnemisLetaushes);
            
            Instantiate(_fishes[Random.Range(0, _fishes.Count)], SpawmPointMoney.position, Quaternion.identity);

            Instantiate(_nenuphars[Random.Range(0, _nenuphars.Count)], SpawmPointMoney.position, Quaternion.identity);

        }
    }
    

    private void Awake()
    {     
	    Application.targetFrameRate = 500;
    }

    public void ScoreUp()
    {
        score++;
        scoreText.text = score.ToString();      
    }

    
}

    



