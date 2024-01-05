using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pteroAnim : MonoBehaviour
{
	public List<GameObject> _dinos;
	private GameObject _dino;
	private float WaitTime = 0.1f;
	
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("DinoWalkAnimation");
    }

    IEnumerator DinoWalkAnimation()
    {
        while (true)
        {               	       
            for (int count = 0; count < _dinos.Count; count++)
            {
                yield return new WaitForSeconds(WaitTime);

                for (int count2 = 0; count2 < _dinos.Count; count2++)
                {
                    _dino = _dinos[count2];                
                    _dino.SetActive(false);


                }

                _dino = _dinos[count];
                _dino.SetActive(true);
            }
        }
            

    }
}
