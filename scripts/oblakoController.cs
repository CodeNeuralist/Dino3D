using UnityEngine;

public class oblakoController : MonoBehaviour
{
    public float speed;

    // Update is called once per frame
    void Update()
    {
        destroyEnemy();
        transform.Translate(Vector3.forward * speed * Time.deltaTime);


    }

    private void destroyEnemy()
    {

        if (transform.position.z < -23)
        {
            Destroy(gameObject);
        }

    }
}
