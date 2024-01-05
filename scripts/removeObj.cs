using UnityEngine;

public class removeObj : MonoBehaviour
{
    // Start is called before the first frame update
    void Update()
    {
        destroyEnemy();
    }

    private void destroyEnemy()
    {

        if (transform.position.z < -23)
        {
            Destroy(gameObject);
        }

    }
}
