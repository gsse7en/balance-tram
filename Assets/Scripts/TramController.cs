using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TramController : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] private Vector3 position;
    // Start is called before the first frame update
    void Start()
    {
        //position = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += speed * position;
    }
}
