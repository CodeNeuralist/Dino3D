using UnityEngine;

public class obstacle : MonoBehaviour
{
    public float speed;

    // Update is called once per frame
    void Update()
    {
        // transform.Translate(0, 0, -0.3f);
        


         transform.Translate(Vector3.forward * speed * Time.deltaTime);  
    }

   

    
}
