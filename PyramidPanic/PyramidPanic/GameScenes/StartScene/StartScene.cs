﻿// met using kan je een XNA codebibliotheek gebruiken in je class
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;

namespace PyramidPanic
{
    public class StartScene : IState // De class StartScene implementeert de interface IState
    {
        // Fields can de class StartScene
        private PyramidPanic game;

        // Contructor van de StartScene-class krijgt een object mee van het type PyramidPanic
        public StartScene(PyramidPanic game)
        {
            this.game = game;
        }

        // Initialize mehode. Deze methode initialiseert (geeft startwaarden aan variabelen)
        // Void will zeggen dat er niets teruggegeven wordt
        public void Initialize()
        {

        }

        // LoadContent methode. Deze methode maakt nieuwe objecten aan van de verschillende classes
        public void LoadContent()
        {

        }

        // Update methode. Deze methode wordt normaal 60 keer per seconde aangeroepen.
        // en update alle variabelen, methods enz......
        public void Update(GameTime gametime)
        {
            if (Input.EdgeDetectKeyDown(Keys.Right) || Input.EdgeDetectMousePressLeft())
            {
                this.game.IState = this.game.PlayScene;
            }
            if (Input.EdgeDetectKeyDown(Keys.Left))
            {
                this.game.IState = this.game.GameOverScene;
            }
        }

        // Draw methode. Deze methode word normaal 60 keer per seconde aangeroepen.
        // En tekent de textures op het canvas.
        public void Draw(GameTime gametime)
        {
            this.game.GraphicsDevice.Clear(Color.YellowGreen);
        }
    }
}