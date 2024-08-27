using UnityEngine;
using UnityEngine.Serialization;

public class Rotator : MonoBehaviour
{
    [FormerlySerializedAs("rotationSpeed")] [SerializeField] private float rotationDegreesPerSecond = 100f;
    [SerializeField] private Vector3 rotationAxis = new Vector3(1f, 1f, 1f);
    
    // Update is called once per frame
    private void Update()
    {
        transform.Rotate(rotationAxis, rotationDegreesPerSecond * Time.deltaTime);
    }
}