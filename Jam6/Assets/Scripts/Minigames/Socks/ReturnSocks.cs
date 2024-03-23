using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReturnSocks : MonoBehaviour
{
    public GameObject sock1;
    public GameObject sock2;
    public GameObject sock3;
    public GameObject sock4;
    public GameObject sock5;
    public GameObject sock6;

    private Vector3 sock1Coord;

    private Vector3 sock2Coord;

    private Vector3 sock3Coord;

    private Vector3 sock4Coord;

    private Vector3 sock5Coord;

    private Vector3 sock6Coord;
    void OnEnable()
    {
        sock1.transform.position = sock1Coord;
        sock2.transform.position = sock2Coord;
        sock3.transform.position = sock3Coord;
        sock4.transform.position = sock4Coord;
        sock5.transform.position = sock5Coord;
        sock6.transform.position = sock6Coord;
    }

    void Start()
    {
        sock1Coord = sock1.transform.position;
        sock2Coord = sock2.transform.position;
        sock3Coord = sock3.transform.position;
        sock4Coord = sock4.transform.position;
        sock5Coord = sock5.transform.position;
        sock6Coord = sock6.transform.position;
    }

}
