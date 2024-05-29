using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PlayerLoop;

public class Spawner : MonoBehaviour
{
    //[SerializeField] private Transform _leftBorder;
    //[SerializeField] private Transform _rightBorder;
    [SerializeField] private GameObject _cube;
    //[SerializeField] private float _maxTime = 5f;
    
    private float _currentTime;

    private void Start()
    {
        //Instantiate(_cube);
    }

    private void Update()
    {
        //_currentTime += Time.deltaTime;
        //var progress = _currentTime / _maxTime;
        //if (Input.GetKey(KeyCode.Space))
        //{
        //    var temp = Vector3.Lerp(_leftBorder.position, _rightBorder.position, progress);
        //    Instantiate(_cube, temp, Quaternion.identity);
        //}
        //if (_currentTime > _maxTime)
        //{
        //    _currentTime = 0;
        //}
        
        if (Input.GetKey(KeyCode.Space))
        {
            var newCube = Instantiate(_cube);
            newCube.transform.position = new Vector3(Random.Range(-15, 15), 20, 0);
        }
    }
}
