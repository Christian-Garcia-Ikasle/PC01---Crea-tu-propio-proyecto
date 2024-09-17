using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "Data", menuName = "ScriptableObjects/SpawnManagerScriptableObject", order = 1)]

public class SpawnCenter : ScriptableObject
{
    public string nombreObjeto;

    public int numeroObjeto = 4;
    public Vector3[] lugarDeSpawn;    

}
