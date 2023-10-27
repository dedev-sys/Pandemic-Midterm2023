using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class InputManager
{
    private static GameControls _gameControls;

    public static void Init(Player player)
    {
        _gameControls = new GameControls();

        _gameControls.Game.Enable();

        _gameControls.Game.Move.performed += ctx =>
        {
            player.Move();
        };

        _gameControls.Game.TreatDisease.started += ctx =>
        {
            player.TreatDisease();
        };

    }
}
