using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace BasicMonoGame;
public class ScreenManager
{
    private Screen _currentScreen;

    public void Initialize()
    {
        _currentScreen = Global._GameScreen;
        // Additional setup for the manager if needed
    }

    public void ChangeScreen(Screen newScreen)
    {
        _currentScreen = newScreen;
        _currentScreen?.Initialize();
        LoadContent();
        
    }

    private void LoadContent()
    {
        _currentScreen?.LoadContent();
    }

    public void Update(GameTime gameTime)
    {
        _currentScreen?.Update(gameTime);
    }

    public void Draw(GameTime gameTime)
    {
        _currentScreen?.Draw(gameTime);
    }
}