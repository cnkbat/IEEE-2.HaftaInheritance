using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParentObjScript : MonoBehaviour
{
    [SerializeField] GameObject testObj;
    [SerializeField] Vector3 position;
    [SerializeField] protected Material material;
    protected GameObject spawnedObj;


    // bahsetmeyi unuttum interfaceyle farkı interface ne olacağını söylerken
    // bu yöntemle nasıl olacağını da değiştirebiliyoruz.
    
    protected virtual void Start()
    {
        Debug.Log("Start Fonksiyonu " + gameObject.name + " tarafından çağırıldı.");
        GetComponent<MeshRenderer>().material = material;

        spawnedObj = Instantiate(testObj, position, Quaternion.identity);
        spawnedObj.name = gameObject.name + " tarafından çağırıldı.";
    }

}
