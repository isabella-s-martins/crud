using UnityEngine;

public class BolaDeFogo : MonoBehaviour
{
    public float velocidade = 500f;
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        
       
        rb.AddForce(Vector2.right * velocidade);

  
        Destroy(gameObject, 3f);
    }
}