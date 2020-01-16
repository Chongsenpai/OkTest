using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class uwu : MonoBehaviour
{
    [SerializeField] GameObject SpawnObject;
    [SerializeField] GameObject Target;

    private void OnTriggerEnter(Collider other)
    {
        GameObject TempSpawn = Instantiate(SpawnObject, Target.transform.position, Target.transform.rotation);
        Destroy(TempSpawn, 3f);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
