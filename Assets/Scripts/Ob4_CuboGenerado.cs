using UnityEngine;
using UnityEngine.UIElements;

public class Ob4_CuboGenerado : MonoBehaviour
{
    public GameObject cuboPrefab;
    public Vector3 OnDisablePosition;
    public Vector3 OnEnablePosition;

    void Awake()
    {
        Instantiate(cuboPrefab, this.transform.position, Quaternion.identity);
        Debug.Log("CuboPrefab generado en la escena desde awake.");
    }

    void Update()
    {
        Instantiate(cuboPrefab, this.transform.position, Quaternion.identity);
        Debug.Log("CuboPrefab generado en la escena desde Update.");
    }

    void OnEnable()
    {
        Instantiate(cuboPrefab, OnEnablePosition, Quaternion.identity);
        Debug.Log("CuboPrefab generado en la escena desde OnEnable.");
    }

    void OnDisable()
    {
        if (!gameObject.scene.isLoaded) return;
        Instantiate(cuboPrefab, OnDisablePosition, Quaternion.identity);
        Debug.Log("CuboPrefab generado en la escena desde OnDisable.");
    }

}
