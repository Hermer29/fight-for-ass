using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Controls;

namespace Playables
{
public class Player : MonoBehaviour, IControlable
{
    [Tooltip("Max Speed = Normal Speed * 2")] 
    public float normalSpeed;

    [SerializeField] 
    private float _currentSpeed;

    public Rigidbody playersRigidBodyComponent;
    private void Awake()
    {
        _currentSpeed = normalSpeed;
        playersRigidBodyComponent = GetComponent<Rigidbody>();
    }
    
    private float _maxSpeed 
    {
        get
        {
            return normalSpeed * 2;
        }
    }

    public void Move(float amount, bool run, Vector3 direction)
    {
        
    }

    public void Rotate(float amount, bool isRight)
    {

    }

    public void Aim()
    {

    }

    public void Shot()
    {

    }

}
}