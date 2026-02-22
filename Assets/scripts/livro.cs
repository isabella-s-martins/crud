using UnityEngine;

public class Livro : MonoBehaviour
{
    public GameObject bolaDeFogoPrefab;
    // 1. Variável de mana (usei int para facilitar o consumo de 1 em 1)
    public int mana = 10;

    void Update()
    {
        // 2. Só conjura se apertar Espaço E mana > 0
        if (Input.GetKeyDown(KeyCode.Space) && mana > 0)
        {
            Instantiate(bolaDeFogoPrefab, transform.position, Quaternion.identity);
            
            // 3. Consome 1 de mana
            mana--; 

            // 4. Feedback no Console
            Debug.Log("Mana restante: " + mana);
        }
        // 5. Se tentar sem mana
        else if (Input.GetKeyDown(KeyCode.Space) && mana <= 0)
        {
            Debug.Log("Sem Mana! Beba uma poção (R).");
        }
    }
}