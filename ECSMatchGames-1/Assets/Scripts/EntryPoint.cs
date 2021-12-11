using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using Systems = Entitas.Systems;

public class EntryPoint : MonoBehaviour
{
    private Entitas.Systems _systems;
    
    // Start is called before the first frame update
    void Start()
    {
        var contexts = Contexts.sharedInstance;
        
        _systems.Initialize();
    }

    // Update is called once per frame
    void Update()
    {
        _systems.Execute();
    }
}
