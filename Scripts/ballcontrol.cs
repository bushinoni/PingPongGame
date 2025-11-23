using UnityEngine;

public class ballcontrol : MonoBehaviour
{
    void Start()
    {

         float randomNumber = Random.Range(0f, 1f);

        if (randomNumber <= 0.5f)
        {
            GetComponent<Rigidbody2D>().AddForce(new Vector2(80f, 10f));
        }
        else
        {
            GetComponent<Rigidbody2D>().AddForce(new Vector2(-80f, -10f));
        }
    }

    void Update()
    {
        
    }
}
