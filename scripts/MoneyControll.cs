using UnityEngine;

public class MoneyControll : MonoBehaviour
{
    private float speed = -10;
    public int rotSpeed = 1;


    // Update is called once per frame
    void Update()
    {
        destroyMoney();
        transform.Translate(Vector3.forward * speed * Time.deltaTime);	       
    }

    private void destroyMoney()
    {
        if (transform.position.z < -23)
        {
            Destroy(gameObject);
        }

    }
}
