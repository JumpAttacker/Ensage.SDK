﻿// <copyright file="StringView.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.Menu.Views
{
    using System;

    using Ensage.SDK.Menu.Attributes;
    using Ensage.SDK.Menu.Entries;

    using SharpDX;

    using Color = System.Drawing.Color;

    [ExportView(typeof(string))]
    public class StringView : IView
    {
        public void Draw(MenuBase context)
        {
            var pos = context.Position;
            var size = context.Size;

            Color color;
            if (context.IsHovered)
            {
                color = Color.Yellow;
            }
            else
            {
                color = Color.White;
            }

            context.Renderer.DrawRectangle(new RectangleF(pos.X, pos.Y, size.X, size.Y), color);
            context.Renderer.DrawText(pos, (string)((MenuItemEntry)context).Value, Color.YellowGreen);
        }

        public Vector2 GetSize(MenuBase context)
        {
            return new Vector2(150, 20);
        }

        public void OnClick(MenuBase context, Vector2 clickPosition)
        {
            throw new NotImplementedException();
        }
    }
}