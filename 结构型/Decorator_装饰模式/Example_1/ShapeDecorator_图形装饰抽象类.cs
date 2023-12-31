﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator_装饰模式.Example_1
{
    public abstract class ShapeDecorator_图形装饰抽象类 : IShape
    {
        protected IShape decoratedShape;

        public ShapeDecorator_图形装饰抽象类(IShape decoratedShape)
        {
            this.decoratedShape = decoratedShape;
        }
        public void Draw()
        {
            Console.WriteLine("123456");
            this.Draw(ConsoleColor.Red);
        }
        public void Draw(ConsoleColor color)
        {
            Console.ForegroundColor = color;
            decoratedShape.Draw();
            Console.ResetColor();
        }
    }
}
