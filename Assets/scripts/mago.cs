using UnityEngine;

public class mago : MonoBehaviour

{
    public GameObject bolaDeFogoPrefab;

    void Update()
    {
        // Exemplo: Atira quando apertar o Espaço
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(bolaDeFogoPrefab, transform.position, Quaternion.identity);
        }
    }
}
