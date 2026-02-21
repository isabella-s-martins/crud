using UnityEngine;

public class BolaDeFogo : MonoBehaviour
{
    public float velocidade = 500f;
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        
        // Aplica a força na própria bola de fogo assim que ela nasce
        rb.AddForce(Vector2.right * velocidade);

        // Se destrói após 3 segundos para não pesar o jogo
        Destroy(gameObject, 3f);
    }
}