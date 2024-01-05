using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class PlayerController : MonoBehaviour
{

    Rigidbody rb;
    public float jumpForce;
    int coints = 0;
    public TextMeshProUGUI moneyText;
    private Touch theTouch;
    public GameObject gameOverAct;
    
    void Start(){
	    coints = PlayerPrefs.GetInt("Money");
        moneyText.text = coints.ToString();
    }
    private void Awake()
    {
        rb = GetComponent<Rigidbody>();

    }
    
    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0)
        {
            theTouch = Input.GetTouch(0);
        
            if (theTouch.position.x < Screen.width / 2)
        	{
        	    rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        	}
        }
    }

    

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "obstacle")
        {
            SceneManager.LoadScene("game");

        }
	    if (other.gameObject.tag == "money")
        {
            Destroy(other.gameObject);
      	    coints = coints + 5;
      	    moneyText.text = coints.ToString();
      	    PlayerPrefs.SetInt("Money", coints);
      
        }
    }


    
	
    
}
