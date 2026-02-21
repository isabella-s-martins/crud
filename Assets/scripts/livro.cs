using UnityEngine;

public class livro : MonoBehaviour
{
       public GameObject bolaDeFogoPrefab;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
 
        Instantiate(bolaDeFogoPrefab,transform.position,Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
