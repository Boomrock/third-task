using System;
using UnityEngine;

namespace Example
{
    public class TransportConfig : ScriptableObject
    {
        //словарь с айдишниками и моделаями
        
        public TransportModel[] Models;
        
        //Get(id)
        // озвращаешь из словаря нужную модель
    }

    [Serializable]
    public class TransportModel
    {
        public int Id;
        public Sprite _sprite;
        public float _speed;
        public Vector2 _size;
        public Color _color;

        public TransportModel(
            int id,
            Sprite Sprite,
            float Speed,
            Vector2 Size,
            Color Color)
        {
            Id = id;
            _sprite = Sprite;
            _speed = Speed;
            _size = Size;
            _color = Color;
        }
    }
}