using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class imagens_dano : MonoBehaviour
{

    // carregar imagens de dano

    public GameObject oops, poof, pow;
    
    private void OnTriggerEnter2D(Collider2D outro)
    {
        if(outro.gameObject.CompareTag("aviao"))
        {
            int aleatorio = Random.Range(0, 3);
            if(aleatorio == 0)
            {
                Instantiate(pow, new Vector3(this.gameObject.transform.position.x, this.gameObject.transform.position.y, -0.4f), Quaternion.identity);
            }

            if (aleatorio == 1)
            {
                Instantiate(poof, new Vector3(this.gameObject.transform.position.x, this.gameObject.transform.position.y, -0.4f), Quaternion.identity);
            }

            if (aleatorio == 2)
            {
                Instantiate(oops, new Vector3(this.gameObject.transform.position.x, this.gameObject.transform.position.y, -0.4f), Quaternion.identity);
            }

        }
    }
}
