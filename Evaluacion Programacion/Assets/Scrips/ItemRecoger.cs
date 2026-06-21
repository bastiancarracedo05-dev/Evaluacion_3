using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using RPG.Inventory;

public class ItemRecoger : MonoBehaviour
{
    public string nombreArma;
    public int danoArma;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            InventarioArmas inventario = other.GetComponent<InventarioArmas>();

            if (inventario != null )
            {
                inventario.AgregarArma(new Arma(nombreArma, danoArma));
                Debug.Log("Recogiste: " + nombreArma);
                Destroy(gameObject);
            }
        }
    }
}
