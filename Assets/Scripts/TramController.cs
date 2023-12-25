using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TramController : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] private Vector3 position;
    bool isFlipped = false;
    // Start is called before the first frame update
    void Start()
    {
        //position = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += speed * position;
        if (Input.GetMouseButtonDown(0))
        {
            isFlipped = !isFlipped;
            position = new Vector3(position.x, -1 * position.y, position.z);
        }
    }
}
