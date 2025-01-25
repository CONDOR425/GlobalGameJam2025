using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spow : MonoBehaviour
{
    // Variabile pubblica per il prefab da instanziare
    public GameObject prefab;

    // Variabile pubblica per definire il tempo tra le istanze
    public float spawnTime = 1.0f;

    // Variabile privata per tenere traccia del tempo
    private float spawnTimer;

    void Start()
    {
        // Inizializza il timer
        spawnTimer = spawnTime;
    }

    void Update()
    {
        // Aggiorna il timer
        spawnTimer -= Time.deltaTime;

        // Controlla se è il momento di creare un nuovo prefab
        if (spawnTimer <= 0f)
        {
            // Resetta il timer
            spawnTimer = spawnTime;

            // Instanzia il prefab nella posizione e rotazione dello spawner
            Instantiate(prefab, transform.position, transform.rotation);
        }

    }
}