using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{

public Transform _transfome;
    // Start is called before the first frame update
    void Start()
    {
        _transfome = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
              Debug.Log("今のY座標は"+ _transfome.position.y);

    }
}
