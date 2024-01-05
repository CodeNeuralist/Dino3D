using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dinoWalkAnim : MonoBehaviour
{

    public List<GameObject> _dinos;
    
    public List<GameObject> _dinos_prised;

    private GameObject _dino;
    private GameObject _dino_priced;
    private float WaitTime = 0.03f;
    
    public static bool walk;

    private Touch theTouch;

    public static bool jump;
    
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("DinoWalkAnimation");
    }
    
    
    // Update is called once per frame
    IEnumerator DinoWalkAnimation()
    {
        while (true)
        {
            if (Input.touchCount > 0)
            {
                theTouch = Input.GetTouch(0);

		        if (theTouch.position.x > Screen.width / 2)
		        {
                    for (int count = 0; count < _dinos_prised.Count; count++)
                    {
                            yield return new WaitForSeconds(WaitTime);

                            for (int count2 = 0; count2 < _dinos_prised.Count; count2++)
                            {
                                _dino = _dinos[count2];
                                _dino_priced = _dinos_prised[count2];
                                _dino_priced.SetActive(false);
                                _dino.SetActive(false);


                            }

                            _dino_priced = _dinos_prised[count];
                            _dino_priced.SetActive(true);
                    }                 
                    
		        }
                else
                {
                    for (int count = 0; count < _dinos.Count; count++)
                    {
                        yield return new WaitForSeconds(WaitTime);

                        for (int count2 = 0; count2 < _dinos.Count; count2++)
                        {
                            _dino = _dinos[count2];
                            _dino_priced = _dinos_prised[count2];
                            _dino_priced.SetActive(false);
                            _dino.SetActive(false);


                        }

                        _dino = _dinos[count];
                        _dino.SetActive(true);
                    }
                    
                }
                
            }
            else
            {
                for (int count = 0; count < _dinos.Count; count++)
                {
                    yield return new WaitForSeconds(WaitTime);

                    for (int count2 = 0; count2 < _dinos.Count; count2++)
                    {
                        _dino = _dinos[count2];
                        _dino_priced = _dinos_prised[count2];
                        _dino_priced.SetActive(false);
                        _dino.SetActive(false);


                    }

                    _dino = _dinos[count];
                    _dino.SetActive(true);
                }
            }
            

        }
    }
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "ground")
        {
            jump = false;
        }
        else
        {
            jump = true;
        }
        
    }
    
}
