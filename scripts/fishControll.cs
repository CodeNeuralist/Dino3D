using UnityEngine;

public class fishControll : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        destroyEnemy();   
    }

    private void destroyEnemy(){
       if (transform.position.z < -10)
       {
     	   Destroy(gameObject);
       }      
    } 
}
