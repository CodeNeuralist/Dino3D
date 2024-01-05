using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;


public class GameManagerMenu : MonoBehaviour

{
    int coints = 0;
    public TextMeshProUGUI moneyText;

    // Start is called before the first frame update
    void Start()
    {
        coints = PlayerPrefs.GetInt("Money");
        moneyText.text = coints.ToString();
    }
   
    public void StartGame()
    {
        SceneManager.LoadScene("game");
    }


}
