using Configs;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour
{
    [SerializeField] private SpriteAnimatorConfig _playerAnimatorConfig;
    [SerializeField] private int _animationSpeed = 10;
    [SerializeField] private LevelObjectView _playerView;

    private SpriteAnimatorController _playerAnimator;

    private void Start()
    {
        _playerAnimatorConfig = Resources.Load<SpriteAnimatorConfig>("PlayerAnimatorConfig");
        if(_playerAnimatorConfig)
        {
            _playerAnimator = new SpriteAnimatorController(_playerAnimatorConfig);
            _playerAnimator.StartAnimation(_playerView.SpriteRenderer, AnimStatePlayer.Run, true, _animationSpeed);
        }
    }

    private void Update()
    {
        _playerAnimator.Update();
    }
}
