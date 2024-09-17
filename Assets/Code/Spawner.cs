using System;
using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using Unity.VisualScripting;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    
    public GameObject cuadrado;
    public SpawnCenter datosSpawn;
    int numeroObjeto = 1;

    // Start is called before the first frame update
    void Start()
    {
        Spawnear();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Spawnear()
    {
        var random = new System.Random();
        int indice = 0 ;
        for (int i = 0; i < datosSpawn.numeroObjeto; i++)
        {
            GameObject objeto = Instantiate(cuadrado, datosSpawn.lugarDeSpawn[random.Next(0,datosSpawn.lugarDeSpawn.Length)], Quaternion.identity);
            objeto.name = datosSpawn.nombreObjeto + numeroObjeto;
            indice = (indice + 1) % datosSpawn.lugarDeSpawn.Length;
            numeroObjeto ++;
        }
    }
}
