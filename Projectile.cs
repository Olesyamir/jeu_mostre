using System;
using Microsoft. Xna. Framework;
using Microsoft. Xna. Framework. Graphics;

namespace jeu_monstre.Projectile;

public class Projectile : GameObject
{
    private static int _degats = 10;
    public Projectile(Texture2D texture, Vector2 position, int size) : base(texture, position, size)
    {
        this.setSpeedY(2f);
    }
    
    public void Update(GameTime gameTime)
    {
        
        _position.Y -= 1+_speed.Y;
    }

    public int getDegats()
    {
        return _degats;
    }
}