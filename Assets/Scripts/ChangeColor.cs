using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class ChangeColor : MonoBehaviour
{
    [SerializeField] private float _duration = 2f;
    [SerializeField] private float _waitingTime = 2f;
    private Color _startColor;
    private Color _nextColor;
    private Renderer _renderer;
    private float _time;
    private float _countTime;

    private void Start()
    {
        _renderer = GetComponent<Renderer>();
        GenerationNextColor();
    }

    private void Update()
    {
        _countTime += Time.deltaTime;
        _time += Time.deltaTime;
        var progress =_time / _duration;
        _renderer.material.color = Color.Lerp(_startColor, _nextColor, progress);
        if (_time > _duration && _countTime > _waitingTime)
        {
            GenerationNextColor();
            _time = 0f;
            _countTime = 0f;
        }
    }

    private void GenerationNextColor()
    {
        _startColor = _renderer.material.color;
        _nextColor = Random.ColorHSV(0f, 1f, 0.8f, 1f, 1f, 1f);
        
    }
}
