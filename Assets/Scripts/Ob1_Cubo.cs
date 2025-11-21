using System;
using UnityEngine;

public class Ob1_Cubo : MonoBehaviour
{
    GameObject cubo;
    public float vRotacion;

    Vector3[] Vertices ={
        new Vector3(0,0,0), //0
        new Vector3(1,0,0), //1
        new Vector3(0,1,0), //2
        new Vector3(1,1,0), //3
        new Vector3(0,1,1), //4
        new Vector3(1,1,1), //5
        new Vector3(1,0,1), //6
        new Vector3(0,0,1)  //7
    };

    int[] Triangulos = {
        0,2,1, //frente
        1,2,3,
        1,3,5, //derecha
        1,5,6,
        6,5,4, //atras
        6,4,7,
        7,4,2, //izquierda
        7,2,0,
        2,4,3, //arriba
        3,4,5,
        0,1,6, //abajo
        0,6,7
    };

    void Awake()
    {
        cubo = new GameObject("Cubo");
        cubo.transform.parent = this.transform;
        cubo.AddComponent<MeshFilter>();
        cubo.AddComponent<MeshRenderer>();

        Mesh malla = new Mesh();
        malla.vertices = Vertices;
        malla.triangles = Triangulos;
        malla.Optimize();
        malla.RecalculateNormals();

        cubo.GetComponent<MeshFilter>().mesh = malla;
        cubo.GetComponent<Renderer>().material = new Material(Shader.Find("Standard"));
    }

    void Start()
    {
        cubo.transform.position = new Vector3(0, 0, 0);
        cubo.transform.localScale = new Vector3(1, 1, 1);
        cubo.GetComponent<Renderer>().material.color = Color.red;
    }

    void Update()
    {
        Vector3 randRotation = new Vector3
        (
            UnityEngine.Random.Range(0, 90),
            UnityEngine.Random.Range(0, 90),
            UnityEngine.Random.Range(0, 90)
        );

        cubo.transform.Rotate(randRotation * vRotacion * Time.deltaTime);
    }

    void OnEnable()
    {
        string GoName = gameObject.name;
        Debug.Log($"El script {GoName} ha sido habilitado.");
    }

    void OnDisable()
    {
        string GoName = gameObject.name;
        Debug.Log($"El script {GoName} ha sido deshabilitado.");
    }
}
